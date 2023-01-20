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
   

    public partial class Form3 : Form
    {
       
        public Form3()
        {
           
            InitializeComponent();
        }
        int borek = 0;
        int top = 0;
        int borek2=0;
        int top2 = 0;
        int borek3=0;
        int top3 = 0;
        int borek4=0;
        int top4 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            borek++;
            top = top + 12;
            textBox1.Text= borek.ToString();
            textBox2.Text= top.ToString();
            if (borek==10)
            {
              button1.Enabled = false;
            }
            if (borek >= 1)
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
            borek--;
            top=top - 12;
            textBox1.Text = borek.ToString();
            textBox2.Text = top.ToString();

            if (borek <= 0 || borek == 0)
            {
                button2.Enabled = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            borek2++;
            top2 = top2 + 15;
            textBox3.Text = borek2.ToString();
            textBox4.Text = top2.ToString();
            if (borek2 == 10)
            {
                button3.Enabled = false;
            }
            if (borek2 >= 1)
            {
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            borek2--;
            top2 = top2 - 15;
            textBox3.Text = borek2.ToString();
            textBox4.Text = top2.ToString();

            if (borek2 <= 0 || borek2 == 0)
            {
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            borek3++;
            top3 = top3 + 18;
            textBox5.Text = borek3.ToString();
            textBox6.Text = top3.ToString();
            if (borek3 == 10)
            {
                button5.Enabled = false;
            }
            if (borek3>= 1)
            {
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            borek3--;
            top3 = top3 - 18;
            textBox5.Text = borek3.ToString();
            textBox6.Text = top3.ToString();

            if (borek3 <= 0 || borek3 == 0)
            {
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            borek4++;
            top4 = top4 + 21;
            textBox7.Text = borek4.ToString();
            textBox8.Text = top4.ToString();
            if (borek4 == 10)
            {
                button7.Enabled = false;
            }
            if (borek4 >= 1)
            {
                button8.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            borek4--;
            top4 = top4 - 21;
            textBox7.Text = borek4.ToString();
            textBox8.Text = top4.ToString();

            if (borek4 <= 0 || borek4 == 0)
            {
                button8.Enabled = false;
            }
        }
    }
}
