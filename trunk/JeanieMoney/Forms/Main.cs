using System;
using System.Data;
using System.Windows.Forms;
using JeanieMoney.Forms.Config;
using ClassLibrary.lib;
using System.Data.Common;
using ClassLibrary;

namespace JeanieMoney.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            dataGridViewJournalRecord.Columns["id"].HeaderText = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_DATAGRIDVIEW_COLUME_ID);
            dataGridViewJournalRecord.Columns["name"].HeaderText = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_DATAGRIDVIEW_COLUME_NAME);
            dataGridViewJournalRecord.Columns["location_name"].HeaderText = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_DATAGRIDVIEW_COLUME_LOCATION);
            dataGridViewJournalRecord.Columns["payer_name"].HeaderText = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_DATAGRIDVIEW_COLUME_PAYER);
            dataGridViewJournalRecord.Columns["payment_mode_name"].HeaderText = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_DATAGRIDVIEW_COLUME_PAYMENTMODE);
            dataGridViewJournalRecord.Columns["money"].HeaderText = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_DATAGRIDVIEW_COLUME_MONEY);
            dataGridViewJournalRecord.Columns["date"].HeaderText = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_DATAGRIDVIEW_COLUME_DATE);

            toolStripButtonRecordInput.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_TOOLSTRIPBUTTON_RECORDINPUT);
            toolStripButtonBeneficiary.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_TOOLSTRIPBUTTON_BENEFICIARY);
            toolStripButtonCategory.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_TOOLSTRIPBUTTON_CATEGORY);
            toolStripButtonLocation.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_TOOLSTRIPBUTTON_LOCATION);
            toolStripButtonPayer.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_TOOLSTRIPBUTTON_PAYER);
            toolStripButtonPaymentMode.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_TOOLSTRIPBUTTON_PAYMENTMODE);
            toolStripButtonProduct.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_TOOLSTRIPBUTTON_PRODUCT);
            toolStripButtonUnit.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_TOOLSTRIPBUTTON_UNIT);

            this.lablePeriod.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_LABEL_PERIOD);
            this.buttonSearch.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_BUTTON_SEARCH);
            Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_FORM_MAIN);
            refreshDataGridView();
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
            DbParameter[] dbParameter ={
                HandlerFactory.getDbHandler().generateDbParameter("dateStart", dateTimePickerStart.Value.ToShortDateString()),
                HandlerFactory.getDbHandler().generateDbParameter("dateEnd",  dateTimePickerEnd.Value.ToShortDateString())
                                          };
            DataTable dt = HandlerFactory.getDbHandler().getDataTable("select * from journal_record where date between @dateStart and @dateEnd", dbParameter);
            dataGridViewJournalRecord.DataSource = dt;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
