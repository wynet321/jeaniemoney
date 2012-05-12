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
            this.labelSearchAbbr = new System.Windows.Forms.Label();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.comboBoxParent = new System.Windows.Forms.ComboBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxAbbr = new System.Windows.Forms.TextBox();
            this.labelAbbr = new System.Windows.Forms.Label();
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
            this.buttonOK.Location = new System.Drawing.Point(37, 182);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelSearchAbbr
            // 
            this.labelSearchAbbr.AutoSize = true;
            this.labelSearchAbbr.Location = new System.Drawing.Point(12, 8);
            this.labelSearchAbbr.Name = "labelSearchAbbr";
            this.labelSearchAbbr.Size = new System.Drawing.Size(47, 12);
            this.labelSearchAbbr.TabIndex = 1;
            this.labelSearchAbbr.Text = "Keyword";
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(66, 6);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(148, 21);
            this.textBoxKeyword.TabIndex = 1;
            this.textBoxKeyword.TextChanged += new System.EventHandler(this.textBoxKeyword_TextChanged);
            // 
            // comboBoxParent
            // 
            this.comboBoxParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParent.FormattingEnabled = true;
            this.comboBoxParent.Location = new System.Drawing.Point(272, 112);
            this.comboBoxParent.Name = "comboBoxParent";
            this.comboBoxParent.Size = new System.Drawing.Size(180, 20);
            this.comboBoxParent.TabIndex = 7;
            this.comboBoxParent.SelectedIndexChanged += new System.EventHandler(this.comboBoxParent_SelectedIndexChanged);
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 12;
            this.listBoxCategory.Location = new System.Drawing.Point(15, 30);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(199, 136);
            this.listBoxCategory.TabIndex = 2;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxCategory_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(272, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 21);
            this.textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(231, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 12);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // textBoxAbbr
            // 
            this.textBoxAbbr.Location = new System.Drawing.Point(272, 88);
            this.textBoxAbbr.Name = "textBoxAbbr";
            this.textBoxAbbr.Size = new System.Drawing.Size(180, 21);
            this.textBoxAbbr.TabIndex = 6;
            // 
            // labelAbbr
            // 
            this.labelAbbr.AutoSize = true;
            this.labelAbbr.Location = new System.Drawing.Point(231, 90);
            this.labelAbbr.Name = "labelAbbr";
            this.labelAbbr.Size = new System.Drawing.Size(29, 12);
            this.labelAbbr.TabIndex = 7;
            this.labelAbbr.Text = "Abbr";
            // 
            // labelParent
            // 
            this.labelParent.AutoSize = true;
            this.labelParent.Location = new System.Drawing.Point(231, 114);
            this.labelParent.Name = "labelParent";
            this.labelParent.Size = new System.Drawing.Size(41, 12);
            this.labelParent.TabIndex = 9;
            this.labelParent.Text = "Parent";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(354, 182);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(139, 182);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 21);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(246, 182);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 21);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxInOut
            // 
            this.groupBoxInOut.Controls.Add(this.radioButtonIn);
            this.groupBoxInOut.Controls.Add(this.radioButtonOut);
            this.groupBoxInOut.Location = new System.Drawing.Point(234, 8);
            this.groupBoxInOut.Name = "groupBoxInOut";
            this.groupBoxInOut.Size = new System.Drawing.Size(218, 42);
            this.groupBoxInOut.TabIndex = 14;
            this.groupBoxInOut.TabStop = false;
            this.groupBoxInOut.Text = "InOut";
            // 
            // radioButtonIn
            // 
            this.radioButtonIn.AutoSize = true;
            this.radioButtonIn.Location = new System.Drawing.Point(81, 18);
            this.radioButtonIn.Name = "radioButtonIn";
            this.radioButtonIn.Size = new System.Drawing.Size(35, 15);
            this.radioButtonIn.TabIndex = 4;
            this.radioButtonIn.Text = "In";
            this.radioButtonIn.UseVisualStyleBackColor = true;
            // 
            // radioButtonOut
            // 
            this.radioButtonOut.AutoSize = true;
            this.radioButtonOut.Checked = true;
            this.radioButtonOut.Location = new System.Drawing.Point(6, 18);
            this.radioButtonOut.Name = "radioButtonOut";
            this.radioButtonOut.Size = new System.Drawing.Size(41, 15);
            this.radioButtonOut.TabIndex = 3;
            this.radioButtonOut.TabStop = true;
            this.radioButtonOut.Text = "Out";
            this.radioButtonOut.UseVisualStyleBackColor = true;
            // 
            // CategoryConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 214);
            this.Controls.Add(this.groupBoxInOut);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelParent);
            this.Controls.Add(this.textBoxAbbr);
            this.Controls.Add(this.labelAbbr);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.comboBoxParent);
            this.Controls.Add(this.textBoxKeyword);
            this.Controls.Add(this.labelSearchAbbr);
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
        private System.Windows.Forms.Label labelSearchAbbr;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.ComboBox comboBoxParent;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAbbr;
        private System.Windows.Forms.Label labelAbbr;
        private System.Windows.Forms.Label labelParent;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxInOut;
        private System.Windows.Forms.RadioButton radioButtonIn;
        private System.Windows.Forms.RadioButton radioButtonOut;
    }
}