using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JeanieMoney.Actions;
using JeanieMoney.Entities;
using JeanieMoney.Utility;

namespace JeanieMoney.Forms.Config
{
    public partial class PaymentModeConfig : BaseConfigForm
    {
        PaymentModeAction paymentModeAction;
        List<PaymentMode> paymentModeList;

        public PaymentModeConfig()
        {
            InitializeComponent();
            paymentModeAction = new PaymentModeAction();
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
            paymentModeList = paymentModeAction.retrievePaymentModeListByAbbr(textBoxKeyword.Text);
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";
            listBox.DataSource = paymentModeList;
            if (0 < listBox.Items.Count)
                listBox.SelectedIndex = 0;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBox.SelectedItem)
            {
                textBoxName.Text = ((PaymentMode)listBox.SelectedItem).Name;
                textBoxAbbr.Text = paymentModeList.ElementAt(listBox.SelectedIndex).Abbr;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }
        private void setCaption()
        {
            this.Text = G18NHandler.GetValue(Constant.CAPTION_FORM_PAYMENTMODE);
        }
        private void init()
        {
            setCaption();
            textBoxName.Clear();
            textBoxAbbr.Clear();
            listBox.DataSource = null;
            textBoxKeyword.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!paymentModeAction.deletePaymentModeById(paymentModeList.ElementAt(listBox.SelectedIndex).Id))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxKeyword_TextChanged(sender, e);
        }
        private Boolean validateInput()
        {
            return true;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            PaymentMode category = new PaymentMode();
            category.Name = textBoxName.Text;
            category.Abbr = textBoxAbbr.Text;
            if (null != listBox.SelectedItem)
            {
                //modify
                category.Id = paymentModeList.ElementAt(listBox.SelectedIndex).Id;
                if (paymentModeAction.updatePaymentModeById(category))
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
            else
            {
                //insert
                category.Id = Guid.NewGuid().ToString();
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
