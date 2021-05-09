using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19
{
    public partial class MainMenu : Form
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter adapter;

        string connectionString = @"Server=tcp:covidtestik19.database.windows.net,1433;Initial Catalog=Covid19;Persist Security Info=False;User ID=Liza;Password=LiLit_01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        int UserId;
        public MainMenu()
        {
            InitializeComponent();

        }
        public MainMenu(int uid)
        {
            InitializeComponent();
            UserId=uid;
            GetName();
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
            label12.Hide();
            label13.Hide();
            GetName();
            label1.Text = "Беларусь за день : "+ DayBelarusCovid();
           label2.Text = "Беларусь все время : " + AllBelarusCovid();
           label5.Text = "Весь мир все время : " + AllWorldCovid();
        }

        private void GetName()
        {
            try
            {
                string query = $"select Surname,Name from [User] where id={UserId}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    cmd = new SqlCommand(query, connection);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        label3.Text = $"{reader.GetString(0)} {reader.GetString(1)}";
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            this.Hide();
            Map map = new Map();
            DialogResult dialogResult = new DialogResult();
            dialogResult = map.ShowDialog();
            this.Show();
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
            PlaneButton.BackgroundImage = Properties.Resources.Diary_on;
            label11.Show();
        }

        private void PlaneButton_MouseLeave(object sender, EventArgs e)
        {
            PlaneButton.BackgroundImage = Properties.Resources.Diary;
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

        private void PlaneButton_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton2_MouseEnter(object sender, EventArgs e)
        {
           gunaGradientButton2.BackgroundImage = Properties.Resources.Help_on;
            label12.Show();
        }

        private void gunaGradientButton2_MouseLeave(object sender, EventArgs e)
        {
            gunaGradientButton2.BackgroundImage = Properties.Resources.Help;
            label12.Hide();
        }

        private void gunaGradientButton1_MouseLeave(object sender, EventArgs e)
        {
            gunaGradientButton1.BackgroundImage = Properties.Resources.Info;
            label13.Hide();
        }

        private void gunaGradientButton1_MouseEnter(object sender, EventArgs e)
        {
            gunaGradientButton1.BackgroundImage = Properties.Resources.Info_on;
            label13.Show();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help help = new Help();
            DialogResult dialogResult = new DialogResult();
            dialogResult = help.ShowDialog();
            this.Show();
        }

        private void gunaGradientButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Info info = new Info();
            DialogResult dialogResult = new DialogResult();
            dialogResult = info.ShowDialog();
            this.Show();
        }
    }
}
