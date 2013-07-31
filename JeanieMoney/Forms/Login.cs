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

        }

        private void setCaption()
        {

            labelUserName.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_LABEL_USERNAME);
            labelPassword.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_LABEL_PASSWORD);
            labelProfile.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_LABEL_PROFILE_NAME);

            buttonCancel.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_BUTTON_CANCEL);
            buttonOK.Text = HandlerFactory.getG18NHandler().getValue(Constant.CAPTION_BUTTON_OK);


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

 
        private void buttonModifyProfile_Click(object sender, EventArgs e)
        {

        }
        private void groupBoxDbConnectionShow()
        {
            this.Width = 512;
            buttonOK.Left = 145;
            buttonCancel.Left = 277;

        }

       

        private void Login_Load(object sender, EventArgs e)
        {
            List<String> profileList = GeneralVariable.configHandler.getElementListByNodePath(Constant.PRODUCT_NAME);
            comboBoxProfile.DataSource = profileList;
            if (comboBoxProfile.Text != null)
            {
                comboBoxProfile.SelectedIndex=0;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void comboBoxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dbType = GeneralVariable.configHandler.getValue(Constant.PRODUCT_NAME +"/"+comboBoxProfile.Items[comboBoxProfile.SelectedIndex].ToString()+ "/Database/DbType");
            string dbConnectionString = GeneralVariable.configHandler.getValue(Constant.PRODUCT_NAME + "/" + comboBoxProfile.Items[comboBoxProfile.SelectedIndex].ToString() + "/Database/DbConnectionString");
            GeneralVariable.dbHandler = HandlerFactory.getDbHandler(dbType, dbConnectionString);
        }

      
    }
}
