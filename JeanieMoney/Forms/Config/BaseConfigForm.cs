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
            this.buttonDelete.Text = G18NHandler.GetValue(Constant.CAPTION_BUTTON_DELETE);
            this.buttonReset.Text = G18NHandler.GetValue(Constant.CAPTION_BUTTON_RESET);
            this.buttonCancel.Text = G18NHandler.GetValue(Constant.CAPTION_BUTTON_CANCEL);
            this.buttonOK.Text = G18NHandler.GetValue(Constant.CAPTION_BUTTON_OK);

            this.labelAbbr.Text = G18NHandler.GetValue(Constant.CAPTION_LABEL_ABBR);
            this.labelName.Text = G18NHandler.GetValue(Constant.CAPTION_LABEL_NAME);
            this.labelKeyword.Text = G18NHandler.GetValue(Constant.CAPTION_LABEL_KEYWORD);

        }
    }
}
