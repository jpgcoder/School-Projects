using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturePuzzle
{
    public partial class Form2 : Form
    {
        int n, m=0,c=10;
        Random rnd = new Random();
        Label l;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(Label lbl in panel4.Controls)
            {
                n = rnd.Next(0,3);
                switch (n)
                {
                    case 0:
                        lbl.BackColor = Color.Red;
                        break;
                    case 1:
                        lbl.BackColor = Color.Green;
                        break;
                    case 2:
                        lbl.BackColor = Color.Blue;
                        break;
                    default:
                        break;
                }
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            l = (Label)sender;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            if (l != null)
            {
                c--;
                l.Top = panel.Top;
                l.Left = panel.Left;
                l.BringToFront();
                if (l.BackColor == panel.BackColor)
                    m++;
                else m--;
                label11.Text = m.ToString();
                l = null;
            }
            else
            {

            }
            if (c == 0)
                MessageBox.Show(String.Format("End. Score: {0}", m));
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Home)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
            }*/
        }
    }
}

