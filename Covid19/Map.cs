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
        int mapp;
        public Map()
        {
            InitializeComponent();
            
        }
        public Map(int map)
        {
            mapp = map;
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
            if (mapp==1)
            {
                webBrowser1.Url = new Uri("https://yandex.by/maps/covid19?ll=27.854172%2C36.733082&z=2.5");
                label2.Text = "Карта распространения коронавируса в мире";
            }  
            else
            {
                webBrowser1.Url = new Uri("https://www.google.com/maps/search/карта+мест+вакцинации+рб/@53.8952521,27.5051996,11z");
                label2.Text = "Карта пунктов вакцинации в Беларуси";
            }
               
        }
        private bool check = false;
        private void label1_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.Height = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
                this.Width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            }
            else
                WindowState = FormWindowState.Normal;
            check = !check;
        }
    }
}
