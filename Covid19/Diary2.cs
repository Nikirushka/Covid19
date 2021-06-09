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

        private void Vaccine()
        {
            try
            {
                string query = $"select Date1 as 'Дата', NameVaccine as 'Название вакцины', Result as 'Самочувствие' from VaccineDiary where ID_user={UserID}";

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
        private void Diary2_Load(object sender, EventArgs e)
        {
            
            gunaDateTimePicker1.Value = DateTime.Now;
            Vaccine();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"insert into VaccineDiary values ({UserID},N'{gunaDateTimePicker1.Value.ToString("yyyy-MM-dd")}',N'{gunaTextBox2.Text}',N'{gunaTextBox1.Text}')";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Vaccine();
        }

    }
}
