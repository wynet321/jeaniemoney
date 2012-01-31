using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JeanieMoney.Entity;
using JeanieMoney.Action;
using JeanieMoney.Forms.Config;
using JeanieMoney.Utility;
using System.Drawing;

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
        BeneficiaryAction beneficiaryAction;
        List<Beneficiary> beneficiaryList;
        ProductSpecificationManufactoryAction productSpecificationManufactoryAction;
        List<ProductSpecificationManufactory> productSpecificationManufactoryList;
        TradeRecordAction tradeRecordAction;
        TradeRecordDetailAction tradeRecordDetailAction;

        public RecordInput()
        {
            InitializeComponent();
            categoryAction = new CategoryAction();
            payerAction = new PayerAction();
            locationAction = new LocationAction();
            tradeRecordAction = new TradeRecordAction();
            tradeRecordDetailAction = new TradeRecordDetailAction();
            beneficiaryAction = new BeneficiaryAction();
            productSpecificationManufactoryAction = new ProductSpecificationManufactoryAction();

            listViewSummaryDetails.Columns.Add("Name");
            listViewSummaryDetails.Columns.Add("Specification");
            listViewSummaryDetails.Columns.Add("Manufactory");
            listViewSummaryDetails.Columns.Add("Beneficiary");
            listViewSummaryDetails.Columns.Add("Total");
            listViewSummaryDetails.Columns.Add("Price");
            listViewSummaryDetails.Columns.Add("Quantity");
            Init();

        }
        private void textBoxMoney_Leave(object sender, EventArgs e)
        {
            labelSummaryResultMoney.Text = textBoxMoney.Text;
        }

        private void dateTimePickerRecordInput_Leave(object sender, EventArgs e)
        {
            labelSummaryResultDate.Text = dateTimePickerRecordInput.Value.ToLongDateString();
        }

        private Boolean validateInput()
        {
            if (0 == labelSummaryResultCategory.Text.Length)
            {
                MessageBox.Show("Please select category first.", "!", MessageBoxButtons.OK);
                textBoxCategory.Focus();
            }
            return true;
        }

        private void radioButtonOut_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOut.Checked)
                labelSummaryResultInOut.Text = "Outgoings";
            else
                labelSummaryResultInOut.Text = "Income";
        }

        private void checkBoxDetails_CheckedChanged(object sender, EventArgs e)
        {
            panelDetails.Visible = !panelDetails.Visible;
            if (panelDetails.Visible)
            {
                panelDetailInit();
                textBoxDetailProduct.Focus();
            }
        }

        private void panelDetailInit()
        {
            labelDetailTotalResult.ResetText();
            labelDetailSpecificationResult.ResetText();
            labelDetailProductResult.ResetText();
            labelDetailPriceAverageResult.ResetText();
            labelDetailManufactoryResult.ResetText();
            textBoxDetailQuantity.Clear();
            textBoxDetailPrice.Clear();
            textBoxDetailBeneficiary.Clear();
            textBoxDetailProduct.Clear();

            //product
            listBoxDetailProduct.DisplayMember = "Name";
            listBoxDetailProduct.ValueMember = "Id";
            listBoxDetailProduct.Visible = false;

            //beneficiary
            listBoxDetailBeneficiary.DisplayMember = "Name";
            listBoxDetailBeneficiary.ValueMember = "Id";
            listBoxDetailBeneficiary.Visible = false;

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
            listBoxCategory.DisplayMember = "Name";
            listBoxCategory.ValueMember = "Id";
            listBoxCategory.Visible = false;

            //payer
            listBoxPayer.DisplayMember = "Name";
            listBoxPayer.ValueMember = "Id";
            listBoxPayer.Visible = false;

            //location
            listBoxLocation.DisplayMember = "Name";
            listBoxLocation.ValueMember = "Id";
            listBoxLocation.Visible = false;
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (validateInput())
                //insert into db;
                ;
        }
        #region category
        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {
            String category = textBoxCategory.Text.Trim();
            categoryList = categoryAction.retrieveCategoryListOfLeafNodeByAbbr(category, radioButtonIn.Checked ? '1' : '0');
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
                    textBoxPayer.Focus();
                    break;
                case Keys.Up: if (0 < listBoxCategory.SelectedIndex) listBoxCategory.SelectedIndex--; break;
                case Keys.Down: if (listBoxCategory.SelectedIndex < listBoxCategory.Items.Count - 1) listBoxCategory.SelectedIndex++; break;
            }
        }

        private void textBoxCategory_Leave(object sender, EventArgs e)
        {
            if (0 == categoryList.Count)
            {
                listBoxCategory.Visible = false;
                if (0 < textBoxCategory.Text.Trim().Length)
                    //add category
                    if (DialogResult.Yes == MessageBox.Show("do you want to add new category?", "?", MessageBoxButtons.YesNo))
                    {
                        CategoryConfig cc = new CategoryConfig(textBoxCategory.Text.Trim());

                        cc.ShowDialog();
                        categoryList = categoryAction.retrieveCategoryListOfLeafNodeByAbbr(textBoxCategory.Text.Trim(), radioButtonIn.Checked ? '1' : '0');
                        if (0 < categoryList.Count)
                        {
                            listBoxCategory.DataSource = categoryList;
                            listBoxCategory.SelectedIndex = 0;
                            labelSummaryResultCategory.Text = categoryList.ElementAt(0).Name;
                        }
                    }
            }
            else if (!listBoxCategory.Focused)
                listBoxCategory.Visible = false;
        }

        private void listBoxCategory_Click(object sender, EventArgs e)
        {
            labelSummaryResultCategory.Text = categoryList.ElementAt(listBoxCategory.SelectedIndex).Name;
            listBoxCategory.Visible = false;
            textBoxPayer.Focus();
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
            payerList = payerAction.retrievePayerListByAbbr(payer);
            listBoxPayer.DataSource = payerList;
            if (0 < listBoxPayer.Items.Count)
            {
                listBoxPayer.SelectedIndex = 0;
                listBoxPayer.Visible = true;
            }
        }

        private void textBoxPayer_Leave(object sender, EventArgs e)
        {
            if (0 == payerList.Count)
            {
                listBoxPayer.Visible = false;
                if (0 < textBoxPayer.Text.Trim().Length)
                    //add payer
                    if (DialogResult.Yes == MessageBox.Show("do you want to add new payer?", "?", MessageBoxButtons.YesNo))
                    {
                        PayerConfig pc = new PayerConfig(textBoxPayer.Text.Trim());
                        pc.ShowDialog();
                        payerList = payerAction.retrievePayerListByAbbr(textBoxPayer.Text.Trim());
                        if (0 < payerList.Count)
                        {
                            listBoxPayer.DataSource = payerList;
                            listBoxPayer.SelectedIndex = 0;
                            labelSummaryResultPayer.Text = payerList.ElementAt(0).Name;
                        }
                    }
            }
            else if (!listBoxPayer.Focused)
                listBoxPayer.Visible = false;
        }
        private void listBoxPayer_Click(object sender, EventArgs e)
        {
            labelSummaryResultPayer.Text = payerList.ElementAt(listBoxPayer.SelectedIndex).Name;
            listBoxPayer.Visible = false;
            textBoxLocation.Focus();
        }
        #endregion payer
        #region location

        private void listBoxLocation_Click(object sender, EventArgs e)
        {
            labelSummaryResultLocation.Text = locationList.ElementAt(listBoxLocation.SelectedIndex).Name;
            listBoxLocation.Visible = false;
            checkBoxDetails.Focus();
        }

        private void textBoxLocation_TextChanged(object sender, EventArgs e)
        {
            String location = textBoxLocation.Text.Trim();
            locationList = locationAction.retrieveLocationListByAbbr(location);
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
                    checkBoxDetails.Focus();
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
            if (0 == locationList.Count)
            {
                listBoxLocation.Visible = false;
                if (0 < textBoxLocation.Text.Trim().Length)
                    //add location
                    if (DialogResult.Yes == MessageBox.Show("do you want to add new location?", "?", MessageBoxButtons.YesNo))
                    {
                        LocationConfig lc = new LocationConfig(textBoxLocation.Text.Trim());

                        lc.ShowDialog();
                        locationList = locationAction.retrieveLocationListByAbbr(textBoxLocation.Text.Trim());
                        if (0 < locationList.Count)
                        {
                            listBoxLocation.DataSource = locationList;
                            listBoxLocation.SelectedIndex = 0;
                            labelSummaryResultLocation.Text = locationList.ElementAt(0).Name;
                        }
                    }
            }
            else if (!listBoxLocation.Focused)
                listBoxLocation.Visible = false;
        }
        #endregion location
        #region product
        private void refreshProductInfo()
        {
            labelDetailProductResult.Text = productSpecificationManufactoryList.ElementAt(listBoxDetailProduct.SelectedIndex).Name;
            labelDetailSpecificationResult.Text = productSpecificationManufactoryList.ElementAt(listBoxDetailProduct.SelectedIndex).Specification;
            labelDetailManufactoryResult.Text = productSpecificationManufactoryList.ElementAt(listBoxDetailProduct.SelectedIndex).ManufactoryName;
            string productId = productSpecificationManufactoryList.ElementAt(listBoxDetailProduct.SelectedIndex).Id;
            labelDetailPriceAverageResult.Text = tradeRecordDetailAction.getProductAveragePriceByProductId(productId);
        }

        private void textBoxDetailProduct_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    listBoxDetailProduct.Visible = false;
                    if (0 < listBoxDetailProduct.Items.Count) refreshProductInfo();
                    textBoxLocation.Focus();
                    break;
                case Keys.Up: if (0 < listBoxDetailProduct.SelectedIndex) listBoxDetailProduct.SelectedIndex--; break;
                case Keys.Down: if (listBoxDetailProduct.SelectedIndex < listBoxDetailProduct.Items.Count - 1) listBoxDetailProduct.SelectedIndex++; break;
            }
        }

        private void buttonShowListDetailProduct_Click(object sender, EventArgs e)
        {
            listBoxDetailProduct.Visible = !listBoxDetailProduct.Visible;
        }

        private void textBoxDetailProduct_TextChanged(object sender, EventArgs e)
        {
            String product = textBoxDetailProduct.Text.Trim();
            productSpecificationManufactoryList = productSpecificationManufactoryAction.retrieveProductSpecificationListByAbbr(product);
            listBoxDetailProduct.DataSource = productSpecificationManufactoryList;
            if (0 < listBoxDetailProduct.Items.Count)
            {
                listBoxDetailProduct.SelectedIndex = 0;
                listBoxDetailProduct.Visible = true;
            }
        }

        private void textBoxDetailProduct_Leave(object sender, EventArgs e)
        {
            if (0 == productSpecificationManufactoryList.Count)
            {
                listBoxDetailProduct.Visible = false;
                if (0 < textBoxDetailProduct.Text.Trim().Length)
                    //add product
                    if (DialogResult.Yes == MessageBox.Show("do you want to add new product?", "?", MessageBoxButtons.YesNo))
                    {
                        ProductConfig pc = new ProductConfig(textBoxDetailProduct.Text.Trim());
                        pc.ShowDialog();
                        productSpecificationManufactoryList = productSpecificationManufactoryAction.retrieveProductSpecificationListByAbbr(textBoxDetailProduct.Text.Trim());
                        if (0 < productSpecificationManufactoryList.Count)
                        {
                            listBoxDetailProduct.DataSource = productSpecificationManufactoryList;
                            listBoxDetailProduct.SelectedIndex = 0;
                            refreshProductInfo();
                        }
                    }
            }
            else if (!listBoxDetailProduct.Focused)
                listBoxDetailProduct.Visible = false;
        }
        private void listBoxDetailProduct_Click(object sender, EventArgs e)
        {
            refreshProductInfo();
            listBoxDetailProduct.Visible = false;
            textBoxLocation.Focus();
        }
        #endregion product
        #region beneficiary
        private void textBoxDetailBeneficiary_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    listBoxDetailBeneficiary.Visible = false;
                    if (0 < listBoxDetailBeneficiary.Items.Count) labelDetailBeneficiaryResult.Text = beneficiaryList.ElementAt(listBoxDetailBeneficiary.SelectedIndex).Name;
                    textBoxLocation.Focus();
                    break;
                case Keys.Up: if (0 < listBoxDetailBeneficiary.SelectedIndex) listBoxDetailBeneficiary.SelectedIndex--; break;
                case Keys.Down: if (listBoxDetailBeneficiary.SelectedIndex < listBoxDetailBeneficiary.Items.Count - 1) listBoxDetailBeneficiary.SelectedIndex++; break;
            }
        }

        private void buttonShowListDetailBeneficiary_Click(object sender, EventArgs e)
        {
            listBoxDetailBeneficiary.Visible = !listBoxDetailBeneficiary.Visible;
        }

        private void textBoxDetailBeneficiary_TextChanged(object sender, EventArgs e)
        {
            String beneficiary = textBoxDetailBeneficiary.Text.Trim();
            beneficiaryList = beneficiaryAction.retrieveBeneficiaryListByAbbr(beneficiary);
            listBoxDetailBeneficiary.DataSource = beneficiaryList;
            if (0 < listBoxDetailBeneficiary.Items.Count)
            {
                listBoxDetailBeneficiary.SelectedIndex = 0;
                listBoxDetailBeneficiary.Visible = true;
            }
        }

        private void textBoxDetailBeneficiary_Leave(object sender, EventArgs e)
        {
            if (0 == beneficiaryList.Count)
            {
                listBoxDetailBeneficiary.Visible = false;
                if (0 < textBoxDetailBeneficiary.Text.Trim().Length)
                    //add beneficiary
                    if (DialogResult.Yes == MessageBox.Show("do you want to add new beneficiary?", "?", MessageBoxButtons.YesNo))
                    {
                        BeneficiaryConfig pc = new BeneficiaryConfig(textBoxDetailBeneficiary.Text.Trim());
                        pc.ShowDialog();
                        beneficiaryList = beneficiaryAction.retrieveBeneficiaryListByAbbr(textBoxDetailBeneficiary.Text.Trim());
                        if (0 < beneficiaryList.Count)
                        {
                            listBoxDetailBeneficiary.DataSource = beneficiaryList;
                            listBoxDetailBeneficiary.SelectedIndex = 0;
                            labelDetailBeneficiaryResult.Text = beneficiaryList.ElementAt(0).Name;
                        }
                    }
            }
            else if (!listBoxDetailBeneficiary.Focused)
                listBoxDetailBeneficiary.Visible = false;
        }
        private void listBoxDetailBeneficiary_Click(object sender, EventArgs e)
        {
            labelDetailBeneficiaryResult.Text = beneficiaryList.ElementAt(listBoxDetailBeneficiary.SelectedIndex).Name;
            listBoxDetailBeneficiary.Visible = false;
            textBoxLocation.Focus();
        }
        #endregion beneficiary

        private void buttonDetailAddToSummary_Click(object sender, EventArgs e)
        {
            if (verifyDetailInput())
            {
                ListViewItem listViewItemDetails=new ListViewItem();
                listViewItemDetails.Text = labelDetailProductResult.Text;
                listViewItemDetails.SubItems.Add(labelDetailSpecificationResult.Text);
                listViewItemDetails.SubItems.Add(labelDetailManufactoryResult.Text);
                listViewItemDetails.SubItems.Add(labelDetailBeneficiaryResult.Text);
                listViewItemDetails.SubItems.Add(labelDetailTotalResult.Text);
                listViewItemDetails.SubItems.Add(textBoxDetailPrice.Text);
                listViewItemDetails.SubItems.Add(textBoxDetailQuantity.Text);
                listViewSummaryDetails.Items.Add(listViewItemDetails);
                panelDetailInit();
            }
        }

        private Boolean verifyDetailInput()
        {

            return true;
        }

        private void textBoxDetailQuantity_Leave(object sender, EventArgs e)
        {
            if (textBoxDetailQuantity.BackColor == Color.Red)
            {
                textBoxDetailQuantity.Focus();
                return;
            }
            if (0 < textBoxDetailPrice.Text.Length)
                labelDetailTotalResult.Text = (decimal.Parse(textBoxDetailPrice.Text) * decimal.Parse(textBoxDetailQuantity.Text)).ToString();

        }

        private void textBoxDetailPrice_Leave(object sender, EventArgs e)
        {
            if (textBoxDetailPrice.BackColor == Color.Red)
            {
                textBoxDetailPrice.Focus();
                return;
            }
            if(0<textBoxDetailQuantity.Text.Length)
                labelDetailTotalResult.Text = (decimal.Parse(textBoxDetailPrice.Text) * decimal.Parse(textBoxDetailQuantity.Text)).ToString();
        }

        private void textBoxDetailPrice_TextChanged(object sender, EventArgs e)
        {
            decimal price;
            if (decimal.TryParse(textBoxDetailPrice.Text.Trim(), out price))
            {
                textBoxDetailPrice.BackColor = Color.White;
            }
            else
            {
                if (0 < textBoxDetailPrice.Text.Length)
                {
                    textBoxDetailPrice.BackColor = Color.Red;
                    labelDetailTotalResult.ResetText();
                }
            }
        }

        private void textBoxDetailQuantity_TextChanged(object sender, EventArgs e)
        {
            decimal quantity;
            if (decimal.TryParse(textBoxDetailQuantity.Text.Trim(), out quantity))
            {
                textBoxDetailQuantity.BackColor = Color.White;
            }
            else
            {
                if (0 < textBoxDetailQuantity.Text.Length)
                {
                    textBoxDetailQuantity.BackColor = Color.Red;
                    labelDetailTotalResult.ResetText();
                }
            }
        }
    }
}
