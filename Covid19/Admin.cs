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

        private void Admin_Load(object sender, EventArgs e)
        {
            UpdateClients();
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
    }
}
