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

        bool gameOver = false;
        public Man_hinh_game()
        {
            InitializeComponent();
            RestartGame();
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
            if(e.KeyCode == Keys.R && gameOver)
            {
                RestartGame();
            }
        }

        private void End_game()
        {
            Thoi_gian_cua_ong.Stop();
            MessageBox.Show("Bạn đã thua số điểm bạn ghi được là " + score.ToString());
            DialogResult dr = MessageBox.Show("Bạn có muốn chơi lại ?", "YES/NO", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                gameOver = true;
                Nut_Restart.Enabled = true;
                Nut_Restart.Visible = true; 
            }
            else
            {
                Man_hinh_menu man_hinh_menu = new Man_hinh_menu();
                man_hinh_menu.Show();
                this.Hide();
            }
        }

        private void RestartGame()
        {
            gameOver = false;
            pic_Bird.Location = new Point(179, 250);
            pic_Ong_tren.Left = 800;
            pic_Ong_duoi.Left = 1200;

            score = 0;
            toc_do_ong = 8;
            score_text.Text = "Score: 0";
            Thoi_gian_cua_ong.Start();
            Nut_Restart.Enabled = false;
            Nut_Restart.Visible = false;
        }

        private void RestartClickEvent(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
