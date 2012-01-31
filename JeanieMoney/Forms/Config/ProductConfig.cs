﻿using System;
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
    public partial class ProductConfig : BaseConfigForm
    {
        private string productName;

        public ProductConfig()
        {
            InitializeComponent();
        }

        public ProductConfig(string name)
        {
            InitializeComponent();
            productName = name;
        }
    }
}
