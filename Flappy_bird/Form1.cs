using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Flappy_bird
{
    public partial class Man_hinh_menu : Form
    {
        WindowsMediaPlayer player=new WindowsMediaPlayer();
        public Man_hinh_menu()
        {
            InitializeComponent();
            player.settings.setMode("loop", true);
            player.settings.volume = 100;
            player.URL = @"D:\laptrinhwindow\Flappy_bird\Flappy_bird\y2mate.com - Flappy Bird Theme Song.mp3";
            player.controls.play();
        }

        //Ham nay giup load form man hinh tro choi
        private void Load_game(object sender, EventArgs e)
        {
            Man_hinh_game man_Hinh_Game = new Man_hinh_game();
            man_Hinh_Game.Show();
            this.Hide();
        }

        //Ham nay giup load form man hinh huong dan
        private void Load_help(object sender, EventArgs e)
        {
            Huong_dan huong_dan=new Huong_dan();
            huong_dan.Show();
            this.Hide();
        }

        private void Dong_man_hinh_game(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void Man_hinh_menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
