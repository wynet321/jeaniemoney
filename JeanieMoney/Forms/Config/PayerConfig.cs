using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JeanieMoney.Action;
using JeanieMoney.Entity;

namespace JeanieMoney.Forms
{
    public partial class PayerConfig : Form
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
                textBoxAbbr.Text = payerListByAbbr.ElementAt(listBoxPayer.SelectedIndex).Abbr;
                payerList = payerAction.retrievePayerList();
                Payer category = new Payer();
                payerList.Insert(0, category);
               
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            textBoxName.Clear();
            textBoxAbbr.Clear();
            listBoxPayer.DataSource = null;
            textBoxKeyword.Clear();
            payerList = payerAction.retrievePayerList();
            Payer category = new Payer();
            payerList.Insert(0, category);
           

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!payerAction.deletePayerById(payerListByAbbr.ElementAt(listBoxPayer.SelectedIndex).Id))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            payerList = payerAction.retrievePayerList();
            
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxKeyword_TextChanged(sender, e);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (null != listBoxPayer.SelectedItem)
            {
                //modify
                Payer category = new Payer();
                category.Id = payerListByAbbr.ElementAt(listBoxPayer.SelectedIndex).Id;
                category.Name = textBoxName.Text;
                
                category.Abbr = textBoxAbbr.Text;
                if (payerAction.updatePayerById(category))
                {
                    MessageBox.Show("OK");
                    payerList = payerAction.retrievePayerList();
                   
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
                Payer category=new Payer();
                category.Id=Guid.NewGuid().ToString();
                category.Name=textBoxName.Text;
                
                category.Abbr=textBoxAbbr.Text;
                if (payerAction.createPayer(category))
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
