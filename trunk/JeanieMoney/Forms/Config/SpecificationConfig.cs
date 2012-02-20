using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JeanieMoney.Utility;
using JeanieMoney.Action;
using JeanieMoney.Entity;

namespace JeanieMoney.Forms.Config
{
    public partial class SpecificationConfig : BaseConfigForm
    {
        SpecificationAction specificationAction;
        List<Specification> specificationListByAbbr;
        List<Specification> specificationList;

        public SpecificationConfig()
        {
            InitializeComponent();
            specificationAction = new SpecificationAction();
            init();
        }

        public SpecificationConfig(string abbr)
        {
            InitializeComponent();
            specificationAction = new SpecificationAction();
            init();
            textBoxAbbr.Text = abbr;
            textBoxAbbr.Enabled = false;
            textBoxKeyword.Enabled = false;
            listBoxSpecification.Enabled = false;
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
                listBoxSpecification.DataSource = null;
                return;
            }
            specificationListByAbbr = specificationAction.retrieveSpecificationListByAbbr(textBoxKeyword.Text);
            listBoxSpecification.DisplayMember = "Name";
            listBoxSpecification.ValueMember = "Id";
            listBoxSpecification.DataSource = specificationListByAbbr;
            if (0 < listBoxSpecification.Items.Count)
                listBoxSpecification.SelectedIndex = 0;
        }

        private void listBoxSpecification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBoxSpecification.SelectedItem)
            {
                textBoxName.Text = ((Specification)listBoxSpecification.SelectedItem).Name;
                textBoxAbbr.Text = specificationListByAbbr.ElementAt(listBoxSpecification.SelectedIndex).Abbr;
                specificationList = specificationAction.retrieveSpecificationList();
                Specification category = new Specification();
                specificationList.Insert(0, category);
               
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
            listBoxSpecification.DataSource = null;
            textBoxKeyword.Clear();
            specificationList = specificationAction.retrieveSpecificationList();
            Specification specification = new Specification();
            specificationList.Insert(0, specification);
           

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!specificationAction.deleteSpecificationById(specificationListByAbbr.ElementAt(listBoxSpecification.SelectedIndex).Id))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            specificationList = specificationAction.retrieveSpecificationList();
            
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxKeyword_TextChanged(sender, e);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (null != listBoxSpecification.SelectedItem)
            {
                //modify
                Specification category = new Specification();
                category.Id = specificationListByAbbr.ElementAt(listBoxSpecification.SelectedIndex).Id;
                category.Name = textBoxName.Text;
                
                category.Abbr = textBoxAbbr.Text;
                if (specificationAction.updateSpecificationById(category))
                {
                    MessageBox.Show("OK");
                    specificationList = specificationAction.retrieveSpecificationList();
                   
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
                Specification category=new Specification();
                category.Id=Guid.NewGuid().ToString();
                category.Name=textBoxName.Text;
                
                category.Abbr=textBoxAbbr.Text;
                if (specificationAction.createSpecification(category))
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
