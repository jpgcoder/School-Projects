using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1, num2;
        bool pl, mi, mul, div;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void lightBlueToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (lightBlueToolStripMenuItem.Checked || toolStripMenuItem2.Checked)
                this.BackColor = Color.LightBlue;
        }

        private void lightGrayToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (lightGrayToolStripMenuItem.Checked || toolStripMenuItem3.Checked)
                this.BackColor = Color.LightGray;
        }

        private void redToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (redToolStripMenuItem.Checked || toolStripMenuItem5.Checked)
                textBox1.ForeColor = Color.Red;
        }

        private void btn2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();

                textBox1.Text += "2";
        }

        private void btn3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "3";
        }

        private void btn4_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "4";
        }

        private void btn5_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "5";
        }

        private void btn6_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "6";
        }

        private void btn7_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "7";
        }

        private void btn8_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "8";
        }

        private void btn9_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "9";
        }

        private void btn0_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "0";
        }

        private void btndot_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += ".";
        }

        private void btnpl_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "+";
            pl = true;
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            
            mul = true;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            mi = true;
            
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            
            div = true;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
              textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
        }

        private void greenToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (greenToolStripMenuItem.Checked || toolStripMenuItem6.Checked)
                textBox1.ForeColor = Color.Green;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneq_MouseClick(object sender, MouseEventArgs e)
        {

            if (pl)
            {
                num1 = double.Parse(textBox1.Text.Substring(0, textBox1.Text.IndexOf("+")));
                num2 = double.Parse(textBox1.Text.Substring(textBox1.Text.IndexOf("+")  +1));
                textBox1.Text = (num1 + num2).ToString();
                pl = false;
            }
            else if (mi)
            {
                num1 = double.Parse(textBox1.Text.Substring(0, textBox1.Text.IndexOf("-")));
                num2 = double.Parse(textBox1.Text.Substring(textBox1.Text.IndexOf("-")+1));
                textBox1.Text = (num1 - num2).ToString();
                mi = false;
            }
            else if (mul)
            {
                num1 = double.Parse(textBox1.Text.Substring(0, textBox1.Text.IndexOf("*")));
                num2 = double.Parse(textBox1.Text.Substring(textBox1.Text.IndexOf("*")+1));
                textBox1.Text = (num1 * num2).ToString();
                mul = false;
            }
            else if (div)
            {
                num1 = double.Parse(textBox1.Text.Substring(0, textBox1.Text.IndexOf("/")));
                num2 = int.Parse(textBox1.Text.Substring(textBox1.Text.IndexOf("/")+1));
                textBox1.Text = (num1 / num2).ToString();
                div=false;
            }
        }

        private void btn1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "1";
        }
    }
}

