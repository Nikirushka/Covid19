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
    public partial class Diary : Form
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter adapter;
        int UserID;
        string connectionString = @"Server=tcp:covidtestik19.database.windows.net,1433;Initial Catalog=Covid19;Persist Security Info=False;User ID=Liza;Password=LiLit_01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public Diary()
        {
            InitializeComponent();
        }
        public Diary(int _ui)
        {
            InitializeComponent();
            UserID = _ui;
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
                string query = $"insert into SicknessDiary values ({UserID},N'{gunaDateTimePicker1.Value.ToString("yyyy-MM-dd")}',N'{gunaDateTimePicker2.Value.ToString("yyyy-MM-dd")}',N'{gunaTextBox1.Text}')";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Diary_Load(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
            gunaTextBox1.Hide();
            groupBox7.Hide();
            gunaDateTimePicker1.Value = DateTime.Now;
            gunaDateTimePicker2.Value = DateTime.Now;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox2.Show();
                if (radioButton4.Checked == true)
                {
                    groupBox3.Show();
                    if (radioButton6.Checked == true || radioButton5.Checked == true || radioButton7.Checked == true)
                    {
                        groupBox4.Show();
                        if (radioButton9.Checked == true)
                        {
                            groupBox5.Show();
                            groupBox6.Show();
                            if (radioButton11.Checked == true)
                            {
                                groupBox7.Show();
                                gunaTextBox1.Show();
                            }
                            else
                            {
                                groupBox7.Hide();
                                gunaTextBox1.Hide();
                            }
                        }
                        else
                        {
                            groupBox5.Hide();
                            groupBox6.Hide();
                            gunaTextBox1.Hide();
                            groupBox7.Hide();
                        }
                    }
                    else
                    {
                        groupBox7.Hide();
                        groupBox4.Hide();
                        groupBox5.Hide();
                        groupBox6.Hide();
                        gunaTextBox1.Hide();
                    }
                }
                else
                {
                    groupBox3.Hide();
                    groupBox4.Hide();
                    groupBox5.Hide();
                    groupBox6.Hide();
                    gunaTextBox1.Hide();
                    groupBox7.Hide();
                }
            }
            else
            {
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
                groupBox6.Hide();
                gunaTextBox1.Hide();
                groupBox7.Hide();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
