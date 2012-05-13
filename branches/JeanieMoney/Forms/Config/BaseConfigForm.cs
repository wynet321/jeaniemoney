using System;
using System.Windows.Forms;
using JeanieMoney.Actions;

namespace JeanieMoney.Forms.Config
{
    
    public partial class BaseConfigForm : Form
    {
        protected JeanieMoney.Actions.IAction action;
        public BaseConfigForm()
        {
            InitializeComponent();
            
        }

        private void textBoxKeyword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
