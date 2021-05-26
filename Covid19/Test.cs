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
            int covid = 0, gripp = 0, all = 0;
            if (radioButton1.Checked == true)
            {
                gripp++; all++;
            }
                
            if (radioButton4.Checked == true)
            {
                covid++;
            }
                
            if (radioButton6.Checked == true)
            {
                gripp++;
            }
                
            if (radioButton8.Checked == true)
            {
                gripp++; all++;
            }
                
            if (radioButton18.Checked == true)
            {
                all++;
            }
               
            if (radioButton10.Checked == true)
            {
                all++;
            }

            if (radioButton12.Checked == true)
            {
                gripp++;
            }
            if (radioButton14.Checked == true)
            {
                covid++;
            }
            if (radioButton16.Checked == true)
            {
                covid++;
            }
            if (radioButton20.Checked == true)
            {
                gripp++;
            }
            if (radioButton22.Checked == true)
            {
                gripp++;
            }
            if(covid==0 && all==0 && gripp==0)
            {
                this.Hide();
                TestRes testRes = new TestRes(0);
                DialogResult dialogResult = new DialogResult();
                dialogResult = testRes.ShowDialog();
                this.Show();
            }
            else if(covid==3)
            {
                this.Hide();
                TestRes testRes = new TestRes(1);
                DialogResult dialogResult = new DialogResult();
                dialogResult = testRes.ShowDialog();
                this.Show();
            }
            else
            {
                if(all>gripp)
                {
                    this.Hide();
                    TestRes testRes = new TestRes(2);
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = testRes.ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    TestRes testRes = new TestRes(3);
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = testRes.ShowDialog();
                    this.Show();
                }
            }

        }
    }
}
