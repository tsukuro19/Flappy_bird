
using Flappy_bird.Model;
using Flappy_bird.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Flappy_bird
{
    public partial class Man_hinh_menu : Form
    {
        private List<string> players;
        private int capDoGame;
        private string playerName;
        private int player = 1;
        private Size initialSize;
        private Point initialLocation;
        private bool isClosing = false;
        public Man_hinh_menu()
        {
            if (instance == null)
            {
                InitializeComponent();
                wplayer.URL = (@"C:\Users\DELL G15\Source\Repos\Flappy_bird\Flappy_bird\Resources\background_music.wav");
                wplayer.controls.play();
                wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wplayer_PlayStateChange);
                wmp_background.Hide();
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
                initialSize = this.Size;
                initialLocation = this.Location;
                cbbLevel.SelectedIndex = 0;
                capDoGame = 0;
            }
            else
            {
                this.Close();
            }
        }

        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void wplayer_PlayStateChange(int newState)
        {
            if ((WMPLib.WMPPlayState)newState == WMPLib.WMPPlayState.wmppsStopped)
            {
                // Nhạc đã kết thúc, chạy lại từ đầu
                wplayer.controls.play();
            }
        }

        private static Man_hinh_menu instance;

        public static Man_hinh_menu Instance
        {
            get { return instance; }
        }

        private void Button_click()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\DELL G15\Source\Repos\Flappy_bird\Flappy_bird\Resources\Button_click.wav");
            player.Play();
        }

        public void HideForm()
        {
            this.Hide();
        }

        public void UpdateFormMode(bool isFullScreen)
        {
            if (isFullScreen)
            {
                Full_screen();
            }
            else
            {
                Window_screen();
            }
        }


        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public int CapDoGame
        {
            get { return capDoGame; }
            set { capDoGame = value; }
        }
        public int score { get; private set; }

        //Ham nay giup load form man hinh tro choi
        public string SelectedPlayerName { get; private set; }

        private void Load_game(object sender, EventArgs e)
        {
            Button_click();
            wplayer.controls.pause();
            Man_hinh_game man_Hinh_Game = new Man_hinh_game();
            man_Hinh_Game.CapDoGame = capDoGame;
            man_Hinh_Game.PlayerName = SelectedPlayerName; // Truyền tên người chơi đã chọn
            man_Hinh_Game.Show();
            this.Hide();
        }

        //Ham nay giup load form man hinh huong dan
        private void Load_help(object sender, EventArgs e)
        {
            Button_click();
            Huong_dan huong_dan = new Huong_dan(this);
            huong_dan.Show();
            this.Hide();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            if (!isClosing)
            {
                isClosing = true;
                this.Close();
                Environment.Exit(0);
            }
        }

        public void Full_screen()
        {
            pic_close.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pic_close.Location = new Point(this.ClientSize.Width - pic_close.Width, 0);
            panel_background.Anchor = AnchorStyles.None;
            panel_background.Location = new Point((this.ClientSize.Width - panel_background.Width) / 2, (this.ClientSize.Height - panel_background.Height) / 2);
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            wmp_background.Hide();
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        public void Window_screen()
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            Size = initialSize;
            Location = initialLocation;
            wmp_background.Hide();
        }

        private void FillRankCombobox(List<Flappy_bird.Model.tb_rank> list_rank)
        {
            this.cb_player.DataSource = list_rank;
            this.cb_player.DisplayMember = "Player";
            this.cb_player.ValueMember = "ID";
        }

        private void Man_hinh_menu_Load(object sender, EventArgs e)
        {
            if (Setting.IsFullScreen)
            {
                Full_screen();
            }
            else
            {
                Window_screen();
            }
            DB_player context = new DB_player();
            List<Flappy_bird.Model.tb_rank> list_rank = context.tb_ranks.ToList();

            // Lấy danh sách tên người chơi từ cơ sở dữ liệu
            List<string> playerNames = list_rank.Select(rank => rank.Player).ToList();

            // Thêm danh sách tên người chơi vào collection hiện có của ComboBox
            cb_player.Items.AddRange(playerNames.ToArray());
        }

        // hàm này dùng để lưu mức độ trò chơi khi đc người dùng chọn 
        private void cbbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            capDoGame = cbbLevel.SelectedIndex;
        }
    
        private void cb_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_language.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
            Man_hinh_menu_Load(this, null);
        }

        private void bt_setting_Click(object sender, EventArgs e)
        {
            Button_click();
            Setting setting = new Setting(this);
            setting.Show();
        }

        private void Bat_dau_game_bt_MouseHover(object sender, EventArgs e)
        {
            Bat_dau_game_bt.BackColor = Color.Yellow;
        }

        private void Bat_dau_game_bt_MouseLeave(object sender, EventArgs e)
        {
            Bat_dau_game_bt.BackColor = Color.Turquoise;
        }

        private void Huong_dan_bt_MouseHover(object sender, EventArgs e)
        {
            Huong_dan_bt.BackColor = Color.Yellow;
        }

        private void Huong_dan_bt_MouseLeave(object sender, EventArgs e)
        {
            Huong_dan_bt.BackColor = Color.Turquoise;
        }

        private void bt_setting_MouseHover(object sender, EventArgs e)
        {
            bt_setting.BackColor = Color.Yellow;
        }

        private void bt_setting_MouseLeave(object sender, EventArgs e)
        {
            bt_setting.BackColor = Color.Turquoise;
        }

        private void btn_rank_Click(object sender, EventArgs e)
        {
            Rank_form rank=new Rank_form();
            rank.Show();
        }

        private void cb_player_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_player.SelectedItem.ToString()== "Tạo tên người chơi" || cb_player.SelectedItem.ToString()== "Create player name")
            {
                Name_player name=new Name_player();
                name.Show();
            }
            else
            {
                ComboBox comboBox = (ComboBox)sender;
        SelectedPlayerName = comboBox.SelectedItem.ToString();
            }
        }
    }
}
