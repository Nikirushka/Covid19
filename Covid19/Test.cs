using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
