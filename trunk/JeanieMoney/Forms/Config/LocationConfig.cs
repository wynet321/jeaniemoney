using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JeanieMoney.Actions;
using JeanieMoney.Entities;
using ClassLibrary.lib;
using JeanieMoney.Forms.Config;

namespace JeanieMoney.Forms
{
    public partial class LocationConfig : BaseConfigForm
    {
        LocationAction locationAction;
        List<Location> locationList;

        public LocationConfig()
        {
            InitializeComponent();
            locationAction = new LocationAction();
            init();
        }
        private void setCaption()
        {
            this.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_FORM_LOCATION);
        }
        public LocationConfig(string abbr)
        {
            InitializeComponent();
            locationAction = new LocationAction();
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
            Location location = new Location();
            location.Abbr = textBoxKeyword.Text.Trim();
            locationList = locationAction.retrieveList(location);
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";
            listBox.DataSource = locationList;
            if (0 < listBox.Items.Count)
                listBox.SelectedIndex = 0;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBox.SelectedItem)
            {
                textBoxName.Text = ((Location)listBox.SelectedItem).Name;
                textBoxAbbr.Text = locationList.ElementAt(listBox.SelectedIndex).Abbr;
            }
            else
            {
                textBoxName.Clear();
                textBoxAbbr.Clear();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
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
            Location location = new Location();
            location.Id = locationList.ElementAt(listBox.SelectedIndex).Id;
            if (!locationAction.delete(location))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            init();

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
            Location category = new Location();

            category.Name = textBoxName.Text;
            category.Abbr = textBoxAbbr.Text;
            if (null != listBox.SelectedItem)
            {
                //modify
                category.Id = locationList.ElementAt(listBox.SelectedIndex).Id;
                if (locationAction.update(category))
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

                if (locationAction.create(category))
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
