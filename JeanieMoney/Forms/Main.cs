using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JeanieMoney.Utility;

namespace JeanieMoney.Forms
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            setCaption();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        private void setCaption()
        {
            this.idDataGridViewTextBoxColumn.HeaderText = PropertyHelper.GetValue("JeanieMoney/Caption/DataGridView/Column/Id");
            this.nameDataGridViewTextBoxColumn.HeaderText = PropertyHelper.GetValue("JeanieMoney/Caption/DataGridView/Column/Name");
            this.locationnameDataGridViewTextBoxColumn.HeaderText = PropertyHelper.GetValue("JeanieMoney/Caption/DataGridView/Column/Location");
            this.payernameDataGridViewTextBoxColumn.HeaderText = PropertyHelper.GetValue("JeanieMoney/Caption/DataGridView/Column/Payer");
            this.paymentcategorynameDataGridViewTextBoxColumn.HeaderText = PropertyHelper.GetValue("JeanieMoney/Caption/DataGridView/Column/PaymentCategory");
            this.moneyDataGridViewTextBoxColumn.HeaderText = PropertyHelper.GetValue("JeanieMoney/Caption/DataGridView/Column/Money");
            
            this.lablePeriod.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Label/Period");

            this.buttonSearch.Text = PropertyHelper.GetValue("JeanieMoney/Caption/Button/Search");
        }
        private void formMain_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'jeanieMoneyDataSet.journal_record' table. You can move, or remove it, as needed.
            this.journal_recordTableAdapter.Fill(this.jeanieMoneyDataSet.journal_record);
            // TODO: This line of code loads data into the 'jeanieMoneyDataSet.journal_record' table. You can move, or remove it, as needed.
            this.journal_recordTableAdapter.Fill(this.jeanieMoneyDataSet.journal_record);
            
        }

        private void toolStripButtonRecordInput_Click(object sender, EventArgs e)
        {
            RecordInput ri = new RecordInput();
            ri.ShowDialog();
            //CategoryConfig cc = new CategoryConfig();
            //cc.ShowDialog();
        }
    }
}
