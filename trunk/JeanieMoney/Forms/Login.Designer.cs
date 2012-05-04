namespace JeanieMoney.Forms
{
    partial class Login
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.grpDBConnection = new System.Windows.Forms.GroupBox();
            this.comboBoxDbType = new System.Windows.Forms.ComboBox();
            this.labelDbType = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblDBAdminPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lblDBAdminName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.lblDBName = new System.Windows.Forms.Label();
            this.textBoxDBName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.lblDBConnection = new System.Windows.Forms.Label();
            this.btnModifyConnection = new System.Windows.Forms.Button();
            this.grpDBConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(145, 214);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(277, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(72, 27);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(143, 21);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(72, 54);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 21);
            this.txtPassword.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(14, 30);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 12);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "UserName";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(14, 57);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 12);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // grpDBConnection
            // 
            this.grpDBConnection.Controls.Add(this.comboBoxDbType);
            this.grpDBConnection.Controls.Add(this.labelDbType);
            this.grpDBConnection.Controls.Add(this.btnTest);
            this.grpDBConnection.Controls.Add(this.lblDBAdminPassword);
            this.grpDBConnection.Controls.Add(this.textBoxPassword);
            this.grpDBConnection.Controls.Add(this.lblDBAdminName);
            this.grpDBConnection.Controls.Add(this.textBoxUserName);
            this.grpDBConnection.Controls.Add(this.lblDBName);
            this.grpDBConnection.Controls.Add(this.textBoxDBName);
            this.grpDBConnection.Controls.Add(this.lblServerName);
            this.grpDBConnection.Controls.Add(this.textBoxServerName);
            this.grpDBConnection.Location = new System.Drawing.Point(230, 13);
            this.grpDBConnection.Name = "grpDBConnection";
            this.grpDBConnection.Size = new System.Drawing.Size(254, 195);
            this.grpDBConnection.TabIndex = 0;
            this.grpDBConnection.TabStop = false;
            this.grpDBConnection.Visible = false;
            // 
            // comboBoxDbType
            // 
            this.comboBoxDbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDbType.FormattingEnabled = true;
            this.comboBoxDbType.Location = new System.Drawing.Point(79, 32);
            this.comboBoxDbType.Name = "comboBoxDbType";
            this.comboBoxDbType.Size = new System.Drawing.Size(143, 20);
            this.comboBoxDbType.TabIndex = 15;
            // 
            // labelDbType
            // 
            this.labelDbType.AutoSize = true;
            this.labelDbType.Location = new System.Drawing.Point(20, 32);
            this.labelDbType.Name = "labelDbType";
            this.labelDbType.Size = new System.Drawing.Size(29, 12);
            this.labelDbType.TabIndex = 14;
            this.labelDbType.Text = "Type";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(121, 166);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 13;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblDBAdminPassword
            // 
            this.lblDBAdminPassword.AutoSize = true;
            this.lblDBAdminPassword.Location = new System.Drawing.Point(20, 139);
            this.lblDBAdminPassword.Name = "lblDBAdminPassword";
            this.lblDBAdminPassword.Size = new System.Drawing.Size(53, 12);
            this.lblDBAdminPassword.TabIndex = 12;
            this.lblDBAdminPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(79, 136);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(143, 21);
            this.textBoxPassword.TabIndex = 11;
            // 
            // lblDBAdminName
            // 
            this.lblDBAdminName.AutoSize = true;
            this.lblDBAdminName.Location = new System.Drawing.Point(20, 112);
            this.lblDBAdminName.Name = "lblDBAdminName";
            this.lblDBAdminName.Size = new System.Drawing.Size(53, 12);
            this.lblDBAdminName.TabIndex = 10;
            this.lblDBAdminName.Text = "UserName";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(79, 109);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(143, 21);
            this.textBoxUserName.TabIndex = 9;
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Location = new System.Drawing.Point(20, 85);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(17, 12);
            this.lblDBName.TabIndex = 8;
            this.lblDBName.Text = "DB";
            // 
            // textBoxDBName
            // 
            this.textBoxDBName.Location = new System.Drawing.Point(79, 82);
            this.textBoxDBName.Name = "textBoxDBName";
            this.textBoxDBName.Size = new System.Drawing.Size(143, 21);
            this.textBoxDBName.TabIndex = 7;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(20, 58);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(41, 12);
            this.lblServerName.TabIndex = 6;
            this.lblServerName.Text = "Server";
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(79, 55);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(143, 21);
            this.textBoxServerName.TabIndex = 5;
            // 
            // lblDBConnection
            // 
            this.lblDBConnection.Location = new System.Drawing.Point(14, 92);
            this.lblDBConnection.Name = "lblDBConnection";
            this.lblDBConnection.Size = new System.Drawing.Size(201, 55);
            this.lblDBConnection.TabIndex = 6;
            this.lblDBConnection.Text = "ServerName:";
            // 
            // btnModifyConnection
            // 
            this.btnModifyConnection.Location = new System.Drawing.Point(135, 179);
            this.btnModifyConnection.Name = "btnModifyConnection";
            this.btnModifyConnection.Size = new System.Drawing.Size(80, 23);
            this.btnModifyConnection.TabIndex = 7;
            this.btnModifyConnection.Text = "Setting(F3)";
            this.btnModifyConnection.UseVisualStyleBackColor = true;
            this.btnModifyConnection.Click += new System.EventHandler(this.btnModifyConnection_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 250);
            this.Controls.Add(this.btnModifyConnection);
            this.Controls.Add(this.lblDBConnection);
            this.Controls.Add(this.grpDBConnection);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "Login";
            this.Text = "Login";
            this.grpDBConnection.ResumeLayout(false);
            this.grpDBConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox grpDBConnection;
        private System.Windows.Forms.Label lblDBConnection;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.TextBox textBoxDBName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblDBAdminPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lblDBAdminName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button btnModifyConnection;
        private System.Windows.Forms.ComboBox comboBoxDbType;
        private System.Windows.Forms.Label labelDbType;
    }
}