namespace JeanieMoney.Forms
{
    partial class RecordInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMoney = new System.Windows.Forms.Label();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.groupBoxInOut = new System.Windows.Forms.GroupBox();
            this.radioButtonIncome = new System.Windows.Forms.RadioButton();
            this.radioButtonOutgoing = new System.Windows.Forms.RadioButton();
            this.dateTimePickerRecordInput = new System.Windows.Forms.DateTimePicker();
            this.labelPayer = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxPayer = new System.Windows.Forms.TextBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.labelSummaryPaymentMode = new System.Windows.Forms.Label();
            this.labelSummaryPaymentModeResult = new System.Windows.Forms.Label();
            this.listViewSummaryDetails = new System.Windows.Forms.ListView();
            this.labelSummaryPayerResult = new System.Windows.Forms.Label();
            this.labelSummaryPayer = new System.Windows.Forms.Label();
            this.labelSummaryLocation = new System.Windows.Forms.Label();
            this.labelSummaryLocationResult = new System.Windows.Forms.Label();
            this.labelSummaryInOutResult = new System.Windows.Forms.Label();
            this.labelSummaryMoney = new System.Windows.Forms.Label();
            this.labelSummaryMoneyResult = new System.Windows.Forms.Label();
            this.labelSummaryDate = new System.Windows.Forms.Label();
            this.labelSummaryDateResult = new System.Windows.Forms.Label();
            this.labelSummaryCategoryResult = new System.Windows.Forms.Label();
            this.labelSummaryCategory = new System.Windows.Forms.Label();
            this.labelSummaryDetails = new System.Windows.Forms.Label();
            this.labelSummaryInOut = new System.Windows.Forms.Label();
            this.listBoxPayer = new System.Windows.Forms.ListBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.listBoxLocation = new System.Windows.Forms.ListBox();
            this.listBoxDetailProduct = new System.Windows.Forms.ListBox();
            this.labelDetailManufactoryName = new System.Windows.Forms.Label();
            this.labelDetailUnit = new System.Windows.Forms.Label();
            this.buttonDetailRemoveFromSummary = new System.Windows.Forms.Button();
            this.buttonDetailAddToSummary = new System.Windows.Forms.Button();
            this.listBoxDetailBeneficiary = new System.Windows.Forms.ListBox();
            this.labelDetailAveragePrice = new System.Windows.Forms.Label();
            this.labelDetailTotal = new System.Windows.Forms.Label();
            this.labelDetailQuantity = new System.Windows.Forms.Label();
            this.textBoxDetailQuantity = new System.Windows.Forms.TextBox();
            this.labelDetailPrice = new System.Windows.Forms.Label();
            this.textBoxDetailPrice = new System.Windows.Forms.TextBox();
            this.labelDetailBeneficiaryName = new System.Windows.Forms.Label();
            this.textBoxDetailBeneficiary = new System.Windows.Forms.TextBox();
            this.labelDetailProduct = new System.Windows.Forms.Label();
            this.textBoxDetailProduct = new System.Windows.Forms.TextBox();
            this.checkBoxDetails = new System.Windows.Forms.CheckBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.labelDetailTotalResult = new System.Windows.Forms.Label();
            this.labelDetailBeneficiaryResult = new System.Windows.Forms.Label();
            this.labelDetailProductResultTitle = new System.Windows.Forms.Label();
            this.labelDetailPriceAverageResult = new System.Windows.Forms.Label();
            this.labelDetailManufactoryResult = new System.Windows.Forms.Label();
            this.labelDetailUnitResult = new System.Windows.Forms.Label();
            this.labelDetailProductResult = new System.Windows.Forms.Label();
            this.listBoxPaymentMode = new System.Windows.Forms.ListBox();
            this.labelPaymentMode = new System.Windows.Forms.Label();
            this.textBoxPaymentMode = new System.Windows.Forms.TextBox();
            this.groupBoxInOut.SuspendLayout();
            this.groupBoxSummary.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(142, 15);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(39, 13);
            this.labelMoney.TabIndex = 0;
            this.labelMoney.Text = "Money";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(187, 12);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(110, 20);
            this.textBoxMoney.TabIndex = 3;
            this.textBoxMoney.Leave += new System.EventHandler(this.textBoxMoney_Leave);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(18, 67);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(49, 13);
            this.labelCategory.TabIndex = 6;
            this.labelCategory.Text = "Category";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(143, 42);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 20;
            this.labelDate.Text = "Date";
            // 
            // groupBoxInOut
            // 
            this.groupBoxInOut.Controls.Add(this.radioButtonIncome);
            this.groupBoxInOut.Controls.Add(this.radioButtonOutgoing);
            this.groupBoxInOut.Location = new System.Drawing.Point(20, 7);
            this.groupBoxInOut.Name = "groupBoxInOut";
            this.groupBoxInOut.Size = new System.Drawing.Size(116, 46);
            this.groupBoxInOut.TabIndex = 0;
            this.groupBoxInOut.TabStop = false;
            // 
            // radioButtonIncome
            // 
            this.radioButtonIncome.AutoSize = true;
            this.radioButtonIncome.Location = new System.Drawing.Point(66, 20);
            this.radioButtonIncome.Name = "radioButtonIncome";
            this.radioButtonIncome.Size = new System.Drawing.Size(34, 17);
            this.radioButtonIncome.TabIndex = 2;
            this.radioButtonIncome.Text = "In";
            this.radioButtonIncome.UseVisualStyleBackColor = true;
            // 
            // radioButtonOutgoing
            // 
            this.radioButtonOutgoing.AutoSize = true;
            this.radioButtonOutgoing.Checked = true;
            this.radioButtonOutgoing.Location = new System.Drawing.Point(6, 20);
            this.radioButtonOutgoing.Name = "radioButtonOutgoing";
            this.radioButtonOutgoing.Size = new System.Drawing.Size(42, 17);
            this.radioButtonOutgoing.TabIndex = 1;
            this.radioButtonOutgoing.TabStop = true;
            this.radioButtonOutgoing.Text = "Out";
            this.radioButtonOutgoing.UseVisualStyleBackColor = true;
            this.radioButtonOutgoing.CheckedChanged += new System.EventHandler(this.radioButtonOut_CheckedChanged);
            // 
            // dateTimePickerRecordInput
            // 
            this.dateTimePickerRecordInput.Location = new System.Drawing.Point(187, 38);
            this.dateTimePickerRecordInput.Name = "dateTimePickerRecordInput";
            this.dateTimePickerRecordInput.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerRecordInput.TabIndex = 4;
            this.dateTimePickerRecordInput.Value = new System.DateTime(2011, 12, 6, 0, 0, 0, 0);
            this.dateTimePickerRecordInput.Leave += new System.EventHandler(this.dateTimePickerRecordInput_Leave);
            // 
            // labelPayer
            // 
            this.labelPayer.AutoSize = true;
            this.labelPayer.Location = new System.Drawing.Point(306, 15);
            this.labelPayer.Name = "labelPayer";
            this.labelPayer.Size = new System.Drawing.Size(34, 13);
            this.labelPayer.TabIndex = 25;
            this.labelPayer.Text = "Payer";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(200, 69);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(48, 13);
            this.labelLocation.TabIndex = 27;
            this.labelLocation.Text = "Location";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(461, 517);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(364, 517);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 16;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(558, 517);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(73, 64);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(115, 20);
            this.textBoxCategory.TabIndex = 6;
            this.textBoxCategory.TextChanged += new System.EventHandler(this.textBoxCategory_TextChanged);
            this.textBoxCategory.Enter += new System.EventHandler(this.textBoxCategory_TextChanged);
            this.textBoxCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCategory_KeyUp);
            this.textBoxCategory.Leave += new System.EventHandler(this.textBoxCategory_Leave);
            // 
            // textBoxPayer
            // 
            this.textBoxPayer.Location = new System.Drawing.Point(349, 12);
            this.textBoxPayer.Name = "textBoxPayer";
            this.textBoxPayer.Size = new System.Drawing.Size(94, 20);
            this.textBoxPayer.TabIndex = 5;
            this.textBoxPayer.TextChanged += new System.EventHandler(this.textBoxPayer_TextChanged);
            this.textBoxPayer.Enter += new System.EventHandler(this.textBoxPayer_TextChanged);
            this.textBoxPayer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPayer_KeyUp);
            this.textBoxPayer.Leave += new System.EventHandler(this.textBoxPayer_Leave);
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(73, 85);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(115, 95);
            this.listBoxCategory.TabIndex = 0;
            this.listBoxCategory.TabStop = false;
            this.listBoxCategory.Click += new System.EventHandler(this.listBoxCategory_Click);
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Controls.Add(this.labelSummaryPaymentMode);
            this.groupBoxSummary.Controls.Add(this.labelSummaryPaymentModeResult);
            this.groupBoxSummary.Controls.Add(this.listViewSummaryDetails);
            this.groupBoxSummary.Controls.Add(this.labelSummaryPayerResult);
            this.groupBoxSummary.Controls.Add(this.labelSummaryPayer);
            this.groupBoxSummary.Controls.Add(this.labelSummaryLocation);
            this.groupBoxSummary.Controls.Add(this.labelSummaryLocationResult);
            this.groupBoxSummary.Controls.Add(this.labelSummaryInOutResult);
            this.groupBoxSummary.Controls.Add(this.labelSummaryMoney);
            this.groupBoxSummary.Controls.Add(this.labelSummaryMoneyResult);
            this.groupBoxSummary.Controls.Add(this.labelSummaryDate);
            this.groupBoxSummary.Controls.Add(this.labelSummaryDateResult);
            this.groupBoxSummary.Controls.Add(this.labelSummaryCategoryResult);
            this.groupBoxSummary.Controls.Add(this.labelSummaryCategory);
            this.groupBoxSummary.Controls.Add(this.labelSummaryDetails);
            this.groupBoxSummary.Controls.Add(this.labelSummaryInOut);
            this.groupBoxSummary.Location = new System.Drawing.Point(461, 7);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(545, 491);
            this.groupBoxSummary.TabIndex = 32;
            this.groupBoxSummary.TabStop = false;
            this.groupBoxSummary.Text = "Summary";
            // 
            // labelSummaryPaymentMode
            // 
            this.labelSummaryPaymentMode.AutoSize = true;
            this.labelSummaryPaymentMode.Location = new System.Drawing.Point(146, 72);
            this.labelSummaryPaymentMode.Name = "labelSummaryPaymentMode";
            this.labelSummaryPaymentMode.Size = new System.Drawing.Size(78, 13);
            this.labelSummaryPaymentMode.TabIndex = 16;
            this.labelSummaryPaymentMode.Text = "PaymentMode:";
            // 
            // labelSummaryPaymentModeResult
            // 
            this.labelSummaryPaymentModeResult.AutoSize = true;
            this.labelSummaryPaymentModeResult.Location = new System.Drawing.Point(253, 72);
            this.labelSummaryPaymentModeResult.Name = "labelSummaryPaymentModeResult";
            this.labelSummaryPaymentModeResult.Size = new System.Drawing.Size(0, 13);
            this.labelSummaryPaymentModeResult.TabIndex = 15;
            // 
            // listViewSummaryDetails
            // 
            this.listViewSummaryDetails.FullRowSelect = true;
            this.listViewSummaryDetails.HideSelection = false;
            this.listViewSummaryDetails.Location = new System.Drawing.Point(25, 112);
            this.listViewSummaryDetails.MultiSelect = false;
            this.listViewSummaryDetails.Name = "listViewSummaryDetails";
            this.listViewSummaryDetails.Size = new System.Drawing.Size(514, 373);
            this.listViewSummaryDetails.TabIndex = 14;
            this.listViewSummaryDetails.TabStop = false;
            this.listViewSummaryDetails.UseCompatibleStateImageBehavior = false;
            this.listViewSummaryDetails.View = System.Windows.Forms.View.Details;
            // 
            // labelSummaryPayerResult
            // 
            this.labelSummaryPayerResult.AutoSize = true;
            this.labelSummaryPayerResult.Location = new System.Drawing.Point(189, 51);
            this.labelSummaryPayerResult.Name = "labelSummaryPayerResult";
            this.labelSummaryPayerResult.Size = new System.Drawing.Size(0, 13);
            this.labelSummaryPayerResult.TabIndex = 12;
            // 
            // labelSummaryPayer
            // 
            this.labelSummaryPayer.AutoSize = true;
            this.labelSummaryPayer.Location = new System.Drawing.Point(146, 51);
            this.labelSummaryPayer.Name = "labelSummaryPayer";
            this.labelSummaryPayer.Size = new System.Drawing.Size(37, 13);
            this.labelSummaryPayer.TabIndex = 11;
            this.labelSummaryPayer.Text = "Payer:";
            // 
            // labelSummaryLocation
            // 
            this.labelSummaryLocation.AutoSize = true;
            this.labelSummaryLocation.Location = new System.Drawing.Point(22, 72);
            this.labelSummaryLocation.Name = "labelSummaryLocation";
            this.labelSummaryLocation.Size = new System.Drawing.Size(49, 13);
            this.labelSummaryLocation.TabIndex = 10;
            this.labelSummaryLocation.Text = "Locaton:";
            // 
            // labelSummaryLocationResult
            // 
            this.labelSummaryLocationResult.AutoSize = true;
            this.labelSummaryLocationResult.Location = new System.Drawing.Point(73, 72);
            this.labelSummaryLocationResult.Name = "labelSummaryLocationResult";
            this.labelSummaryLocationResult.Size = new System.Drawing.Size(0, 13);
            this.labelSummaryLocationResult.TabIndex = 9;
            // 
            // labelSummaryInOutResult
            // 
            this.labelSummaryInOutResult.AutoSize = true;
            this.labelSummaryInOutResult.Location = new System.Drawing.Point(63, 26);
            this.labelSummaryInOutResult.Name = "labelSummaryInOutResult";
            this.labelSummaryInOutResult.Size = new System.Drawing.Size(42, 13);
            this.labelSummaryInOutResult.TabIndex = 8;
            this.labelSummaryInOutResult.Text = "Income";
            // 
            // labelSummaryMoney
            // 
            this.labelSummaryMoney.AutoSize = true;
            this.labelSummaryMoney.Location = new System.Drawing.Point(120, 26);
            this.labelSummaryMoney.Name = "labelSummaryMoney";
            this.labelSummaryMoney.Size = new System.Drawing.Size(42, 13);
            this.labelSummaryMoney.TabIndex = 7;
            this.labelSummaryMoney.Text = "Money:";
            // 
            // labelSummaryMoneyResult
            // 
            this.labelSummaryMoneyResult.AutoSize = true;
            this.labelSummaryMoneyResult.Location = new System.Drawing.Point(168, 26);
            this.labelSummaryMoneyResult.Name = "labelSummaryMoneyResult";
            this.labelSummaryMoneyResult.Size = new System.Drawing.Size(31, 13);
            this.labelSummaryMoneyResult.TabIndex = 6;
            this.labelSummaryMoneyResult.Text = "1000";
            // 
            // labelSummaryDate
            // 
            this.labelSummaryDate.AutoSize = true;
            this.labelSummaryDate.Location = new System.Drawing.Point(253, 26);
            this.labelSummaryDate.Name = "labelSummaryDate";
            this.labelSummaryDate.Size = new System.Drawing.Size(33, 13);
            this.labelSummaryDate.TabIndex = 5;
            this.labelSummaryDate.Text = "Date:";
            // 
            // labelSummaryDateResult
            // 
            this.labelSummaryDateResult.AutoSize = true;
            this.labelSummaryDateResult.Location = new System.Drawing.Point(289, 26);
            this.labelSummaryDateResult.Name = "labelSummaryDateResult";
            this.labelSummaryDateResult.Size = new System.Drawing.Size(65, 13);
            this.labelSummaryDateResult.TabIndex = 4;
            this.labelSummaryDateResult.Text = "2011/12/12";
            // 
            // labelSummaryCategoryResult
            // 
            this.labelSummaryCategoryResult.AutoSize = true;
            this.labelSummaryCategoryResult.Location = new System.Drawing.Point(77, 51);
            this.labelSummaryCategoryResult.Name = "labelSummaryCategoryResult";
            this.labelSummaryCategoryResult.Size = new System.Drawing.Size(0, 13);
            this.labelSummaryCategoryResult.TabIndex = 3;
            // 
            // labelSummaryCategory
            // 
            this.labelSummaryCategory.AutoSize = true;
            this.labelSummaryCategory.Location = new System.Drawing.Point(22, 51);
            this.labelSummaryCategory.Name = "labelSummaryCategory";
            this.labelSummaryCategory.Size = new System.Drawing.Size(52, 13);
            this.labelSummaryCategory.TabIndex = 2;
            this.labelSummaryCategory.Text = "Category:";
            // 
            // labelSummaryDetails
            // 
            this.labelSummaryDetails.AutoSize = true;
            this.labelSummaryDetails.Location = new System.Drawing.Point(22, 96);
            this.labelSummaryDetails.Name = "labelSummaryDetails";
            this.labelSummaryDetails.Size = new System.Drawing.Size(39, 13);
            this.labelSummaryDetails.TabIndex = 1;
            this.labelSummaryDetails.Text = "Details";
            // 
            // labelSummaryInOut
            // 
            this.labelSummaryInOut.AutoSize = true;
            this.labelSummaryInOut.Location = new System.Drawing.Point(22, 26);
            this.labelSummaryInOut.Name = "labelSummaryInOut";
            this.labelSummaryInOut.Size = new System.Drawing.Size(36, 13);
            this.labelSummaryInOut.TabIndex = 0;
            this.labelSummaryInOut.Text = "InOut:";
            // 
            // listBoxPayer
            // 
            this.listBoxPayer.FormattingEnabled = true;
            this.listBoxPayer.Location = new System.Drawing.Point(349, 29);
            this.listBoxPayer.Name = "listBoxPayer";
            this.listBoxPayer.Size = new System.Drawing.Size(94, 134);
            this.listBoxPayer.TabIndex = 0;
            this.listBoxPayer.TabStop = false;
            this.listBoxPayer.Click += new System.EventHandler(this.listBoxPayer_Click);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(259, 67);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(184, 20);
            this.textBoxLocation.TabIndex = 7;
            this.textBoxLocation.TextChanged += new System.EventHandler(this.textBoxLocation_TextChanged);
            this.textBoxLocation.Enter += new System.EventHandler(this.textBoxLocation_TextChanged);
            this.textBoxLocation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxLocation_KeyUp);
            this.textBoxLocation.Leave += new System.EventHandler(this.textBoxLocation_Leave);
            // 
            // listBoxLocation
            // 
            this.listBoxLocation.FormattingEnabled = true;
            this.listBoxLocation.Location = new System.Drawing.Point(259, 87);
            this.listBoxLocation.Name = "listBoxLocation";
            this.listBoxLocation.Size = new System.Drawing.Size(184, 147);
            this.listBoxLocation.TabIndex = 0;
            this.listBoxLocation.TabStop = false;
            this.listBoxLocation.Click += new System.EventHandler(this.listBoxLocation_Click);
            // 
            // listBoxDetailProduct
            // 
            this.listBoxDetailProduct.FormattingEnabled = true;
            this.listBoxDetailProduct.Location = new System.Drawing.Point(65, 33);
            this.listBoxDetailProduct.Name = "listBoxDetailProduct";
            this.listBoxDetailProduct.Size = new System.Drawing.Size(288, 134);
            this.listBoxDetailProduct.TabIndex = 0;
            this.listBoxDetailProduct.TabStop = false;
            this.listBoxDetailProduct.Click += new System.EventHandler(this.listBoxDetailProduct_Click);
            // 
            // labelDetailManufactoryName
            // 
            this.labelDetailManufactoryName.AutoSize = true;
            this.labelDetailManufactoryName.Location = new System.Drawing.Point(24, 79);
            this.labelDetailManufactoryName.Name = "labelDetailManufactoryName";
            this.labelDetailManufactoryName.Size = new System.Drawing.Size(94, 13);
            this.labelDetailManufactoryName.TabIndex = 42;
            this.labelDetailManufactoryName.Text = "ManufactoryName";
            // 
            // labelDetailUnit
            // 
            this.labelDetailUnit.AutoSize = true;
            this.labelDetailUnit.Location = new System.Drawing.Point(24, 57);
            this.labelDetailUnit.Name = "labelDetailUnit";
            this.labelDetailUnit.Size = new System.Drawing.Size(26, 13);
            this.labelDetailUnit.TabIndex = 41;
            this.labelDetailUnit.Text = "Unit";
            // 
            // buttonDetailRemoveFromSummary
            // 
            this.buttonDetailRemoveFromSummary.Location = new System.Drawing.Point(400, 161);
            this.buttonDetailRemoveFromSummary.Name = "buttonDetailRemoveFromSummary";
            this.buttonDetailRemoveFromSummary.Size = new System.Drawing.Size(31, 23);
            this.buttonDetailRemoveFromSummary.TabIndex = 15;
            this.buttonDetailRemoveFromSummary.Text = "<<";
            this.buttonDetailRemoveFromSummary.UseVisualStyleBackColor = true;
            // 
            // buttonDetailAddToSummary
            // 
            this.buttonDetailAddToSummary.Location = new System.Drawing.Point(400, 103);
            this.buttonDetailAddToSummary.Name = "buttonDetailAddToSummary";
            this.buttonDetailAddToSummary.Size = new System.Drawing.Size(31, 23);
            this.buttonDetailAddToSummary.TabIndex = 14;
            this.buttonDetailAddToSummary.Text = ">>";
            this.buttonDetailAddToSummary.UseVisualStyleBackColor = true;
            this.buttonDetailAddToSummary.Click += new System.EventHandler(this.buttonDetailAddToSummary_Click);
            // 
            // listBoxDetailBeneficiary
            // 
            this.listBoxDetailBeneficiary.FormattingEnabled = true;
            this.listBoxDetailBeneficiary.Location = new System.Drawing.Point(85, 202);
            this.listBoxDetailBeneficiary.Name = "listBoxDetailBeneficiary";
            this.listBoxDetailBeneficiary.Size = new System.Drawing.Size(100, 108);
            this.listBoxDetailBeneficiary.TabIndex = 0;
            this.listBoxDetailBeneficiary.TabStop = false;
            this.listBoxDetailBeneficiary.Click += new System.EventHandler(this.listBoxDetailBeneficiary_Click);
            // 
            // labelDetailAveragePrice
            // 
            this.labelDetailAveragePrice.AutoSize = true;
            this.labelDetailAveragePrice.Location = new System.Drawing.Point(24, 103);
            this.labelDetailAveragePrice.Name = "labelDetailAveragePrice";
            this.labelDetailAveragePrice.Size = new System.Drawing.Size(71, 13);
            this.labelDetailAveragePrice.TabIndex = 36;
            this.labelDetailAveragePrice.Text = "PriceAverage";
            // 
            // labelDetailTotal
            // 
            this.labelDetailTotal.AutoSize = true;
            this.labelDetailTotal.Location = new System.Drawing.Point(222, 249);
            this.labelDetailTotal.Name = "labelDetailTotal";
            this.labelDetailTotal.Size = new System.Drawing.Size(31, 13);
            this.labelDetailTotal.TabIndex = 35;
            this.labelDetailTotal.Text = "Total";
            // 
            // labelDetailQuantity
            // 
            this.labelDetailQuantity.AutoSize = true;
            this.labelDetailQuantity.Location = new System.Drawing.Point(204, 216);
            this.labelDetailQuantity.Name = "labelDetailQuantity";
            this.labelDetailQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelDetailQuantity.TabIndex = 34;
            this.labelDetailQuantity.Text = "Quantity";
            // 
            // textBoxDetailQuantity
            // 
            this.textBoxDetailQuantity.Location = new System.Drawing.Point(260, 212);
            this.textBoxDetailQuantity.Name = "textBoxDetailQuantity";
            this.textBoxDetailQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxDetailQuantity.TabIndex = 13;
            this.textBoxDetailQuantity.TextChanged += new System.EventHandler(this.textBoxDetailQuantity_TextChanged);
            this.textBoxDetailQuantity.Leave += new System.EventHandler(this.textBoxDetailQuantity_Leave);
            // 
            // labelDetailPrice
            // 
            this.labelDetailPrice.AutoSize = true;
            this.labelDetailPrice.Location = new System.Drawing.Point(219, 185);
            this.labelDetailPrice.Name = "labelDetailPrice";
            this.labelDetailPrice.Size = new System.Drawing.Size(31, 13);
            this.labelDetailPrice.TabIndex = 32;
            this.labelDetailPrice.Text = "Price";
            // 
            // textBoxDetailPrice
            // 
            this.textBoxDetailPrice.Location = new System.Drawing.Point(260, 182);
            this.textBoxDetailPrice.Name = "textBoxDetailPrice";
            this.textBoxDetailPrice.Size = new System.Drawing.Size(101, 20);
            this.textBoxDetailPrice.TabIndex = 12;
            this.textBoxDetailPrice.TextChanged += new System.EventHandler(this.textBoxDetailPrice_TextChanged);
            this.textBoxDetailPrice.Leave += new System.EventHandler(this.textBoxDetailPrice_Leave);
            // 
            // labelDetailBeneficiaryName
            // 
            this.labelDetailBeneficiaryName.AutoSize = true;
            this.labelDetailBeneficiaryName.Location = new System.Drawing.Point(11, 185);
            this.labelDetailBeneficiaryName.Name = "labelDetailBeneficiaryName";
            this.labelDetailBeneficiaryName.Size = new System.Drawing.Size(58, 13);
            this.labelDetailBeneficiaryName.TabIndex = 29;
            this.labelDetailBeneficiaryName.Text = "beneficiary";
            // 
            // textBoxDetailBeneficiary
            // 
            this.textBoxDetailBeneficiary.Location = new System.Drawing.Point(85, 182);
            this.textBoxDetailBeneficiary.Name = "textBoxDetailBeneficiary";
            this.textBoxDetailBeneficiary.Size = new System.Drawing.Size(100, 20);
            this.textBoxDetailBeneficiary.TabIndex = 11;
            this.textBoxDetailBeneficiary.TextChanged += new System.EventHandler(this.textBoxDetailBeneficiary_TextChanged);
            this.textBoxDetailBeneficiary.Enter += new System.EventHandler(this.textBoxDetailBeneficiary_TextChanged);
            this.textBoxDetailBeneficiary.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxDetailBeneficiary_KeyUp);
            this.textBoxDetailBeneficiary.Leave += new System.EventHandler(this.textBoxDetailBeneficiary_Leave);
            // 
            // labelDetailProduct
            // 
            this.labelDetailProduct.AutoSize = true;
            this.labelDetailProduct.Location = new System.Drawing.Point(24, 15);
            this.labelDetailProduct.Name = "labelDetailProduct";
            this.labelDetailProduct.Size = new System.Drawing.Size(35, 13);
            this.labelDetailProduct.TabIndex = 25;
            this.labelDetailProduct.Text = "Name";
            // 
            // textBoxDetailProduct
            // 
            this.textBoxDetailProduct.Location = new System.Drawing.Point(65, 12);
            this.textBoxDetailProduct.Name = "textBoxDetailProduct";
            this.textBoxDetailProduct.Size = new System.Drawing.Size(288, 20);
            this.textBoxDetailProduct.TabIndex = 10;
            this.textBoxDetailProduct.TextChanged += new System.EventHandler(this.textBoxDetailProduct_TextChanged);
            this.textBoxDetailProduct.Enter += new System.EventHandler(this.textBoxDetailProduct_TextChanged);
            this.textBoxDetailProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxDetailProduct_KeyUp);
            this.textBoxDetailProduct.Leave += new System.EventHandler(this.textBoxDetailProduct_Leave);
            // 
            // checkBoxDetails
            // 
            this.checkBoxDetails.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDetails.AutoSize = true;
            this.checkBoxDetails.Location = new System.Drawing.Point(11, 138);
            this.checkBoxDetails.Name = "checkBoxDetails";
            this.checkBoxDetails.Size = new System.Drawing.Size(58, 23);
            this.checkBoxDetails.TabIndex = 9;
            this.checkBoxDetails.Text = "Details->";
            this.checkBoxDetails.UseVisualStyleBackColor = true;
            this.checkBoxDetails.CheckedChanged += new System.EventHandler(this.checkBoxDetails_CheckedChanged);
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.labelDetailTotalResult);
            this.panelDetails.Controls.Add(this.listBoxDetailBeneficiary);
            this.panelDetails.Controls.Add(this.labelDetailBeneficiaryResult);
            this.panelDetails.Controls.Add(this.labelDetailProductResultTitle);
            this.panelDetails.Controls.Add(this.labelDetailPriceAverageResult);
            this.panelDetails.Controls.Add(this.labelDetailManufactoryResult);
            this.panelDetails.Controls.Add(this.labelDetailUnitResult);
            this.panelDetails.Controls.Add(this.labelDetailProductResult);
            this.panelDetails.Controls.Add(this.listBoxDetailProduct);
            this.panelDetails.Controls.Add(this.labelDetailManufactoryName);
            this.panelDetails.Controls.Add(this.textBoxDetailProduct);
            this.panelDetails.Controls.Add(this.labelDetailUnit);
            this.panelDetails.Controls.Add(this.labelDetailProduct);
            this.panelDetails.Controls.Add(this.buttonDetailRemoveFromSummary);
            this.panelDetails.Controls.Add(this.buttonDetailAddToSummary);
            this.panelDetails.Controls.Add(this.textBoxDetailBeneficiary);
            this.panelDetails.Controls.Add(this.labelDetailAveragePrice);
            this.panelDetails.Controls.Add(this.labelDetailBeneficiaryName);
            this.panelDetails.Controls.Add(this.labelDetailTotal);
            this.panelDetails.Controls.Add(this.labelDetailQuantity);
            this.panelDetails.Controls.Add(this.textBoxDetailPrice);
            this.panelDetails.Controls.Add(this.textBoxDetailQuantity);
            this.panelDetails.Controls.Add(this.labelDetailPrice);
            this.panelDetails.Location = new System.Drawing.Point(12, 167);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(443, 332);
            this.panelDetails.TabIndex = 41;
            this.panelDetails.Visible = false;
            // 
            // labelDetailTotalResult
            // 
            this.labelDetailTotalResult.AutoSize = true;
            this.labelDetailTotalResult.Location = new System.Drawing.Point(263, 249);
            this.labelDetailTotalResult.Name = "labelDetailTotalResult";
            this.labelDetailTotalResult.Size = new System.Drawing.Size(0, 13);
            this.labelDetailTotalResult.TabIndex = 49;
            // 
            // labelDetailBeneficiaryResult
            // 
            this.labelDetailBeneficiaryResult.AutoSize = true;
            this.labelDetailBeneficiaryResult.Location = new System.Drawing.Point(82, 212);
            this.labelDetailBeneficiaryResult.Name = "labelDetailBeneficiaryResult";
            this.labelDetailBeneficiaryResult.Size = new System.Drawing.Size(0, 13);
            this.labelDetailBeneficiaryResult.TabIndex = 48;
            // 
            // labelDetailProductResultTitle
            // 
            this.labelDetailProductResultTitle.AutoSize = true;
            this.labelDetailProductResultTitle.Location = new System.Drawing.Point(29, 35);
            this.labelDetailProductResultTitle.Name = "labelDetailProductResultTitle";
            this.labelDetailProductResultTitle.Size = new System.Drawing.Size(35, 13);
            this.labelDetailProductResultTitle.TabIndex = 47;
            this.labelDetailProductResultTitle.Text = "Name";
            // 
            // labelDetailPriceAverageResult
            // 
            this.labelDetailPriceAverageResult.AutoSize = true;
            this.labelDetailPriceAverageResult.Location = new System.Drawing.Point(101, 103);
            this.labelDetailPriceAverageResult.Name = "labelDetailPriceAverageResult";
            this.labelDetailPriceAverageResult.Size = new System.Drawing.Size(0, 13);
            this.labelDetailPriceAverageResult.TabIndex = 46;
            // 
            // labelDetailManufactoryResult
            // 
            this.labelDetailManufactoryResult.AutoSize = true;
            this.labelDetailManufactoryResult.Location = new System.Drawing.Point(124, 79);
            this.labelDetailManufactoryResult.Name = "labelDetailManufactoryResult";
            this.labelDetailManufactoryResult.Size = new System.Drawing.Size(0, 13);
            this.labelDetailManufactoryResult.TabIndex = 45;
            // 
            // labelDetailUnitResult
            // 
            this.labelDetailUnitResult.AutoSize = true;
            this.labelDetailUnitResult.Location = new System.Drawing.Point(98, 57);
            this.labelDetailUnitResult.Name = "labelDetailUnitResult";
            this.labelDetailUnitResult.Size = new System.Drawing.Size(0, 13);
            this.labelDetailUnitResult.TabIndex = 44;
            // 
            // labelDetailProductResult
            // 
            this.labelDetailProductResult.AutoSize = true;
            this.labelDetailProductResult.Location = new System.Drawing.Point(64, 35);
            this.labelDetailProductResult.Name = "labelDetailProductResult";
            this.labelDetailProductResult.Size = new System.Drawing.Size(0, 13);
            this.labelDetailProductResult.TabIndex = 43;
            // 
            // listBoxPaymentMode
            // 
            this.listBoxPaymentMode.FormattingEnabled = true;
            this.listBoxPaymentMode.Location = new System.Drawing.Point(119, 118);
            this.listBoxPaymentMode.Name = "listBoxPaymentMode";
            this.listBoxPaymentMode.Size = new System.Drawing.Size(184, 147);
            this.listBoxPaymentMode.TabIndex = 0;
            this.listBoxPaymentMode.TabStop = false;
            this.listBoxPaymentMode.Click += new System.EventHandler(this.listBoxPaymentMode_Click);
            // 
            // labelPaymentMode
            // 
            this.labelPaymentMode.AutoSize = true;
            this.labelPaymentMode.Location = new System.Drawing.Point(18, 100);
            this.labelPaymentMode.Name = "labelPaymentMode";
            this.labelPaymentMode.Size = new System.Drawing.Size(75, 13);
            this.labelPaymentMode.TabIndex = 44;
            this.labelPaymentMode.Text = "PaymentMode";
            // 
            // textBoxPaymentMode
            // 
            this.textBoxPaymentMode.Location = new System.Drawing.Point(119, 96);
            this.textBoxPaymentMode.Name = "textBoxPaymentMode";
            this.textBoxPaymentMode.Size = new System.Drawing.Size(184, 20);
            this.textBoxPaymentMode.TabIndex = 8;
            this.textBoxPaymentMode.TextChanged += new System.EventHandler(this.textBoxPaymentMode_TextChanged);
            this.textBoxPaymentMode.Enter += new System.EventHandler(this.textBoxPaymentMode_TextChanged);
            this.textBoxPaymentMode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPaymentMode_KeyUp);
            this.textBoxPaymentMode.Leave += new System.EventHandler(this.textBoxPaymentMode_Leave);
            // 
            // RecordInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 553);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.listBoxPaymentMode);
            this.Controls.Add(this.labelPaymentMode);
            this.Controls.Add(this.textBoxPaymentMode);
            this.Controls.Add(this.listBoxLocation);
            this.Controls.Add(this.listBoxPayer);
            this.Controls.Add(this.groupBoxSummary);
            this.Controls.Add(this.textBoxPayer);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelPayer);
            this.Controls.Add(this.dateTimePickerRecordInput);
            this.Controls.Add(this.groupBoxInOut);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.checkBoxDetails);
            this.Controls.Add(this.panelDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RecordInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RecordInput";
            this.Load += new System.EventHandler(this.RecordInput_Load);
            this.groupBoxInOut.ResumeLayout(false);
            this.groupBoxInOut.PerformLayout();
            this.groupBoxSummary.ResumeLayout(false);
            this.groupBoxSummary.PerformLayout();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.GroupBox groupBoxInOut;
        private System.Windows.Forms.RadioButton radioButtonIncome;
        private System.Windows.Forms.RadioButton radioButtonOutgoing;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecordInput;
        private System.Windows.Forms.Label labelPayer;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxPayer;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label labelSummaryPayerResult;
        private System.Windows.Forms.Label labelSummaryPayer;
        private System.Windows.Forms.Label labelSummaryLocation;
        private System.Windows.Forms.Label labelSummaryLocationResult;
        private System.Windows.Forms.Label labelSummaryInOutResult;
        private System.Windows.Forms.Label labelSummaryMoney;
        private System.Windows.Forms.Label labelSummaryMoneyResult;
        private System.Windows.Forms.Label labelSummaryDate;
        private System.Windows.Forms.Label labelSummaryDateResult;
        private System.Windows.Forms.Label labelSummaryCategoryResult;
        private System.Windows.Forms.Label labelSummaryCategory;
        private System.Windows.Forms.Label labelSummaryDetails;
        private System.Windows.Forms.Label labelSummaryInOut;
        private System.Windows.Forms.ListBox listBoxPayer;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.ListBox listBoxLocation;
        private System.Windows.Forms.ListBox listBoxDetailProduct;
        private System.Windows.Forms.Label labelDetailManufactoryName;
        private System.Windows.Forms.Label labelDetailUnit;
        private System.Windows.Forms.Button buttonDetailRemoveFromSummary;
        private System.Windows.Forms.Button buttonDetailAddToSummary;
        private System.Windows.Forms.ListBox listBoxDetailBeneficiary;
        private System.Windows.Forms.Label labelDetailAveragePrice;
        private System.Windows.Forms.Label labelDetailTotal;
        private System.Windows.Forms.Label labelDetailQuantity;
        private System.Windows.Forms.TextBox textBoxDetailQuantity;
        private System.Windows.Forms.Label labelDetailPrice;
        private System.Windows.Forms.TextBox textBoxDetailPrice;
        private System.Windows.Forms.Label labelDetailBeneficiaryName;
        private System.Windows.Forms.TextBox textBoxDetailBeneficiary;
        private System.Windows.Forms.Label labelDetailProduct;
        private System.Windows.Forms.TextBox textBoxDetailProduct;
        private System.Windows.Forms.CheckBox checkBoxDetails;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label labelDetailPriceAverageResult;
        private System.Windows.Forms.Label labelDetailManufactoryResult;
        private System.Windows.Forms.Label labelDetailUnitResult;
        private System.Windows.Forms.Label labelDetailProductResult;
        private System.Windows.Forms.Label labelDetailProductResultTitle;
        private System.Windows.Forms.Label labelDetailBeneficiaryResult;
        private System.Windows.Forms.ListView listViewSummaryDetails;
        private System.Windows.Forms.Label labelDetailTotalResult;
        private System.Windows.Forms.ListBox listBoxPaymentMode;
        private System.Windows.Forms.Label labelPaymentMode;
        private System.Windows.Forms.TextBox textBoxPaymentMode;
        private System.Windows.Forms.Label labelSummaryPaymentMode;
        private System.Windows.Forms.Label labelSummaryPaymentModeResult;
    }
}