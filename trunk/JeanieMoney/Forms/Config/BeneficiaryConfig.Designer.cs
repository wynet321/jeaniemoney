namespace JeanieMoney.Forms.Config
{
    partial class BeneficiaryConfig:BaseConfigForm
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
            this.SuspendLayout();
            // 
            // BeneficiaryConfig
            // 
            buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            textBoxKeyword.TextChanged += new System.EventHandler(this.textBoxKeyword_TextChanged);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 214);
            this.Name = "BeneficiaryConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

    }
}