using System;
using System.Data;
using System.Windows.Forms;
using JeanieMoney.Forms.Config;
using ClassLibrary.lib;

namespace JeanieMoney.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            refreshDataGridView();
            setCaption();
        }
        private void setCaption()
        {
            dataGridViewJournalRecord.Columns["id"].HeaderText = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_DATAGRIDVIEW_COLUME_ID);
            dataGridViewJournalRecord.Columns["name"].HeaderText = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_DATAGRIDVIEW_COLUME_NAME);
            dataGridViewJournalRecord.Columns["location_name"].HeaderText = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_DATAGRIDVIEW_COLUME_LOCATION);
            dataGridViewJournalRecord.Columns["payer_name"].HeaderText = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_DATAGRIDVIEW_COLUME_PAYER);
            dataGridViewJournalRecord.Columns["payment_mode_name"].HeaderText = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_DATAGRIDVIEW_COLUME_PAYMENTMODE);
            dataGridViewJournalRecord.Columns["money"].HeaderText = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_DATAGRIDVIEW_COLUME_MONEY);
            dataGridViewJournalRecord.Columns["date"].HeaderText = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_DATAGRIDVIEW_COLUME_DATE);

            toolStripButtonRecordInput.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_TOOLSTRIPBUTTON_RECORDINPUT);
            toolStripButtonBeneficiary.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_TOOLSTRIPBUTTON_BENEFICIARY);
            toolStripButtonCategory.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_TOOLSTRIPBUTTON_CATEGORY);
            toolStripButtonLocation.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_TOOLSTRIPBUTTON_LOCATION);
            toolStripButtonPayer.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_TOOLSTRIPBUTTON_PAYER);
            toolStripButtonPaymentMode.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_TOOLSTRIPBUTTON_PAYMENTMODE);
            toolStripButtonProduct.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_TOOLSTRIPBUTTON_PRODUCT);
            toolStripButtonUnit.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_TOOLSTRIPBUTTON_UNIT);

            this.lablePeriod.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_LABEL_PERIOD);
            this.buttonSearch.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_BUTTON_SEARCH);
            Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_FORM_MAIN);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            
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
            DataTable dt = HandlerFactory.getDbHandler().getDataTable("select * from journal_record where date between '" + dateTimePickerStart.Value.ToShortDateString() + "' and '" + dateTimePickerEnd.Value.ToShortDateString() + "'");
            dataGridViewJournalRecord.DataSource = dt;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
    }
}
