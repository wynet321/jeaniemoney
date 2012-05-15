using System;
using System.Data;
using System.Windows.Forms;
using JeanieMoney.Utility;
using JeanieMoney.Forms.Config;

namespace JeanieMoney.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        private void setCaption()
        {
            dataGridViewJournalRecord.Columns["id"].HeaderText = G18NHandler.GetValue("JeanieMoney/Caption/DataGridView/Column/Id");
            dataGridViewJournalRecord.Columns["name"].HeaderText = G18NHandler.GetValue("JeanieMoney/Caption/DataGridView/Column/Name");
            dataGridViewJournalRecord.Columns["location_name"].HeaderText = G18NHandler.GetValue("JeanieMoney/Caption/DataGridView/Column/Location");
            dataGridViewJournalRecord.Columns["payer_name"].HeaderText = G18NHandler.GetValue("JeanieMoney/Caption/DataGridView/Column/Payer");
            dataGridViewJournalRecord.Columns["payment_mode_name"].HeaderText = G18NHandler.GetValue("JeanieMoney/Caption/DataGridView/Column/PaymentMode");
            dataGridViewJournalRecord.Columns["money"].HeaderText = G18NHandler.GetValue("JeanieMoney/Caption/DataGridView/Column/Money");
            dataGridViewJournalRecord.Columns["date"].HeaderText = G18NHandler.GetValue("JeanieMoney/Caption/DataGridView/Column/Date");
            this.lablePeriod.Text = G18NHandler.GetValue("JeanieMoney/Caption/Label/Period");
            this.buttonSearch.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/Search");
        }
        private void Main_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
            setCaption();
        }

        private void toolStripButtonRecordInput_Click(object sender, EventArgs e)
        {
            RecordInput ri = new RecordInput();
            ri.ShowDialog();
        }

        private void toolStripButtonCategory_Click(object sender, EventArgs e)
        {
            CategoryConfig cc = new CategoryConfig();
            cc.ShowDialog();
        }

        private void toolStripButtonPayer_Click(object sender, EventArgs e)
        {
            PayerConfig pc = new PayerConfig();
            pc.ShowDialog();
        }

        private void toolStripButtonLocation_Click(object sender, EventArgs e)
        {
            LocationConfig lc = new LocationConfig();
            lc.ShowDialog();
        }

        private void toolStripButtonProduct_Click(object sender, EventArgs e)
        {
            ProductConfig pc = new ProductConfig();
            pc.ShowDialog();
        }

        private void toolStripButtonUnit_Click(object sender, EventArgs e)
        {
            UnitConfig sc = new UnitConfig();
            sc.ShowDialog();
        }

        private void toolStripButtonPaymentMode_Click(object sender, EventArgs e)
        {
            PaymentModeConfig pcc = new PaymentModeConfig();
            pcc.ShowDialog();
        }

        private void toolStripButtonBeneficiary_Click(object sender, EventArgs e)
        {
            BeneficiaryConfig bc = new BeneficiaryConfig();
            bc.ShowDialog();
        }
        private void refreshDataGridView()
        {
            DataTable dt = DbHandler.getDataTable("select * from journal_record where date between '" + dateTimePickerStart.Value.ToShortDateString() + "' and '" + dateTimePickerEnd.Value.ToShortDateString() + "'");
            dataGridViewJournalRecord.DataSource = dt;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
    }
}
