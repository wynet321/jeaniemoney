using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JeanieMoney.Utility;
using JeanieMoney.Actions;
using JeanieMoney.Entities;
using JeanieMoney.Forms.Config;

namespace JeanieMoney.Forms
{
    public partial class ProductConfig : BaseConfigForm
    {
        ProductAction productAction;
        List<Product> productListByAbbr;
        List<Product> productList;

        public ProductConfig()
        {
            InitializeComponent();
            productAction = new ProductAction();
            init();
        }

        public ProductConfig(string abbr)
        {
            InitializeComponent();
            productAction = new ProductAction();
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
            productListByAbbr = productAction.retrieveProductListByAbbr(textBoxKeyword.Text);
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";
            listBox.DataSource = productListByAbbr;
            if (0 < listBox.Items.Count)
                listBox.SelectedIndex = 0;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBox.SelectedItem)
            {
                textBoxName.Text = ((Product)listBox.SelectedItem).Name;
                textBoxAbbr.Text = productListByAbbr.ElementAt(listBox.SelectedIndex).Abbr;
                textBoxBarcode.Text = productListByAbbr.ElementAt(listBox.SelectedIndex).Barcode;
                productList = productAction.retrieveProductList();
                Product category = new Product();
                productList.Insert(0, category);
               
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }
        private void setCaption()
        {
           this.labelBarcode.Text = G18NHandler.GetValue("jeanieMoney/Caption/Label/Barcode");

            this.Text = G18NHandler.GetValue("JeanieMoney/Caption/Form/Product");
        }
        private void init()
        {
            setCaption();
            textBoxName.Clear();
            textBoxAbbr.Clear();
            listBox.DataSource = null;
            textBoxKeyword.Clear();
            productList = productAction.retrieveProductList();
            Product product = new Product();
            productList.Insert(0, product);
           

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!productAction.deleteProductById(productListByAbbr.ElementAt(listBox.SelectedIndex).Id))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            productList = productAction.retrieveProductList();
            
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxKeyword_TextChanged(sender, e);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (null != listBox.SelectedItem)
            {
                //modify
                Product category = new Product();
                category.Id = productListByAbbr.ElementAt(listBox.SelectedIndex).Id;
                category.Name = textBoxName.Text;
                category.Abbr = textBoxAbbr.Text;
                category.Barcode = textBoxBarcode.Text;
                if (productAction.updateProductById(category))
                {
                    MessageBox.Show("OK");
                    productList = productAction.retrieveProductList();
                   
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
                Product category=new Product();
                category.Id=Guid.NewGuid().ToString();
                category.Name=textBoxName.Text;
                category.Abbr=textBoxAbbr.Text;
                category.Barcode = textBoxBarcode.Text;
                if (productAction.createProduct(category))
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
