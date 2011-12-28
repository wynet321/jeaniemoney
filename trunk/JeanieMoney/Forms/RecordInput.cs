using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JeanieMoney.Entity;
using JeanieMoney.Action;

namespace JeanieMoney.Forms
{
    public partial class RecordInput : Form
    {
        CategoryAction categoryAction;
        List<Category> categoryList;
        PayerAction payerAction;
        List<Payer> payerList;
        public RecordInput()
        {
            InitializeComponent();
            categoryAction = new CategoryAction();
            payerAction = new PayerAction();
            Init();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RecordInput_Load(object sender, EventArgs e)
        {

        }

        private void Init()
        {
            dateTimePickerRecordInput.Value = DateTime.Now;
            radioButtonOut.Select();
            textBoxMoney.Clear();
            categoryList = categoryAction.retrieveCategoryListOfLeafNodeByPinyin("%",radioButtonIn.Checked?'1':'0');
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
            comboBoxCategory.DataSource = categoryList;


        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }


        private void textBoxCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            String category;
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (0 < comboBoxCategory.Items.Count)
                    textBoxCategory.Text = comboBoxCategory.Text;
                else
                {
                    //add category
                    if (DialogResult.Yes == MessageBox.Show("do you want to add new category?", "?", MessageBoxButtons.YesNo))
                    {
                        CategoryConfig cc = new CategoryConfig(textBoxCategory.Text);
                        cc.ShowDialog();
                        categoryList = categoryAction.retrieveCategoryListOfLeafNodeByPinyin(textBoxCategory.Text, radioButtonIn.Checked ? '1' : '0');
                        if (0 < categoryList.Count)
                        {
                            comboBoxCategory.DataSource = categoryList;
                            comboBoxCategory.SelectedIndex = 0;
                            textBoxCategory.Text = categoryList.ElementAt(0).Name;
                        }
                    }

                }
                comboBoxCategory.DroppedDown = false;
            }
            else
            {
                category = textBoxCategory.Text.Trim();
                categoryList = categoryAction.retrieveCategoryListOfLeafNodeByPinyin(category, radioButtonIn.Checked ? '1' : '0');
                comboBoxCategory.DataSource = categoryList;
                if (0 < comboBoxCategory.Items.Count)
                {
                    comboBoxCategory.DroppedDown = true;
                    comboBoxCategory.SelectedIndex = 0;
                }
            }
        }

        private void textBoxPayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (0 < comboBoxPayer.Items.Count)
                    textBoxPayer.Text = comboBoxPayer.Text;
                else
                {
                    //add payer
                    if (DialogResult.Yes == MessageBox.Show("do you want to add new payer?", "?", MessageBoxButtons.YesNo))
                    {
                        PayerConfig pc = new PayerConfig(textBoxPayer.Text);
                        pc.ShowDialog();
                        payerList = payerAction.retrievePayerListByPinyin(textBoxPayer.Text);
                        if (0 < payerList.Count)
                        {
                            comboBoxPayer.DataSource = payerList;
                            comboBoxPayer.SelectedIndex = 0;
                            textBoxPayer.Text = payerList.ElementAt(0).Name;
                        }
                    }

                }
                comboBoxPayer.DroppedDown = false;
            }
            else
            {
                payerList = payerAction.retrievePayerListByPinyin(textBoxPayer.Text + e.KeyChar.ToString());
                comboBoxPayer.DataSource = payerList;
                if (0 < comboBoxPayer.Items.Count)
                {
                    comboBoxPayer.DroppedDown = true;
                    comboBoxPayer.SelectedIndex = 0;
                }
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCategory.Text = comboBoxCategory.Text;
        }
    }
}
