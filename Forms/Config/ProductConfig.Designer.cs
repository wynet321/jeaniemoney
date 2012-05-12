namespace JeanieMoney.Forms
{
    partial class ProductConfig
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxAbbr = new System.Windows.Forms.TextBox();
            this.labelAbbr = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.listBoxProduct = new System.Windows.Forms.ListBox();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.labelSearchAbbr = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(246, 185);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 21);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(139, 185);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 21);
            this.buttonReset.TabIndex = 23;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(354, 185);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxAbbr
            // 
            this.textBoxAbbr.Location = new System.Drawing.Point(272, 60);
            this.textBoxAbbr.Name = "textBoxAbbr";
            this.textBoxAbbr.Size = new System.Drawing.Size(180, 21);
            this.textBoxAbbr.TabIndex = 21;
            // 
            // labelAbbr
            // 
            this.labelAbbr.AutoSize = true;
            this.labelAbbr.Location = new System.Drawing.Point(231, 63);
            this.labelAbbr.Name = "labelAbbr";
            this.labelAbbr.Size = new System.Drawing.Size(29, 12);
            this.labelAbbr.TabIndex = 20;
            this.labelAbbr.Text = "Abbr";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(272, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 21);
            this.textBoxName.TabIndex = 19;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(231, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 12);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Name";
            // 
            // listBoxProduct
            // 
            this.listBoxProduct.FormattingEnabled = true;
            this.listBoxProduct.ItemHeight = 12;
            this.listBoxProduct.Location = new System.Drawing.Point(15, 33);
            this.listBoxProduct.Name = "listBoxProduct";
            this.listBoxProduct.Size = new System.Drawing.Size(199, 136);
            this.listBoxProduct.TabIndex = 17;
            this.listBoxProduct.SelectedIndexChanged += new System.EventHandler(this.listBoxProduct_SelectedIndexChanged);
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(66, 9);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(148, 21);
            this.textBoxKeyword.TabIndex = 16;
            this.textBoxKeyword.TextChanged += new System.EventHandler(this.textBoxKeyword_TextChanged);
            // 
            // labelSearchAbbr
            // 
            this.labelSearchAbbr.AutoSize = true;
            this.labelSearchAbbr.Location = new System.Drawing.Point(12, 11);
            this.labelSearchAbbr.Name = "labelSearchAbbr";
            this.labelSearchAbbr.Size = new System.Drawing.Size(47, 12);
            this.labelSearchAbbr.TabIndex = 15;
            this.labelSearchAbbr.Text = "Keyword";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(37, 185);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(272, 87);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(180, 21);
            this.textBoxBarcode.TabIndex = 26;
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Location = new System.Drawing.Point(219, 90);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(47, 12);
            this.labelBarcode.TabIndex = 25;
            this.labelBarcode.Text = "Barcode";
            // 
            // ProductConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 214);
            this.Controls.Add(this.textBoxBarcode);
            this.Controls.Add(this.labelBarcode);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxAbbr);
            this.Controls.Add(this.labelAbbr);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBoxProduct);
            this.Controls.Add(this.textBoxKeyword);
            this.Controls.Add(this.labelSearchAbbr);
            this.Controls.Add(this.buttonOK);
            this.Name = "ProductConfig";
            this.Text = "ProductConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxAbbr;
        private System.Windows.Forms.Label labelAbbr;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox listBoxProduct;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.Label labelSearchAbbr;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label labelBarcode;
    }
}