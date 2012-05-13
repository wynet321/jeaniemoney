using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JeanieMoney.Actions;
using JeanieMoney.Entities;
using JeanieMoney.Utility;
using JeanieMoney.Forms.Config;

namespace JeanieMoney.Forms
{
    public partial class LocationConfig :BaseConfigForm
    {
        LocationAction locationAction;
        List<Location> locationListByAbbr;
        List<Location> locationList;

        public LocationConfig()
        {
            InitializeComponent();
            locationAction = new LocationAction();
            init();
        }
        private void setCaption()
        {
                       this.Text = G18NHandler.GetValue("JeanieMoney/Caption/Form/Location");
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
            locationListByAbbr = locationAction.retrieveLocationListByAbbr(textBoxKeyword.Text);
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";
            listBox.DataSource = locationListByAbbr;
            if (0 < listBox.Items.Count)
                listBox.SelectedIndex = 0;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBox.SelectedItem)
            {
                textBoxName.Text = ((Location)listBox.SelectedItem).Name;
                textBoxAbbr.Text = locationListByAbbr.ElementAt(listBox.SelectedIndex).Abbr;
                locationList = locationAction.retrieveLocationList();
                Location category = new Location();
                locationList.Insert(0, category);

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
            locationList = locationAction.retrieveLocationList();
            Location category = new Location();
            locationList.Insert(0, category);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!locationAction.deleteLocationById(locationListByAbbr.ElementAt(listBox.SelectedIndex).Id))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            init();

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (null != listBox.SelectedItem)
            {
                //modify
                Location category = new Location();
                category.Id = locationListByAbbr.ElementAt(listBox.SelectedIndex).Id;
                category.Name = textBoxName.Text;
                category.Abbr = textBoxAbbr.Text;
                if (locationAction.updateLocationById(category))
                {
                    MessageBox.Show("OK");
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
                Location category = new Location();
                category.Id = Guid.NewGuid().ToString();
                category.Name = textBoxName.Text;

                category.Abbr = textBoxAbbr.Text;
                if (locationAction.createLocation(category))
                {
                    MessageBox.Show("OK");
                    
                }
                else
                {
                    MessageBox.Show("Fail");
                    return;
                }
            }
            init();
        }

      

    }
}
