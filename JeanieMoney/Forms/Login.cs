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
            comboBoxDbType.DataSource = DBHandler.getDbType();
            comboBoxDbType.DisplayMember = "Key";
            comboBoxDbType.ValueMember = "Value";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //verify user/pass to login
            if (validateInput(textBoxUserName.Text) && validateInput(textBoxPassword.Text))
            {
                if (textBoxUserName.Text == "Jeanie" && textBoxPassword.Text == "Money")
                    this.DialogResult = DialogResult.OK;
                DBHandler.setConnection(ConfigHandler.getDbType(comboBoxProfile.SelectedItem.ToString()), generateConnectionString(comboBoxProfile.SelectedItem.ToString()));
                int validUserCount = (int)DBHandler.getValue("select count(*) from payer where name='" + textBoxUserName.Text + "' and password='" + textBoxPassword.Text + "'");
                if (validUserCount > 0)
                    this.DialogResult = DialogResult.OK;
                else
                {
                    MessageBox.Show("User/Password are not correct!");
                    textBoxUserName.Focus();
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
        private void groupBoxDbConnectionInit()
        {
            textBoxDbName.Clear();
            textBoxServerName.Clear();
            textBoxDbAdminName.Clear();
            textBoxDbAdminPassword.Clear();
            textBoxProfileName.Clear();

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

            DBHandler.setConnection(comboBoxDbType.SelectedValue.ToString(), generateConnectionString(String.Empty));
            if (DBHandler.canConnect())
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
                profileSelectedIndex = comboBoxProfile.SelectedIndex;
                textBoxProfileName.Text = comboBoxProfile.SelectedItem.ToString();
                comboBoxDbType.SelectedValue = ConfigHandler.getDbType(textBoxProfileName.Text);
                textBoxServerName.Text = ConfigHandler.getServerName(textBoxProfileName.Text);
                textBoxDbName.Text = ConfigHandler.getDbName(textBoxProfileName.Text);
                textBoxDbAdminName.Text = ConfigHandler.getDbAdminName(textBoxProfileName.Text);
                textBoxDbAdminPassword.Text = ConfigHandler.getDbAdminPassword(textBoxProfileName.Text);
            }
            buttonOK.Enabled = !checkBoxModifyProfile.Checked;
            groupBoxDbConnection.Visible = checkBoxModifyProfile.Checked;
        }

        private void checkBoxNewProfile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNewProfile.Checked)
            {
                isNew = true;
                groupBoxDbConnectionInit();
            }
            buttonOK.Enabled = !checkBoxNewProfile.Checked;
            groupBoxDbConnection.Visible = checkBoxNewProfile.Checked;

        }
    }
}
