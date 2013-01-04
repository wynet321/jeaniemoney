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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.groupBoxDbConnection = new System.Windows.Forms.GroupBox();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.textBoxProfileName = new System.Windows.Forms.TextBox();
            this.comboBoxDbType = new System.Windows.Forms.ComboBox();
            this.labelDbType = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelDbOperatorPassword = new System.Windows.Forms.Label();
            this.textBoxDbAdminPassword = new System.Windows.Forms.TextBox();
            this.labelDbOperatorName = new System.Windows.Forms.Label();
            this.textBoxDbAdminName = new System.Windows.Forms.TextBox();
            this.labelDBName = new System.Windows.Forms.Label();
            this.textBoxDbName = new System.Windows.Forms.TextBox();
            this.labelDbServerHostName = new System.Windows.Forms.Label();
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
            this.buttonOK.Text = "ok";
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
            this.buttonCancel.Text = "cancel";
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
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(14, 33);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(53, 13);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(14, 62);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(52, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "password";
            // 
            // groupBoxDbConnection
            // 
            this.groupBoxDbConnection.Controls.Add(this.labelProfileName);
            this.groupBoxDbConnection.Controls.Add(this.textBoxProfileName);
            this.groupBoxDbConnection.Controls.Add(this.comboBoxDbType);
            this.groupBoxDbConnection.Controls.Add(this.labelDbType);
            this.groupBoxDbConnection.Controls.Add(this.buttonTest);
            this.groupBoxDbConnection.Controls.Add(this.labelDbOperatorPassword);
            this.groupBoxDbConnection.Controls.Add(this.textBoxDbAdminPassword);
            this.groupBoxDbConnection.Controls.Add(this.labelDbOperatorName);
            this.groupBoxDbConnection.Controls.Add(this.textBoxDbAdminName);
            this.groupBoxDbConnection.Controls.Add(this.labelDBName);
            this.groupBoxDbConnection.Controls.Add(this.textBoxDbName);
            this.groupBoxDbConnection.Controls.Add(this.labelDbServerHostName);
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
            this.labelProfileName.Size = new System.Drawing.Size(33, 13);
            this.labelProfileName.TabIndex = 17;
            this.labelProfileName.Text = "name";
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
            this.labelDbType.Size = new System.Drawing.Size(27, 13);
            this.labelDbType.TabIndex = 14;
            this.labelDbType.Text = "type";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(147, 191);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 25);
            this.buttonTest.TabIndex = 13;
            this.buttonTest.Text = "test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelDbOperatorPassword
            // 
            this.labelDbOperatorPassword.AutoSize = true;
            this.labelDbOperatorPassword.Location = new System.Drawing.Point(20, 157);
            this.labelDbOperatorPassword.Name = "labelDbOperatorPassword";
            this.labelDbOperatorPassword.Size = new System.Drawing.Size(52, 13);
            this.labelDbOperatorPassword.TabIndex = 12;
            this.labelDbOperatorPassword.Text = "password";
            // 
            // textBoxDbAdminPassword
            // 
            this.textBoxDbAdminPassword.Location = new System.Drawing.Point(79, 154);
            this.textBoxDbAdminPassword.Name = "textBoxDbAdminPassword";
            this.textBoxDbAdminPassword.Size = new System.Drawing.Size(143, 20);
            this.textBoxDbAdminPassword.TabIndex = 11;
            this.textBoxDbAdminPassword.UseSystemPasswordChar = true;
            // 
            // labelDbOperatorName
            // 
            this.labelDbOperatorName.AutoSize = true;
            this.labelDbOperatorName.Location = new System.Drawing.Point(20, 128);
            this.labelDbOperatorName.Name = "labelDbOperatorName";
            this.labelDbOperatorName.Size = new System.Drawing.Size(53, 13);
            this.labelDbOperatorName.TabIndex = 10;
            this.labelDbOperatorName.Text = "username";
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
            this.labelDBName.Size = new System.Drawing.Size(45, 13);
            this.labelDBName.TabIndex = 8;
            this.labelDBName.Text = "dbname";
            // 
            // textBoxDbName
            // 
            this.textBoxDbName.Location = new System.Drawing.Point(79, 95);
            this.textBoxDbName.Name = "textBoxDbName";
            this.textBoxDbName.Size = new System.Drawing.Size(143, 20);
            this.textBoxDbName.TabIndex = 7;
            // 
            // labelDbServerHostName
            // 
            this.labelDbServerHostName.AutoSize = true;
            this.labelDbServerHostName.Location = new System.Drawing.Point(20, 69);
            this.labelDbServerHostName.Name = "labelDbServerHostName";
            this.labelDbServerHostName.Size = new System.Drawing.Size(53, 13);
            this.labelDbServerHostName.TabIndex = 6;
            this.labelDbServerHostName.Text = "hostname";
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
            this.labelProfile.Size = new System.Drawing.Size(35, 13);
            this.labelProfile.TabIndex = 8;
            this.labelProfile.Text = "profile";
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
            this.checkBoxModifyProfile.Text = "modify";
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
            this.checkBoxNewProfile.Text = "new";
            this.checkBoxNewProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNewProfile.UseVisualStyleBackColor = true;
            this.checkBoxNewProfile.CheckedChanged += new System.EventHandler(this.checkBoxNewProfile_CheckedChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 283);
            this.Controls.Add(this.checkBoxNewProfile);
            this.Controls.Add(this.checkBoxModifyProfile);
            this.Controls.Add(this.comboBoxProfile);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.groupBoxDbConnection);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.GroupBox groupBoxDbConnection;
        private System.Windows.Forms.Label labelDBName;
        private System.Windows.Forms.TextBox textBoxDbName;
        private System.Windows.Forms.Label labelDbServerHostName;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelDbOperatorPassword;
        private System.Windows.Forms.TextBox textBoxDbAdminPassword;
        private System.Windows.Forms.Label labelDbOperatorName;
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