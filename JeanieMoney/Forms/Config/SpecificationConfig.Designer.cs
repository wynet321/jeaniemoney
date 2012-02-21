using JeanieMoney.Utility;
namespace JeanieMoney.Forms.Config
{
    partial class SpecificationConfig:BaseConfigForm
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
            this.listBoxSpecification = new System.Windows.Forms.ListBox();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.labelSearchAbbr = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(251, 216);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 35;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(144, 216);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 34;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(359, 216);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxAbbr
            // 
            this.textBoxAbbr.Location = new System.Drawing.Point(277, 78);
            this.textBoxAbbr.Name = "textBoxAbbr";
            this.textBoxAbbr.Size = new System.Drawing.Size(180, 20);
            this.textBoxAbbr.TabIndex = 32;
            // 
            // labelAbbr
            // 
            this.labelAbbr.AutoSize = true;
            this.labelAbbr.Location = new System.Drawing.Point(236, 81);
            this.labelAbbr.Name = "labelAbbr";
            this.labelAbbr.Size = new System.Drawing.Size(29, 13);
            this.labelAbbr.TabIndex = 31;
            this.labelAbbr.Text = "Abbr";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(277, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 20);
            this.textBoxName.TabIndex = 30;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(236, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "Name";
            // 
            // listBoxSpecification
            // 
            this.listBoxSpecification.FormattingEnabled = true;
            this.listBoxSpecification.Location = new System.Drawing.Point(20, 52);
            this.listBoxSpecification.Name = "listBoxSpecification";
            this.listBoxSpecification.Size = new System.Drawing.Size(199, 147);
            this.listBoxSpecification.TabIndex = 28;
            this.listBoxSpecification.SelectedIndexChanged += new System.EventHandler(this.listBoxSpecification_SelectedIndexChanged);
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(71, 26);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(148, 20);
            this.textBoxKeyword.TabIndex = 27;
            this.textBoxKeyword.TextChanged += new System.EventHandler(this.textBoxKeyword_TextChanged);
            // 
            // labelSearchAbbr
            // 
            this.labelSearchAbbr.AutoSize = true;
            this.labelSearchAbbr.Location = new System.Drawing.Point(17, 28);
            this.labelSearchAbbr.Name = "labelSearchAbbr";
            this.labelSearchAbbr.Size = new System.Drawing.Size(48, 13);
            this.labelSearchAbbr.TabIndex = 26;
            this.labelSearchAbbr.Text = "Keyword";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(42, 216);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 25;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // SpecificationConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 264);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxAbbr);
            this.Controls.Add(this.labelAbbr);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBoxSpecification);
            this.Controls.Add(this.textBoxKeyword);
            this.Controls.Add(this.labelSearchAbbr);
            this.Controls.Add(this.buttonOK);
            this.Name = "SpecificationConfig";
            this.Text = "SpecificationConfig";
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
        private System.Windows.Forms.ListBox listBoxSpecification;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.Label labelSearchAbbr;
        private System.Windows.Forms.Button buttonOK;
    }
}