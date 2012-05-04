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
        public Login()
        {
            InitializeComponent();
            comboBoxDbType.DataSource = DBHandler.getDbType();
            comboBoxDbType.DisplayMember = "Key";
            comboBoxDbType.ValueMember = "Value";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DBHandler.setConnection(ConfigHandler.getValue("JeanieMoney/DbType"), ConfigHandler.getValue("JeanieMoney/ConnectionString"));
            this.DialogResult=DialogResult.OK;
        }

        private void btnModifyConnection_Click(object sender, EventArgs e)
        {
            grpDBConnection.Visible=!grpDBConnection.Visible;
            grpDBConnectionInit();
        }
        private void grpDBConnectionInit()
        {
            textBoxDBName.Clear();
            textBoxServerName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            String connectionString = "";
            connectionString = "Data Source=" + textBoxServerName.Text + ";Initial Catalog="+textBoxDBName.Text+";User id=" + textBoxUserName.Text + ";Password=" + textBoxPassword.Text + ";";

            DBHandler.setConnection(comboBoxDbType.SelectedValue.ToString(),connectionString);
        }
    }
}
