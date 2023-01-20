using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seymabakery
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int sim1 = 0;
        int top1= 0;
        int sim2 = 0;
        int top2= 0;
        int sim3 = 0;
        int top3= 0;
        int sim4 = 0;
        int top4 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            sim1++;
            top1 = top1 + 12;
            textBox1.Text = sim1.ToString();
            textBox2.Text = top1.ToString();
            if (sim1 == 10)
            {
                button1.Enabled = false;
            }
            if (sim1 >= 1)
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sim1--;
            top1 = top1 - 12;
            textBox1.Text = sim1.ToString();
            textBox2.Text = top1.ToString();

            if (sim1 <= 0 || sim1 == 0)
            {
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sim2++;
            top2 = top2 + 15;
            textBox3.Text = sim2.ToString();
            textBox4.Text = top2.ToString();
            if (sim2 == 10)
            {
                button3.Enabled = false;
            }
            if (sim2 >= 1)
            {
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sim2--;
            top2 = top2 - 15;
            textBox3.Text = sim2.ToString();
            textBox4.Text = top2.ToString();

            if (sim2 <= 0 || sim2 == 0)
            {
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sim3++;
            top3 = top3 + 18;
            textBox5.Text = sim3.ToString();
            textBox6.Text = top3.ToString();
            if (sim3 == 10)
            {
                button5.Enabled = false;
            }
            if (sim3 >= 1)
            {
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sim3--;
            top3 = top3 - 18;
            textBox5.Text = sim3.ToString();
            textBox6.Text = top3.ToString();

            if (sim3 <= 0 || sim3 == 0)
            {
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            sim4++;
            top4 = top4 + 21;
            textBox7.Text = sim4.ToString();
            textBox8.Text = top4.ToString();
            if (sim4 == 10)
            {
                button7.Enabled = false;
            }
            if (sim4 >= 1)
            {
                button8.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sim4--;
            top4 = top4 - 21;
            textBox7.Text = sim4.ToString();
            textBox8.Text = top4.ToString();

            if (sim4 <= 0 || sim4 == 0)
            {
                button8.Enabled = false;
            }
        }
    }
}
