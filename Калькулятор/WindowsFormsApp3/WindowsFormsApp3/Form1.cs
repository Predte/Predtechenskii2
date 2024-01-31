using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool N2;
        public Form1()
        {
            N2 = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if(N2)
            {
                N2 = false;
                textBox1.Text = "0";
            }
            Button b = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = b.Text;
            else
                textBox1.Text = textBox1.Text + b.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            D = b.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if(D=="+")
            {
                res = dn1 + dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "×")
            {
                res = dn1 * dn2;
            }
            if (D == "/")
            {
                res = dn1 / dn2;
                if (dn2 == 0)
                {
                    textBox1.Text = Convert.ToString(dn2);
                }
            }
            if (D == "√")
            {
                res = Math.Sqrt(dn1);
            }
            if (D == "x^2")
            {
                res = Math.Pow(dn1, 2);
            }
            if (D == "sin")
            {
                res = Math.Sin(dn1);
                textBox1.Text = Convert.ToString(res);
            }
            if (D == "cos")
            {
                res = Math.Cos(dn1);
                textBox1.Text = Convert.ToString(res);
            }
            if (D == "tg")
            {
                res = Math.Tan(dn1);
                textBox1.Text = Convert.ToString(res);
            }
            if (D == "Ctg")
            {
                res = 1 / Math.Tan(dn1);
                textBox1.Text = Convert.ToString(res);
            }
            D = "=";
            N2 = true;
            textBox1.Text = res.ToString();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            D = b.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            D = b.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            D = b.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            D = b.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            D = b.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            D = b.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
