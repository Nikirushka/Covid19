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
    public partial class MainMenu : Form
    {
        int UserId;
        public MainMenu()
        {
            InitializeComponent();

        }
        public MainMenu(int uid)
        {
            InitializeComponent();
            UserId=uid;
        }
        private String DayBelarusCovid()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            String Response = wc.DownloadString("https://www.worldometers.info/coronavirus/country/belarus/");
            String Rate = System.Text.RegularExpressions.Regex.Match(Response, @"<ul class=""news_ul""><li class=""news_li""><strong>([0-9]+\,[0-9]+) new cases</strong>").Groups[1].Value;
            return Rate;
        }
        private String AllBelarusCovid()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            String Response = wc.DownloadString("https://www.worldometers.info/coronavirus/country/belarus/");
            String Rate = System.Text.RegularExpressions.Regex.Match(Response, @"<span style=""color:#aaa"">([0-9]+\,[0-9]+) </span>").Groups[1].Value;
            return Rate;
        }
        private String AllWorldCovid()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            String Response = wc.DownloadString("https://www.worldometers.info/coronavirus/");
            String Rate = System.Text.RegularExpressions.Regex.Match(Response, @"<span style=""color:#aaa"">([0-9]+\,[0-9]+\,[0-9]+) </span>").Groups[1].Value;
            return Rate;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();

            label1.Text = "Беларусь за день : "+ DayBelarusCovid();
           label2.Text = "Беларусь все время : " + AllBelarusCovid();
           label5.Text = "Весь мир все время : " + AllWorldCovid();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            History history = new History();
            DialogResult dialogResult = new DialogResult();
            dialogResult = history.ShowDialog();
            this.Show();
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Symptoms symptoms = new Symptoms();
            DialogResult dialogResult = new DialogResult();
            dialogResult = symptoms.ShowDialog();
            this.Show();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void HistoryButton_MouseEnter(object sender, EventArgs e)
        {
            HistoryButton.BackgroundImage = Properties.Resources.History_on;
            label6.Show();
        }

        private void HistoryButton_MouseLeave(object sender, EventArgs e)
        {
            HistoryButton.BackgroundImage = Properties.Resources.History;
            label6.Hide();
        }

        private void MapButton_MouseEnter(object sender, EventArgs e)
        {
            MapButton.BackgroundImage = Properties.Resources.Map_on;
            label9.Show();
        }

        private void MapButton_MouseLeave(object sender, EventArgs e)
        {
            MapButton.BackgroundImage = Properties.Resources.Map;
            label9.Hide();
        }

        private void PlaneButton_MouseEnter(object sender, EventArgs e)
        {
            PlaneButton.BackgroundImage = Properties.Resources.Plane_on;
            label11.Show();
        }

        private void PlaneButton_MouseLeave(object sender, EventArgs e)
        {
            PlaneButton.BackgroundImage = Properties.Resources.Plane;
            label11.Hide();
        }

        private void SymptomsButton_MouseEnter(object sender, EventArgs e)
        {
            SymptomsButton.BackgroundImage = Properties.Resources.Symptoms_on;
            label7.Show();
        }

        private void SymptomsButton_MouseLeave(object sender, EventArgs e)
        {
            label7.Hide();
            SymptomsButton.BackgroundImage = Properties.Resources.Symptoms;
        }

        private void VaccinationButton_MouseEnter(object sender, EventArgs e)
        {
            VaccinationButton.BackgroundImage = Properties.Resources.Vaccination_on;
            label8.Show();
        }

        private void VaccinationButton_MouseLeave(object sender, EventArgs e)
        {
            VaccinationButton.BackgroundImage = Properties.Resources.Vaccination;
            label8.Hide();
        }

        private void TestButton_MouseEnter(object sender, EventArgs e)
        {
            TestButton.BackgroundImage = Properties.Resources.Test_on;
            label10.Show();
        }

        private void TestButton_MouseLeave(object sender, EventArgs e)
        {
            TestButton.BackgroundImage = Properties.Resources.Test;
            label10.Hide();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.FromArgb(110, 148, 255);
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Black;
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Test test = new Test();
            DialogResult dialogResult = new DialogResult();
            dialogResult = test.ShowDialog();
            this.Show();
        }
    }
}
