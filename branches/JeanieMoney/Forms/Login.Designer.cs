﻿namespace JeanieMoney.Forms
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.groupBoxDbConnection = new System.Windows.Forms.GroupBox();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.textBoxProfileName = new System.Windows.Forms.TextBox();
            this.comboBoxDbType = new System.Windows.Forms.ComboBox();
            this.labelDbType = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelDbAdminPassword = new System.Windows.Forms.Label();
            this.textBoxDbAdminPassword = new System.Windows.Forms.TextBox();
            this.labelDbAdminName = new System.Windows.Forms.Label();
            this.textBoxDbAdminName = new System.Windows.Forms.TextBox();
            this.labelDBName = new System.Windows.Forms.Label();
            this.textBoxDbName = new System.Windows.Forms.TextBox();
            this.labelServerName = new System.Windows.Forms.Label();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.labelProfile = new System.Windows.Forms.Label();
            this.comboBoxProfile = new System.Windows.Forms.ComboBox();
            this.checkBoxModifyProfile = new System.Windows.Forms.CheckBox();
            this.checkBoxNewProfile = new System.Windows.Forms.CheckBox();
            this.groupBoxDbConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(33, 235);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 25);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(141, 235);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 25);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(72, 29);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(143, 20);
            this.textBoxUserName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(72, 59);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(143, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(14, 33);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "UserName";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(14, 62);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // groupBoxDbConnection
            // 
            this.groupBoxDbConnection.Controls.Add(this.labelProfileName);
            this.groupBoxDbConnection.Controls.Add(this.textBoxProfileName);
            this.groupBoxDbConnection.Controls.Add(this.comboBoxDbType);
            this.groupBoxDbConnection.Controls.Add(this.labelDbType);
            this.groupBoxDbConnection.Controls.Add(this.buttonTest);
            this.groupBoxDbConnection.Controls.Add(this.labelDbAdminPassword);
            this.groupBoxDbConnection.Controls.Add(this.textBoxDbAdminPassword);
            this.groupBoxDbConnection.Controls.Add(this.labelDbAdminName);
            this.groupBoxDbConnection.Controls.Add(this.textBoxDbAdminName);
            this.groupBoxDbConnection.Controls.Add(this.labelDBName);
            this.groupBoxDbConnection.Controls.Add(this.textBoxDbName);
            this.groupBoxDbConnection.Controls.Add(this.labelServerName);
            this.groupBoxDbConnection.Controls.Add(this.textBoxServerName);
            this.groupBoxDbConnection.Location = new System.Drawing.Point(230, 3);
            this.groupBoxDbConnection.Name = "groupBoxDbConnection";
            this.groupBoxDbConnection.Size = new System.Drawing.Size(254, 222);
            this.groupBoxDbConnection.TabIndex = 0;
            this.groupBoxDbConnection.TabStop = false;
            this.groupBoxDbConnection.Visible = false;
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Location = new System.Drawing.Point(20, 18);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(36, 13);
            this.labelProfileName.TabIndex = 17;
            this.labelProfileName.Text = "Profile";
            // 
            // textBoxProfileName
            // 
            this.textBoxProfileName.Location = new System.Drawing.Point(79, 15);
            this.textBoxProfileName.Name = "textBoxProfileName";
            this.textBoxProfileName.Size = new System.Drawing.Size(143, 20);
            this.textBoxProfileName.TabIndex = 16;
            // 
            // comboBoxDbType
            // 
            this.comboBoxDbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDbType.FormattingEnabled = true;
            this.comboBoxDbType.Location = new System.Drawing.Point(79, 41);
            this.comboBoxDbType.Name = "comboBoxDbType";
            this.comboBoxDbType.Size = new System.Drawing.Size(143, 21);
            this.comboBoxDbType.TabIndex = 15;
            // 
            // labelDbType
            // 
            this.labelDbType.AutoSize = true;
            this.labelDbType.Location = new System.Drawing.Point(20, 41);
            this.labelDbType.Name = "labelDbType";
            this.labelDbType.Size = new System.Drawing.Size(31, 13);
            this.labelDbType.TabIndex = 14;
            this.labelDbType.Text = "Type";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(147, 191);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 25);
            this.buttonTest.TabIndex = 13;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelDbAdminPassword
            // 
            this.labelDbAdminPassword.AutoSize = true;
            this.labelDbAdminPassword.Location = new System.Drawing.Point(20, 157);
            this.labelDbAdminPassword.Name = "labelDbAdminPassword";
            this.labelDbAdminPassword.Size = new System.Drawing.Size(53, 13);
            this.labelDbAdminPassword.TabIndex = 12;
            this.labelDbAdminPassword.Text = "Password";
            // 
            // textBoxDbAdminPassword
            // 
            this.textBoxDbAdminPassword.Location = new System.Drawing.Point(79, 154);
            this.textBoxDbAdminPassword.Name = "textBoxDbAdminPassword";
            this.textBoxDbAdminPassword.Size = new System.Drawing.Size(143, 20);
            this.textBoxDbAdminPassword.TabIndex = 11;
            this.textBoxDbAdminPassword.UseSystemPasswordChar = true;
            // 
            // labelDbAdminName
            // 
            this.labelDbAdminName.AutoSize = true;
            this.labelDbAdminName.Location = new System.Drawing.Point(20, 128);
            this.labelDbAdminName.Name = "labelDbAdminName";
            this.labelDbAdminName.Size = new System.Drawing.Size(57, 13);
            this.labelDbAdminName.TabIndex = 10;
            this.labelDbAdminName.Text = "UserName";
            // 
            // textBoxDbAdminName
            // 
            this.textBoxDbAdminName.Location = new System.Drawing.Point(79, 125);
            this.textBoxDbAdminName.Name = "textBoxDbAdminName";
            this.textBoxDbAdminName.Size = new System.Drawing.Size(143, 20);
            this.textBoxDbAdminName.TabIndex = 9;
            // 
            // labelDBName
            // 
            this.labelDBName.AutoSize = true;
            this.labelDBName.Location = new System.Drawing.Point(20, 99);
            this.labelDBName.Name = "labelDBName";
            this.labelDBName.Size = new System.Drawing.Size(22, 13);
            this.labelDBName.TabIndex = 8;
            this.labelDBName.Text = "DB";
            // 
            // textBoxDbName
            // 
            this.textBoxDbName.Location = new System.Drawing.Point(79, 95);
            this.textBoxDbName.Name = "textBoxDbName";
            this.textBoxDbName.Size = new System.Drawing.Size(143, 20);
            this.textBoxDbName.TabIndex = 7;
            // 
            // labelServerName
            // 
            this.labelServerName.AutoSize = true;
            this.labelServerName.Location = new System.Drawing.Point(20, 69);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(38, 13);
            this.labelServerName.TabIndex = 6;
            this.labelServerName.Text = "Server";
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(79, 66);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(143, 20);
            this.textBoxServerName.TabIndex = 5;
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Location = new System.Drawing.Point(19, 92);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(36, 13);
            this.labelProfile.TabIndex = 8;
            this.labelProfile.Text = "Profile";
            // 
            // comboBoxProfile
            // 
            this.comboBoxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfile.FormattingEnabled = true;
            this.comboBoxProfile.Location = new System.Drawing.Point(72, 89);
            this.comboBoxProfile.Name = "comboBoxProfile";
            this.comboBoxProfile.Size = new System.Drawing.Size(143, 21);
            this.comboBoxProfile.TabIndex = 3;
            // 
            // checkBoxModifyProfile
            // 
            this.checkBoxModifyProfile.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxModifyProfile.Location = new System.Drawing.Point(136, 147);
            this.checkBoxModifyProfile.Name = "checkBoxModifyProfile";
            this.checkBoxModifyProfile.Size = new System.Drawing.Size(79, 26);
            this.checkBoxModifyProfile.TabIndex = 7;
            this.checkBoxModifyProfile.Text = "Modify(F3)";
            this.checkBoxModifyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxModifyProfile.UseVisualStyleBackColor = true;
            this.checkBoxModifyProfile.CheckedChanged += new System.EventHandler(this.checkBoxModifyProfile_CheckedChanged);
            // 
            // checkBoxNewProfile
            // 
            this.checkBoxNewProfile.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxNewProfile.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNewProfile.Location = new System.Drawing.Point(136, 117);
            this.checkBoxNewProfile.Name = "checkBoxNewProfile";
            this.checkBoxNewProfile.Size = new System.Drawing.Size(79, 24);
            this.checkBoxNewProfile.TabIndex = 6;
            this.checkBoxNewProfile.Text = "New(F2)";
            this.checkBoxNewProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNewProfile.UseVisualStyleBackColor = true;
            this.checkBoxNewProfile.CheckedChanged += new System.EventHandler(this.checkBoxNewProfile_CheckedChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(248, 283);
            this.Controls.Add(this.checkBoxNewProfile);
            this.Controls.Add(this.checkBoxModifyProfile);
            this.Controls.Add(this.comboBoxProfile);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.groupBoxDbConnection);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBoxDbConnection.ResumeLayout(false);
            this.groupBoxDbConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox groupBoxDbConnection;
        private System.Windows.Forms.Label labelDBName;
        private System.Windows.Forms.TextBox textBoxDbName;
        private System.Windows.Forms.Label labelServerName;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelDbAdminPassword;
        private System.Windows.Forms.TextBox textBoxDbAdminPassword;
        private System.Windows.Forms.Label labelDbAdminName;
        private System.Windows.Forms.TextBox textBoxDbAdminName;
        private System.Windows.Forms.ComboBox comboBoxDbType;
        private System.Windows.Forms.Label labelDbType;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.TextBox textBoxProfileName;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.ComboBox comboBoxProfile;
        private System.Windows.Forms.CheckBox checkBoxModifyProfile;
        private System.Windows.Forms.CheckBox checkBoxNewProfile;
    }
}