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
        public partial class Man_hinh_menu : Form
        {
            // biến để lưu cấp độ
            private int capDoGame;
            // Biến để lưu tên
            private string playerName;
            // biến này tạo ra để đếm người chơi nếu không đặt tên
            private int player = 1;

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

        public Man_hinh_menu()
            {
                InitializeComponent();
                //đặt mặc định cho cbbLevel là dễ 
                cbbLevel.SelectedIndex = 0;
                capDoGame = 0; // Mặc định là dễ (0: dễ, 1: trung bình, 2: khó)
            }

            //Ham nay giup load form man hinh tro choi
            private void Load_game(object sender, EventArgs e)
            {

                Man_hinh_game man_Hinh_Game = new Man_hinh_game();
                man_Hinh_Game.PlayerName = playerName;
                man_Hinh_Game.CapDoGame = capDoGame;
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
            // hàm này dùng để lưu mức độ trò chơi khi đc người dùng chọn 
            private void cbbLevel_SelectedIndexChanged(object sender, EventArgs e)
            {
                capDoGame = cbbLevel.SelectedIndex;
            }
            //Hàm này dùng để đặt tên
            private void txtPlayer_TextChanged(object sender, EventArgs e)
            {
                if (txtPlayer.Text == " ")
                {
                    playerName = "Người chơi " + player;
                    player++;
                
                }
                else
                {
                    playerName = txtPlayer.Text;
                }
            }

        private void btnBangXephang_Click(object sender, EventArgs e)
        {
            List<string> players = new List<string>();
            players.Add(playerName + ": " + score.ToString());

            

            players.Sort((x, y) => {
                int scoreX = int.Parse(x.Split(':')[1].Trim());
                int scoreY = int.Parse(y.Split(':')[1].Trim());
                return scoreY.CompareTo(scoreX);
            });

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----- RANKINGS -----");
            for (int i = 0; i < players.Count; i++)
            {
                sb.AppendLine((i + 1) + ". " + players[i]);
            }

            MessageBox.Show(sb.ToString());
        }
    }
    }
