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
            this.comboBoxPayer = new System.Windows.Forms.ComboBox();
            this.labelPayer = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxPayer = new System.Windows.Forms.TextBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.buttonShowListCategory = new System.Windows.Forms.Button();
            this.groupBoxInOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(87, 18);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(39, 13);
            this.labelMoney.TabIndex = 0;
            this.labelMoney.Text = "Money";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(132, 15);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(100, 20);
            this.textBoxMoney.TabIndex = 2;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(77, 54);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(49, 13);
            this.labelCategory.TabIndex = 6;
            this.labelCategory.Text = "Category";
            // 
            // label1Date
            // 
            this.label1Date.AutoSize = true;
            this.label1Date.Location = new System.Drawing.Point(241, 19);
            this.label1Date.Name = "label1Date";
            this.label1Date.Size = new System.Drawing.Size(30, 13);
            this.label1Date.TabIndex = 20;
            this.label1Date.Text = "Date";
            // 
            // groupBoxInOut
            // 
            this.groupBoxInOut.Controls.Add(this.radioButtonIn);
            this.groupBoxInOut.Controls.Add(this.radioButtonOut);
            this.groupBoxInOut.Location = new System.Drawing.Point(12, 18);
            this.groupBoxInOut.Name = "groupBoxInOut";
            this.groupBoxInOut.Size = new System.Drawing.Size(59, 69);
            this.groupBoxInOut.TabIndex = 0;
            this.groupBoxInOut.TabStop = false;
            this.groupBoxInOut.Text = "InOut";
            // 
            // radioButtonIn
            // 
            this.radioButtonIn.AutoSize = true;
            this.radioButtonIn.Location = new System.Drawing.Point(6, 42);
            this.radioButtonIn.Name = "radioButtonIn";
            this.radioButtonIn.Size = new System.Drawing.Size(34, 17);
            this.radioButtonIn.TabIndex = 0;
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
            // 
            // dateTimePickerRecordInput
            // 
            this.dateTimePickerRecordInput.Location = new System.Drawing.Point(280, 15);
            this.dateTimePickerRecordInput.Name = "dateTimePickerRecordInput";
            this.dateTimePickerRecordInput.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerRecordInput.TabIndex = 3;
            this.dateTimePickerRecordInput.Value = new System.DateTime(2011, 12, 6, 0, 0, 0, 0);
            // 
            // comboBoxPayer
            // 
            this.comboBoxPayer.AutoCompleteCustomSource.AddRange(new string[] {
            "abc",
            "cba",
            "dkls",
            "fdsak"});
            this.comboBoxPayer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxPayer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPayer.FormattingEnabled = true;
            this.comboBoxPayer.Location = new System.Drawing.Point(280, 51);
            this.comboBoxPayer.Name = "comboBoxPayer";
            this.comboBoxPayer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPayer.TabIndex = 5;
            // 
            // labelPayer
            // 
            this.labelPayer.AutoSize = true;
            this.labelPayer.Location = new System.Drawing.Point(240, 54);
            this.labelPayer.Name = "labelPayer";
            this.labelPayer.Size = new System.Drawing.Size(34, 13);
            this.labelPayer.TabIndex = 25;
            this.labelPayer.Text = "Payer";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.AutoCompleteCustomSource.AddRange(new string[] {
            "abc",
            "cba",
            "dkls",
            "fdsak"});
            this.comboBoxLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(70, 101);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(282, 21);
            this.comboBoxLocation.TabIndex = 6;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(15, 104);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(48, 13);
            this.labelLocation.TabIndex = 27;
            this.labelLocation.Text = "Location";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(199, 164);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDetail
            // 
            this.buttonDetail.Location = new System.Drawing.Point(371, 99);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonDetail.TabIndex = 7;
            this.buttonDetail.Text = "Detail";
            this.buttonDetail.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(102, 164);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(296, 164);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(132, 51);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(83, 20);
            this.textBoxCategory.TabIndex = 28;
            this.textBoxCategory.TextChanged += new System.EventHandler(this.textBoxCategory_TextChanged);
            this.textBoxCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCategory_KeyPress);
            this.textBoxCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCategory_KeyUp);
            // 
            // textBoxPayer
            // 
            this.textBoxPayer.Location = new System.Drawing.Point(281, 51);
            this.textBoxPayer.Name = "textBoxPayer";
            this.textBoxPayer.Size = new System.Drawing.Size(100, 20);
            this.textBoxPayer.TabIndex = 29;
            this.textBoxPayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPayer_KeyPress);
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(132, 71);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(100, 95);
            this.listBoxCategory.TabIndex = 30;
            // 
            // buttonShowListCategory
            // 
            this.buttonShowListCategory.Location = new System.Drawing.Point(212, 51);
            this.buttonShowListCategory.Name = "buttonShowListCategory";
            this.buttonShowListCategory.Size = new System.Drawing.Size(20, 21);
            this.buttonShowListCategory.TabIndex = 31;
            this.buttonShowListCategory.Text = "!";
            this.buttonShowListCategory.UseVisualStyleBackColor = true;
            // 
            // RecordInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 216);
            this.Controls.Add(this.buttonShowListCategory);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.textBoxPayer);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.comboBoxPayer);
            this.Controls.Add(this.labelPayer);
            this.Controls.Add(this.dateTimePickerRecordInput);
            this.Controls.Add(this.groupBoxInOut);
            this.Controls.Add(this.label1Date);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.labelMoney);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RecordInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RecordInput";
            this.Load += new System.EventHandler(this.RecordInput_Load);
            this.groupBoxInOut.ResumeLayout(false);
            this.groupBoxInOut.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxPayer;
        private System.Windows.Forms.Label labelPayer;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxPayer;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.Button buttonShowListCategory;
    }
}