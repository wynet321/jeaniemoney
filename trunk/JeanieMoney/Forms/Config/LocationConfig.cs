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
    public partial class LocationConfig : Form
    {
        LocationAction locationAction;
        List<Location> locationListByPinyin;
        List<Location> locationList;

        public LocationConfig()
        {
            InitializeComponent();
            locationAction = new LocationAction();
            init();
        }

        public LocationConfig(string pinyin)
        {
            InitializeComponent();
            locationAction = new LocationAction();
            init();
            textBoxPinyin.Text = pinyin;
            textBoxPinyin.Enabled = false;
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
            locationListByPinyin = locationAction.retrieveLocationListByPinyin(textBoxKeyword.Text);
            listBoxLocation.DisplayMember = "Name";
            listBoxLocation.ValueMember = "Id";
            listBoxLocation.DataSource = locationListByPinyin;
            if (0 < listBoxLocation.Items.Count)
                listBoxLocation.SelectedIndex = 0;
        }

        private void listBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBoxLocation.SelectedItem)
            {
                textBoxName.Text = ((Location)listBoxLocation.SelectedItem).Name;
                textBoxPinyin.Text = locationListByPinyin.ElementAt(listBoxLocation.SelectedIndex).Pinyin;
                locationList = locationAction.retrieveLocationList();
                Location category = new Location();
                locationList.Insert(0, category);

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
            listBoxLocation.DataSource = null;
            textBoxKeyword.Clear();
            locationList = locationAction.retrieveLocationList();
            Location category = new Location();
            locationList.Insert(0, category);


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!locationAction.deleteLocationById(locationListByPinyin.ElementAt(listBoxLocation.SelectedIndex).Id))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            locationList = locationAction.retrieveLocationList();

            textBoxName.Clear();
            textBoxPinyin.Clear();
            textBoxKeyword_TextChanged(sender, e);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (null != listBoxLocation.SelectedItem)
            {
                //modify
                Location category = new Location();
                category.Id = locationListByPinyin.ElementAt(listBoxLocation.SelectedIndex).Id;
                category.Name = textBoxName.Text;

                category.Pinyin = textBoxPinyin.Text;
                if (locationAction.updateLocationById(category))
                {
                    MessageBox.Show("OK");
                    locationList = locationAction.retrieveLocationList();

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
                Location category = new Location();
                category.Id = Guid.NewGuid().ToString();
                category.Name = textBoxName.Text;

                category.Pinyin = textBoxPinyin.Text;
                if (locationAction.createLocation(category))
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
