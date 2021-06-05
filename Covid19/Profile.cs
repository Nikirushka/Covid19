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
    public partial class Profile : Form
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter adapter;

        string connectionString = @"Server=tcp:covidtestik19.database.windows.net,1433;Initial Catalog=Covid19;Persist Security Info=False;User ID=Liza;Password=LiLit_01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        int UserID;
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(int _userid)
        {
            UserID = _userid;
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"update [User] set Surname=N'{TextBox1.Text}', Name=N'{TextBox2.Text}', Patronymic=N'{TextBox3.Text}', Login=N'{TextBox4.Text}',Password=N'{TextBox5.Text}',Phone=N'{maskedTextBox1.Text}', Age = N'{gunaTextBox1.Text}', Email=N'{gunaTextBox2.Text}' where id={UserID}";
                cmd = new SqlCommand(query, connection);

                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Info();
        }

        private void Diary_Load(object sender, EventArgs e)
        {
            Info();
        }
        private void Info()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"select * from [user] where [User].id={UserID}";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TextBox1.Text = reader.GetString(1);
                    TextBox2.Text = reader.GetString(2);
                    TextBox3.Text = reader.GetString(3);
                    maskedTextBox1.Text = reader.GetString(4);
                    gunaTextBox2.Text = reader.GetString(5);
                    gunaTextBox1.Text = reader.GetInt32(6).ToString();
                    TextBox4.Text = reader.GetString(7);
                    TextBox5.Text = reader.GetString(8);

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diary diary = new Diary(UserID);
            DialogResult dialogResult = new DialogResult();
            dialogResult = diary.ShowDialog();
            this.Show();
        }
    }
}
