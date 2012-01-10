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
            this.label1Date = new System.Windows.Forms.Label();
            this.groupBoxInOut = new System.Windows.Forms.GroupBox();
            this.radioButtonIn = new System.Windows.Forms.RadioButton();
            this.radioButtonOut = new System.Windows.Forms.RadioButton();
            this.dateTimePickerRecordInput = new System.Windows.Forms.DateTimePicker();
            this.labelPayer = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxPayer = new System.Windows.Forms.TextBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.buttonShowListCategory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.labelMoneyUnit = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.buttonShowListLocation = new System.Windows.Forms.Button();
            this.listBoxLocation = new System.Windows.Forms.ListBox();
            this.groupBoxInOut.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // label1Date
            // 
            this.label1Date.AutoSize = true;
            this.label1Date.Location = new System.Drawing.Point(143, 42);
            this.label1Date.Name = "label1Date";
            this.label1Date.Size = new System.Drawing.Size(30, 13);
            this.label1Date.TabIndex = 20;
            this.label1Date.Text = "Date";
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
            this.buttonReset.Location = new System.Drawing.Point(339, 391);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDetails
            // 
            this.buttonDetails.Location = new System.Drawing.Point(17, 125);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(75, 23);
            this.buttonDetails.TabIndex = 8;
            this.buttonDetails.Text = "Details";
            this.buttonDetails.UseVisualStyleBackColor = true;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(242, 391);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(436, 391);
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
            this.buttonShowListCategory.TabIndex = 31;
            this.buttonShowListCategory.Text = "!";
            this.buttonShowListCategory.UseVisualStyleBackColor = true;
            this.buttonShowListCategory.Click += new System.EventHandler(this.buttonShowListCategory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBoxDetails);
            this.groupBox1.Controls.Add(this.labelSummaryResultPayer);
            this.groupBox1.Controls.Add(this.labelSummaryPayer);
            this.groupBox1.Controls.Add(this.labelSummaryLocation);
            this.groupBox1.Controls.Add(this.labelSummaryResultLocation);
            this.groupBox1.Controls.Add(this.labelSummaryResultInOut);
            this.groupBox1.Controls.Add(this.labelSummaryMoney);
            this.groupBox1.Controls.Add(this.labelSummaryResultMoney);
            this.groupBox1.Controls.Add(this.labelSummaryDate);
            this.groupBox1.Controls.Add(this.labelSummaryResultDate);
            this.groupBox1.Controls.Add(this.labelSummaryResultCategory);
            this.groupBox1.Controls.Add(this.labelSummaryCategory);
            this.groupBox1.Controls.Add(this.labelSummaryDetails);
            this.groupBox1.Controls.Add(this.labelSummaryInOut);
            this.groupBox1.Location = new System.Drawing.Point(390, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 373);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Yuan";
            // 
            // listBoxDetails
            // 
            this.listBoxDetails.FormattingEnabled = true;
            this.listBoxDetails.Location = new System.Drawing.Point(25, 113);
            this.listBoxDetails.Name = "listBoxDetails";
            this.listBoxDetails.Size = new System.Drawing.Size(361, 251);
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
            this.buttonShowListPayer.TabIndex = 33;
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
            // labelMoneyUnit
            // 
            this.labelMoneyUnit.AutoSize = true;
            this.labelMoneyUnit.Location = new System.Drawing.Point(303, 15);
            this.labelMoneyUnit.Name = "labelMoneyUnit";
            this.labelMoneyUnit.Size = new System.Drawing.Size(32, 13);
            this.labelMoneyUnit.TabIndex = 35;
            this.labelMoneyUnit.Text = "Yuan";
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
            this.buttonShowListLocation.TabIndex = 37;
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
            // RecordInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 426);
            this.Controls.Add(this.listBoxLocation);
            this.Controls.Add(this.buttonShowListLocation);
            this.Controls.Add(this.labelMoneyUnit);
            this.Controls.Add(this.listBoxPayer);
            this.Controls.Add(this.buttonShowListPayer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonShowListCategory);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.textBoxPayer);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelPayer);
            this.Controls.Add(this.dateTimePickerRecordInput);
            this.Controls.Add(this.groupBoxInOut);
            this.Controls.Add(this.label1Date);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label label1Date;
        private System.Windows.Forms.GroupBox groupBoxInOut;
        private System.Windows.Forms.RadioButton radioButtonIn;
        private System.Windows.Forms.RadioButton radioButtonOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecordInput;
        private System.Windows.Forms.Label labelPayer;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxPayer;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.Button buttonShowListCategory;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShowListPayer;
        private System.Windows.Forms.ListBox listBoxPayer;
        private System.Windows.Forms.Label labelMoneyUnit;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Button buttonShowListLocation;
        private System.Windows.Forms.ListBox listBoxLocation;
    }
}