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
    public partial class LocationConfig : BaseConfigForm
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
            this.buttonDelete.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/Delete");
            this.buttonReset.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/Reset");
            this.buttonCancel.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/Cancel");
            this.buttonOK.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/OK");

            this.labelAbbr.Text = G18NHandler.GetValue("JeanieMoney/Caption/Label/Abbr");
            this.labelName.Text = G18NHandler.GetValue("JeanieMoney/Caption/Label/Name");
            this.labelSearchAbbr.Text = G18NHandler.GetValue("JeanieMoney/Caption/Label/Abbr");

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
            listBoxLocation.Enabled = false;
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
                listBoxLocation.DataSource = null;
                return;
            }
            locationListByAbbr = locationAction.retrieveLocationListByAbbr(textBoxKeyword.Text);
            listBoxLocation.DisplayMember = "Name";
            listBoxLocation.ValueMember = "Id";
            listBoxLocation.DataSource = locationListByAbbr;
            if (0 < listBoxLocation.Items.Count)
                listBoxLocation.SelectedIndex = 0;
        }

        private void listBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBoxLocation.SelectedItem)
            {
                textBoxName.Text = ((Location)listBoxLocation.SelectedItem).Name;
                textBoxAbbr.Text = locationListByAbbr.ElementAt(listBoxLocation.SelectedIndex).Abbr;
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
            listBoxLocation.DataSource = null;
            textBoxKeyword.Clear();
            locationList = locationAction.retrieveLocationList();
            Location category = new Location();
            locationList.Insert(0, category);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!locationAction.deleteLocationById(locationListByAbbr.ElementAt(listBoxLocation.SelectedIndex).Id))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            init();

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (null != listBoxLocation.SelectedItem)
            {
                //modify
                Location category = new Location();
                category.Id = locationListByAbbr.ElementAt(listBoxLocation.SelectedIndex).Id;
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
