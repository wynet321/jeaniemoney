﻿namespace JeanieMoney.Forms
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
            this.listViewSummaryDetails = new System.Windows.Forms.ListView();
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
            this.textBoxDetailQuantity = new System.Windows.Forms.TextBox();
            this.labelDetailPrice = new System.Windows.Forms.Label();
            this.textBoxDetailPrice = new System.Windows.Forms.TextBox();
            this.buttonDetailShowListBeneficiary = new System.Windows.Forms.Button();
            this.labelBeneficiaryName = new System.Windows.Forms.Label();
            this.textBoxDetailBeneficiary = new System.Windows.Forms.TextBox();
            this.buttonDetailShowListProductName = new System.Windows.Forms.Button();
            this.labelDetailProductName = new System.Windows.Forms.Label();
            this.textBoxDetailProduct = new System.Windows.Forms.TextBox();
            this.checkBoxDetails = new System.Windows.Forms.CheckBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.labelDetailTotalResult = new System.Windows.Forms.Label();
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
            this.labelMoney.Location = new System.Drawing.Point(142, 14);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(35, 12);
            this.labelMoney.TabIndex = 0;
            this.labelMoney.Text = "Money";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(187, 11);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(110, 21);
            this.textBoxMoney.TabIndex = 3;
            this.textBoxMoney.Leave += new System.EventHandler(this.textBoxMoney_Leave);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(18, 62);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(53, 12);
            this.labelCategory.TabIndex = 6;
            this.labelCategory.Text = "Category";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(143, 39);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(29, 12);
            this.labelDate.TabIndex = 20;
            this.labelDate.Text = "Date";
            // 
            // groupBoxInOut
            // 
            this.groupBoxInOut.Controls.Add(this.radioButtonIn);
            this.groupBoxInOut.Controls.Add(this.radioButtonOut);
            this.groupBoxInOut.Location = new System.Drawing.Point(17, 11);
            this.groupBoxInOut.Name = "groupBoxInOut";
            this.groupBoxInOut.Size = new System.Drawing.Size(116, 42);
            this.groupBoxInOut.TabIndex = 0;
            this.groupBoxInOut.TabStop = false;
            this.groupBoxInOut.Text = "InOut";
            // 
            // radioButtonIn
            // 
            this.radioButtonIn.AutoSize = true;
            this.radioButtonIn.Location = new System.Drawing.Point(66, 18);
            this.radioButtonIn.Name = "radioButtonIn";
            this.radioButtonIn.Size = new System.Drawing.Size(35, 16);
            this.radioButtonIn.TabIndex = 2;
            this.radioButtonIn.Text = "In";
            this.radioButtonIn.UseVisualStyleBackColor = true;
            // 
            // radioButtonOut
            // 
            this.radioButtonOut.AutoSize = true;
            this.radioButtonOut.Checked = true;
            this.radioButtonOut.Location = new System.Drawing.Point(6, 18);
            this.radioButtonOut.Name = "radioButtonOut";
            this.radioButtonOut.Size = new System.Drawing.Size(41, 16);
            this.radioButtonOut.TabIndex = 1;
            this.radioButtonOut.TabStop = true;
            this.radioButtonOut.Text = "Out";
            this.radioButtonOut.UseVisualStyleBackColor = true;
            this.radioButtonOut.CheckedChanged += new System.EventHandler(this.radioButtonOut_CheckedChanged);
            // 
            // dateTimePickerRecordInput
            // 
            this.dateTimePickerRecordInput.Location = new System.Drawing.Point(187, 35);
            this.dateTimePickerRecordInput.Name = "dateTimePickerRecordInput";
            this.dateTimePickerRecordInput.Size = new System.Drawing.Size(144, 21);
            this.dateTimePickerRecordInput.TabIndex = 4;
            this.dateTimePickerRecordInput.Value = new System.DateTime(2011, 12, 6, 0, 0, 0, 0);
            this.dateTimePickerRecordInput.Leave += new System.EventHandler(this.dateTimePickerRecordInput_Leave);
            // 
            // labelPayer
            // 
            this.labelPayer.AutoSize = true;
            this.labelPayer.Location = new System.Drawing.Point(228, 65);
            this.labelPayer.Name = "labelPayer";
            this.labelPayer.Size = new System.Drawing.Size(35, 12);
            this.labelPayer.TabIndex = 25;
            this.labelPayer.Text = "Payer";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(14, 91);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(53, 12);
            this.labelLocation.TabIndex = 27;
            this.labelLocation.Text = "Location";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(461, 477);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 21);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(364, 477);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(558, 477);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(73, 59);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(115, 21);
            this.textBoxCategory.TabIndex = 5;
            this.textBoxCategory.TextChanged += new System.EventHandler(this.textBoxCategory_TextChanged);
            this.textBoxCategory.Enter += new System.EventHandler(this.textBoxCategory_TextChanged);
            this.textBoxCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCategory_KeyUp);
            this.textBoxCategory.Leave += new System.EventHandler(this.textBoxCategory_Leave);
            // 
            // textBoxPayer
            // 
            this.textBoxPayer.Location = new System.Drawing.Point(271, 62);
            this.textBoxPayer.Name = "textBoxPayer";
            this.textBoxPayer.Size = new System.Drawing.Size(94, 21);
            this.textBoxPayer.TabIndex = 6;
            this.textBoxPayer.TextChanged += new System.EventHandler(this.textBoxPayer_TextChanged);
            this.textBoxPayer.Enter += new System.EventHandler(this.textBoxPayer_TextChanged);
            this.textBoxPayer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPayer_KeyUp);
            this.textBoxPayer.Leave += new System.EventHandler(this.textBoxPayer_Leave);
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 12;
            this.listBoxCategory.Location = new System.Drawing.Point(73, 78);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(115, 184);
            this.listBoxCategory.TabIndex = 30;
            this.listBoxCategory.Click += new System.EventHandler(this.listBoxCategory_Click);
            // 
            // buttonShowListCategory
            // 
            this.buttonShowListCategory.Location = new System.Drawing.Point(187, 58);
            this.buttonShowListCategory.Name = "buttonShowListCategory";
            this.buttonShowListCategory.Size = new System.Drawing.Size(20, 19);
            this.buttonShowListCategory.TabIndex = 0;
            this.buttonShowListCategory.Text = "!";
            this.buttonShowListCategory.UseVisualStyleBackColor = true;
            this.buttonShowListCategory.Click += new System.EventHandler(this.buttonShowListCategory_Click);
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Controls.Add(this.listViewSummaryDetails);
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
            this.groupBoxSummary.Location = new System.Drawing.Point(461, 6);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(545, 453);
            this.groupBoxSummary.TabIndex = 32;
            this.groupBoxSummary.TabStop = false;
            this.groupBoxSummary.Text = "Summary";
            // 
            // listViewSummaryDetails
            // 
            this.listViewSummaryDetails.FullRowSelect = true;
            this.listViewSummaryDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSummaryDetails.Location = new System.Drawing.Point(25, 103);
            this.listViewSummaryDetails.MultiSelect = false;
            this.listViewSummaryDetails.Name = "listViewSummaryDetails";
            this.listViewSummaryDetails.Size = new System.Drawing.Size(514, 345);
            this.listViewSummaryDetails.TabIndex = 14;
            this.listViewSummaryDetails.UseCompatibleStateImageBehavior = false;
            this.listViewSummaryDetails.View = System.Windows.Forms.View.Details;
            // 
            // labelSummaryResultPayer
            // 
            this.labelSummaryResultPayer.AutoSize = true;
            this.labelSummaryResultPayer.Location = new System.Drawing.Point(189, 47);
            this.labelSummaryResultPayer.Name = "labelSummaryResultPayer";
            this.labelSummaryResultPayer.Size = new System.Drawing.Size(0, 12);
            this.labelSummaryResultPayer.TabIndex = 12;
            // 
            // labelSummaryPayer
            // 
            this.labelSummaryPayer.AutoSize = true;
            this.labelSummaryPayer.Location = new System.Drawing.Point(146, 47);
            this.labelSummaryPayer.Name = "labelSummaryPayer";
            this.labelSummaryPayer.Size = new System.Drawing.Size(41, 12);
            this.labelSummaryPayer.TabIndex = 11;
            this.labelSummaryPayer.Text = "Payer:";
            // 
            // labelSummaryLocation
            // 
            this.labelSummaryLocation.AutoSize = true;
            this.labelSummaryLocation.Location = new System.Drawing.Point(22, 66);
            this.labelSummaryLocation.Name = "labelSummaryLocation";
            this.labelSummaryLocation.Size = new System.Drawing.Size(53, 12);
            this.labelSummaryLocation.TabIndex = 10;
            this.labelSummaryLocation.Text = "Locaton:";
            // 
            // labelSummaryResultLocation
            // 
            this.labelSummaryResultLocation.AutoSize = true;
            this.labelSummaryResultLocation.Location = new System.Drawing.Point(73, 66);
            this.labelSummaryResultLocation.Name = "labelSummaryResultLocation";
            this.labelSummaryResultLocation.Size = new System.Drawing.Size(0, 12);
            this.labelSummaryResultLocation.TabIndex = 9;
            // 
            // labelSummaryResultInOut
            // 
            this.labelSummaryResultInOut.AutoSize = true;
            this.labelSummaryResultInOut.Location = new System.Drawing.Point(63, 24);
            this.labelSummaryResultInOut.Name = "labelSummaryResultInOut";
            this.labelSummaryResultInOut.Size = new System.Drawing.Size(41, 12);
            this.labelSummaryResultInOut.TabIndex = 8;
            this.labelSummaryResultInOut.Text = "Income";
            // 
            // labelSummaryMoney
            // 
            this.labelSummaryMoney.AutoSize = true;
            this.labelSummaryMoney.Location = new System.Drawing.Point(120, 24);
            this.labelSummaryMoney.Name = "labelSummaryMoney";
            this.labelSummaryMoney.Size = new System.Drawing.Size(41, 12);
            this.labelSummaryMoney.TabIndex = 7;
            this.labelSummaryMoney.Text = "Money:";
            // 
            // labelSummaryResultMoney
            // 
            this.labelSummaryResultMoney.AutoSize = true;
            this.labelSummaryResultMoney.Location = new System.Drawing.Point(168, 24);
            this.labelSummaryResultMoney.Name = "labelSummaryResultMoney";
            this.labelSummaryResultMoney.Size = new System.Drawing.Size(29, 12);
            this.labelSummaryResultMoney.TabIndex = 6;
            this.labelSummaryResultMoney.Text = "1000";
            // 
            // labelSummaryDate
            // 
            this.labelSummaryDate.AutoSize = true;
            this.labelSummaryDate.Location = new System.Drawing.Point(253, 24);
            this.labelSummaryDate.Name = "labelSummaryDate";
            this.labelSummaryDate.Size = new System.Drawing.Size(35, 12);
            this.labelSummaryDate.TabIndex = 5;
            this.labelSummaryDate.Text = "Date:";
            // 
            // labelSummaryResultDate
            // 
            this.labelSummaryResultDate.AutoSize = true;
            this.labelSummaryResultDate.Location = new System.Drawing.Point(289, 24);
            this.labelSummaryResultDate.Name = "labelSummaryResultDate";
            this.labelSummaryResultDate.Size = new System.Drawing.Size(65, 12);
            this.labelSummaryResultDate.TabIndex = 4;
            this.labelSummaryResultDate.Text = "2011/12/12";
            // 
            // labelSummaryResultCategory
            // 
            this.labelSummaryResultCategory.AutoSize = true;
            this.labelSummaryResultCategory.Location = new System.Drawing.Point(77, 47);
            this.labelSummaryResultCategory.Name = "labelSummaryResultCategory";
            this.labelSummaryResultCategory.Size = new System.Drawing.Size(0, 12);
            this.labelSummaryResultCategory.TabIndex = 3;
            // 
            // labelSummaryCategory
            // 
            this.labelSummaryCategory.AutoSize = true;
            this.labelSummaryCategory.Location = new System.Drawing.Point(22, 47);
            this.labelSummaryCategory.Name = "labelSummaryCategory";
            this.labelSummaryCategory.Size = new System.Drawing.Size(59, 12);
            this.labelSummaryCategory.TabIndex = 2;
            this.labelSummaryCategory.Text = "Category:";
            // 
            // labelSummaryDetails
            // 
            this.labelSummaryDetails.AutoSize = true;
            this.labelSummaryDetails.Location = new System.Drawing.Point(22, 89);
            this.labelSummaryDetails.Name = "labelSummaryDetails";
            this.labelSummaryDetails.Size = new System.Drawing.Size(47, 12);
            this.labelSummaryDetails.TabIndex = 1;
            this.labelSummaryDetails.Text = "Details";
            // 
            // labelSummaryInOut
            // 
            this.labelSummaryInOut.AutoSize = true;
            this.labelSummaryInOut.Location = new System.Drawing.Point(22, 24);
            this.labelSummaryInOut.Name = "labelSummaryInOut";
            this.labelSummaryInOut.Size = new System.Drawing.Size(41, 12);
            this.labelSummaryInOut.TabIndex = 0;
            this.labelSummaryInOut.Text = "InOut:";
            // 
            // buttonShowListPayer
            // 
            this.buttonShowListPayer.Location = new System.Drawing.Point(364, 61);
            this.buttonShowListPayer.Name = "buttonShowListPayer";
            this.buttonShowListPayer.Size = new System.Drawing.Size(20, 19);
            this.buttonShowListPayer.TabIndex = 0;
            this.buttonShowListPayer.Text = "!";
            this.buttonShowListPayer.UseVisualStyleBackColor = true;
            this.buttonShowListPayer.Click += new System.EventHandler(this.buttonShowListPayer_Click);
            // 
            // listBoxPayer
            // 
            this.listBoxPayer.FormattingEnabled = true;
            this.listBoxPayer.ItemHeight = 12;
            this.listBoxPayer.Location = new System.Drawing.Point(271, 78);
            this.listBoxPayer.Name = "listBoxPayer";
            this.listBoxPayer.Size = new System.Drawing.Size(94, 184);
            this.listBoxPayer.TabIndex = 34;
            this.listBoxPayer.Click += new System.EventHandler(this.listBoxPayer_Click);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(73, 89);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(292, 21);
            this.textBoxLocation.TabIndex = 7;
            this.textBoxLocation.TextChanged += new System.EventHandler(this.textBoxLocation_TextChanged);
            this.textBoxLocation.Enter += new System.EventHandler(this.textBoxLocation_TextChanged);
            this.textBoxLocation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxLocation_KeyUp);
            this.textBoxLocation.Leave += new System.EventHandler(this.textBoxLocation_Leave);
            // 
            // buttonShowListLocation
            // 
            this.buttonShowListLocation.Location = new System.Drawing.Point(364, 88);
            this.buttonShowListLocation.Name = "buttonShowListLocation";
            this.buttonShowListLocation.Size = new System.Drawing.Size(20, 19);
            this.buttonShowListLocation.TabIndex = 0;
            this.buttonShowListLocation.Text = "!";
            this.buttonShowListLocation.UseVisualStyleBackColor = true;
            this.buttonShowListLocation.Click += new System.EventHandler(this.buttonShowListLocation_Click);
            // 
            // listBoxLocation
            // 
            this.listBoxLocation.FormattingEnabled = true;
            this.listBoxLocation.ItemHeight = 12;
            this.listBoxLocation.Location = new System.Drawing.Point(73, 107);
            this.listBoxLocation.Name = "listBoxLocation";
            this.listBoxLocation.Size = new System.Drawing.Size(292, 244);
            this.listBoxLocation.TabIndex = 38;
            this.listBoxLocation.Click += new System.EventHandler(this.listBoxLocation_Click);
            // 
            // listBoxDetailProduct
            // 
            this.listBoxDetailProduct.FormattingEnabled = true;
            this.listBoxDetailProduct.ItemHeight = 12;
            this.listBoxDetailProduct.Location = new System.Drawing.Point(65, 30);
            this.listBoxDetailProduct.Name = "listBoxDetailProduct";
            this.listBoxDetailProduct.Size = new System.Drawing.Size(288, 124);
            this.listBoxDetailProduct.TabIndex = 37;
            this.listBoxDetailProduct.Click += new System.EventHandler(this.listBoxDetailProduct_Click);
            // 
            // labelDetailManufactoryName
            // 
            this.labelDetailManufactoryName.AutoSize = true;
            this.labelDetailManufactoryName.Location = new System.Drawing.Point(24, 73);
            this.labelDetailManufactoryName.Name = "labelDetailManufactoryName";
            this.labelDetailManufactoryName.Size = new System.Drawing.Size(95, 12);
            this.labelDetailManufactoryName.TabIndex = 42;
            this.labelDetailManufactoryName.Text = "ManufactoryName";
            // 
            // labelDetailSpecification
            // 
            this.labelDetailSpecification.AutoSize = true;
            this.labelDetailSpecification.Location = new System.Drawing.Point(24, 53);
            this.labelDetailSpecification.Name = "labelDetailSpecification";
            this.labelDetailSpecification.Size = new System.Drawing.Size(83, 12);
            this.labelDetailSpecification.TabIndex = 41;
            this.labelDetailSpecification.Text = "Specification";
            // 
            // buttonDetailRemoveFromSummary
            // 
            this.buttonDetailRemoveFromSummary.Location = new System.Drawing.Point(400, 149);
            this.buttonDetailRemoveFromSummary.Name = "buttonDetailRemoveFromSummary";
            this.buttonDetailRemoveFromSummary.Size = new System.Drawing.Size(31, 21);
            this.buttonDetailRemoveFromSummary.TabIndex = 40;
            this.buttonDetailRemoveFromSummary.Text = "<<";
            this.buttonDetailRemoveFromSummary.UseVisualStyleBackColor = true;
            // 
            // buttonDetailAddToSummary
            // 
            this.buttonDetailAddToSummary.Location = new System.Drawing.Point(400, 95);
            this.buttonDetailAddToSummary.Name = "buttonDetailAddToSummary";
            this.buttonDetailAddToSummary.Size = new System.Drawing.Size(31, 21);
            this.buttonDetailAddToSummary.TabIndex = 39;
            this.buttonDetailAddToSummary.Text = ">>";
            this.buttonDetailAddToSummary.UseVisualStyleBackColor = true;
            this.buttonDetailAddToSummary.Click += new System.EventHandler(this.buttonDetailAddToSummary_Click);
            // 
            // listBoxDetailBeneficiary
            // 
            this.listBoxDetailBeneficiary.FormattingEnabled = true;
            this.listBoxDetailBeneficiary.ItemHeight = 12;
            this.listBoxDetailBeneficiary.Location = new System.Drawing.Point(85, 186);
            this.listBoxDetailBeneficiary.Name = "listBoxDetailBeneficiary";
            this.listBoxDetailBeneficiary.Size = new System.Drawing.Size(100, 88);
            this.listBoxDetailBeneficiary.TabIndex = 38;
            this.listBoxDetailBeneficiary.Click += new System.EventHandler(this.listBoxDetailBeneficiary_Click);
            // 
            // labelDetailPriceAverage
            // 
            this.labelDetailPriceAverage.AutoSize = true;
            this.labelDetailPriceAverage.Location = new System.Drawing.Point(24, 95);
            this.labelDetailPriceAverage.Name = "labelDetailPriceAverage";
            this.labelDetailPriceAverage.Size = new System.Drawing.Size(77, 12);
            this.labelDetailPriceAverage.TabIndex = 36;
            this.labelDetailPriceAverage.Text = "PriceAverage";
            // 
            // labelDetailTotal
            // 
            this.labelDetailTotal.AutoSize = true;
            this.labelDetailTotal.Location = new System.Drawing.Point(222, 230);
            this.labelDetailTotal.Name = "labelDetailTotal";
            this.labelDetailTotal.Size = new System.Drawing.Size(35, 12);
            this.labelDetailTotal.TabIndex = 35;
            this.labelDetailTotal.Text = "Total";
            // 
            // labelDetailQuantity
            // 
            this.labelDetailQuantity.AutoSize = true;
            this.labelDetailQuantity.Location = new System.Drawing.Point(204, 199);
            this.labelDetailQuantity.Name = "labelDetailQuantity";
            this.labelDetailQuantity.Size = new System.Drawing.Size(53, 12);
            this.labelDetailQuantity.TabIndex = 34;
            this.labelDetailQuantity.Text = "Quantity";
            // 
            // textBoxDetailQuantity
            // 
            this.textBoxDetailQuantity.Location = new System.Drawing.Point(260, 196);
            this.textBoxDetailQuantity.Name = "textBoxDetailQuantity";
            this.textBoxDetailQuantity.Size = new System.Drawing.Size(100, 21);
            this.textBoxDetailQuantity.TabIndex = 33;
            this.textBoxDetailQuantity.TextChanged += new System.EventHandler(this.textBoxDetailQuantity_TextChanged);
            this.textBoxDetailQuantity.Leave += new System.EventHandler(this.textBoxDetailQuantity_Leave);
            // 
            // labelDetailPrice
            // 
            this.labelDetailPrice.AutoSize = true;
            this.labelDetailPrice.Location = new System.Drawing.Point(219, 171);
            this.labelDetailPrice.Name = "labelDetailPrice";
            this.labelDetailPrice.Size = new System.Drawing.Size(35, 12);
            this.labelDetailPrice.TabIndex = 32;
            this.labelDetailPrice.Text = "Price";
            // 
            // textBoxDetailPrice
            // 
            this.textBoxDetailPrice.Location = new System.Drawing.Point(260, 168);
            this.textBoxDetailPrice.Name = "textBoxDetailPrice";
            this.textBoxDetailPrice.Size = new System.Drawing.Size(101, 21);
            this.textBoxDetailPrice.TabIndex = 31;
            this.textBoxDetailPrice.TextChanged += new System.EventHandler(this.textBoxDetailPrice_TextChanged);
            this.textBoxDetailPrice.Leave += new System.EventHandler(this.textBoxDetailPrice_Leave);
            // 
            // buttonDetailShowListBeneficiary
            // 
            this.buttonDetailShowListBeneficiary.Location = new System.Drawing.Point(184, 168);
            this.buttonDetailShowListBeneficiary.Name = "buttonDetailShowListBeneficiary";
            this.buttonDetailShowListBeneficiary.Size = new System.Drawing.Size(21, 18);
            this.buttonDetailShowListBeneficiary.TabIndex = 30;
            this.buttonDetailShowListBeneficiary.Text = "!";
            this.buttonDetailShowListBeneficiary.UseVisualStyleBackColor = true;
            this.buttonDetailShowListBeneficiary.Click += new System.EventHandler(this.buttonShowListDetailBeneficiary_Click);
            // 
            // labelBeneficiaryName
            // 
            this.labelBeneficiaryName.AutoSize = true;
            this.labelBeneficiaryName.Location = new System.Drawing.Point(11, 171);
            this.labelBeneficiaryName.Name = "labelBeneficiaryName";
            this.labelBeneficiaryName.Size = new System.Drawing.Size(71, 12);
            this.labelBeneficiaryName.TabIndex = 29;
            this.labelBeneficiaryName.Text = "beneficiary";
            // 
            // textBoxDetailBeneficiary
            // 
            this.textBoxDetailBeneficiary.Location = new System.Drawing.Point(85, 168);
            this.textBoxDetailBeneficiary.Name = "textBoxDetailBeneficiary";
            this.textBoxDetailBeneficiary.Size = new System.Drawing.Size(100, 21);
            this.textBoxDetailBeneficiary.TabIndex = 28;
            this.textBoxDetailBeneficiary.TextChanged += new System.EventHandler(this.textBoxDetailBeneficiary_TextChanged);
            this.textBoxDetailBeneficiary.Enter += new System.EventHandler(this.textBoxDetailBeneficiary_TextChanged);
            this.textBoxDetailBeneficiary.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxDetailBeneficiary_KeyUp);
            this.textBoxDetailBeneficiary.Leave += new System.EventHandler(this.textBoxDetailBeneficiary_Leave);
            // 
            // buttonDetailShowListProductName
            // 
            this.buttonDetailShowListProductName.Location = new System.Drawing.Point(352, 11);
            this.buttonDetailShowListProductName.Name = "buttonDetailShowListProductName";
            this.buttonDetailShowListProductName.Size = new System.Drawing.Size(21, 18);
            this.buttonDetailShowListProductName.TabIndex = 27;
            this.buttonDetailShowListProductName.Text = "!";
            this.buttonDetailShowListProductName.UseVisualStyleBackColor = true;
            this.buttonDetailShowListProductName.Click += new System.EventHandler(this.buttonShowListDetailProduct_Click);
            // 
            // labelDetailProductName
            // 
            this.labelDetailProductName.AutoSize = true;
            this.labelDetailProductName.Location = new System.Drawing.Point(24, 14);
            this.labelDetailProductName.Name = "labelDetailProductName";
            this.labelDetailProductName.Size = new System.Drawing.Size(29, 12);
            this.labelDetailProductName.TabIndex = 25;
            this.labelDetailProductName.Text = "Name";
            // 
            // textBoxDetailProduct
            // 
            this.textBoxDetailProduct.Location = new System.Drawing.Point(65, 11);
            this.textBoxDetailProduct.Name = "textBoxDetailProduct";
            this.textBoxDetailProduct.Size = new System.Drawing.Size(288, 21);
            this.textBoxDetailProduct.TabIndex = 23;
            this.textBoxDetailProduct.TextChanged += new System.EventHandler(this.textBoxDetailProduct_TextChanged);
            this.textBoxDetailProduct.Enter += new System.EventHandler(this.textBoxDetailProduct_TextChanged);
            this.textBoxDetailProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxDetailProduct_KeyUp);
            this.textBoxDetailProduct.Leave += new System.EventHandler(this.textBoxDetailProduct_Leave);
            // 
            // checkBoxDetails
            // 
            this.checkBoxDetails.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDetails.AutoSize = true;
            this.checkBoxDetails.Location = new System.Drawing.Point(11, 127);
            this.checkBoxDetails.Name = "checkBoxDetails";
            this.checkBoxDetails.Size = new System.Drawing.Size(69, 22);
            this.checkBoxDetails.TabIndex = 40;
            this.checkBoxDetails.Text = "Details->";
            this.checkBoxDetails.UseVisualStyleBackColor = true;
            this.checkBoxDetails.CheckedChanged += new System.EventHandler(this.checkBoxDetails_CheckedChanged);
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.labelDetailTotalResult);
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
            this.panelDetails.Controls.Add(this.textBoxDetailPrice);
            this.panelDetails.Controls.Add(this.textBoxDetailQuantity);
            this.panelDetails.Controls.Add(this.labelDetailPrice);
            this.panelDetails.Location = new System.Drawing.Point(12, 154);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(443, 306);
            this.panelDetails.TabIndex = 41;
            this.panelDetails.Visible = false;
            // 
            // labelDetailTotalResult
            // 
            this.labelDetailTotalResult.AutoSize = true;
            this.labelDetailTotalResult.Location = new System.Drawing.Point(263, 230);
            this.labelDetailTotalResult.Name = "labelDetailTotalResult";
            this.labelDetailTotalResult.Size = new System.Drawing.Size(0, 12);
            this.labelDetailTotalResult.TabIndex = 49;
            // 
            // labelDetailBeneficiaryResult
            // 
            this.labelDetailBeneficiaryResult.AutoSize = true;
            this.labelDetailBeneficiaryResult.Location = new System.Drawing.Point(82, 196);
            this.labelDetailBeneficiaryResult.Name = "labelDetailBeneficiaryResult";
            this.labelDetailBeneficiaryResult.Size = new System.Drawing.Size(0, 12);
            this.labelDetailBeneficiaryResult.TabIndex = 48;
            // 
            // labelDetailProductNameResultTitle
            // 
            this.labelDetailProductNameResultTitle.AutoSize = true;
            this.labelDetailProductNameResultTitle.Location = new System.Drawing.Point(29, 32);
            this.labelDetailProductNameResultTitle.Name = "labelDetailProductNameResultTitle";
            this.labelDetailProductNameResultTitle.Size = new System.Drawing.Size(29, 12);
            this.labelDetailProductNameResultTitle.TabIndex = 47;
            this.labelDetailProductNameResultTitle.Text = "Name";
            // 
            // labelDetailPriceAverageResult
            // 
            this.labelDetailPriceAverageResult.AutoSize = true;
            this.labelDetailPriceAverageResult.Location = new System.Drawing.Point(101, 95);
            this.labelDetailPriceAverageResult.Name = "labelDetailPriceAverageResult";
            this.labelDetailPriceAverageResult.Size = new System.Drawing.Size(0, 12);
            this.labelDetailPriceAverageResult.TabIndex = 46;
            // 
            // labelDetailManufactoryResult
            // 
            this.labelDetailManufactoryResult.AutoSize = true;
            this.labelDetailManufactoryResult.Location = new System.Drawing.Point(124, 73);
            this.labelDetailManufactoryResult.Name = "labelDetailManufactoryResult";
            this.labelDetailManufactoryResult.Size = new System.Drawing.Size(0, 12);
            this.labelDetailManufactoryResult.TabIndex = 45;
            // 
            // labelDetailSpecificationResult
            // 
            this.labelDetailSpecificationResult.AutoSize = true;
            this.labelDetailSpecificationResult.Location = new System.Drawing.Point(98, 53);
            this.labelDetailSpecificationResult.Name = "labelDetailSpecificationResult";
            this.labelDetailSpecificationResult.Size = new System.Drawing.Size(0, 12);
            this.labelDetailSpecificationResult.TabIndex = 44;
            // 
            // labelDetailProductResult
            // 
            this.labelDetailProductResult.AutoSize = true;
            this.labelDetailProductResult.Location = new System.Drawing.Point(64, 32);
            this.labelDetailProductResult.Name = "labelDetailProductResult";
            this.labelDetailProductResult.Size = new System.Drawing.Size(0, 12);
            this.labelDetailProductResult.TabIndex = 43;
            // 
            // RecordInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 510);
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
        private System.Windows.Forms.TextBox textBoxDetailQuantity;
        private System.Windows.Forms.Label labelDetailPrice;
        private System.Windows.Forms.TextBox textBoxDetailPrice;
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
        private System.Windows.Forms.ListView listViewSummaryDetails;
        private System.Windows.Forms.Label labelDetailTotalResult;
    }
}