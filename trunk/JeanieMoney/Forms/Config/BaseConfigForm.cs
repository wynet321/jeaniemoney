using System;
using System.Windows.Forms;
using JeanieMoney.Actions;
using JeanieMoney.Utility;

namespace JeanieMoney.Forms.Config
{
    
    public partial class BaseConfigForm : Form
    {
       
        public BaseConfigForm()
        {
            InitializeComponent();
            setCaption();
        }
        private void setCaption()
        {
            this.buttonDelete.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/Delete");
            this.buttonReset.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/Reset");
            this.buttonCancel.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/Cancel");
            this.buttonOK.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/OK");

            this.labelAbbr.Text = G18NHandler.GetValue("JeanieMoney/Caption/Label/Abbr");
            this.labelName.Text = G18NHandler.GetValue("JeanieMoney/Caption/Label/Name");
            this.labelKeyword.Text = G18NHandler.GetValue("JeanieMoney/Caption/Label/Keyword");

            this.Text = G18NHandler.GetValue("JeanieMoney/Caption/Form/Beneficiary");
        }
    }
}
