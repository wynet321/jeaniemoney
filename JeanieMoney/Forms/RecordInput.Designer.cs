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
            this.radioButtonIn = new System.Windows.Forms.RadioButton();
            this.radioButtonOut = new System.Windows.Forms.RadioButton();
            this.dateTimePickerRecordInput = new System.Windows.Forms.DateTimePicker();
            this.labelPayer = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxPayer = new System.Windows.Forms.TextBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.buttonShowListCategory = new System.Windows.Forms.Button();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.listBoxDetails = new System.Windows.Forms.ListBox();
            this.labelSummaryResultPayer = new System.Windows.Forms.Label();
            this.labelSummaryPayer = new System.Windows.Forms.Label();
            this.labelSummaryLocation = new System.Windows.Forms.Label();
            this.labelSummaryResultLocation = new System.Windows.Forms.Label();
            this.labelSummaryResultInOut = new System.Windows.Forms.Label();
            this.labelSummaryMoney = new System.Windows.Forms.Label();
            this.labelSummaryResultMoney = new System.Windows.Forms.Label();
            this.labelSummaryDate = new System.Windows.Forms.Label();
            this.labelSummaryResultDate = new System.Windows.Forms.Label();
            this.labelSummaryResultCategory = new System.Windows.Forms.Label();
            this.labelSummaryCategory = new System.Windows.Forms.Label();
            this.labelSummaryDetails = new System.Windows.Forms.Label();
            this.labelSummaryInOut = new System.Windows.Forms.Label();
            this.buttonShowListPayer = new System.Windows.Forms.Button();
            this.listBoxPayer = new System.Windows.Forms.ListBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.buttonShowListLocation = new System.Windows.Forms.Button();
            this.listBoxLocation = new System.Windows.Forms.ListBox();
            this.listBoxDetailProduct = new System.Windows.Forms.ListBox();
            this.labelDetailManufactoryName = new System.Windows.Forms.Label();
            this.labelDetailSpecification = new System.Windows.Forms.Label();
            this.buttonDetailRemoveFromSummary = new System.Windows.Forms.Button();
            this.buttonDetailAddToSummary = new System.Windows.Forms.Button();
            this.listBoxDetailBeneficiary = new System.Windows.Forms.ListBox();
            this.labelDetailPriceAverage = new System.Windows.Forms.Label();
            this.labelDetailTotal = new System.Windows.Forms.Label();
            this.labelDetailQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelDetailPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonDetailShowListBeneficiary = new System.Windows.Forms.Button();
            this.labelBeneficiaryName = new System.Windows.Forms.Label();
            this.textBoxDetailBeneficiary = new System.Windows.Forms.TextBox();
            this.buttonDetailShowListProductName = new System.Windows.Forms.Button();
            this.labelDetailProductName = new System.Windows.Forms.Label();
            this.textBoxDetailProduct = new System.Windows.Forms.TextBox();
            this.checkBoxDetails = new System.Windows.Forms.CheckBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.labelDetailBeneficiaryResult = new System.Windows.Forms.Label();
            this.labelDetailProductNameResultTitle = new System.Windows.Forms.Label();
            this.labelDetailPriceAverageResult = new System.Windows.Forms.Label();
            this.labelDetailManufactoryResult = new System.Windows.Forms.Label();
            this.labelDetailSpecificationResult = new System.Windows.Forms.Label();
            this.labelDetailProductResult = new System.Windows.Forms.Label();
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
            this.groupBoxInOut.Controls.Add(this.radioButtonIn);
            this.groupBoxInOut.Controls.Add(this.radioButtonOut);
            this.groupBoxInOut.Location = new System.Drawing.Point(17, 12);
            this.groupBoxInOut.Name = "groupBoxInOut";
            this.groupBoxInOut.Size = new System.Drawing.Size(116, 46);
            this.groupBoxInOut.TabIndex = 0;
            this.groupBoxInOut.TabStop = false;
            this.groupBoxInOut.Text = "InOut";
            // 
            // radioButtonIn
            // 
            this.radioButtonIn.AutoSize = true;
            this.radioButtonIn.Location = new System.Drawing.Point(66, 19);
            this.radioButtonIn.Name = "radioButtonIn";
            this.radioButtonIn.Size = new System.Drawing.Size(34, 17);
            this.radioButtonIn.TabIndex = 2;
            this.radioButtonIn.Text = "In";
            this.radioButtonIn.UseVisualStyleBackColor = true;
            // 
            // radioButtonOut
            // 
            this.radioButtonOut.AutoSize = true;
            this.radioButtonOut.Checked = true;
            this.radioButtonOut.Location = new System.Drawing.Point(6, 19);
            this.radioButtonOut.Name = "radioButtonOut";
            this.radioButtonOut.Size = new System.Drawing.Size(42, 17);
            this.radioButtonOut.TabIndex = 1;
            this.radioButtonOut.TabStop = true;
            this.radioButtonOut.Text = "Out";
            this.radioButtonOut.UseVisualStyleBackColor = true;
            this.radioButtonOut.CheckedChanged += new System.EventHandler(this.radioButtonOut_CheckedChanged);
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
            this.labelPayer.Location = new System.Drawing.Point(228, 70);
            this.labelPayer.Name = "labelPayer";
            this.labelPayer.Size = new System.Drawing.Size(34, 13);
            this.labelPayer.TabIndex = 25;
            this.labelPayer.Text = "Payer";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(14, 99);
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
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(364, 517);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(558, 517);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(73, 64);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(115, 20);
            this.textBoxCategory.TabIndex = 5;
            this.textBoxCategory.TextChanged += new System.EventHandler(this.textBoxCategory_TextChanged);
            this.textBoxCategory.Enter += new System.EventHandler(this.textBoxCategory_TextChanged);
            this.textBoxCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCategory_KeyUp);
            this.textBoxCategory.Leave += new System.EventHandler(this.textBoxCategory_Leave);
            // 
            // textBoxPayer
            // 
            this.textBoxPayer.Location = new System.Drawing.Point(271, 67);
            this.textBoxPayer.Name = "textBoxPayer";
            this.textBoxPayer.Size = new System.Drawing.Size(94, 20);
            this.textBoxPayer.TabIndex = 6;
            this.textBoxPayer.TextChanged += new System.EventHandler(this.textBoxPayer_TextChanged);
            this.textBoxPayer.Enter += new System.EventHandler(this.textBoxPayer_TextChanged);
            this.textBoxPayer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPayer_KeyUp);
            this.textBoxPayer.Leave += new System.EventHandler(this.textBoxPayer_Leave);
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(73, 84);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(115, 199);
            this.listBoxCategory.TabIndex = 30;
            this.listBoxCategory.Click += new System.EventHandler(this.listBoxCategory_Click);
            // 
            // buttonShowListCategory
            // 
            this.buttonShowListCategory.Location = new System.Drawing.Point(187, 63);
            this.buttonShowListCategory.Name = "buttonShowListCategory";
            this.buttonShowListCategory.Size = new System.Drawing.Size(20, 21);
            this.buttonShowListCategory.TabIndex = 0;
            this.buttonShowListCategory.Text = "!";
            this.buttonShowListCategory.UseVisualStyleBackColor = true;
            this.buttonShowListCategory.Click += new System.EventHandler(this.buttonShowListCategory_Click);
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Controls.Add(this.listBoxDetails);
            this.groupBoxSummary.Controls.Add(this.labelSummaryResultPayer);
            this.groupBoxSummary.Controls.Add(this.labelSummaryPayer);
            this.groupBoxSummary.Controls.Add(this.labelSummaryLocation);
            this.groupBoxSummary.Controls.Add(this.labelSummaryResultLocation);
            this.groupBoxSummary.Controls.Add(this.labelSummaryResultInOut);
            this.groupBoxSummary.Controls.Add(this.labelSummaryMoney);
            this.groupBoxSummary.Controls.Add(this.labelSummaryResultMoney);
            this.groupBoxSummary.Controls.Add(this.labelSummaryDate);
            this.groupBoxSummary.Controls.Add(this.labelSummaryResultDate);
            this.groupBoxSummary.Controls.Add(this.labelSummaryResultCategory);
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
            // listBoxDetails
            // 
            this.listBoxDetails.Enabled = false;
            this.listBoxDetails.FormattingEnabled = true;
            this.listBoxDetails.Location = new System.Drawing.Point(25, 113);
            this.listBoxDetails.Name = "listBoxDetails";
            this.listBoxDetails.Size = new System.Drawing.Size(514, 368);
            this.listBoxDetails.TabIndex = 13;
            // 
            // labelSummaryResultPayer
            // 
            this.labelSummaryResultPayer.AutoSize = true;
            this.labelSummaryResultPayer.Location = new System.Drawing.Point(189, 51);
            this.labelSummaryResultPayer.Name = "labelSummaryResultPayer";
            this.labelSummaryResultPayer.Size = new System.Drawing.Size(0, 13);
            this.labelSummaryResultPayer.TabIndex = 12;
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
            // labelSummaryResultLocation
            // 
            this.labelSummaryResultLocation.AutoSize = true;
            this.labelSummaryResultLocation.Location = new System.Drawing.Point(73, 72);
            this.labelSummaryResultLocation.Name = "labelSummaryResultLocation";
            this.labelSummaryResultLocation.Size = new System.Drawing.Size(0, 13);
            this.labelSummaryResultLocation.TabIndex = 9;
            // 
            // labelSummaryResultInOut
            // 
            this.labelSummaryResultInOut.AutoSize = true;
            this.labelSummaryResultInOut.Location = new System.Drawing.Point(63, 26);
            this.labelSummaryResultInOut.Name = "labelSummaryResultInOut";
            this.labelSummaryResultInOut.Size = new System.Drawing.Size(42, 13);
            this.labelSummaryResultInOut.TabIndex = 8;
            this.labelSummaryResultInOut.Text = "Income";
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
            // labelSummaryResultMoney
            // 
            this.labelSummaryResultMoney.AutoSize = true;
            this.labelSummaryResultMoney.Location = new System.Drawing.Point(168, 26);
            this.labelSummaryResultMoney.Name = "labelSummaryResultMoney";
            this.labelSummaryResultMoney.Size = new System.Drawing.Size(31, 13);
            this.labelSummaryResultMoney.TabIndex = 6;
            this.labelSummaryResultMoney.Text = "1000";
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
            // labelSummaryResultDate
            // 
            this.labelSummaryResultDate.AutoSize = true;
            this.labelSummaryResultDate.Location = new System.Drawing.Point(289, 26);
            this.labelSummaryResultDate.Name = "labelSummaryResultDate";
            this.labelSummaryResultDate.Size = new System.Drawing.Size(65, 13);
            this.labelSummaryResultDate.TabIndex = 4;
            this.labelSummaryResultDate.Text = "2011/12/12";
            // 
            // labelSummaryResultCategory
            // 
            this.labelSummaryResultCategory.AutoSize = true;
            this.labelSummaryResultCategory.Location = new System.Drawing.Point(77, 51);
            this.labelSummaryResultCategory.Name = "labelSummaryResultCategory";
            this.labelSummaryResultCategory.Size = new System.Drawing.Size(0, 13);
            this.labelSummaryResultCategory.TabIndex = 3;
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
            // buttonShowListPayer
            // 
            this.buttonShowListPayer.Location = new System.Drawing.Point(364, 66);
            this.buttonShowListPayer.Name = "buttonShowListPayer";
            this.buttonShowListPayer.Size = new System.Drawing.Size(20, 21);
            this.buttonShowListPayer.TabIndex = 0;
            this.buttonShowListPayer.Text = "!";
            this.buttonShowListPayer.UseVisualStyleBackColor = true;
            this.buttonShowListPayer.Click += new System.EventHandler(this.buttonShowListPayer_Click);
            // 
            // listBoxPayer
            // 
            this.listBoxPayer.FormattingEnabled = true;
            this.listBoxPayer.Location = new System.Drawing.Point(271, 84);
            this.listBoxPayer.Name = "listBoxPayer";
            this.listBoxPayer.Size = new System.Drawing.Size(94, 199);
            this.listBoxPayer.TabIndex = 34;
            this.listBoxPayer.Click += new System.EventHandler(this.listBoxPayer_Click);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(73, 96);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(292, 20);
            this.textBoxLocation.TabIndex = 7;
            this.textBoxLocation.TextChanged += new System.EventHandler(this.textBoxLocation_TextChanged);
            this.textBoxLocation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxLocation_KeyUp);
            this.textBoxLocation.Leave += new System.EventHandler(this.textBoxLocation_Leave);
            // 
            // buttonShowListLocation
            // 
            this.buttonShowListLocation.Location = new System.Drawing.Point(364, 95);
            this.buttonShowListLocation.Name = "buttonShowListLocation";
            this.buttonShowListLocation.Size = new System.Drawing.Size(20, 21);
            this.buttonShowListLocation.TabIndex = 0;
            this.buttonShowListLocation.Text = "!";
            this.buttonShowListLocation.UseVisualStyleBackColor = true;
            this.buttonShowListLocation.Click += new System.EventHandler(this.buttonShowListLocation_Click);
            // 
            // listBoxLocation
            // 
            this.listBoxLocation.FormattingEnabled = true;
            this.listBoxLocation.Location = new System.Drawing.Point(73, 116);
            this.listBoxLocation.Name = "listBoxLocation";
            this.listBoxLocation.Size = new System.Drawing.Size(292, 264);
            this.listBoxLocation.TabIndex = 38;
            this.listBoxLocation.Click += new System.EventHandler(this.listBoxLocation_Click);
            // 
            // listBoxDetailProduct
            // 
            this.listBoxDetailProduct.FormattingEnabled = true;
            this.listBoxDetailProduct.Location = new System.Drawing.Point(65, 35);
            this.listBoxDetailProduct.Name = "listBoxDetailProduct";
            this.listBoxDetailProduct.Size = new System.Drawing.Size(288, 134);
            this.listBoxDetailProduct.TabIndex = 37;
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
            // labelDetailSpecification
            // 
            this.labelDetailSpecification.AutoSize = true;
            this.labelDetailSpecification.Location = new System.Drawing.Point(24, 57);
            this.labelDetailSpecification.Name = "labelDetailSpecification";
            this.labelDetailSpecification.Size = new System.Drawing.Size(68, 13);
            this.labelDetailSpecification.TabIndex = 41;
            this.labelDetailSpecification.Text = "Specification";
            // 
            // buttonDetailRemoveFromSummary
            // 
            this.buttonDetailRemoveFromSummary.Location = new System.Drawing.Point(400, 161);
            this.buttonDetailRemoveFromSummary.Name = "buttonDetailRemoveFromSummary";
            this.buttonDetailRemoveFromSummary.Size = new System.Drawing.Size(31, 23);
            this.buttonDetailRemoveFromSummary.TabIndex = 40;
            this.buttonDetailRemoveFromSummary.Text = "<<";
            this.buttonDetailRemoveFromSummary.UseVisualStyleBackColor = true;
            // 
            // buttonDetailAddToSummary
            // 
            this.buttonDetailAddToSummary.Location = new System.Drawing.Point(400, 103);
            this.buttonDetailAddToSummary.Name = "buttonDetailAddToSummary";
            this.buttonDetailAddToSummary.Size = new System.Drawing.Size(31, 23);
            this.buttonDetailAddToSummary.TabIndex = 39;
            this.buttonDetailAddToSummary.Text = ">>";
            this.buttonDetailAddToSummary.UseVisualStyleBackColor = true;
            // 
            // listBoxDetailBeneficiary
            // 
            this.listBoxDetailBeneficiary.FormattingEnabled = true;
            this.listBoxDetailBeneficiary.Location = new System.Drawing.Point(85, 202);
            this.listBoxDetailBeneficiary.Name = "listBoxDetailBeneficiary";
            this.listBoxDetailBeneficiary.Size = new System.Drawing.Size(120, 95);
            this.listBoxDetailBeneficiary.TabIndex = 38;
            this.listBoxDetailBeneficiary.Click += new System.EventHandler(this.listBoxDetailBeneficiary_Click);
            // 
            // labelDetailPriceAverage
            // 
            this.labelDetailPriceAverage.AutoSize = true;
            this.labelDetailPriceAverage.Location = new System.Drawing.Point(24, 103);
            this.labelDetailPriceAverage.Name = "labelDetailPriceAverage";
            this.labelDetailPriceAverage.Size = new System.Drawing.Size(71, 13);
            this.labelDetailPriceAverage.TabIndex = 36;
            this.labelDetailPriceAverage.Text = "PriceAverage";
            // 
            // labelDetailTotal
            // 
            this.labelDetailTotal.AutoSize = true;
            this.labelDetailTotal.Location = new System.Drawing.Point(216, 249);
            this.labelDetailTotal.Name = "labelDetailTotal";
            this.labelDetailTotal.Size = new System.Drawing.Size(31, 13);
            this.labelDetailTotal.TabIndex = 35;
            this.labelDetailTotal.Text = "Total";
            // 
            // labelDetailQuantity
            // 
            this.labelDetailQuantity.AutoSize = true;
            this.labelDetailQuantity.Location = new System.Drawing.Point(211, 215);
            this.labelDetailQuantity.Name = "labelDetailQuantity";
            this.labelDetailQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelDetailQuantity.TabIndex = 34;
            this.labelDetailQuantity.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(263, 212);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 33;
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
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(260, 182);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(101, 20);
            this.textBoxPrice.TabIndex = 31;
            // 
            // buttonDetailShowListBeneficiary
            // 
            this.buttonDetailShowListBeneficiary.Location = new System.Drawing.Point(184, 182);
            this.buttonDetailShowListBeneficiary.Name = "buttonDetailShowListBeneficiary";
            this.buttonDetailShowListBeneficiary.Size = new System.Drawing.Size(21, 20);
            this.buttonDetailShowListBeneficiary.TabIndex = 30;
            this.buttonDetailShowListBeneficiary.Text = "!";
            this.buttonDetailShowListBeneficiary.UseVisualStyleBackColor = true;
            this.buttonDetailShowListBeneficiary.Click += new System.EventHandler(this.buttonShowListDetailBeneficiary_Click);
            // 
            // labelBeneficiaryName
            // 
            this.labelBeneficiaryName.AutoSize = true;
            this.labelBeneficiaryName.Location = new System.Drawing.Point(21, 185);
            this.labelBeneficiaryName.Name = "labelBeneficiaryName";
            this.labelBeneficiaryName.Size = new System.Drawing.Size(58, 13);
            this.labelBeneficiaryName.TabIndex = 29;
            this.labelBeneficiaryName.Text = "beneficiary";
            // 
            // textBoxDetailBeneficiaryName
            // 
            this.textBoxDetailBeneficiary.Location = new System.Drawing.Point(85, 182);
            this.textBoxDetailBeneficiary.Name = "textBoxDetailBeneficiaryName";
            this.textBoxDetailBeneficiary.Size = new System.Drawing.Size(100, 20);
            this.textBoxDetailBeneficiary.TabIndex = 28;
            this.textBoxDetailBeneficiary.TextChanged += new System.EventHandler(this.textBoxDetailBeneficiary_TextChanged);
            this.textBoxDetailBeneficiary.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxDetailBeneficiary_KeyUp);
            this.textBoxDetailBeneficiary.Leave += new System.EventHandler(this.textBoxDetailBeneficiary_Leave);
            // 
            // buttonDetailShowListProductName
            // 
            this.buttonDetailShowListProductName.Location = new System.Drawing.Point(352, 12);
            this.buttonDetailShowListProductName.Name = "buttonDetailShowListProductName";
            this.buttonDetailShowListProductName.Size = new System.Drawing.Size(21, 20);
            this.buttonDetailShowListProductName.TabIndex = 27;
            this.buttonDetailShowListProductName.Text = "!";
            this.buttonDetailShowListProductName.UseVisualStyleBackColor = true;
            this.buttonDetailShowListProductName.Click += new System.EventHandler(this.buttonShowListDetailProduct_Click);
            // 
            // labelDetailProductName
            // 
            this.labelDetailProductName.AutoSize = true;
            this.labelDetailProductName.Location = new System.Drawing.Point(24, 15);
            this.labelDetailProductName.Name = "labelDetailProductName";
            this.labelDetailProductName.Size = new System.Drawing.Size(35, 13);
            this.labelDetailProductName.TabIndex = 25;
            this.labelDetailProductName.Text = "Name";
            // 
            // textBoxDetailProduct
            // 
            this.textBoxDetailProduct.Location = new System.Drawing.Point(65, 12);
            this.textBoxDetailProduct.Name = "textBoxDetailProduct";
            this.textBoxDetailProduct.Size = new System.Drawing.Size(288, 20);
            this.textBoxDetailProduct.TabIndex = 23;
            this.textBoxDetailProduct.TextChanged += new System.EventHandler(this.textBoxDetailProduct_TextChanged);
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
            this.checkBoxDetails.TabIndex = 40;
            this.checkBoxDetails.Text = "Details->";
            this.checkBoxDetails.UseVisualStyleBackColor = true;
            this.checkBoxDetails.CheckedChanged += new System.EventHandler(this.checkBoxDetails_CheckedChanged);
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.listBoxDetailBeneficiary);
            this.panelDetails.Controls.Add(this.labelDetailBeneficiaryResult);
            this.panelDetails.Controls.Add(this.labelDetailProductNameResultTitle);
            this.panelDetails.Controls.Add(this.labelDetailPriceAverageResult);
            this.panelDetails.Controls.Add(this.labelDetailManufactoryResult);
            this.panelDetails.Controls.Add(this.labelDetailSpecificationResult);
            this.panelDetails.Controls.Add(this.labelDetailProductResult);
            this.panelDetails.Controls.Add(this.listBoxDetailProduct);
            this.panelDetails.Controls.Add(this.labelDetailManufactoryName);
            this.panelDetails.Controls.Add(this.textBoxDetailProduct);
            this.panelDetails.Controls.Add(this.labelDetailSpecification);
            this.panelDetails.Controls.Add(this.labelDetailProductName);
            this.panelDetails.Controls.Add(this.buttonDetailRemoveFromSummary);
            this.panelDetails.Controls.Add(this.buttonDetailAddToSummary);
            this.panelDetails.Controls.Add(this.buttonDetailShowListProductName);
            this.panelDetails.Controls.Add(this.textBoxDetailBeneficiary);
            this.panelDetails.Controls.Add(this.labelDetailPriceAverage);
            this.panelDetails.Controls.Add(this.labelBeneficiaryName);
            this.panelDetails.Controls.Add(this.labelDetailTotal);
            this.panelDetails.Controls.Add(this.buttonDetailShowListBeneficiary);
            this.panelDetails.Controls.Add(this.labelDetailQuantity);
            this.panelDetails.Controls.Add(this.textBoxPrice);
            this.panelDetails.Controls.Add(this.textBoxQuantity);
            this.panelDetails.Controls.Add(this.labelDetailPrice);
            this.panelDetails.Location = new System.Drawing.Point(12, 167);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(443, 331);
            this.panelDetails.TabIndex = 41;
            this.panelDetails.Visible = false;
            // 
            // labelDetailBeneficiaryNameResult
            // 
            this.labelDetailBeneficiaryResult.AutoSize = true;
            this.labelDetailBeneficiaryResult.Location = new System.Drawing.Point(82, 212);
            this.labelDetailBeneficiaryResult.Name = "labelDetailBeneficiaryNameResult";
            this.labelDetailBeneficiaryResult.Size = new System.Drawing.Size(0, 13);
            this.labelDetailBeneficiaryResult.TabIndex = 48;
            // 
            // labelDetailProductNameResultTitle
            // 
            this.labelDetailProductNameResultTitle.AutoSize = true;
            this.labelDetailProductNameResultTitle.Location = new System.Drawing.Point(29, 35);
            this.labelDetailProductNameResultTitle.Name = "labelDetailProductNameResultTitle";
            this.labelDetailProductNameResultTitle.Size = new System.Drawing.Size(35, 13);
            this.labelDetailProductNameResultTitle.TabIndex = 47;
            this.labelDetailProductNameResultTitle.Text = "Name";
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
            // labelDetailSpecificationResult
            // 
            this.labelDetailSpecificationResult.AutoSize = true;
            this.labelDetailSpecificationResult.Location = new System.Drawing.Point(98, 57);
            this.labelDetailSpecificationResult.Name = "labelDetailSpecificationResult";
            this.labelDetailSpecificationResult.Size = new System.Drawing.Size(0, 13);
            this.labelDetailSpecificationResult.TabIndex = 44;
            // 
            // labelDetailProductResult
            // 
            this.labelDetailProductResult.AutoSize = true;
            this.labelDetailProductResult.Location = new System.Drawing.Point(64, 35);
            this.labelDetailProductResult.Name = "labelDetailProductResult";
            this.labelDetailProductResult.Size = new System.Drawing.Size(0, 13);
            this.labelDetailProductResult.TabIndex = 43;
            // 
            // RecordInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 552);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.checkBoxDetails);
            this.Controls.Add(this.listBoxLocation);
            this.Controls.Add(this.buttonShowListLocation);
            this.Controls.Add(this.listBoxPayer);
            this.Controls.Add(this.buttonShowListPayer);
            this.Controls.Add(this.groupBoxSummary);
            this.Controls.Add(this.buttonShowListCategory);
            this.Controls.Add(this.listBoxCategory);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RecordInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RecordInput";
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
        private System.Windows.Forms.RadioButton radioButtonIn;
        private System.Windows.Forms.RadioButton radioButtonOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecordInput;
        private System.Windows.Forms.Label labelPayer;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxPayer;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.Button buttonShowListCategory;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label labelSummaryResultPayer;
        private System.Windows.Forms.Label labelSummaryPayer;
        private System.Windows.Forms.Label labelSummaryLocation;
        private System.Windows.Forms.Label labelSummaryResultLocation;
        private System.Windows.Forms.Label labelSummaryResultInOut;
        private System.Windows.Forms.Label labelSummaryMoney;
        private System.Windows.Forms.Label labelSummaryResultMoney;
        private System.Windows.Forms.Label labelSummaryDate;
        private System.Windows.Forms.Label labelSummaryResultDate;
        private System.Windows.Forms.Label labelSummaryResultCategory;
        private System.Windows.Forms.Label labelSummaryCategory;
        private System.Windows.Forms.Label labelSummaryDetails;
        private System.Windows.Forms.Label labelSummaryInOut;
        private System.Windows.Forms.ListBox listBoxDetails;
        private System.Windows.Forms.Button buttonShowListPayer;
        private System.Windows.Forms.ListBox listBoxPayer;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Button buttonShowListLocation;
        private System.Windows.Forms.ListBox listBoxLocation;
        private System.Windows.Forms.ListBox listBoxDetailProduct;
        private System.Windows.Forms.Label labelDetailManufactoryName;
        private System.Windows.Forms.Label labelDetailSpecification;
        private System.Windows.Forms.Button buttonDetailRemoveFromSummary;
        private System.Windows.Forms.Button buttonDetailAddToSummary;
        private System.Windows.Forms.ListBox listBoxDetailBeneficiary;
        private System.Windows.Forms.Label labelDetailPriceAverage;
        private System.Windows.Forms.Label labelDetailTotal;
        private System.Windows.Forms.Label labelDetailQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelDetailPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonDetailShowListBeneficiary;
        private System.Windows.Forms.Label labelBeneficiaryName;
        private System.Windows.Forms.TextBox textBoxDetailBeneficiary;
        private System.Windows.Forms.Button buttonDetailShowListProductName;
        private System.Windows.Forms.Label labelDetailProductName;
        private System.Windows.Forms.TextBox textBoxDetailProduct;
        private System.Windows.Forms.CheckBox checkBoxDetails;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label labelDetailPriceAverageResult;
        private System.Windows.Forms.Label labelDetailManufactoryResult;
        private System.Windows.Forms.Label labelDetailSpecificationResult;
        private System.Windows.Forms.Label labelDetailProductResult;
        private System.Windows.Forms.Label labelDetailProductNameResultTitle;
        private System.Windows.Forms.Label labelDetailBeneficiaryResult;
    }
}