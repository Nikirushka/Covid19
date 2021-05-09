using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            webBrowser1.Url = new Uri("https://yandex.by/maps/covid19?ll=27.854172%2C36.733082&z=2.5");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {

        }

        private void Map_Load(object sender, EventArgs e)
        {

        }

    }
}
