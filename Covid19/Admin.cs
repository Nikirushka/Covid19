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
    public partial class Admin : Form
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter adapter;

        string connectionString = @"Server=tcp:covidtestik19.database.windows.net,1433;Initial Catalog=Covid19;Persist Security Info=False;User ID=Liza;Password=LiLit_01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        int UserID;
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(int uid)
        {
            InitializeComponent();
            UserID = uid;
        }
        Point point = new Point(12, 68);
        private void Admin_Load(object sender, EventArgs e)
        {
            UpdateClients();
            Test();
            Stats();
            users.Location = point;
            tests.Hide();
            users.Show();
            Stat.Hide();
        }

        private void Test()
        {
            try
            {
                try
                {
                    string query = $"select count(*) from TestCorona";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            label3.Text = $"Всего тестов : {reader.GetInt32(0)}";
                        }
                        reader.Close();
                        query = $"select count(*) from TestCorona where TestCorona.Result = N'Вероятнее всего, симптомы, которые Вы указали, соответствуют наличию covid19. В данной ситуации советуем Вам обратиться за помощью к вашему лечащему врачу.'";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            label4.Text = $"Количество Covid19 : {reader.GetInt32(0)}";
                        }
                        reader.Close();
                        query = $"select count(*) from TestCorona where TestCorona.Result = N'Вероятнее всего, симптомы, которые Вы указали, соответствуют наличию аллергии. В данной ситуации советуем Вам обратиться за помощью к вашему лечащему врачу.'";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            label5.Text = $"Количество аллергии : {reader.GetInt32(0)}";
                        }
                        reader.Close();
                        query = $"select count(*) from TestCorona where TestCorona.Result = N'Вероятнее всего, симптомы, которые Вы указали, соответствуют наличию гриппа. В данной ситуации советуем Вам обратиться за помощью к вашему лечащему врачу.'";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            label6.Text = $"Количество гриппа : {reader.GetInt32(0)}";
                        }
                        reader.Close();
                        query = $"select count(*) from TestCorona where TestCorona.Result = N'Вы здоровы!'";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            label9.Text = $"Количество здоровых : {reader.GetInt32(0)}";
                        }
                        reader.Close();
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Stats()
        {
            try
            {
                try
                {
                    string query = $"select count(*) from [User]";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            label12.Text = $"Всего пользователей : {reader.GetInt32(0)}";
                        }
                        reader.Close();
                        query = $"select count(*) from [User] WHERE Age between 0 and 18";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            label7.Text = $"Количество пользователей 0-18 : {reader.GetInt32(0)}";
                        }
                        reader.Close();
                        query = $"select count(*) from [User] WHERE Age between 19 and 35";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            label11.Text = $"Количество пользователей 19-35 : {reader.GetInt32(0)}";
                        }
                        reader.Close();
                        query = $"select count(*) from [User] WHERE Age between 36 and 80";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            label10.Text = $"Количество пользователей 36-80 : {reader.GetInt32(0)}";
                        }
                        reader.Close();
                       
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateClients()
        {
            
            try
            {
                string query = $"select * from UserInfo";
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(query, connection);

                    ds = new DataSet();
                    adapter.Fill(ds);
                    AllDataGridView.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser newUser = new NewUser();
            DialogResult dialogResult = new DialogResult();
            dialogResult = newUser.ShowDialog();
            UpdateClients();
            this.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            int index = 0;
            foreach (DataGridViewCell cell in AllDataGridView.SelectedCells)
            {
                index = cell.RowIndex;
            }
            string a = (AllDataGridView[0, index].Value.ToString());
            string b = (AllDataGridView[1, index].Value.ToString());
            string c = (AllDataGridView[2, index].Value.ToString());
            string d = (AllDataGridView[3, index].Value.ToString());
            string ee = (AllDataGridView[4, index].Value.ToString());
            string f = (AllDataGridView[5, index].Value.ToString());
            string g = (AllDataGridView[6, index].Value.ToString());
            string h = (AllDataGridView[7, index].Value.ToString());
            int index1 = 0;
            foreach (DataGridViewCell cell in AllDataGridView.SelectedCells)
            {
                index1 = cell.RowIndex;
            }
            string query = $"select * from [user]";
            AllDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllDataGridView.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(query, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                AllDataGridView.DataSource = ds.Tables[0];
                connection.Close();
            }
            connection = new SqlConnection(connectionString);
            connection.Open();
            string choose_id = (AllDataGridView[0, index1].Value.ToString());
            UpdateClients();
            NewUser newuser = new NewUser(Convert.ToInt32(choose_id), a, b, c, d, ee,f,g,h);
            DialogResult dialogResult = new DialogResult();
            dialogResult = newuser.ShowDialog();
            UpdateClients();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {

                int index = 0;
                foreach (DataGridViewCell cell in AllDataGridView.SelectedCells)
                {
                    index = cell.RowIndex;
                }
                string query = $"select * from [user] ";
                AllDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                AllDataGridView.AllowUserToAddRows = false;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(query, connection);

                    ds = new DataSet();
                    adapter.Fill(ds);
                    AllDataGridView.DataSource = ds.Tables[0];
                    connection.Close();
                }
                connection = new SqlConnection(connectionString);
                connection.Open();

                string choose_id = (AllDataGridView[0, index].Value.ToString());

                string delQuery = $"DELETE FROM [user] WHERE ID = {choose_id}";


                cmd = new SqlCommand(delQuery, connection);

                cmd.ExecuteNonQuery();
                
                connection.Close();
                UpdateClients();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click_1(object sender, EventArgs e)
        {
            UpdateClients();
            users.Location = point;
            tests.Hide();
            users.Show();
            Stat.Hide();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Test();
            tests.Location = point;
            tests.Show();
            users.Hide();
            Stat.Hide();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Stats();
            Stat.Location = point;
            Stat.Show();
            users.Hide();
            tests.Hide();
        }
    }
}
