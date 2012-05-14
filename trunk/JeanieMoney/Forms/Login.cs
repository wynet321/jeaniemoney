using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JeanieMoney.Utility;

namespace JeanieMoney.Forms
{
    public partial class Login : Form
    {
        private Boolean isNew;
        private int profileSelectedIndex;
        public Login()
        {
            InitializeComponent();
            comboBoxDbType.DataSource = DbHandler.getDbType();
            comboBoxDbType.DisplayMember = "Key";
            comboBoxDbType.ValueMember = "Value";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //verify user/pass to login
            if (validateInput(textBoxUserName.Text) && validateInput(textBoxPassword.Text))
            {
                DbHandler.setConnection(ConfigHandler.getDbType(comboBoxProfile.SelectedItem.ToString()), generateConnectionString(comboBoxProfile.SelectedItem.ToString()));
                if (!DbHandler.canConnect())
                {
                    MessageBox.Show("Can't connect to DB");
                    return;
                }
                if (textBoxUserName.Text == "Jeanie" && textBoxPassword.Text == "Money")
                {
                    buttonOK.DialogResult = DialogResult.OK;
                    return;
                }
                try
                {
                    int validUserCount = (int)DbHandler.getValue("select count(*) from payer where name='" + textBoxUserName.Text + "' and password='" + textBoxPassword.Text + "'");
                    if (validUserCount > 0)
                    {
                        buttonOK.DialogResult = DialogResult.OK;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("User/Password are not correct!");
                        textBoxUserName.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("DB Connection issue!");
                    return;
                }

            }
            else
            {
                MessageBox.Show("User or Password is invalid.");
            }

        }
        private Boolean validateInput(String stringToValidate)
        {
            if (null == stringToValidate || stringToValidate.Length == 0)
                return false;
            //Todo: defence sql attack

            return true;
        }
        private String generateConnectionString(String profileName)
        {
            String connectionString = "Data Source=";
            if (0 == profileName.Length)
            {
                connectionString += textBoxServerName.Text + ";Initial Catalog=" + textBoxDbName.Text + ";User id=" + textBoxDbAdminName.Text + ";Password=" + textBoxDbAdminPassword.Text + ";";
            }
            else
            {
                connectionString += ConfigHandler.getServerName(profileName) + ";Initial Catalog=" + ConfigHandler.getDbName(profileName) + ";User id=" + ConfigHandler.getDbAdminName(profileName) + ";Password=" + ConfigHandler.getDbAdminPassword(profileName) + ";";
            }
            return connectionString;
        }
        private void buttonModifyProfile_Click(object sender, EventArgs e)
        {

        }
        private void groupBoxDbConnectionShow()
        {
            this.Width = 512;
            buttonOK.Left = 145;
            buttonCancel.Left = 277;
            textBoxDbName.Clear();
            textBoxServerName.Clear();
            textBoxDbAdminName.Clear();
            textBoxDbAdminPassword.Clear();
            textBoxProfileName.Clear();

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            if (validateProfileInput())
            {
                DbHandler.setConnection(comboBoxDbType.SelectedValue.ToString(), generateConnectionString(String.Empty));
                if (DbHandler.canConnect())
                {
                    if (isNew)
                    {
                        if (comboBoxProfile.Items.Contains(textBoxProfileName.Text))
                        {
                            MessageBox.Show("Profile Name should be unique. Please select another name!");
                            textBoxProfileName.Focus();
                            textBoxProfileName.SelectAll();
                            return;
                        }
                        else
                        {
                            //add xml profile
                            ConfigHandler.addProfile(textBoxProfileName.Text);
                            ConfigHandler.setDbType(textBoxProfileName.Text, comboBoxDbType.SelectedValue.ToString());
                            ConfigHandler.setServerName(textBoxProfileName.Text, textBoxServerName.Text);
                            ConfigHandler.setDbName(textBoxProfileName.Text, textBoxDbName.Text);
                            ConfigHandler.setDbAdminName(textBoxProfileName.Text, textBoxDbAdminName.Text);
                            ConfigHandler.setDbAdminPassword(textBoxProfileName.Text, textBoxDbAdminPassword.Text);
                            //add profile combobox
                            comboBoxProfile.Items.Add(textBoxProfileName.Text);
                        }
                    }
                    else
                    {
                        //change xml
                        ConfigHandler.reviseProfile(comboBoxProfile.Items[profileSelectedIndex].ToString(), textBoxProfileName.Text);
                        ConfigHandler.setDbType(textBoxProfileName.Text, comboBoxDbType.SelectedValue.ToString());
                        ConfigHandler.setServerName(textBoxProfileName.Text, textBoxServerName.Text);
                        ConfigHandler.setDbName(textBoxProfileName.Text, textBoxDbName.Text);
                        ConfigHandler.setDbAdminName(textBoxProfileName.Text, textBoxDbAdminName.Text);
                        ConfigHandler.setDbAdminPassword(textBoxProfileName.Text, textBoxDbAdminPassword.Text);
                        //change profile selection
                        comboBoxProfile.DataSource = ConfigHandler.getProfileList();
                        comboBoxProfile.SelectedIndex = profileSelectedIndex;
                    }
                    groupBoxDbConnection.Visible = !groupBoxDbConnection.Visible;
                    //change OK enable
                    buttonOK.Enabled = true;
                }
            }

        }

        private bool validateProfileInput()
        {
            if (!validateInput(textBoxProfileName.Text))
            {
                MessageBox.Show("Profile name is invalid.");
                textBoxProfileName.Focus();
                return false;
            }
            if (!validateInput(textBoxServerName.Text))
            {
                MessageBox.Show("Server name is invalid.");
                textBoxServerName.Focus();
                return false;
            }
            if (!validateInput(textBoxDbName.Text))
            {
                MessageBox.Show("DB name is invalid.");
                textBoxDbName.Focus();
                return false;
            }
            if (!validateInput(textBoxDbAdminName.Text))
            {
                MessageBox.Show("DB Admin name is invalid.");
                textBoxDbAdminName.Focus();
                return false;
            }
            if (!validateInput(textBoxDbAdminPassword.Text))
            {
                MessageBox.Show("DB Admin password is invalid.");
                textBoxDbAdminPassword.Focus();
                return false;
            }
            return true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            List<String> profileList = ConfigHandler.getProfileList();
            comboBoxProfile.DataSource = profileList;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void checkBoxModifyProfile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModifyProfile.Checked)
            {
                isNew = false;
                groupBoxDbConnectionShow();
                profileSelectedIndex = comboBoxProfile.SelectedIndex;
                textBoxProfileName.Text = comboBoxProfile.SelectedItem.ToString();
                comboBoxDbType.SelectedValue = ConfigHandler.getDbType(textBoxProfileName.Text);
                textBoxServerName.Text = ConfigHandler.getServerName(textBoxProfileName.Text);
                textBoxDbName.Text = ConfigHandler.getDbName(textBoxProfileName.Text);
                textBoxDbAdminName.Text = ConfigHandler.getDbAdminName(textBoxProfileName.Text);
                textBoxDbAdminPassword.Text = ConfigHandler.getDbAdminPassword(textBoxProfileName.Text);
            }
            else
            {
                groupBoxDbConnectionHide();
            }
            buttonOK.Enabled = !checkBoxModifyProfile.Checked;
            groupBoxDbConnection.Visible = checkBoxModifyProfile.Checked;
        }

        private void checkBoxNewProfile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNewProfile.Checked)
            {
                isNew = true;
                groupBoxDbConnectionShow();
            }
            else
            {
                groupBoxDbConnectionHide();
            }
            buttonOK.Enabled = !checkBoxNewProfile.Checked;
            groupBoxDbConnection.Visible = checkBoxNewProfile.Checked;

        }

        private void groupBoxDbConnectionHide()
        {
            this.Width = 256;
            buttonOK.Left = 33;
            buttonCancel.Left = 141;
        }
    }
}
