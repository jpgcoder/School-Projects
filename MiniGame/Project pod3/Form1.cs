using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_pod3
{
    public partial class Form1 : Form
    {
        int score = 0;
        int t = 120, min = 1, sec = 60;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void timer_crab1_Tick(object sender, EventArgs e)
        {
            pic_crab1.Top -= 2;
            if (pic_crab1.Bounds.IntersectsWith(pictureBox117.Bounds))
            {
                timer_crab1u.Enabled = false;
                timer_crab1d.Enabled = true;
            }

            if (pic_crab1.Bounds.IntersectsWith(pic_player.Bounds))
            {
                timer1.Enabled = false;
                timer_crab1d.Enabled = false;
                timer_crab2d.Enabled = false;
                timer_crab1u.Enabled = false;
                timer_crab2u.Enabled = false;
                timer_crab3r.Enabled = false;
                timer_crab3l.Enabled = false;
                MessageBox.Show("باختی");

            }


        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer_crab1u.Enabled = true;
            timer_crab2d.Enabled = true;
            timer_crab3l.Enabled = true;
            btn_down.Enabled = true;
            btn_up.Enabled = true;
            btn_right.Enabled = true;
            btn_left.Enabled = true;
            timer1.Enabled = true;

        }

        private void timer_crab1d_Tick(object sender, EventArgs e)
        {
            pic_crab1.Top += 2;
            if (pic_crab1.Bounds.IntersectsWith(pictureBox113.Bounds))
            {
                timer_crab1d.Enabled = false;
                timer_crab1u.Enabled = true;
            }
            if (pic_crab1.Bounds.IntersectsWith(pic_player.Bounds))
            {
                timer1.Enabled = false;
                timer_crab1d.Enabled = false;
                timer_crab2d.Enabled = false;
                timer_crab1u.Enabled = false;
                timer_crab2u.Enabled = false;
                timer_crab3r.Enabled = false;
                timer_crab3l.Enabled = false;
                MessageBox.Show("باختی");

            }
        }

        private void timer_crab2u_Tick(object sender, EventArgs e)
        {
            pic_crab2.Top -= 2;
            if (pic_crab2.Bounds.IntersectsWith(pictureBox18.Bounds))
            {
                timer_crab2u.Enabled = false;
                timer_crab2d.Enabled = true;
            }
            if (pic_crab2.Bounds.IntersectsWith(pic_player.Bounds))
            {
                timer1.Enabled = false;
                timer_crab1d.Enabled = false;
                timer_crab2d.Enabled = false;
                timer_crab1u.Enabled = false;
                timer_crab2u.Enabled = false;
                timer_crab3r.Enabled = false;
                timer_crab3l.Enabled = false;
                MessageBox.Show("باختی");

            }
        }

        private void timer_crab2d_Tick(object sender, EventArgs e)
        {
            pic_crab2.Top += 2;
            if (pic_crab2.Bounds.IntersectsWith(pictureBox56.Bounds))
            {
                timer_crab2d.Enabled = false;
                timer_crab2u.Enabled = true;
            }
            if (pic_crab2.Bounds.IntersectsWith(pic_player.Bounds))
            {
                timer1.Enabled = false;
                timer_crab1d.Enabled = false;
                timer_crab2d.Enabled = false;
                timer_crab1u.Enabled = false;
                timer_crab2u.Enabled = false;
                timer_crab3r.Enabled = false;
                timer_crab3l.Enabled = false;
                MessageBox.Show("باختی");

            }
        }

        private void timer_crab3l_Tick(object sender, EventArgs e)
        {
            pic_crab3.Left -= 2;
            if (pic_crab3.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                timer_crab3l.Enabled = false;
                timer_crab3r.Enabled = true;
            }
            if (pic_crab3.Bounds.IntersectsWith(pic_player.Bounds))
            {
                timer1.Enabled = false;
                timer_crab1d.Enabled = false;
                timer_crab2d.Enabled = false;
                timer_crab1u.Enabled = false;
                timer_crab2u.Enabled = false;
                timer_crab3r.Enabled = false;
                timer_crab3l.Enabled = false;
                MessageBox.Show("باختی");

            }
        }

        private void timer_crab3r_Tick(object sender, EventArgs e)
        {
            pic_crab3.Left += 2;
            if (pic_crab3.Bounds.IntersectsWith(pictureBox92.Bounds))
            {
                timer_crab3r.Enabled = false;
                timer_crab3l.Enabled = true;
            }
            if (pic_crab3.Bounds.IntersectsWith(pic_player.Bounds))
            {
                timer1.Enabled = false;
                timer_crab1d.Enabled = false;
                timer_crab2d.Enabled = false;
                timer_crab1u.Enabled = false;
                timer_crab2u.Enabled = false;
                timer_crab3r.Enabled = false;
                timer_crab3l.Enabled = false;
                MessageBox.Show("باختی");

            }
        }
     
        

        private void btn_up_Click(object sender, EventArgs e)
        {
            pic_player.Top -= pic_player.Height + 1;
            if (pic_player.Bounds.IntersectsWith(btn_irainianstuff3.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff1.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff2.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff4.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff5.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff6.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff7.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff8.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff9.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff10.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff11.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff12.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff13.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff14.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff15.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff16.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff17.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff18.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff19.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff20.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff21.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff22.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff23.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff24.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff25.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff26.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff27.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff28.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff29.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff30.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff31.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff32.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff33.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff34.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff35.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff36.Bounds))
            {
                score++;
                lbl_score.Text = score.ToString();
            }
            if (pic_player.Bounds.IntersectsWith(picbox_irani1.Bounds) || pic_player.Bounds.IntersectsWith(picbox_irani2.Bounds) || pic_player.Bounds.IntersectsWith(picbox_irani3.Bounds) || pic_player.Bounds.IntersectsWith(picbox_irani4.Bounds))
            {
                score += 5;
                lbl_score.Text = score.ToString();
            }
           if( pic_player.Bounds.IntersectsWith(pic_crab1.Bounds) || pic_player.Bounds.IntersectsWith(pic_crab2.Bounds) || pic_player.Bounds.IntersectsWith(pic_crab3.Bounds))
            {
                timer1.Enabled = false;
                timer_crab1d.Enabled = false;
                timer_crab2d.Enabled = false;
                timer_crab1u.Enabled = false;
                timer_crab2u.Enabled = false;
                timer_crab3r.Enabled = false;
                timer_crab3l.Enabled = false;
                MessageBox.Show("باختی");
              
            }
           if(pic_player.Bounds.IntersectsWith(pictureBox1.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox2.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox3.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox4.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox5.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox6.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox7.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox8.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox9.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox10.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox11.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox12.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox13.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox14.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox15.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox16.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox17.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox18.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox19.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox20.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox21.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox22.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox23.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox24.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox25.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox26.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox27.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox28.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox29.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox30.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox31.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox32.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox33.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox34.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox35.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox36.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox37.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox38.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox39.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox40.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox41.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox42.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox43.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox44.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox45.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox46.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox47.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox48.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox49.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox50.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox51.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox52.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox53.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox54.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox55.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox56.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox58.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox59.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox60.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox61.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox62.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox63.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox64.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox65.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox66.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox67.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox68.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox69.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox70.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox71.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox72.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox73.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox74.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox77.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox78.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox79.Bounds)||
                pic_player.Bounds.IntersectsWith(pictureBox80.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox81.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox82.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox83.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox84.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox85.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox86.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox87.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox88.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox89.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox90.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox91.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox92.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox93.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox94.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox95.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox96.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox97.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox98.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox99.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox100.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox101.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox102.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox103.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox104.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox105.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox106.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox107.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox108.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox109.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox110.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox111.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox112.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox113.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox114.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox115.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox116.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox117.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox118.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox119.Bounds)|| pic_player.Bounds.IntersectsWith(pictureBox120.Bounds))
            {
                pic_player.Top += pic_player.Height + 1;
            }
        }
        

        private void btn_left_Click(object sender, EventArgs e)
        {
            pic_player.Left -= pic_player.Height + 1;
            if (pic_player.Bounds.IntersectsWith(btn_irainianstuff3.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff1.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff2.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff4.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff5.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff6.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff7.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff8.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff9.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff10.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff11.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff12.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff13.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff14.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff15.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff16.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff17.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff18.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff19.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff20.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff21.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff22.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff23.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff24.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff25.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff26.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff27.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff28.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff29.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff30.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff31.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff32.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff33.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff34.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff35.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff36.Bounds))
            {
                score++;
                lbl_score.Text = score.ToString();
            }
            if (pic_player.Bounds.IntersectsWith(btn_externalstuff1.Bounds) || pic_player.Bounds.IntersectsWith(btn_externalstuff2.Bounds) || pic_player.Bounds.IntersectsWith(btn_externalstuff3.Bounds) ||
              pic_player.Bounds.IntersectsWith(btn_externalstuff4.Bounds) || pic_player.Bounds.IntersectsWith(btn_externalstuff5.Bounds) || pic_player.Bounds.IntersectsWith(btn_externalstuff6.Bounds) )
            
     
            {
                score--;
                lbl_score.Text = score.ToString();
            }

            if (pic_player.Bounds.IntersectsWith(picbox_irani1.Bounds) || pic_player.Bounds.IntersectsWith(picbox_irani2.Bounds) || pic_player.Bounds.IntersectsWith(picbox_irani3.Bounds) || pic_player.Bounds.IntersectsWith(picbox_irani4.Bounds))
                {
                score += 5;
                lbl_score.Text = score.ToString();
            }

            if (pic_player.Bounds.IntersectsWith(pic_crab1.Bounds) || pic_player.Bounds.IntersectsWith(pic_crab2.Bounds) || pic_player.Bounds.IntersectsWith(pic_crab3.Bounds))
            {
                timer1.Enabled = false;
                timer_crab1d.Enabled = false;
                timer_crab2d.Enabled = false;
                timer_crab1u.Enabled = false;
                timer_crab2u.Enabled = false;
                timer_crab3r.Enabled = false;
                timer_crab3l.Enabled = false;
                MessageBox.Show("باختی");
            }
            if (pic_player.Bounds.IntersectsWith(pictureBox1.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox2.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox3.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox4.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox5.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox6.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox7.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox8.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox9.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox10.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox11.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox12.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox13.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox14.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox15.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox16.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox17.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox18.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox19.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox20.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox21.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox22.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox23.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox24.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox25.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox26.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox27.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox28.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox29.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox30.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox31.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox32.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox33.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox34.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox35.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox36.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox37.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox38.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox39.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox40.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox41.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox42.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox43.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox44.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox45.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox46.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox47.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox48.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox49.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox50.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox51.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox52.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox53.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox54.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox55.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox56.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox58.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox59.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox60.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox61.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox62.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox63.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox64.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox65.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox66.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox67.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox68.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox69.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox70.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox71.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox72.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox73.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox74.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox77.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox78.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox79.Bounds) ||
               pic_player.Bounds.IntersectsWith(pictureBox80.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox81.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox82.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox83.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox84.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox85.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox86.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox87.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox88.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox89.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox90.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox91.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox92.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox93.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox94.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox95.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox96.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox97.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox98.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox99.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox100.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox101.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox102.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox103.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox104.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox105.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox106.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox107.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox108.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox109.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox110.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox111.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox112.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox113.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox114.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox115.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox116.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox117.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox118.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox119.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox120.Bounds))
            {
                pic_player.Left += pic_player.Height + 1;
            }


        }

        private void btn_right_Click(object sender, EventArgs e)

        {
            pic_player.Left += pic_player.Width+1;
            if (pic_player.Bounds.IntersectsWith(btn_irainianstuff3.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff1.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff2.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff4.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff5.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff6.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff7.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff8.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff9.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff10.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff11.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff12.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff13.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff14.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff15.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff16.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff17.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff18.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff19.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff20.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff21.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff22.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff23.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff24.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff25.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff26.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff27.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff28.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff29.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff30.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff31.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff32.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff33.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff34.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff35.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff36.Bounds))
            {
                score++;
                lbl_score.Text = score.ToString();
            }
          
            if (pic_player.Bounds.IntersectsWith(btn_externalstuff1.Bounds) || pic_player.Bounds.IntersectsWith(btn_externalstuff2.Bounds) || pic_player.Bounds.IntersectsWith(btn_externalstuff3.Bounds) ||
            pic_player.Bounds.IntersectsWith(btn_externalstuff4.Bounds) || pic_player.Bounds.IntersectsWith(btn_externalstuff5.Bounds) || pic_player.Bounds.IntersectsWith(btn_externalstuff6.Bounds))


            {
                score--;
                lbl_score.Text = score.ToString();
            }
            if (pic_player.Bounds.IntersectsWith(picbox_irani1.Bounds) || pic_player.Bounds.IntersectsWith(picbox_irani2.Bounds) || pic_player.Bounds.IntersectsWith(picbox_irani3.Bounds) || pic_player.Bounds.IntersectsWith(picbox_irani4.Bounds))
            {
                score += 5;
                lbl_score.Text = score.ToString();
            }
            if (pic_player.Bounds.IntersectsWith(pic_crab1.Bounds) || pic_player.Bounds.IntersectsWith(pic_crab2.Bounds) || pic_player.Bounds.IntersectsWith(pic_crab3.Bounds))
            {
                timer1.Enabled = false;
                timer_crab1d.Enabled = false;
                timer_crab2d.Enabled = false;
                timer_crab1u.Enabled = false;
                timer_crab2u.Enabled = false;
                timer_crab3r.Enabled = false;
                timer_crab3l.Enabled = false;
                MessageBox.Show("باختی");
             

            }
            if (pic_player.Bounds.IntersectsWith(pictureBox1.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox2.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox3.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox4.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox5.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox6.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox7.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox8.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox9.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox10.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox11.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox12.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox13.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox14.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox15.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox16.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox17.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox18.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox19.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox20.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox21.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox22.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox23.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox24.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox25.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox26.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox27.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox28.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox29.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox30.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox31.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox32.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox33.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox34.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox35.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox36.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox37.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox38.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox39.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox40.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox41.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox42.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox43.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox44.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox45.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox46.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox47.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox48.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox49.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox50.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox51.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox52.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox53.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox54.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox55.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox56.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox58.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox59.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox60.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox61.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox62.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox63.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox64.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox65.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox66.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox67.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox68.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox69.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox70.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox71.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox72.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox73.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox74.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox77.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox78.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox79.Bounds) ||
                pic_player.Bounds.IntersectsWith(pictureBox80.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox81.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox82.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox83.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox84.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox85.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox86.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox87.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox88.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox89.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox90.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox91.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox92.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox93.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox94.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox95.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox96.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox97.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox98.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox99.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox100.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox101.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox102.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox103.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox104.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox105.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox106.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox107.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox108.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox109.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox110.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox111.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox112.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox113.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox114.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox115.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox116.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox117.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox118.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox119.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox120.Bounds))
            {
                pic_player.Left -= pic_player.Width + 1;
            }


        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            pic_player.Top += pic_player.Height + 1;
            if (pic_player.Bounds.IntersectsWith(btn_irainianstuff3.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff1.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff2.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff4.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff5.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff6.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff7.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff8.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff9.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff10.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff11.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff12.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff13.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff14.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff15.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff16.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff17.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff18.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff19.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff20.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff21.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff22.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff23.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff24.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff25.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff26.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff27.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff28.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff29.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff30.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff31.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff32.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff33.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff34.Bounds) || pic_player.Bounds.IntersectsWith(btn_irainianstuff35.Bounds) ||
                pic_player.Bounds.IntersectsWith(btn_irainianstuff36.Bounds))
            {
                score++;
                lbl_score.Text = score.ToString();
            }
            if (pic_player.Bounds.IntersectsWith(btn_externalstuff1.Bounds) || pic_player.Bounds.IntersectsWith(btn_externalstuff2.Bounds) || pic_player.Bounds.IntersectsWith(btn_externalstuff3.Bounds) ||
          pic_player.Bounds.IntersectsWith(btn_externalstuff4.Bounds) || pic_player.Bounds.IntersectsWith(btn_externalstuff5.Bounds) || pic_player.Bounds.IntersectsWith(btn_externalstuff6.Bounds))


            {
                score--;
                lbl_score.Text = score.ToString();
            }
            if (pic_player.Bounds.IntersectsWith(picbox_irani1.Bounds) || pic_player.Bounds.IntersectsWith(picbox_irani2.Bounds) || pic_player.Bounds.IntersectsWith(picbox_irani3.Bounds) || pic_player.Bounds.IntersectsWith(picbox_irani4.Bounds))
            {
                score += 5;
                lbl_score.Text = score.ToString();
            }
            if (pic_player.Bounds.IntersectsWith(pic_crab1.Bounds) || pic_player.Bounds.IntersectsWith(pic_crab2.Bounds) || pic_player.Bounds.IntersectsWith(pic_crab3.Bounds))
            {
                timer1.Enabled = false;
                timer_crab1d.Enabled = false;
                timer_crab2d.Enabled = false;
                timer_crab1u.Enabled = false;
                timer_crab2u.Enabled = false;
                timer_crab3r.Enabled = false;
                timer_crab3l.Enabled = false;
                MessageBox.Show("باختی");
              
            }
            if (pic_player.Bounds.IntersectsWith(pictureBox1.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox2.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox3.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox4.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox5.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox6.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox7.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox8.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox9.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox10.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox11.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox12.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox13.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox14.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox15.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox16.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox17.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox18.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox19.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox20.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox21.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox22.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox23.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox24.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox25.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox26.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox27.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox28.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox29.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox30.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox31.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox32.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox33.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox34.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox35.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox36.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox37.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox38.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox39.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox40.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox41.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox42.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox43.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox44.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox45.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox46.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox47.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox48.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox49.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox50.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox51.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox52.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox53.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox54.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox55.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox56.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox58.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox59.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox60.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox61.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox62.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox63.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox64.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox65.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox66.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox67.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox68.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox69.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox70.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox71.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox72.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox73.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox74.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox77.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox78.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox79.Bounds) ||
               pic_player.Bounds.IntersectsWith(pictureBox80.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox81.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox82.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox83.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox84.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox85.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox86.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox87.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox88.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox89.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox90.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox91.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox92.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox93.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox94.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox95.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox96.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox97.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox98.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox99.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox100.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox101.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox102.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox103.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox104.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox105.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox106.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox107.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox108.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox109.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox110.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox111.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox112.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox113.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox114.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox115.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox116.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox117.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox118.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox119.Bounds) || pic_player.Bounds.IntersectsWith(pictureBox120.Bounds))
            {
                pic_player.Top -= pic_player.Height + 1;
            }
        }


        

        private void pic_player_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
      
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec--;
            if(sec==0)
            {
                min--;
            }
            
            lbl_min.Text = min.ToString();
            lbl_sec.Text = sec.ToString();
            if(min==0&&sec==0)
            {
                timer1.Enabled = false;
                timer_crab1d.Enabled = false;
                timer_crab2d.Enabled = false;
                timer_crab1u.Enabled = false;
                timer_crab2u.Enabled = false;
                timer_crab3r.Enabled = false;
                timer_crab3l.Enabled = false;

                MessageBox.Show("زمان شما تمام شد");
             
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
