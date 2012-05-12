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

namespace JeanieMoney.Forms.Config
{
    public partial class UnitConfig : BaseConfigForm
    {
        UnitAction unitAction;
        List<Unit> unitListByAbbr;
        List<Unit> unitList;

        public UnitConfig()
        {
            InitializeComponent();
            unitAction = new UnitAction();
            init();
        }

        public UnitConfig(string abbr)
        {
            InitializeComponent();
            unitAction = new UnitAction();
            init();
            textBoxAbbr.Text = abbr;
            textBoxAbbr.Enabled = false;
            textBoxKeyword.Enabled = false;
            listBoxUnit.Enabled = false;
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
                listBoxUnit.DataSource = null;
                return;
            }
            unitListByAbbr = unitAction.retrieveUnitListByAbbr(textBoxKeyword.Text);
            listBoxUnit.DisplayMember = "Name";
            listBoxUnit.ValueMember = "Id";
            listBoxUnit.DataSource = unitListByAbbr;
            if (0 < listBoxUnit.Items.Count)
                listBoxUnit.SelectedIndex = 0;
        }

        private void listBoxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != listBoxUnit.SelectedItem)
            {
                textBoxName.Text = ((Unit)listBoxUnit.SelectedItem).Name;
                textBoxAbbr.Text = unitListByAbbr.ElementAt(listBoxUnit.SelectedIndex).Abbr;
                unitList = unitAction.retrieveUnitList();
                Unit category = new Unit();
                unitList.Insert(0, category);
               
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
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

            this.Text = G18NHandler.GetValue("JeanieMoney/Caption/Form/Unit");
        }

        private void init()
        {
            setCaption();
            textBoxName.Clear();
            textBoxAbbr.Clear();
            listBoxUnit.DataSource = null;
            textBoxKeyword.Clear();
            unitList = unitAction.retrieveUnitList();
            Unit unit = new Unit();
            unitList.Insert(0, unit);
           

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!unitAction.deleteUnitById(unitListByAbbr.ElementAt(listBoxUnit.SelectedIndex).Id))
            {
                MessageBox.Show("delete failed");
                return;
            }
            MessageBox.Show("delete OK");
            unitList = unitAction.retrieveUnitList();
            
            textBoxName.Clear();
            textBoxAbbr.Clear();
            textBoxKeyword_TextChanged(sender, e);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (null != listBoxUnit.SelectedItem)
            {
                //modify
                Unit category = new Unit();
                category.Id = unitListByAbbr.ElementAt(listBoxUnit.SelectedIndex).Id;
                category.Name = textBoxName.Text;
                
                category.Abbr = textBoxAbbr.Text;
                if (unitAction.updateUnitById(category))
                {
                    MessageBox.Show("OK");
                    unitList = unitAction.retrieveUnitList();
                   
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
                Unit category=new Unit();
                category.Id=Guid.NewGuid().ToString();
                category.Name=textBoxName.Text;
                
                category.Abbr=textBoxAbbr.Text;
                if (unitAction.createUnit(category))
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
