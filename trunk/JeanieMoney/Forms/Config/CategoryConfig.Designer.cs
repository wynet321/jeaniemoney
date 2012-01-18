namespace JeanieMoney.Forms
{
    partial class CategoryConfig
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.comboBoxParent = new System.Windows.Forms.ComboBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPinyin = new System.Windows.Forms.TextBox();
            this.labelPinyin = new System.Windows.Forms.Label();
            this.labelParent = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxInOut = new System.Windows.Forms.GroupBox();
            this.radioButtonIn = new System.Windows.Forms.RadioButton();
            this.radioButtonOut = new System.Windows.Forms.RadioButton();
            this.groupBoxInOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(37, 197);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(12, 9);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(48, 13);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Keyword";
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(66, 6);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(148, 20);
            this.textBoxKeyword.TabIndex = 1;
            this.textBoxKeyword.TextChanged += new System.EventHandler(this.textBoxKeyword_TextChanged);
            // 
            // comboBoxParent
            // 
            this.comboBoxParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParent.FormattingEnabled = true;
            this.comboBoxParent.Location = new System.Drawing.Point(272, 121);
            this.comboBoxParent.Name = "comboBoxParent";
            this.comboBoxParent.Size = new System.Drawing.Size(180, 21);
            this.comboBoxParent.TabIndex = 7;
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(15, 32);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(199, 147);
            this.listBoxCategory.TabIndex = 2;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxCategory_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(272, 69);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(231, 72);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // textBoxPinyin
            // 
            this.textBoxPinyin.Location = new System.Drawing.Point(272, 95);
            this.textBoxPinyin.Name = "textBoxPinyin";
            this.textBoxPinyin.Size = new System.Drawing.Size(180, 20);
            this.textBoxPinyin.TabIndex = 6;
            // 
            // labelPinyin
            // 
            this.labelPinyin.AutoSize = true;
            this.labelPinyin.Location = new System.Drawing.Point(231, 98);
            this.labelPinyin.Name = "labelPinyin";
            this.labelPinyin.Size = new System.Drawing.Size(35, 13);
            this.labelPinyin.TabIndex = 7;
            this.labelPinyin.Text = "Pinyin";
            // 
            // labelParent
            // 
            this.labelParent.AutoSize = true;
            this.labelParent.Location = new System.Drawing.Point(231, 124);
            this.labelParent.Name = "labelParent";
            this.labelParent.Size = new System.Drawing.Size(38, 13);
            this.labelParent.TabIndex = 9;
            this.labelParent.Text = "Parent";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(354, 197);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(139, 197);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(246, 197);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxInOut
            // 
            this.groupBoxInOut.Controls.Add(this.radioButtonIn);
            this.groupBoxInOut.Controls.Add(this.radioButtonOut);
            this.groupBoxInOut.Location = new System.Drawing.Point(234, 9);
            this.groupBoxInOut.Name = "groupBoxInOut";
            this.groupBoxInOut.Size = new System.Drawing.Size(218, 46);
            this.groupBoxInOut.TabIndex = 14;
            this.groupBoxInOut.TabStop = false;
            this.groupBoxInOut.Text = "InOut";
            // 
            // radioButtonIn
            // 
            this.radioButtonIn.AutoSize = true;
            this.radioButtonIn.Location = new System.Drawing.Point(81, 19);
            this.radioButtonIn.Name = "radioButtonIn";
            this.radioButtonIn.Size = new System.Drawing.Size(34, 17);
            this.radioButtonIn.TabIndex = 4;
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
            this.radioButtonOut.TabIndex = 3;
            this.radioButtonOut.TabStop = true;
            this.radioButtonOut.Text = "Out";
            this.radioButtonOut.UseVisualStyleBackColor = true;
            // 
            // CategoryConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 232);
            this.Controls.Add(this.groupBoxInOut);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelParent);
            this.Controls.Add(this.textBoxPinyin);
            this.Controls.Add(this.labelPinyin);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.comboBoxParent);
            this.Controls.Add(this.textBoxKeyword);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.buttonOK);
            this.Name = "CategoryConfig";
            this.Text = "CategoryConfig";
            this.groupBoxInOut.ResumeLayout(false);
            this.groupBoxInOut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.ComboBox comboBoxParent;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPinyin;
        private System.Windows.Forms.Label labelPinyin;
        private System.Windows.Forms.Label labelParent;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxInOut;
        private System.Windows.Forms.RadioButton radioButtonIn;
        private System.Windows.Forms.RadioButton radioButtonOut;
    }
}