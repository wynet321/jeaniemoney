using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JeanieMoney.Actions;
using JeanieMoney.Entities;
using JeanieMoney.Forms.Config;
using ClassLibrary.lib;

namespace JeanieMoney.Forms
{
    public partial class PayerConfig : BaseConfigForm
    {
        PayerAction payerAction;
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
            Payer payer = new Payer();
            payer.Abbr = textBoxKeyword.Text;
            payerList = payerAction.retrieveList(payer);
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";
            listBox.DataSource = payerList;
            if (0 < listBox.Items.Count)
                listBox.SelectedIndex = 0;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBox.SelectedItem)
            {
                textBoxName.Text = ((Payer)listBox.SelectedItem).Name;
                textBoxAbbr.Text = payerList.ElementAt(listBox.SelectedIndex).Abbr;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }
        private void setCaption()
        {
            this.labelPassword.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_LABEL_PASSWORD);

            this.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_FORM_PAYER);
        }
        private void init()
        {
            setCaption();
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxPassword.Clear();
            listBox.DataSource = null;
            textBoxKeyword.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Payer payer = new Payer();
            payer.Id = payerList.ElementAt(listBox.SelectedIndex).Id;
            if (!payerAction.delete(payer))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
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
            if (null != listBox.SelectedItem)
            {
                //modify
                payer.Id = payerList.ElementAt(listBox.SelectedIndex).Id;
                if (payerAction.update(payer))
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
                payer.Id = Guid.NewGuid().ToString();
                if (payerAction.create(payer))
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
