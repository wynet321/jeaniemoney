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
        BeneficiaryAction BeneficiaryAction;
        List<Beneficiary> BeneficiaryListByAbbr;
        List<Beneficiary> BeneficiaryList;

        public BeneficiaryConfig()
        {
            InitializeComponent();
            BeneficiaryAction = new BeneficiaryAction();
            init();
        }

        public BeneficiaryConfig(string abbr)
        {
            InitializeComponent();
            BeneficiaryAction = new BeneficiaryAction();
            init();
            textBoxAbbr.Text = abbr;
            textBoxAbbr.Enabled = false;
            textBoxKeyword.Enabled = false;
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
            if (0 == textBoxKeyword.Text.Length)
            {
                listBoxBeneficiary.DataSource = null;
                return;
            }
            BeneficiaryListByAbbr = BeneficiaryAction.retrieveBeneficiaryListByAbbr(textBoxKeyword.Text);
            listBoxBeneficiary.DisplayMember = "Name";
            listBoxBeneficiary.ValueMember = "Id";
            listBoxBeneficiary.DataSource = BeneficiaryListByAbbr;
            if (0 < listBoxBeneficiary.Items.Count)
                listBoxBeneficiary.SelectedIndex = 0;
        }

        private void listBoxBeneficiary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBoxBeneficiary.SelectedItem)
            {
                textBoxName.Text = ((Beneficiary)listBoxBeneficiary.SelectedItem).Name;
                textBoxAbbr.Text = BeneficiaryListByAbbr.ElementAt(listBoxBeneficiary.SelectedIndex).Abbr;
                BeneficiaryList = BeneficiaryAction.retrieveBeneficiaryList();
                Beneficiary category = new Beneficiary();
                BeneficiaryList.Insert(0, category);
               
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
            listBoxBeneficiary.DataSource = null;
            textBoxKeyword.Clear();
            BeneficiaryList = BeneficiaryAction.retrieveBeneficiaryList();
            Beneficiary category = new Beneficiary();
            BeneficiaryList.Insert(0, category);
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
            if (!BeneficiaryAction.deleteBeneficiaryById(BeneficiaryListByAbbr.ElementAt(listBoxBeneficiary.SelectedIndex).Id))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            BeneficiaryList = BeneficiaryAction.retrieveBeneficiaryList();
            
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxKeyword_TextChanged(sender, e);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (null != listBoxBeneficiary.SelectedItem)
            {
                //modify
                Beneficiary category = new Beneficiary();
                category.Id = BeneficiaryListByAbbr.ElementAt(listBoxBeneficiary.SelectedIndex).Id;
                category.Name = textBoxName.Text;
                
                category.Abbr = textBoxAbbr.Text;
                if (BeneficiaryAction.updateBeneficiaryById(category))
                {
                    MessageBox.Show("OK");
                    BeneficiaryList = BeneficiaryAction.retrieveBeneficiaryList();
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
                Beneficiary category=new Beneficiary();
                category.Id=Guid.NewGuid().ToString();
                category.Name=textBoxName.Text;
                
                category.Abbr=textBoxAbbr.Text;
                if (BeneficiaryAction.createBeneficiary(category))
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
