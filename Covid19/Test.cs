using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox2.Show();
                if (radioButton4.Checked == true)
                {
                    groupBox3.Show();
                    if (radioButton6.Checked == true)
                    {
                        groupBox4.Show();
                        if (radioButton9.Checked == true)
                        {
                            groupBox5.Show();
                            groupBox6.Show();
                            if (radioButton11.Checked == true)
                            {
                                gunaTextBox1.Show();
                            }
                            else
                            {
                                gunaTextBox1.Hide();
                            }
                        }
                        else
                        {
                            groupBox5.Hide();
                            groupBox6.Hide();
                            gunaTextBox1.Hide();
                        }
                    }
                    else
                    {
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
            }  
        }

        private void Test_Load(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
            gunaTextBox1.Hide();
            gunaDateTimePicker1.Value = DateTime.Now;
            gunaDateTimePicker2.Value = DateTime.Now;

        }
    }
}
