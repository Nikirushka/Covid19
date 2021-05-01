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
    public partial class Symptoms : Form
    {
        public Symptoms()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Black;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.FromArgb(245, 242, 235);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Symptoms_Load(object sender, EventArgs e)
        {
            l1.Hide(); l2.Hide(); l3.Hide(); l4.Hide(); l5.Hide(); l6.Hide(); l7.Hide(); l8.Hide();
           
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            l1.Show();   
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            l1.Hide(); l1.Text = "Высокая температура\nтела";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            l1.Text = "90%";
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            l2.Show();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            l2.Hide(); l2.Text = "Кашель";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            l2.Text = "80%";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            l3.Text = "55%";
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            l3.Show();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            l3.Hide(); l3.Text = "Одышка";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            l4.Text = ">20%";
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            l4.Show();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            l4.Hide(); l4.Text = "Ощущуния сдавленности\nв грудной клетке";
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            l5.Show();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            l5.Hide(); l5.Text = "Головная боль";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            l5.Text = "8%";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            l6.Text = "5%";
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            l6.Show();
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            l6.Hide();l6.Text = "Кровохарканье";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            l7.Text = "3%";
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            l7.Show();
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            l7.Hide(); l7.Text = "Диарея";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            l8.Text = "2%";
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            l8.Show();
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            l8.Hide(); l8.Text = "Тошнота, рвота";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Test test = new Test();
            DialogResult dialogResult = new DialogResult();
            dialogResult = test.ShowDialog();
            this.Show();
        }
    }
}
