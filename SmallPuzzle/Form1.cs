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
    public partial class Form1 : Form
    {
        bool[] correct = new bool[16];
        object selected=null;
        int a = 0;
        PictureBox pic;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selected = sender;
        }

    

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if(selected!=null)
            {
                pic.Top = panel2.Top;
                pic.Left = panel2.Left;
                pic.BringToFront();
               
            }
            if(pic==pictureBox2)
            {
                correct[1] = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            selected = sender;

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel1.Top;
                pic.Left = panel1.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox1)
            {
                correct[0] = true;
            }
        }
       

        private void panel3_MouseClick_1(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel3.Top;
                pic.Left = panel3.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox3)
            {
                correct[2] = true;
            }
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel4.Top;
                pic.Left = panel4.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox4)
            {
                correct[3] = true;
            }
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel5.Top;
                pic.Left = panel5.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox5)
            {
                correct[4] = true;
            }
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel6.Top;
                pic.Left = panel6.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox6)
            {
                correct[5] = true;
            }
        }

        private void panel7_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel7.Top;
                pic.Left = panel7.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox7)
            {
                correct[6] = true;
            }
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel8.Top;
                pic.Left = panel8.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox8)
            {
                correct[7] = true;
            }
        }

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel9.Top;
                pic.Left = panel9.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox9)
            {
                correct[8] = true;
            }
        }

        private void panel10_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel10.Top;
                pic.Left = panel10.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox10)
            {
                correct[9] = true;
            }
        }

        private void panel11_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel11.Top;
                pic.Left = panel11.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox11)
            {
                correct[10] = true;
            }
        }

        private void panel12_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel12.Top;
                pic.Left = panel12.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox12)
            {
                correct[11] = true;
            }
        }

        private void panel13_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel13.Top;
                pic.Left = panel13.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox13)
            {
                correct[12] = true;
            }
        }

        private void panel14_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel14.Top;
                pic.Left = panel14.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox14)
            {
                correct[13] = true;
            }
        }

        private void panel15_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel15.Top;
                pic.Left = panel15.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox15)
            { 
                correct[14] = true;
            }
        }

        private void panel16_MouseClick(object sender, MouseEventArgs e)
        {
            pic = (PictureBox)selected;
            if (selected != null)
            {
                pic.Top = panel16.Top;
                pic.Left = panel16.Left;
                pic.BringToFront();
            }
            if (pic == pictureBox16)
            {
                correct[15] = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Tab)
            {
                pictureBox1.Top = panel17.Top;
                pictureBox1.Left = panel17.Left;
                pictureBox2.Top = panel17.Top;
                pictureBox2.Left = panel17.Left;
                pictureBox3.Top = panel17.Top;
                pictureBox3.Left = panel17.Left;
                pictureBox4.Top = panel17.Top;
                pictureBox4.Left = panel17.Left;
                pictureBox5.Top = panel17.Top;
                pictureBox5.Left = panel17.Left;
                pictureBox6.Top = panel17.Top;
                pictureBox6.Left = panel17.Left;
                pictureBox7.Top = panel17.Top;
                pictureBox7.Left = panel17.Left;
                pictureBox8.Top = panel17.Top;
                pictureBox8.Left = panel17.Left;
                pictureBox9.Top = panel17.Top;
                pictureBox9.Left = panel17.Left;
                pictureBox10.Top = panel17.Top;
                pictureBox10.Left = panel17.Left;
                pictureBox11.Top = panel17.Top;
                pictureBox11.Left = panel17.Left;
                pictureBox12.Top = panel17.Top;
                pictureBox12.Left = panel17.Left;
                pictureBox13.Top = panel17.Top;
                pictureBox13.Left = panel17.Left;
                pictureBox14.Top = panel17.Top;
                pictureBox14.Left = panel17.Left;
                pictureBox15.Top = panel17.Top;
                pictureBox15.Left = panel17.Left;
                pictureBox16.Top = panel17.Top;
                pictureBox16.Left = panel17.Left;
            }
            if(e.KeyCode==Keys.Escape)
            {
                for(int i = 0;i<16;i++)
                {
                    if (correct[i] == true)
                    {
                        a++;
                    }
                    
                }
                if (a == 16)
                {
                    MessageBox.Show("برنده");
                    
                }
                else
                {
                    MessageBox.Show("بازنده");
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
