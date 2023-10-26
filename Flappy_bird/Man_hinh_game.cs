using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird
{
    public partial class Man_hinh_game : Form
    {

        int toc_do_ong;
        int toc_do_enemy;
        //gravity la do roi cua chim
        int gravity = 5;
        int score = 0;
        int store_random;
        bool gameOver = false;
        // biến capDoGame
        private int capDoGame;
        int life,height_random;//height_random được sử dụng để sửa lại random độ cao ống khi đổi qua full screen
        private Size initialSize;
        private Point initialLocation;
        Random rnd=new Random();

        public int CapDoGame
        {
            get { return capDoGame; }
            set { capDoGame = value; }
        }

        public Man_hinh_game()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            initialSize = this.Size;
            initialLocation = this.Location;
            Game_lose.Hide();
            label_high_score_store.Text = Properties.Settings.Default.h_score;
        }

        void Life_index()
        {
            if (life == 1)
            {
                life_1.Image = Properties.Resources.life_white;
            }
            if (life == 2)
            {
                life_2.Image= Properties.Resources.life_white;  
            }

            if (life == 3)
            {
                life_3.Image= Properties.Resources.life_white;
                Die();
                End_game();
                int a = Int32.Parse(label_high_score_store.Text);
                if (score > a)
                {
                    label_high_score_store.Text=score.ToString();
                    Properties.Settings.Default.h_score = label_high_score_store.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void Function_game(int toc_do_ong,int height_ong)
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
                if (capDoGame == 1) // level TB
                {
                    pic_Ong_duoi.Left = random.Next(100, 800) + 400;
                }
                else if (capDoGame == 2) // level khó
                {
                    pic_Ong_duoi.Left = random.Next(100, 800) + 800;
                }
                else // level dễ
                {
                    pic_Ong_duoi.Left = random.Next(100, 800);
                }
                Take_score();
                score++;
            }
            //tuong tu method tren
            if (pic_Ong_tren.Left < -180)
            {
                if (capDoGame == 1) // level TB
                {
                    pic_Ong_tren.Height = random.Next(30, height_ong);
                    pic_Ong_tren.Left = random.Next(300, 950) + 400;
                }
                else if (capDoGame == 2) // level khó
                {
                    pic_Ong_tren.Height = random.Next(30, height_ong);
                    pic_Ong_tren.Left = random.Next(300, 950) + 800;
                }
                else //  level dễ
                {
                    pic_Ong_tren.Height = random.Next(30, height_ong);
                    pic_Ong_tren.Left = random.Next(300, 950);
                }
                Take_score();
                score++;
            }
        }

        private void Game_update()
        {
            if (pic_Bird.Bounds.IntersectsWith(pic_Ong_duoi.Bounds) || pic_Bird.Bounds.IntersectsWith(pic_Ong_tren.Bounds) || pic_Bird.Bounds.IntersectsWith(pic_Nen_dat.Bounds) || pic_Bird.Bounds.IntersectsWith(pic_enemy.Bounds) || pic_Bird.Top < -25)
            {
                pic_enemy.Location = new Point(store_random, 0);
                pic_enemy.Left += this.Width;
                pic_Ong_duoi.Left += this.Width;
                pic_Ong_tren.Left += this.Width;
                pic_Bird.Location = new Point(179, 250);
                life += 1;
                Life_index();
            }
            if (score > 5)
            {
                toc_do_ong = 15;
            }
            else if (score > 30)
            {
                toc_do_ong = 25;
            }
        }

        private void Enemy_move(int toc_do_enemy)
        {
            pic_enemy.Left -= toc_do_enemy;
            if(pic_enemy.Left < -180)
            {
                store_random = rnd.Next(0, 300); // Cập nhật lại giá trị ngẫu nhiên cho vị trí y của pic_enemy
                pic_enemy.Location = new Point(this.ClientSize.Width + 180, store_random); // Đặt lại vị trí của pic_enemy ở góc màn hình bên phải với vị trí y ngẫu nhiên
            }
        }

        private void Game_timer_event(object sender, EventArgs e)
        {
            if (Setting.IsFullScreen)
            {
                toc_do_ong = 15;
                toc_do_enemy = 30;
                height_random = 100;
                Function_game(toc_do_ong,height_random);
                Enemy_move(toc_do_enemy);
            }
            else
            {
                toc_do_ong = 8;
                toc_do_enemy = 6;
                height_random = 300;
                Function_game(toc_do_ong, height_random);
                Enemy_move(toc_do_enemy);
            }
            Game_update();
        }

        private void Game_key_is_down(object sender, KeyEventArgs e)
        {
            if (Setting.IsFullScreen)
            {
                if (e.KeyCode == Keys.Space)
                {
                    gravity = -20;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Space)
                {
                    gravity = -5;
                }
            }
        }

        private void Game_key_is_up(object sender, KeyEventArgs e)
        {
            if (Setting.IsFullScreen)
            {
                if (e.KeyCode == Keys.Space)
                {
                    gravity = 20;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Space)
                {
                    gravity = 5;
                }
            }
        }
        private void Take_score()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\DELL G15\source\repos\Flappy_bird\Flappy_bird\Resources\sfx_point.wav");
            player.Play();
        }

        private void Die()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\DELL G15\source\repos\Flappy_bird\Flappy_bird\Resources\sfx_die.wav");
            player.Play();
        }

        private void End_game()
        {
            Thoi_gian_cua_ong.Stop();
            lb_score_lose.Text=score.ToString();
            lb_high_score_lose.Text=label_high_score_store.Text;
            score_text.Visible=false;
            lb_high_score.Visible=false;
            label_high_score_store.Visible=false;
            Game_lose.Show();
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
            // để khi thua thì vẫn giữ tốc độ game theo độ khó
            hamCapDoGame();
        }

        public void Full_screen()
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        public void Window_screen()
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            Size = initialSize;
            Location = initialLocation;
        }

        private void Man_hinh_game_Load(object sender, EventArgs e)
        {
            hamCapDoGame();
            if (Setting.IsFullScreen)
            {
                Full_screen();
            }
            else
            {
                Window_screen();
            }
        }
        // hàm này tạo để thay đổi tốc độ theo độ khó
        private void hamCapDoGame()
        {
            switch (capDoGame)
            {
                case 0: // Dễ
                    toc_do_ong = 8;
                    gravity = 5;
                    Thoi_gian_cua_ong.Interval = 1000 / 60; // chỉnh tốc độ khung hình
                    break;
                case 1: // Trung bình
                    toc_do_ong = 12;
                    gravity = 8;
                    Thoi_gian_cua_ong.Interval = 1000 / 45;
                    break;
                case 2: // Khó
                    toc_do_ong = 16;
                    gravity = 10;
                    Thoi_gian_cua_ong.Interval = 1000 / 30;
                    break;
                default: // Mặc định là dễ
                    toc_do_ong = 8;
                    gravity = 5;
                    Thoi_gian_cua_ong.Interval = 1000 / 60;
                    break;
            }
            
        }

        private void pic_home_Click(object sender, EventArgs e)
        {
            Man_hinh_menu menu = new Man_hinh_menu();
            menu.Show();
            this.Hide();
        }


        private void pic_replay_Click(object sender, EventArgs e)
        {
            Thoi_gian_cua_ong.Start();
            Game_lose.Hide();
            gameOver = false;
            pic_Bird.Location = new Point(179, 250);
            pic_Ong_tren.Left = 800;
            pic_Ong_duoi.Left = 1200;
            score = 0;
            score_text.Text = "Score: 0";
            score_text.Visible = true;
            lb_high_score.Visible = true;
            label_high_score_store.Visible = true;
            life_1.Image = Properties.Resources.life;
            life_2.Image = Properties.Resources.life;
            life_3.Image = Properties.Resources.life;
            life = 0;
            hamCapDoGame();
        }
    }
}
