using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird
{
    public partial class Man_hinh_game : Form
    {

        int toc_do_ong = 8;
        //gravity la do roi cua chim
        int gravity = 5;
        int score = 0;
        public Man_hinh_game()
        {
            InitializeComponent();
        }



        private void Dong_man_hinh_game(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Game_timer_event(object sender, EventArgs e)
        {
            pic_Bird.Top += gravity;
            pic_Ong_duoi.Left -= toc_do_ong;
            pic_Ong_tren.Left -= toc_do_ong;
            score_text.Text = "Score: " + score.ToString();
            Random random = new Random();
            //Method nay dung de chay ong tren neu nhu no nho hon 150 thi no se xuat hien o toa do 800 keo dai man hinh ra la se thay
            //score se duoc tinh khi no di het ong voi moi ong la 1 diem
            if (pic_Ong_duoi.Left < -150)
            {
                pic_Ong_duoi.Left = random.Next(100,800);
                score++;
            }
            //tuong tu method tren
            if (pic_Ong_tren.Left < -180)
            {
                pic_Ong_tren.Height = random.Next(30,400);
                pic_Ong_tren.Left = random.Next(300,950);
                score++;
            }

            if(pic_Bird.Bounds.IntersectsWith(pic_Ong_duoi.Bounds) || pic_Bird.Bounds.IntersectsWith(pic_Ong_tren.Bounds) || pic_Bird.Bounds.IntersectsWith(pic_Nen_dat.Bounds))
            {
                End_game();
            }

           if (score > 5)
            {
                toc_do_ong = 15;
            }else if (score > 30)
            {
                toc_do_ong = 25;
            }

            if (pic_Bird.Top < -25)
            {
                End_game();
            }
        }

        private void Game_key_is_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Game_key_is_up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void End_game()
        {
            Thoi_gian_cua_ong.Stop();
            MessageBox.Show("Bạn đã thua số điểm bạn ghi được là " + score.ToString());
        }
    }
}
