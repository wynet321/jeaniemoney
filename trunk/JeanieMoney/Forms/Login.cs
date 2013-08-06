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
            //set caption
            labelUserName.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_LABEL_USERNAME);
            labelPassword.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_LABEL_PASSWORD);

            buttonCancel.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_BUTTON_CANCEL);
            buttonOK.Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_BUTTON_OK);

            Text = HandlerFactory.getLanguageHandler().getCaption(Constant.CAPTION_FORM_LOGIN);

            //size
            this.Size = new System.Drawing.Size(250, 200);
            buttonOK.Width = 80;
            buttonCancel.Width = buttonOK.Width;
            buttonOK.Height = 25;
            buttonCancel.Height = buttonOK.Height;
            labelUserName.Height = 25;
            labelPassword.Height = labelUserName.Height;
            textBoxUserName.Width = 120;
            textBoxPassword.Width = textBoxUserName.Width;
            textBoxUserName.Height = 25;
            textBoxPassword.Height = textBoxUserName.Height;

            labelUserName.Left = HandlerFactory.getConfigHandler().getInteger("Configuration/Layout/Left");
            labelPassword.Left = labelUserName.Left;
            textBoxUserName.Left = labelUserName.Left + labelUserName.Width + 10;
            textBoxPassword.Left = textBoxUserName.Left;

            labelUserName.Top = HandlerFactory.getConfigHandler().getInteger("Configuration/Layout/Top");
            labelPassword.Top = labelUserName.Top + labelUserName.Height + 15;
            textBoxUserName.Top = labelUserName.Top-4;
            textBoxPassword.Top = labelPassword.Top-4;

            buttonOK.Left = (this.Width - buttonOK.Width - buttonCancel.Width) / 3;
            buttonCancel.Left = buttonOK.Left * 2 + buttonOK.Width;

            buttonOK.Top = labelPassword.Top + labelPassword.Height + 40;
            buttonCancel.Top = buttonOK.Top;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
