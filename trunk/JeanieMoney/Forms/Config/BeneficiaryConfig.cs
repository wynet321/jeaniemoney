using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JeanieMoney.Actions;
using JeanieMoney.Entities;
using JeanieMoney.Utility;

namespace JeanieMoney.Forms.Config
{
    public partial class BeneficiaryConfig : BaseConfigForm
    {
        BeneficiaryAction beneficiaryAction;
        List<Beneficiary> beneficiaryList;

        public BeneficiaryConfig()
        {
            InitializeComponent();
            beneficiaryAction = new BeneficiaryAction();
            init();
        }

        public BeneficiaryConfig(string abbr)
        {
            InitializeComponent();
            beneficiaryAction = new BeneficiaryAction();
            init();
            textBoxAbbr.Text = abbr;
            textBoxAbbr.Enabled = false;
            textBoxKeyword.Enabled = false;
            listBox.Enabled = false;
            buttonDelete.Enabled = false;
            buttonReset.Enabled = false;
            textBoxName.Select();
        }
        private void setCaption()
        {
            this.Text = G18NHandler.getValue(Constant.CAPTION_FORM_BENEFICIARY);
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
            Beneficiary beneficiary = new Beneficiary();
            beneficiary.Abbr = textBoxKeyword.Text;
            beneficiaryList = beneficiaryAction.retrieveList(beneficiary);
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";
            listBox.DataSource = beneficiaryList;
            if (0 < listBox.Items.Count)
                listBox.SelectedIndex = 0;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBox.SelectedItem)
            {
                textBoxName.Text = ((Beneficiary)listBox.SelectedItem).Name;
                textBoxAbbr.Text = beneficiaryList.ElementAt(listBox.SelectedIndex).Abbr;
                //beneficiaryList = beneficiaryAction.retrieveList(null);
                //Beneficiary category = new Beneficiary();
                //beneficiaryList.Insert(0, category);

            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            setCaption();
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxKeyword.Clear();

            listBox.DataSource = null;
            //beneficiaryList = beneficiaryAction.retrieveList(null);
            //Beneficiary category = new Beneficiary();
            //beneficiaryList.Insert(0, category);
        }
        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Beneficiary beneficiary = new Beneficiary();
            beneficiary.Id=beneficiaryList.ElementAt(listBox.SelectedIndex).Id;
            if (!beneficiaryAction.delete(beneficiary))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            
            refresh(sender,e);
        }
        private void refresh(object sender, EventArgs e)
        {
            //beneficiaryList = beneficiaryAction.retrieveList(null);
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxKeyword_TextChanged(sender, e);
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (null != listBox.SelectedItem)
            {
                //modify
                Beneficiary beneficiary = new Beneficiary();
                beneficiary.Id = beneficiaryList.ElementAt(listBox.SelectedIndex).Id;
                beneficiary.Name = textBoxName.Text;
                beneficiary.Abbr = textBoxAbbr.Text;
                if (beneficiaryAction.update(beneficiary))
                {
                    MessageBox.Show("OK");
                    refresh(sender, e);
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
                Beneficiary beneficiary = new Beneficiary();
                beneficiary.Id = Guid.NewGuid().ToString();
                beneficiary.Name = textBoxName.Text;
                beneficiary.Abbr = textBoxAbbr.Text;
                if (beneficiaryAction.create(beneficiary))
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
