using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JeanieMoney.Utility;
using JeanieMoney.Forms.Config;
using JeanieMoney.Actions;
using JeanieMoney.Entities;

namespace JeanieMoney.Forms
{
    public partial class PayerConfig : BaseConfigForm
    {
        PayerAction payerAction;
        List<Payer> payerListByAbbr;
        List<Payer> payerList;

        public PayerConfig()
        {
            InitializeComponent();
            payerAction = new PayerAction();
            init();
        }

        public PayerConfig(string abbr)
        {
            InitializeComponent();
            payerAction = new PayerAction();
            init();
            textBoxAbbr.Text = abbr;
            textBoxAbbr.Enabled = false;
            textBoxKeyword.Enabled = false;
            listBoxPayer.Enabled = false;
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
                listBoxPayer.DataSource = null;
                return;
            }
            payerListByAbbr = payerAction.retrievePayerListByAbbr(textBoxKeyword.Text);
            listBoxPayer.DisplayMember = "Name";
            listBoxPayer.ValueMember = "Id";
            listBoxPayer.DataSource = payerListByAbbr;
            if (0 < listBoxPayer.Items.Count)
                listBoxPayer.SelectedIndex = 0;
        }

        private void listBoxPayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBoxPayer.SelectedItem)
            {
                textBoxName.Text = ((Payer)listBoxPayer.SelectedItem).Name;
                //textBoxAbbr.Text = payerListByAbbr.ElementAt(listBoxPayer.SelectedIndex).Abbr;
                payerList = payerAction.retrievePayerList();
                Payer category = new Payer();
                payerList.Insert(0, category);
               
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
            this.labelPassword.Text = G18NHandler.GetValue("JeanieMoney/Caption/Label/Password");

            this.Text = G18NHandler.GetValue("JeanieMoney/Caption/Form/Payer");
        }
        private void init()
        {
            setCaption();
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxPassword.Clear();
            listBoxPayer.DataSource = null;
            textBoxKeyword.Clear();
            payerList = payerAction.retrievePayerList();
            Payer payer = new Payer();
            payerList.Insert(0, payer);
           

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //if (!payerAction.deletePayerById(payerListByAbbr.ElementAt(listBoxPayer.SelectedIndex).Id))
            //{
            //    MessageBox.Show("delete failed");
            //    return;
            //}
            MessageBox.Show("delete OK");
            payerList = payerAction.retrievePayerList();
            
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxPassword.Clear();
            textBoxKeyword_TextChanged(sender, e);
        }

        private Boolean validateInput()
        {
            if (textBoxPassword.TextLength < 8 || 0 == textBoxName.TextLength || 0 == textBoxAbbr.TextLength)
            {
                MessageBox.Show("Validate Input failed!");
                return false;
            }
            return true;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!validateInput())
            {
                return;
            }
            Payer payer = new Payer();
            payer.Name = textBoxName.Text;
            payer.Abbr = textBoxAbbr.Text;
            payer.Password = textBoxPassword.Text;
            if (null != listBoxPayer.SelectedItem)
            {
                //modify
                //payer.Id = payerListByAbbr.ElementAt(listBoxPayer.SelectedIndex).Id;
                if (payerAction.updatePayerById(payer))
                {
                    MessageBox.Show("OK");
                    payerList = payerAction.retrievePayerList();
                    textBoxName.Clear();
                    textBoxAbbr.Clear();
                    textBoxPassword.Clear();
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
                payer.Id=Guid.NewGuid().ToString();
                if (payerAction.createPayer(payer))
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
