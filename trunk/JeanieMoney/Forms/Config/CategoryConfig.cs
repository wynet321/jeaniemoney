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
            listBoxCategory.Enabled = false;
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
                listBoxCategory.DataSource = null;
                return;
            }
            categoryListByAbbr = categoryAction.retrieveCategoryListByAbbr(textBoxKeyword.Text);
            listBoxCategory.DisplayMember = "Name";
            listBoxCategory.ValueMember = "Id";
            listBoxCategory.DataSource = categoryListByAbbr;
            if (0 < listBoxCategory.Items.Count)
                listBoxCategory.SelectedIndex = 0;
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBoxCategory.SelectedItem)
            {
                textBoxName.Text = ((Category)listBoxCategory.SelectedItem).Name;
                textBoxAbbr.Text = categoryListByAbbr.ElementAt(listBoxCategory.SelectedIndex).Abbr;
                radioButtonIn.Checked=((Category)listBoxCategory.SelectedItem).InOrOut=='1'?true:false;
                radioButtonOut.Checked = !radioButtonIn.Checked;
                categoryList = categoryAction.retrieveCategoryList();
                Category category = new Category();
                categoryList.Insert(0, category);
                comboBoxParent.DisplayMember = "Name";
                comboBoxParent.ValueMember = "Id";
                comboBoxParent.DataSource = categoryList;
                comboBoxParent.SelectedValue = categoryListByAbbr.ElementAt(listBoxCategory.SelectedIndex).ParentId;
                if (null == comboBoxParent.SelectedValue)
                    comboBoxParent.SelectedIndex = 0;
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
            listBoxCategory.DataSource = null;
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
            if (!categoryAction.deleteCategoryById(categoryListByAbbr.ElementAt(listBoxCategory.SelectedIndex).Id))
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
            if (null != listBoxCategory.SelectedItem)
            {
                //modify
                Category category = new Category();
                category.Id = categoryListByAbbr.ElementAt(listBoxCategory.SelectedIndex).Id;
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
    }
}
