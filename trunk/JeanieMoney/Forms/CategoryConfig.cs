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
    public partial class CategoryConfig : Form
    {
        CategoryAction categoryAction;
        List<Category> categoryListByPinyin;
        List<Category> categoryList;

        public CategoryConfig()
        {
            InitializeComponent();
            categoryAction = new CategoryAction();
            init();
        }

        public CategoryConfig(string pinyin)
        {
            InitializeComponent();
            categoryAction = new CategoryAction();
            init();
            textBoxPinyin.Text = pinyin;
            textBoxPinyin.Enabled = false;
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
            categoryListByPinyin = categoryAction.retrieveCategoryListByPinyin(textBoxKeyword.Text);
            listBoxCategory.DisplayMember = "Name";
            listBoxCategory.ValueMember = "Id";
            listBoxCategory.DataSource = categoryListByPinyin;
            if (0 < listBoxCategory.Items.Count)
                listBoxCategory.SelectedIndex = 0;
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBoxCategory.SelectedItem)
            {
                textBoxName.Text = ((Category)listBoxCategory.SelectedItem).Name;
                textBoxPinyin.Text = categoryListByPinyin.ElementAt(listBoxCategory.SelectedIndex).Pinyin;
                categoryList = categoryAction.retrieveCategoryList();
                Category category = new Category();
                categoryList.Insert(0, category);
                comboBoxParent.DisplayMember = "Name";
                comboBoxParent.ValueMember = "Id";
                comboBoxParent.DataSource = categoryList;
                comboBoxParent.SelectedValue = categoryListByPinyin.ElementAt(listBoxCategory.SelectedIndex).ParentId;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            textBoxName.Clear();
            textBoxPinyin.Clear();
            listBoxCategory.DataSource = null;
            textBoxKeyword.Clear();
            categoryList = categoryAction.retrieveCategoryList();
            Category category = new Category();
            categoryList.Insert(0, category);
            comboBoxParent.DisplayMember = "Name";
            comboBoxParent.ValueMember = "Id";
            comboBoxParent.DataSource = categoryList;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!categoryAction.deleteCategoryById(categoryListByPinyin.ElementAt(listBoxCategory.SelectedIndex).Id))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            categoryList = categoryAction.retrieveCategoryList();
            comboBoxParent.DataSource = categoryList;
            textBoxName.Clear();
            textBoxPinyin.Clear();
            textBoxKeyword_TextChanged(sender, e);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (null != listBoxCategory.SelectedItem)
            {
                //modify
                Category category = new Category();
                category.Id = categoryListByPinyin.ElementAt(listBoxCategory.SelectedIndex).Id;
                category.Name = textBoxName.Text;
                category.ParentId = categoryList.ElementAt(comboBoxParent.SelectedIndex).Id;
                category.Pinyin = textBoxPinyin.Text;
                if (categoryAction.updateCategoryById(category))
                {
                    MessageBox.Show("OK");
                    categoryList = categoryAction.retrieveCategoryList();
                    comboBoxParent.DataSource = categoryList;
                    textBoxName.Clear();
                    textBoxPinyin.Clear();
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
                category.Pinyin=textBoxPinyin.Text;
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
