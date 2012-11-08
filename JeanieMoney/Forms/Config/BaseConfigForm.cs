using System;
using System.Windows.Forms;
using JeanieMoney.Actions;
using ClassLibrary.lib;

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
            this.buttonDelete.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_BUTTON_DELETE);
            this.buttonReset.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_BUTTON_RESET);
            this.buttonCancel.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_BUTTON_CANCEL);
            this.buttonOK.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_BUTTON_OK);

            this.labelAbbr.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_LABEL_ABBR);
            this.labelName.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_LABEL_NAME);
            this.labelKeyword.Text = HandlerFactory.getHandlerFactory.getG18NHandler()().getValue(Constant.CAPTION_LABEL_KEYWORD);

        }
    }
}
