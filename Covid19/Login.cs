using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        string connectionString = @"Server=tcp:covidtestik19.database.windows.net,1433;Initial Catalog=Covid19;Persist Security Info=False;User ID=Liza;Password=LiLit_01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public Login()

        {
            InitializeComponent();
            SetWebBrowserCompatiblityLevel();
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginTextBox_Click(object sender, EventArgs e)
        {
            LoginTextBox.Text = "";
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = "";
        }
        private static void SetWebBrowserCompatiblityLevel()
        {
            string appName = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
            int lvl = 1000 * GetBrowserVersion();
            bool fixVShost = File.Exists(Path.ChangeExtension(Application.ExecutablePath, ".vshost.exe"));

            WriteCompatiblityLevel("HKEY_LOCAL_MACHINE", appName + ".exe", lvl);
            if (fixVShost) WriteCompatiblityLevel("HKEY_LOCAL_MACHINE", appName + ".vshost.exe", lvl);

            WriteCompatiblityLevel("HKEY_CURRENT_USER", appName + ".exe", lvl);
            if (fixVShost) WriteCompatiblityLevel("HKEY_CURRENT_USER", appName + ".vshost.exe", lvl);
        }

        private static void WriteCompatiblityLevel(string root, string appName, int lvl)
        {
            try
            {
                Microsoft.Win32.Registry.SetValue(root + @"\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", appName, lvl);
            }
            catch (Exception)
            {
            }
        }

        public static int GetBrowserVersion()
        {
            string strKeyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer";
            string[] ls = new string[] { "svcVersion", "svcUpdateVersion", "Version", "W2kVersion" };

            int maxVer = 0;
            for (int i = 0; i < ls.Length; ++i)
            {
                object objVal = Microsoft.Win32.Registry.GetValue(strKeyPath, ls[i], "0");
                string strVal = Convert.ToString(objVal);
                if (strVal != null)
                {
                    int iPos = strVal.IndexOf('.');
                    if (iPos > 0)
                        strVal = strVal.Substring(0, iPos);

                    int res = 0;
                    if (int.TryParse(strVal, out res))
                        maxVer = Math.Max(maxVer, res);
                }
            }

            return maxVer;
        }

    }
}
