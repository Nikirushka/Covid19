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
    public partial class Login : Form
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter adapter;

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|Corona.mdf';Integrated Security=True";
        public Login()

        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                string LoginTB, PasswordTB;
                LoginTB = LoginTextBox.Text;
                PasswordTB = PasswordTextBox.Text;
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"SELECT id FROM [User] WHERE (Login=N'{LoginTB}'COLLATE CYRILLIC_General_CS_AS)";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("Неправильный логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    reader.Close();
                    return;
                }
                else
                {
                    reader.Close();
                    query = $"SELECT * FROM [User] WHERE (Login=N'{LoginTB}'COLLATE CYRILLIC_General_CS_AS) AND (Password= N'{PasswordTB}' COLLATE CYRILLIC_General_CS_AS) ";
                    cmd = new SqlCommand(query, connection);
                    reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("Неправильный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {
                        this.Hide();
                        reader.Close();
                        query = $"SELECT * FROM [User] WHERE (Login=N'{LoginTB}'COLLATE CYRILLIC_General_CS_AS) AND (Password= '{PasswordTB}' COLLATE CYRILLIC_General_CS_AS) AND Access=1";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            int UserID = 0;
                            reader.Close();
                            query = $"exec GetID N'{LoginTB}',N'{PasswordTB}'";
                            cmd = new SqlCommand(query, connection);
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                UserID = reader.GetInt32(0);
                            }
                            reader.Close();
                            this.Hide();
                            Admin admin = new Admin(UserID);
                            DialogResult dialogResult = new DialogResult();
                            dialogResult = admin.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            int UserID = 0;
                            reader.Close();
                            query = $"exec GetID N'{LoginTB}',N'{PasswordTB}'";
                            cmd = new SqlCommand(query, connection);
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                UserID = reader.GetInt32(0);
                            }
                            reader.Close();
                            this.Hide();
                            MainMenu mainMenu = new MainMenu(UserID);
                            DialogResult dialogResult = new DialogResult();
                            dialogResult = mainMenu.ShowDialog();
                            this.Show();
                        }
                        
                        
                    }
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser newUser = new NewUser();
            DialogResult dialogResult = new DialogResult();
            dialogResult = newUser.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
