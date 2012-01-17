using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JeanieMoney.Forms
{
    public partial class RecordInputDetails : Form
    {
        private string tradeId = "";
        public RecordInputDetails(string tradeId)
        {
            InitializeComponent();
            this.tradeId = tradeId;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }
    }
}
