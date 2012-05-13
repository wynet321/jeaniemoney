using JeanieMoney.Utility;
namespace JeanieMoney.Forms.Config
{
    partial class UnitConfig:BaseConfigForm
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
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click); this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.textBoxKeyword.TextChanged += new System.EventHandler(this.textBoxKeyword_TextChanged);
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            
            // 
            // UnitConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 244);
            this.Name = "UnitConfig";
            this.Text = "UnitConfig";
            this.ResumeLayout(false);

        }

        #endregion

    }
}