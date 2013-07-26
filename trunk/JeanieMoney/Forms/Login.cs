using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary.lib;
using System.Data.Common;

namespace JeanieMoney.Forms
{
    public partial class Login : Form
    {
        private Boolean isNewProfile;
        private int profileSelectedIndex;
        public Login()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            setCaption();
            this.Size = new System.Drawing.Size(264, 321);

            comboBoxDbType.DataSource = HandlerFactory.dbType;
            comboBoxDbType.DisplayMember = "Key";
            comboBoxDbType.ValueMember = "Value";
        }

        private void setCaption()
        {
            labelDbOperatorName.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_LABEL_DB_OPERATOR_NAME);
            labelDbOperatorPassword.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_LABEL_DB_OPERATOR_PASSWORD);
            labelDBName.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_LABEL_DB_NAME);
            labelDbType.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_LABEL_DB_TYPE);
            labelProfileName.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_LABEL_PROFILE_NAME);
            labelDbServerHostName.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_LABEL_DB_SERVER_HOSTNAME);

            labelUserName.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_LABEL_USERNAME);
            labelPassword.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_LABEL_PASSWORD);
            labelProfile.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_LABEL_PROFILE_NAME);

            buttonCancel.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_BUTTON_CANCEL);
            buttonOK.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_BUTTON_OK);
            buttonTest.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_BUTTON_TEST);

            checkBoxModifyProfile.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_CHECKBOX_MODIFY) + "(F3)";
            checkBoxNewProfile.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_CHECKBOX_NEW) + "(F2)";

            Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_FORM_LOGIN);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //verify user/pass value
            if (validateInput(textBoxUserName.Text) && validateInput(textBoxPassword.Text))
            {
                //Super admin validation
                if (textBoxUserName.Text == Constant.SUPER_ADMIN_USER_NAME && textBoxPassword.Text == Constant.SUPER_ADMIN_PASSWORD)
                {
                    this.DialogResult = DialogResult.OK;
                    return;
                }

                //check user/password
                DbParameter[] dbParameter ={
                GeneralVariable.dbHandler.generateDbParameter("name", textBoxUserName.Text),
                GeneralVariable.dbHandler.generateDbParameter("password", textBoxPassword.Text)
                                          };
                int validUserCount = (int)GeneralVariable.dbHandler.getValue("select count(*) from payer where name=@name and password=@password", dbParameter);
                if (validUserCount > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    return;
                }
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
            //Todo: validation

            return true;
            throw new NotImplementedException();
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
                //connectionString += ConfigHandler.getServerName(profileName) + ";Initial Catalog=" + ConfigHandler.getDbName(profileName) + ";User id=" + ConfigHandler.getDbAdminName(profileName) + ";Password=" + ConfigHandler.getDbAdminPassword(profileName) + ";";
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
                //HandlerFactory.getDbHandler().setConnection(comboBoxDbType.SelectedValue.ToString(), generateConnectionString(String.Empty));
                if (HandlerFactory.getDbHandler().canConnect())
                {
                    if (isNewProfile)
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
                            HandlerFactory.getConfigHandler().addProfile(textBoxProfileName.Text);
                            GeneralVariable.configHandler = HandlerFactory.getConfigHandler(textBoxProfileName.Text);
                            GeneralVariable.configHandler.setDbType(comboBoxDbType.SelectedValue.ToString());
                            GeneralVariable.configHandler.setServerName(textBoxServerName.Text);
                            GeneralVariable.configHandler.setDbName(textBoxDbName.Text);
                            GeneralVariable.configHandler.setDbAdminName(textBoxDbAdminName.Text);
                            GeneralVariable.configHandler.setDbAdminPassword(textBoxDbAdminPassword.Text);
                            
                            //add profile combobox
                            comboBoxProfile.Items.Add(textBoxProfileName.Text);
                        }
                    }
                    else
                    {
                        //change xml
                        GeneralVariable.configHandler.reviseProfile(comboBoxProfile.Items[profileSelectedIndex].ToString(), textBoxProfileName.Text);
                        GeneralVariable.configHandler.setDbType( comboBoxDbType.SelectedValue.ToString());
                        GeneralVariable.configHandler.setServerName( textBoxServerName.Text);
                        GeneralVariable.configHandler.setDbName( textBoxDbName.Text);
                        GeneralVariable.configHandler.setDbAdminName(textBoxDbAdminName.Text);
                        GeneralVariable.configHandler.setDbAdminPassword( textBoxDbAdminPassword.Text);
                        GeneralVariable.configHandler = HandlerFactory.getConfigHandler(textBoxProfileName.Text);
                        //change profile selection
                        comboBoxProfile.DataSource = GeneralVariable.configHandler.getProfiles();
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
            List<String> profileList = c.getProfiles();
            comboBoxProfile.DataSource = profileList;
            if (comboBoxProfile.Text == null)
            {
                checkBoxNewProfile_CheckedChanged(sender, e);
            }
            else
            {
                comboBoxProfile.SelectedIndex=0;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void checkBoxModifyProfile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModifyProfile.Checked)
            {
                isNewProfile = false;
                groupBoxDbConnectionShow();
                profileSelectedIndex = comboBoxProfile.SelectedIndex;
                GeneralVariable.configHandler = HandlerFactory.getConfigHandler(textBoxProfileName.Text);
                textBoxProfileName.Text = comboBoxProfile.SelectedItem.ToString();
                comboBoxDbType.SelectedValue = GeneralVariable.configHandler.getDbType();
                textBoxServerName.Text = GeneralVariable.configHandler.getServerName();
                textBoxDbName.Text = GeneralVariable.configHandler.getDbName();
                textBoxDbAdminName.Text = GeneralVariable.configHandler.getDbAdminName();
                textBoxDbAdminPassword.Text = GeneralVariable.configHandler.getDbAdminPassword();
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
                isNewProfile = true;
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
