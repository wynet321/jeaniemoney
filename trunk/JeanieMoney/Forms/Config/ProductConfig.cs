using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JeanieMoney.Actions;
using JeanieMoney.Entities;
using JeanieMoney.Forms.Config;
using ClassLibrary.lib;

namespace JeanieMoney.Forms
{
    public partial class ProductConfig : BaseConfigForm
    {
        ProductAction productAction;
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
            productList = productAction.retrieveProductListByAbbr(textBoxKeyword.Text);
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";
            listBox.DataSource = productList;
            if (0 < listBox.Items.Count)
                listBox.SelectedIndex = 0;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBox.SelectedItem)
            {
                textBoxName.Text = ((Product)listBox.SelectedItem).Name;
                textBoxAbbr.Text = productList.ElementAt(listBox.SelectedIndex).Abbr;
                textBoxBarcode.Text = productList.ElementAt(listBox.SelectedIndex).Barcode;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }
        private void setCaption()
        {
            this.labelBarcode.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_LABEL_BARCODE);

            this.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_FORM_PRODUCT);
        }
        private void init()
        {
            setCaption();
            textBoxName.Clear();
            textBoxAbbr.Clear();
            listBox.DataSource = null;
            textBoxKeyword.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!productAction.delete(productList.ElementAt(listBox.SelectedIndex).Id))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxKeyword_TextChanged(sender, e);
        }
        private Boolean validateInput()
        {
            return true;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!validateInput())
            {
                return;
            }
            Product category = new Product();
            category.Name = textBoxName.Text;
            category.Abbr = textBoxAbbr.Text;
            category.Barcode = textBoxBarcode.Text;
            if (null != listBox.SelectedItem)
            {
                //modify
                category.Id = productList.ElementAt(listBox.SelectedIndex).Id;
                if (productAction.updateProductById(category))
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
            else
            {
                //insert
                category.Id = Guid.NewGuid().ToString();
                if (productAction.create(category))
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
