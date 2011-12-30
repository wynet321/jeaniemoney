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
        LocationAction locationAction;
        List<Location> locationList;
        public RecordInput()
        {
            InitializeComponent();
            categoryAction = new CategoryAction();
            payerAction = new PayerAction();
            locationAction = new LocationAction();
            Init();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Init()
        {
            dateTimePickerRecordInput.Value = DateTime.Now;
            radioButtonOut.Select();
            textBoxMoney.Clear();
            //category
            categoryList = categoryAction.retrieveCategoryListOfLeafNodeByPinyin("%", radioButtonIn.Checked ? '1' : '0');
            listBoxCategory.DisplayMember = "Name";
            listBoxCategory.ValueMember = "Id";
            listBoxCategory.DataSource = categoryList;
            listBoxCategory.Visible = false;

            //payer
            payerList = payerAction.retrievePayerListByPinyin("%");
            listBoxPayer.DisplayMember = "Name";
            listBoxPayer.ValueMember = "Id";
            listBoxPayer.DataSource = payerList;
            listBoxPayer.Visible = false;

            //location
            locationList = locationAction.retrieveLocationListByPinyin("%");
            listBoxLocation.DisplayMember = "Name";
            listBoxLocation.ValueMember = "Id";
            listBoxLocation.DataSource = locationList;
            listBoxLocation.Visible = false;
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }
        #region category
        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {
            String category = textBoxCategory.Text.Trim();
            categoryList = categoryAction.retrieveCategoryListOfLeafNodeByPinyin(category, radioButtonIn.Checked ? '1' : '0');
            listBoxCategory.DataSource = categoryList;
            if (0 < listBoxCategory.Items.Count)
            {
                listBoxCategory.SelectedIndex = 0;
                listBoxCategory.Visible = true;
            }
        }

        private void textBoxCategory_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    listBoxCategory.Visible = false;
                    if (0 < listBoxCategory.Items.Count) labelSummaryResultCategory.Text = categoryList.ElementAt(listBoxCategory.SelectedIndex).Name;
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
                                listBoxCategory.DataSource = categoryList;
                                listBoxCategory.SelectedIndex = 0;
                                labelSummaryResultCategory.Text = categoryList.ElementAt(0).Name;
                            }
                        }
                    }
                    textBoxPayer.Focus();
                    break;
                case Keys.Up: if (0 < listBoxCategory.SelectedIndex) listBoxCategory.SelectedIndex--; break;
                case Keys.Down: if (listBoxCategory.SelectedIndex < listBoxCategory.Items.Count - 1) listBoxCategory.SelectedIndex++; break;
            }
        }

        private void textBoxCategory_Leave(object sender, EventArgs e)
        {
            listBoxCategory.Visible = false;
        }

        private void listBoxCategory_DoubleClick(object sender, EventArgs e)
        {
            labelSummaryResultCategory.Text = categoryList.ElementAt(listBoxCategory.SelectedIndex).Name;
            listBoxCategory.Visible = false;
        }

        private void buttonShowListCategory_Click(object sender, EventArgs e)
        {
            listBoxCategory.Visible = !listBoxCategory.Visible;
        }
        #endregion category
        #region payer
        private void textBoxPayer_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    listBoxPayer.Visible = false;
                    if (0 < listBoxPayer.Items.Count) labelSummaryResultPayer.Text = payerList.ElementAt(listBoxPayer.SelectedIndex).Name;
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
                                listBoxPayer.DataSource = payerList;
                                listBoxPayer.SelectedIndex = 0;
                                labelSummaryResultPayer.Text = payerList.ElementAt(0).Name;
                            }
                        }
                    }
                    textBoxLocation.Focus();
                    break;
                case Keys.Up: if (0 < listBoxPayer.SelectedIndex) listBoxPayer.SelectedIndex--; break;
                case Keys.Down: if (listBoxPayer.SelectedIndex < listBoxPayer.Items.Count - 1) listBoxPayer.SelectedIndex++; break;
            }
        }

        private void buttonShowListPayer_Click(object sender, EventArgs e)
        {
            listBoxPayer.Visible = !listBoxPayer.Visible;
        }

        private void textBoxPayer_TextChanged(object sender, EventArgs e)
        {
            String payer = textBoxPayer.Text.Trim();
            payerList = payerAction.retrievePayerListByPinyin(payer);
            listBoxPayer.DataSource = payerList;
            if (0 < listBoxPayer.Items.Count)
            {
                listBoxPayer.SelectedIndex = 0;
                listBoxPayer.Visible = true;
            }
        }

        private void textBoxPayer_Leave(object sender, EventArgs e)
        {
            listBoxPayer.Visible = false;
        }

        private void listBoxPayer_DoubleClick(object sender, EventArgs e)
        {
            labelSummaryResultPayer.Text = payerList.ElementAt(listBoxPayer.SelectedIndex).Name;
            listBoxPayer.Visible = false;
        }
        #endregion payer
        #region location
        private void listBoxLocation_DoubleClick(object sender, EventArgs e)
        {
            labelSummaryResultLocation.Text = locationList.ElementAt(listBoxLocation.SelectedIndex).Name;
            listBoxLocation.Visible = false;
        }

        private void textBoxLocation_TextChanged(object sender, EventArgs e)
        {
            String location = textBoxLocation.Text.Trim();
            locationList = locationAction.retrieveLocationListByPinyin(location);
            listBoxLocation.DataSource = locationList;
            if (0 < listBoxLocation.Items.Count)
            {
                listBoxLocation.SelectedIndex = 0;
                listBoxLocation.Visible = true;
            }
        }

        private void textBoxLocation_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    listBoxLocation.Visible = false;
                    if (0 < listBoxLocation.Items.Count) labelSummaryResultLocation.Text = locationList.ElementAt(listBoxLocation.SelectedIndex).Name;
                    else
                    {
                        //add location
                        if (DialogResult.Yes == MessageBox.Show("do you want to add new location?", "?", MessageBoxButtons.YesNo))
                        {
                            LocationConfig pc = new LocationConfig(textBoxLocation.Text);
                            pc.ShowDialog();
                            locationList = locationAction.retrieveLocationListByPinyin(textBoxLocation.Text);
                            if (0 < locationList.Count)
                            {
                                listBoxLocation.DataSource = locationList;
                                listBoxLocation.SelectedIndex = 0;
                                labelSummaryResultLocation.Text = locationList.ElementAt(0).Name;
                            }
                        }
                    }
                    textBoxLocation.Focus();
                    break;
                case Keys.Up: if (0 < listBoxLocation.SelectedIndex) listBoxLocation.SelectedIndex--; break;
                case Keys.Down: if (listBoxLocation.SelectedIndex < listBoxLocation.Items.Count - 1) listBoxLocation.SelectedIndex++; break;
            }
        }

        private void buttonShowListLocation_Click(object sender, EventArgs e)
        {
            listBoxLocation.Visible = !listBoxLocation.Visible;
        }

        private void textBoxLocation_Leave(object sender, EventArgs e)
        {
            listBoxLocation.Visible = false;
        }
        #endregion location

    }
}
