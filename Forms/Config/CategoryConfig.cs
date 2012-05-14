﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JeanieMoney.Actions;
using JeanieMoney.Entities;
using JeanieMoney.Utility;
using JeanieMoney.Forms.Config;

namespace JeanieMoney.Forms
{
    public partial class CategoryConfig : BaseConfigForm
    {
        CategoryAction categoryAction;
        List<Category> categoryListByAbbr;
        List<Category> categoryList;

        public CategoryConfig()
        {
            InitializeComponent();
            categoryAction = new CategoryAction();
            init();
        }

        public CategoryConfig(string abbr)
        {
            InitializeComponent();
            categoryAction = new CategoryAction();
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
            categoryListByAbbr = categoryAction.retrieveCategoryListByAbbr(textBoxKeyword.Text);
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";
            listBox.DataSource = categoryListByAbbr;
            if (0 < listBox.Items.Count)
                listBox.SelectedIndex = 0;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBox.SelectedItem)
            {
                textBoxName.Text = ((Category)listBox.SelectedItem).Name;
                textBoxAbbr.Text = categoryListByAbbr.ElementAt(listBox.SelectedIndex).Abbr;
                radioButtonIn.Checked=((Category)listBox.SelectedItem).InOrOut=='1'?true:false;
                radioButtonOut.Checked = !radioButtonIn.Checked;
                categoryList = categoryAction.retrieveCategoryList();
                Category category = new Category();
                categoryList.Insert(0, category);
                comboBoxParent.DisplayMember = "Name";
                comboBoxParent.ValueMember = "Id";
                comboBoxParent.DataSource = categoryList;
                comboBoxParent.SelectedValue = categoryListByAbbr.ElementAt(listBox.SelectedIndex).ParentId;
                if (null == comboBoxParent.SelectedValue)
                    comboBoxParent.SelectedIndex = 0;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }
        private void setCaption()
        {
           
            this.labelParent.Text = G18NHandler.GetValue("JeanieMoney/Caption/Label/Parent");

            this.groupBoxInOut.Text = G18NHandler.GetValue("JeanieMoney/Caption/Group/InOut");
            this.radioButtonIn.Text = G18NHandler.GetValue("JeanieMoney/Caption/Radio/Income");
            this.radioButtonOut.Text = G18NHandler.GetValue("JeanieMoney/Caption/Radio/Outgoing");

            this.Text = G18NHandler.GetValue("JeanieMoney/Caption/Form/Category");
        }
        private void init()
        {
            setCaption();
            textBoxName.Clear();
            textBoxAbbr.Clear();
            listBox.DataSource = null;
            textBoxKeyword.Clear();
            categoryList = categoryAction.retrieveCategoryList();
            Category category = new Category();
            categoryList.Insert(0, category);
            comboBoxParent.DisplayMember = "Name";
            comboBoxParent.ValueMember = "Id";
            comboBoxParent.DataSource = categoryList;
            radioButtonIn.Checked = true;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!categoryAction.deleteCategoryById(categoryListByAbbr.ElementAt(listBox.SelectedIndex).Id))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            categoryList = categoryAction.retrieveCategoryList();
            comboBoxParent.DataSource = categoryList;
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxKeyword_TextChanged(sender, e);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (null != listBox.SelectedItem)
            {
                //modify
                Category category = new Category();
                category.Id = categoryListByAbbr.ElementAt(listBox.SelectedIndex).Id;
                category.Name = textBoxName.Text;
                category.ParentId = categoryList.ElementAt(comboBoxParent.SelectedIndex).Id;
                category.Abbr = textBoxAbbr.Text;
                category.InOrOut = radioButtonIn.Checked ? '1' : '0';
                if (categoryAction.updateCategoryById(category))
                {
                    MessageBox.Show("OK");
                    categoryList = categoryAction.retrieveCategoryList();
                    comboBoxParent.DataSource = categoryList;
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
                Category category=new Category();
                category.Id=Guid.NewGuid().ToString();
                category.Name=textBoxName.Text;
                category.ParentId=categoryList.ElementAt(comboBoxParent.SelectedIndex).Id;
                category.Abbr=textBoxAbbr.Text;
                category.InOrOut = radioButtonIn.Checked?'1':'0';
                if (categoryAction.createCategory(category))
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

        private void comboBoxParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 != comboBoxParent.SelectedIndex)
            {
                Category category = new Category();
                category=categoryAction.retrieveCategoryById(comboBoxParent.SelectedValue.ToString());
                if('0' == category.InOrOut)
                    radioButtonOut.Select();
                else
                    radioButtonIn.Select();
            }
        }
    }
}