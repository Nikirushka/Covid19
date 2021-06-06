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
    public partial class Test : Form
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter adapter;
        int UserID;
        string connectionString = @"Server=tcp:covidtestik19.database.windows.net,1433;Initial Catalog=Covid19;Persist Security Info=False;User ID=Liza;Password=LiLit_01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public Test()
        {
            InitializeComponent();
        }
        public Test(int _ui)
        {
            InitializeComponent();
            UserID = _ui;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void Test_Load(object sender, EventArgs e)
        {
           

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if((radioButton1.Checked || radioButton2.Checked) && (radioButton3.Checked || radioButton4.Checked) && (radioButton5.Checked || radioButton6.Checked) && (radioButton7.Checked || radioButton8.Checked) && (radioButton9.Checked || radioButton10.Checked) && (radioButton11.Checked || radioButton12.Checked) && (radioButton13.Checked || radioButton14.Checked) && (radioButton15.Checked || radioButton16.Checked) && (radioButton17.Checked || radioButton18.Checked) && (radioButton19.Checked || radioButton20.Checked) && (radioButton21.Checked || radioButton22.Checked) )
            {
                int covid = 0, gripp = 0, all = 0;
                bool cought=false, drycought=false, headache=false, runnynose=false, eyeswatery=false, sneeze=false, fever=false, temp=false, breath=false, throat=false, pain=false;
                string result;
                if (radioButton1.Checked == true)
                {
                    gripp++; all++; cought = true;
                }
                else cought = false;

                if (radioButton4.Checked == true)
                {
                    covid++; drycought = true;
                }
                else drycought = false;

                if (radioButton6.Checked == true)
                {
                    gripp++; headache = true;
                }
                else headache = false;

                if (radioButton8.Checked == true)
                {
                    gripp++; all++; runnynose = true;
                }
                else runnynose = false;

                if (radioButton18.Checked == true)
                {
                    all++; eyeswatery = true;
                }
                else eyeswatery = false;

                if (radioButton10.Checked == true)
                {
                    all++; sneeze = true;
                }
                else sneeze = false;

                if (radioButton12.Checked == true)
                {
                    gripp++; fever = true;
                }
                else fever = false;
                if (radioButton14.Checked == true)
                {
                    covid++; temp = true;
                }
                else temp = false;
                if (radioButton16.Checked == true)
                {
                    covid++; breath = true;
                }
                else breath = false;
                if (radioButton20.Checked == true)
                {
                    gripp++; throat = true;
                }
                else throat = false;
                if (radioButton22.Checked == true)
                {
                    gripp++; pain = true;
                }
                else pain = false;
                if (covid == 0 && all == 0 && gripp == 0)
                {
                    this.Hide();
                    TestRes testRes = new TestRes(0);
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = testRes.ShowDialog();
                    this.Show();
                    result = "Вы здоровы!";
                    try
                    {
                        connection = new SqlConnection(connectionString);
                        connection.Open();
                        string query = $"insert into TestCorona values ({UserID},'{cought}','{drycought}', '{headache}', '{runnynose}', '{eyeswatery}', '{sneeze}', '{fever}', '{temp}', '{breath}', '{throat}', '{pain}',N'{result}',GETDATE())";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (covid == 3)
                {
                    this.Hide();
                    TestRes testRes = new TestRes(1);
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = testRes.ShowDialog();
                    this.Show();
                    result = "Вероятнее всего, симптомы, которые Вы указали, соответствуют наличию covid19. В данной ситуации советуем Вам обратиться за помощью к вашему лечащему врачу.";
                    try
                    {
                        connection = new SqlConnection(connectionString);
                        connection.Open();
                        string query = $"insert into TestCorona values ({UserID},'{cought}','{drycought}', '{headache}', '{runnynose}', '{eyeswatery}','{sneeze}', '{fever}', '{temp}', '{breath}', '{throat}', '{pain}',N'{result}',GETDATE())";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (all > gripp)
                    {
                        this.Hide();
                        TestRes testRes = new TestRes(2);
                        DialogResult dialogResult = new DialogResult();
                        dialogResult = testRes.ShowDialog();
                        this.Show();
                        result = "Вероятнее всего, симптомы, которые Вы указали, соответствуют наличию аллергии. В данной ситуации советуем Вам обратиться за помощью к вашему лечащему врачу.";
                        try
                        {
                            connection = new SqlConnection(connectionString);
                            connection.Open();
                            string query = $"insert into TestCorona values ({UserID},'{cought}','{drycought}', '{headache}', '{runnynose}', '{eyeswatery}', '{sneeze}', '{fever}', '{temp}', '{breath}', '{throat}', '{pain}',N'{result}',GETDATE())";
                            cmd = new SqlCommand(query, connection);
                            reader = cmd.ExecuteReader();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        this.Hide();
                        TestRes testRes = new TestRes(3);
                        DialogResult dialogResult = new DialogResult();
                        dialogResult = testRes.ShowDialog();
                        this.Show();
                        result = "Вероятнее всего, симптомы, которые Вы указали, соответствуют наличию гриппа. В данной ситуации советуем Вам обратиться за помощью к вашему лечащему врачу.";
                        try
                        {
                            connection = new SqlConnection(connectionString);
                            connection.Open();
                            string query = $"insert into TestCorona values ({UserID},'{cought}','{drycought}', '{headache}', '{runnynose}', '{eyeswatery}', '{sneeze}', '{fever}', '{temp}', '{breath}', '{throat}', '{pain}',N'{result}',GETDATE())";
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
            else
            {
                MessageBox.Show("Дайте ответ на все вопросы!","Внимание",MessageBoxButtons.OK);
            }

        }
    }
}
