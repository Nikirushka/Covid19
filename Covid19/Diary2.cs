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
    public partial class Diary2 : Form
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter adapter;
        int UserID;
        string connectionString = @"Server=tcp:covidtestik19.database.windows.net,1433;Initial Catalog=Covid19;Persist Security Info=False;User ID=Liza;Password=LiLit_01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public Diary2()
        {
            InitializeComponent();
        }
       
        public Diary2(int a)
        {
            InitializeComponent();
            UserID = a;
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        bool check;
        private void Diary2_Load(object sender, EventArgs e)
        {
            
            gunaDateTimePicker1.Value = DateTime.Now;
            gunaDateTimePicker2.Value = DateTime.Now;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"SELECT result FROM [VaccineDiary] WHERE ID_user=N'{UserID}'";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        EnterButton.Hide();
                        gunaButton1.Show();
                        gunaTextBox1.Text = reader.GetString(0);
                    }
                }
                else
                {
                    EnterButton.Show();
                    gunaButton1.Hide();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"insert into VaccineDiary values ({UserID},N'{gunaDateTimePicker1.Value.ToString("yyyy-MM-dd")}',N'{gunaDateTimePicker2.Value.ToString("yyyy-MM-dd")}',N'{gunaTextBox1.Text}')";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"update VaccineDiary set Date1=N'{gunaDateTimePicker1.Value.ToString("yyyy-MM-dd")}', Date2=N'{gunaDateTimePicker2.Value.ToString("yyyy-MM-dd")}',Result=N'{gunaTextBox1.Text}'";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
