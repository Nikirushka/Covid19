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
    public partial class NewUser : Form
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter adapter;
        int UserID;
        string connectionString = @"Server=tcp:covidtestik19.database.windows.net,1433;Initial Catalog=Covid19;Persist Security Info=False;User ID=Liza;Password=LiLit_01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public NewUser()
        {
            InitializeComponent();
            gunaButton1.Hide();
            label1.Text = "Регистрация";
        }
        public NewUser(int _uid,string _name, string _surname, string _patr, string _log, string _pas)
        {
            InitializeComponent();
            UserID = _uid;
            label1.Text = "Изменение";
            TextBox1.Text = _name;
            TextBox2.Text = _surname;
            TextBox3.Text = _patr;
            TextBox4.Text = _log;
            TextBox5.Text = _pas;
            gunaButton1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
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
                int check = 0;
                string query = $"exec check_login N'{TextBox4.Text}'";
                cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    check = reader.GetInt32(0);
                }
                reader.Close();
                connection.Close();
                if (check == 1)
                {
                    MessageBox.Show("Пользователь с таким логином существует!\nПридумайте другой :)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    connection.Open();

                    query = $"insert into [user] values(N'{TextBox1.Text}',N'{TextBox2.Text}',N'{TextBox3.Text}',N'{TextBox4.Text}',N'{TextBox5.Text}',0)";
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Пользователь создан!", "ИНФОРМАЦИЯ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"update [User] set Surname=N'{TextBox1.Text}', Name=N'{TextBox2.Text}', Patronymic=N'{TextBox3.Text}', Login=N'{TextBox4.Text}',Password=N'{TextBox5.Text}' where id={UserID}";
                cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
