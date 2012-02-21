using System;
using System.Windows.Forms;
using JeanieMoney.Utility;
using JeanieMoney.Action;
using JeanieMoney.Entity;
using System.Collections.Generic;
using System.Linq;

namespace JeanieMoney.Forms.Config
{
    public partial class PaymentCategoryConfig : BaseConfigForm
    {
        PaymentCategoryAction paymentCategoryAction;
        List<PaymentCategory> paymentCategoryList;
        List<PaymentCategory> paymentCategoryListByAbbr;

        public PaymentCategoryConfig()
        {
            InitializeComponent();
            paymentCategoryAction=new PaymentCategoryAction();
            init();
        }

         public PaymentCategoryConfig(string abbr)
        {
            InitializeComponent();
            paymentCategoryAction = new PaymentCategoryAction();
            init();
            textBoxAbbr.Text = abbr;
            textBoxAbbr.Enabled = false;
            textBoxKeyword.Enabled = false;
            listBoxPaymentCategory.Enabled = false;
            buttonDelete.Enabled = false;
            buttonReset.Enabled = false;
            textBoxName.Select();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBoxKeyword_TextChanged(object sender, EventArgs e)
        {
            if (0 == textBoxKeyword.Text.Length)
            {
                listBoxPaymentCategory.DataSource = null;
                return;
            }
            paymentCategoryListByAbbr = paymentCategoryAction.retrievePaymentCategoryListByAbbr(textBoxKeyword.Text);
            listBoxPaymentCategory.DisplayMember = "Name";
            listBoxPaymentCategory.ValueMember = "Id";
            listBoxPaymentCategory.DataSource = paymentCategoryListByAbbr;
            if (0 < listBoxPaymentCategory.Items.Count)
                listBoxPaymentCategory.SelectedIndex = 0;
        }

        private void listBoxPaymentCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBoxPaymentCategory.SelectedItem)
            {
                textBoxName.Text = ((PaymentCategory)listBoxPaymentCategory.SelectedItem).Name;
                textBoxAbbr.Text = paymentCategoryListByAbbr.ElementAt(listBoxPaymentCategory.SelectedIndex).Abbr;
                paymentCategoryList = paymentCategoryAction.retrievePaymentCategoryList();
                PaymentCategory category = new PaymentCategory();
                paymentCategoryList.Insert(0, category);
               
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }
        private void setCaption()
        {
            this.buttonDelete.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Button/Delete");
            this.buttonReset.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Button/Reset");
            this.buttonCancel.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Button/Cancel");
            this.buttonOK.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Button/OK");

            this.labelAbbr.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Label/Abbr");
            this.labelName.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Label/Name");
            this.labelSearchAbbr.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Label/Abbr");

            this.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Form/PaymentCategory");
        }
        private void init()
        {
            setCaption();
            textBoxName.Clear();
            textBoxAbbr.Clear();
            listBoxPaymentCategory.DataSource = null;
            textBoxKeyword.Clear();
            paymentCategoryList = paymentCategoryAction.retrievePaymentCategoryList();
            PaymentCategory paymentCategory = new PaymentCategory();
            paymentCategoryList.Insert(0, paymentCategory);
           

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!paymentCategoryAction.deletePaymentCategoryById(paymentCategoryListByAbbr.ElementAt(listBoxPaymentCategory.SelectedIndex).Id))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            paymentCategoryList = paymentCategoryAction.retrievePaymentCategoryList();
            
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxKeyword_TextChanged(sender, e);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (null != listBoxPaymentCategory.SelectedItem)
            {
                //modify
                PaymentCategory category = new PaymentCategory();
                category.Id = paymentCategoryListByAbbr.ElementAt(listBoxPaymentCategory.SelectedIndex).Id;
                category.Name = textBoxName.Text;

                category.Abbr = textBoxAbbr.Text;
                if (paymentCategoryAction.updatePaymentCategoryById(category))
                {
                    MessageBox.Show("OK");
                    paymentCategoryList = paymentCategoryAction.retrievePaymentCategoryList();

                    textBoxName.Clear();
                    textBoxAbbr.Clear();
                    textBoxKeyword_TextChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("Fail");
                    return;
                }
            }
            else
            {
                //insert
                PaymentCategory category = new PaymentCategory();
                category.Id = Guid.NewGuid().ToString();
                category.Name = textBoxName.Text;

                category.Abbr = textBoxAbbr.Text;
                if (paymentCategoryAction.createPaymentCategory(category))
                {
                    MessageBox.Show("OK");
                    init();
                }
                else
                {
                    MessageBox.Show("Fail");
                    return;
                }
            }
        }
    }
}
