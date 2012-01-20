using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JeanieMoney.Forms.Config
{
    public partial class BeneficiaryConfig : Form
    {
        private string abbr;
        public BeneficiaryConfig()
        {
            InitializeComponent();
        }

        public BeneficiaryConfig(string abbr)
        {
            InitializeComponent();
            this.abbr = abbr;
        }
    }
}
