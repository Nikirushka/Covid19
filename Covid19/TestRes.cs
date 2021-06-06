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
    public partial class TestRes : Form
    {
        public TestRes()
        {
            InitializeComponent();
        }
        public TestRes(int a)
        {
            InitializeComponent();
            if(a==0)
            {
                label1.Text = "Вы здоровы!";
            }
            else if(a==1)
            {
                label1.Text = "Вероятнее всего, симптомы, которые Вы указали, соответствуют наличию covid19. В данной ситуации советуем Вам обратиться за помощью к вашему лечащему врачу.";
            }
            else if (a==2)
            {
                label1.Text = "Вероятнее всего, симптомы, которые Вы указали, соответствуют наличию аллергии. В данной ситуации советуем Вам обратиться за помощью к вашему лечащему врачу.";
            }
            else
            {
                label1.Text = "Вероятнее всего, симптомы, которые Вы указали, соответствуют наличию гриппа. В данной ситуации советуем Вам обратиться за помощью к вашему лечащему врачу.";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TestRes_Load(object sender, EventArgs e)
        {

        }
    }
}
