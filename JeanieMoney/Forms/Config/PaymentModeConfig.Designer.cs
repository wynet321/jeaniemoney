namespace JeanieMoney.Forms.Config
{
    partial class PaymentModeConfig:BaseConfigForm
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
            buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            textBoxKeyword.TextChanged += new System.EventHandler(this.textBoxKeyword_TextChanged);
            buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
          
            // 
            // PaymentModeConfig
            // 
            this.Name = "PaymentModeConfig";
            this.ResumeLayout(false);

        }

        #endregion

    }
}
