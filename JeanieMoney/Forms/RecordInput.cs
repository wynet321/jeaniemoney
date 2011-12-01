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
    public partial class RecordInput : Form
    {
        public RecordInput()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RecordInput_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            dateTimePickerRecordInput.Value = DateTime.Now;
            radioButtonOut.Select();
            textBoxMoney.Clear();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Init();
        }
    }
}
