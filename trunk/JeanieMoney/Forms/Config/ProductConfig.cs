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
            listBoxProduct.Enabled = false;
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
                listBoxProduct.DataSource = null;
                return;
            }
            productListByAbbr = productAction.retrieveProductListByAbbr(textBoxKeyword.Text);
            listBoxProduct.DisplayMember = "Name";
            listBoxProduct.ValueMember = "Id";
            listBoxProduct.DataSource = productListByAbbr;
            if (0 < listBoxProduct.Items.Count)
                listBoxProduct.SelectedIndex = 0;
        }

        private void listBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBoxProduct.SelectedItem)
            {
                textBoxName.Text = ((Product)listBoxProduct.SelectedItem).Name;
                textBoxAbbr.Text = productListByAbbr.ElementAt(listBoxProduct.SelectedIndex).Abbr;
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
            this.buttonDelete.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Button/Delete");
            this.buttonReset.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Button/Reset");
            this.buttonCancel.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Button/Cancel");
            this.buttonOK.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Button/OK");

            this.labelAbbr.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Label/Abbr");
            this.labelName.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Label/Name");
            this.labelSearchAbbr.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Label/Abbr");

            this.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Form/Product");
        }
        private void init()
        {
            setCaption();
            textBoxName.Clear();
            textBoxAbbr.Clear();
            listBoxProduct.DataSource = null;
            textBoxKeyword.Clear();
            productList = productAction.retrieveProductList();
            Product product = new Product();
            productList.Insert(0, product);
           

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!productAction.deleteProductById(productListByAbbr.ElementAt(listBoxProduct.SelectedIndex).Id))
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
            if (null != listBoxProduct.SelectedItem)
            {
                //modify
                Product category = new Product();
                category.Id = productListByAbbr.ElementAt(listBoxProduct.SelectedIndex).Id;
                category.Name = textBoxName.Text;
                
                category.Abbr = textBoxAbbr.Text;
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
