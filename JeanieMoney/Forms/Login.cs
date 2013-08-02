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
        public Login()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            setCaption();
            this.Size = new System.Drawing.Size(264, 321);

        }

        private void setCaption()
        {
            labelUserName.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_LABEL_USERNAME);
            labelPassword.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_LABEL_PASSWORD);
            labelProfile.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_LABEL_PROFILE_NAME);

            buttonCancel.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_BUTTON_CANCEL);
            buttonOK.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_BUTTON_OK);

            Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_FORM_LOGIN);
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
                HandlerFactory.getDbHandler().generateDbParameter("name", textBoxUserName.Text),
                HandlerFactory.getDbHandler().generateDbParameter("password", textBoxPassword.Text)
                                          };
                int validUserCount = int.Parse(HandlerFactory.getDbHandler().getValue("select count(*) from payer where name=@name and password=@password", dbParameter).ToString());
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

        private void Login_Load(object sender, EventArgs e)
        {
            List<String> profileList = HandlerFactory.getConfigHandler().getRootElementList();
            comboBoxProfile.DataSource = profileList;
            if (comboBoxProfile.Text != null)
            {
                comboBoxProfile.SelectedIndex = 0;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void comboBoxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string dbType = HandlerFactory.getConfigHandler().getValue( comboBoxProfile.Items[comboBoxProfile.SelectedIndex].ToString() + "/Database/DbType");
            //string dbConnectionString = HandlerFactory.getConfigHandler().getValue( comboBoxProfile.Items[comboBoxProfile.SelectedIndex].ToString() + "/Database/DbConnectionString");

        }


    }
}
