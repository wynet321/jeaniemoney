using System;
using System.Windows.Forms;
using JeanieMoney.Utility;
using JeanieMoney.Action;
using JeanieMoney.Entity;
using System.Collections.Generic;
using System.Linq;

namespace JeanieMoney.Forms.Config
{
    public partial class PaymentModeConfig : BaseConfigForm
    {
        PaymentModeAction paymentModeAction;
        List<PaymentMode> paymentModeList;
        List<PaymentMode> paymentModeListByAbbr;

        public PaymentModeConfig()
        {
            InitializeComponent();
            paymentModeAction=new PaymentModeAction();
            init();
        }

         public PaymentModeConfig(string abbr)
        {
            InitializeComponent();
            paymentModeAction = new PaymentModeAction();
            init();
            textBoxAbbr.Text = abbr;
            textBoxAbbr.Enabled = false;
            textBoxKeyword.Enabled = false;
            listBoxPaymentMode.Enabled = false;
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
                listBoxPaymentMode.DataSource = null;
                return;
            }
            paymentModeListByAbbr = paymentModeAction.retrievePaymentModeListByAbbr(textBoxKeyword.Text);
            listBoxPaymentMode.DisplayMember = "Name";
            listBoxPaymentMode.ValueMember = "Id";
            listBoxPaymentMode.DataSource = paymentModeListByAbbr;
            if (0 < listBoxPaymentMode.Items.Count)
                listBoxPaymentMode.SelectedIndex = 0;
        }

        private void listBoxPaymentMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBoxPaymentMode.SelectedItem)
            {
                textBoxName.Text = ((PaymentMode)listBoxPaymentMode.SelectedItem).Name;
                textBoxAbbr.Text = paymentModeListByAbbr.ElementAt(listBoxPaymentMode.SelectedIndex).Abbr;
                paymentModeList = paymentModeAction.retrievePaymentModeList();
                PaymentMode category = new PaymentMode();
                paymentModeList.Insert(0, category);
               
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }
        private void setCaption()
        {
            this.buttonDelete.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/Delete");
            this.buttonReset.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/Reset");
            this.buttonCancel.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/Cancel");
            this.buttonOK.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/OK");

            this.labelAbbr.Text = G18NHandler.GetValue("JeanieMoney/Caption/Label/Abbr");
            this.labelName.Text = G18NHandler.GetValue("JeanieMoney/Caption/Label/Name");
            this.labelSearchAbbr.Text = G18NHandler.GetValue("JeanieMoney/Caption/Label/Abbr");

            this.Text = G18NHandler.GetValue("JeanieMoney/Caption/Form/PaymentMode");
        }
        private void init()
        {
            setCaption();
            textBoxName.Clear();
            textBoxAbbr.Clear();
            listBoxPaymentMode.DataSource = null;
            textBoxKeyword.Clear();
            paymentModeList = paymentModeAction.retrievePaymentModeList();
            PaymentMode paymentMode = new PaymentMode();
            paymentModeList.Insert(0, paymentMode);
           

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!paymentModeAction.deletePaymentModeById(paymentModeListByAbbr.ElementAt(listBoxPaymentMode.SelectedIndex).Id))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            paymentModeList = paymentModeAction.retrievePaymentModeList();
            
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxKeyword_TextChanged(sender, e);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (null != listBoxPaymentMode.SelectedItem)
            {
                //modify
                PaymentMode category = new PaymentMode();
                category.Id = paymentModeListByAbbr.ElementAt(listBoxPaymentMode.SelectedIndex).Id;
                category.Name = textBoxName.Text;

                category.Abbr = textBoxAbbr.Text;
                if (paymentModeAction.updatePaymentModeById(category))
                {
                    MessageBox.Show("OK");
                    paymentModeList = paymentModeAction.retrievePaymentModeList();

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
                PaymentMode category = new PaymentMode();
                category.Id = Guid.NewGuid().ToString();
                category.Name = textBoxName.Text;

                category.Abbr = textBoxAbbr.Text;
                if (paymentModeAction.createPaymentMode(category))
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
