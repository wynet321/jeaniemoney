using System;
using System.Windows.Forms;
using JeanieMoney.Utility;
using JeanieMoney.Actions;
using JeanieMoney.Entities;
using System.Collections.Generic;

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
            listBox.Enabled = false;
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
                listBox.DataSource = null;
                return;
            }
            paymentModeListByAbbr = paymentModeAction.retrievePaymentModeListByAbbr(textBoxKeyword.Text);
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";
            listBox.DataSource = paymentModeListByAbbr;
            if (0 < listBox.Items.Count)
                listBox.SelectedIndex = 0;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBox.SelectedItem)
            {
                textBoxName.Text = ((PaymentMode)listBox.SelectedItem).Name;
                textBoxAbbr.Text = paymentModeListByAbbr.ElementAt(listBox.SelectedIndex).Abbr;
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
            
            this.Text = G18NHandler.GetValue("JeanieMoney/Caption/Form/PaymentMode");
        }
        private void init()
        {
            setCaption();
            textBoxName.Clear();
            textBoxAbbr.Clear();
            listBox.DataSource = null;
            textBoxKeyword.Clear();
            paymentModeList = paymentModeAction.retrievePaymentModeList();
            PaymentMode paymentMode = new PaymentMode();
            paymentModeList.Insert(0, paymentMode);
           

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!paymentModeAction.deletePaymentModeById(paymentModeListByAbbr.ElementAt(listBox.SelectedIndex).Id))
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
            if (null != listBox.SelectedItem)
            {
                //modify
                PaymentMode category = new PaymentMode();
                category.Id = paymentModeListByAbbr.ElementAt(listBox.SelectedIndex).Id;
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
