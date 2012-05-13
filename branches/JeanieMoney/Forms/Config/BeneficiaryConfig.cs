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
using JeanieMoney.Utility;

namespace JeanieMoney.Forms.Config
{
    public partial class BeneficiaryConfig : BaseConfigForm
    {
        BeneficiaryAction beneficiaryAction;
        List<Beneficiary> beneficiaryList;
        //List<Beneficiary> beneficiaryList;

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
            base.textBoxKeyword.Enabled = false;
            listBoxBeneficiary.Enabled = false;
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
            if (0 == base.textBoxKeyword.Text.Length)
            {
                listBoxBeneficiary.DataSource = null;
                return;
            }
            Beneficiary beneficiary = new Beneficiary();
            beneficiary.Abbr = base.textBoxKeyword.Text;
            beneficiaryList = beneficiaryAction.retrieveList(beneficiary);
            listBoxBeneficiary.DisplayMember = "Name";
            listBoxBeneficiary.ValueMember = "Id";
            listBoxBeneficiary.DataSource = beneficiaryList;
            if (0 < listBoxBeneficiary.Items.Count)
                listBoxBeneficiary.SelectedIndex = 0;
        }

        private void listBoxBeneficiary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBoxBeneficiary.SelectedItem)
            {
                textBoxName.Text = ((Beneficiary)listBoxBeneficiary.SelectedItem).Name;
                textBoxAbbr.Text = beneficiaryList.ElementAt(listBoxBeneficiary.SelectedIndex).Abbr;
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
            base.textBoxKeyword.Clear();

            listBoxBeneficiary.DataSource = null;
            //beneficiaryList = beneficiaryAction.retrieveList(null);
            //Beneficiary category = new Beneficiary();
            //beneficiaryList.Insert(0, category);
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

            this.Text = G18NHandler.GetValue("JeanieMoney/Caption/Form/Beneficiary");
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Beneficiary beneficiary = new Beneficiary();
            beneficiary.Id=beneficiaryList.ElementAt(listBoxBeneficiary.SelectedIndex).Id;
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
            if (null != listBoxBeneficiary.SelectedItem)
            {
                //modify
                Beneficiary beneficiary = new Beneficiary();
                beneficiary.Id = beneficiaryList.ElementAt(listBoxBeneficiary.SelectedIndex).Id;
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
