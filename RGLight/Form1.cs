using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGLight
{
    public partial class Form1 : Form
    {
        int l;
        public Form1()
        {
            InitializeComponent();
            l = pictureBox1.Left;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left + pictureBox1.Width >= panel1.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("باختی");
                
            }
            
        }

        private void greenlight_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void redlight_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
                pictureBox1.Left = l;
        }
    }
}
