namespace Flappy_bird
{
    partial class Man_hinh_game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Man_hinh_game));
            this.pic_Bird = new System.Windows.Forms.PictureBox();
            this.pic_Nen_dat = new System.Windows.Forms.PictureBox();
            this.pic_Ong_tren = new System.Windows.Forms.PictureBox();
            this.pic_Ong_duoi = new System.Windows.Forms.PictureBox();
            this.score_text = new System.Windows.Forms.Label();
            this.Thoi_gian_cua_ong = new System.Windows.Forms.Timer(this.components);
            this.life_1 = new System.Windows.Forms.PictureBox();
            this.life_2 = new System.Windows.Forms.PictureBox();
            this.life_3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_enemy = new System.Windows.Forms.PictureBox();
            this.Game_lose = new System.Windows.Forms.GroupBox();
            this.pic_home = new System.Windows.Forms.PictureBox();
            this.pic_replay = new System.Windows.Forms.PictureBox();
            this.lb_high_score_lose = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_score_lose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_high_score = new System.Windows.Forms.Label();
            this.label_high_score_store = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nen_dat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ong_tren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ong_duoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_enemy)).BeginInit();
            this.Game_lose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_replay)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Bird
            // 
            this.pic_Bird.BackColor = System.Drawing.Color.Transparent;
            this.pic_Bird.Image = global::Flappy_bird.Properties.Resources._3933c213d43ed004e381fefdb9ec0605_w200;
            resources.ApplyResources(this.pic_Bird, "pic_Bird");
            this.pic_Bird.Name = "pic_Bird";
            this.pic_Bird.TabStop = false;
            // 
            // pic_Nen_dat
            // 
            resources.ApplyResources(this.pic_Nen_dat, "pic_Nen_dat");
            this.pic_Nen_dat.Image = global::Flappy_bird.Properties.Resources.ground;
            this.pic_Nen_dat.Name = "pic_Nen_dat";
            this.pic_Nen_dat.TabStop = false;
            // 
            // pic_Ong_tren
            // 
            resources.ApplyResources(this.pic_Ong_tren, "pic_Ong_tren");
            this.pic_Ong_tren.BackColor = System.Drawing.Color.Transparent;
            this.pic_Ong_tren.Image = global::Flappy_bird.Properties.Resources.pipedown;
            this.pic_Ong_tren.Name = "pic_Ong_tren";
            this.pic_Ong_tren.TabStop = false;
            // 
            // pic_Ong_duoi
            // 
            resources.ApplyResources(this.pic_Ong_duoi, "pic_Ong_duoi");
            this.pic_Ong_duoi.BackColor = System.Drawing.Color.Transparent;
            this.pic_Ong_duoi.Image = global::Flappy_bird.Properties.Resources.pipe;
            this.pic_Ong_duoi.Name = "pic_Ong_duoi";
            this.pic_Ong_duoi.TabStop = false;
            // 
            // score_text
            // 
            resources.ApplyResources(this.score_text, "score_text");
            this.score_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.score_text.Name = "score_text";
            // 
            // Thoi_gian_cua_ong
            // 
            this.Thoi_gian_cua_ong.Enabled = true;
            this.Thoi_gian_cua_ong.Interval = 20;
            this.Thoi_gian_cua_ong.Tick += new System.EventHandler(this.Game_timer_event);
            // 
            // life_1
            // 
            this.life_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.life_1.Image = global::Flappy_bird.Properties.Resources.life;
            resources.ApplyResources(this.life_1, "life_1");
            this.life_1.Name = "life_1";
            this.life_1.TabStop = false;
            // 
            // life_2
            // 
            this.life_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.life_2.Image = global::Flappy_bird.Properties.Resources.life;
            resources.ApplyResources(this.life_2, "life_2");
            this.life_2.Name = "life_2";
            this.life_2.TabStop = false;
            // 
            // life_3
            // 
            this.life_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.life_3.Image = global::Flappy_bird.Properties.Resources.life;
            resources.ApplyResources(this.life_3, "life_3");
            this.life_3.Name = "life_3";
            this.life_3.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.life_1);
            this.panel1.Controls.Add(this.life_3);
            this.panel1.Controls.Add(this.life_2);
            this.panel1.Name = "panel1";
            // 
            // pic_enemy
            // 
            this.pic_enemy.BackColor = System.Drawing.Color.Transparent;
            this.pic_enemy.Image = global::Flappy_bird.Properties.Resources.ezgif_4_dae19659ba;
            resources.ApplyResources(this.pic_enemy, "pic_enemy");
            this.pic_enemy.Name = "pic_enemy";
            this.pic_enemy.TabStop = false;
            // 
            // Game_lose
            // 
            resources.ApplyResources(this.Game_lose, "Game_lose");
            this.Game_lose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.Game_lose.Controls.Add(this.pic_home);
            this.Game_lose.Controls.Add(this.pic_replay);
            this.Game_lose.Controls.Add(this.lb_high_score_lose);
            this.Game_lose.Controls.Add(this.label3);
            this.Game_lose.Controls.Add(this.lb_score_lose);
            this.Game_lose.Controls.Add(this.label2);
            this.Game_lose.Controls.Add(this.label1);
            this.Game_lose.Name = "Game_lose";
            this.Game_lose.TabStop = false;
            // 
            // pic_home
            // 
            this.pic_home.Image = global::Flappy_bird.Properties.Resources.icons8_home_96;
            resources.ApplyResources(this.pic_home, "pic_home");
            this.pic_home.Name = "pic_home";
            this.pic_home.TabStop = false;
            this.pic_home.Click += new System.EventHandler(this.pic_home_Click);
            // 
            // pic_replay
            // 
            this.pic_replay.Image = global::Flappy_bird.Properties.Resources.icons8_restart_96;
            resources.ApplyResources(this.pic_replay, "pic_replay");
            this.pic_replay.Name = "pic_replay";
            this.pic_replay.TabStop = false;
            this.pic_replay.Click += new System.EventHandler(this.pic_replay_Click);
            // 
            // lb_high_score_lose
            // 
            resources.ApplyResources(this.lb_high_score_lose, "lb_high_score_lose");
            this.lb_high_score_lose.Name = "lb_high_score_lose";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lb_score_lose
            // 
            resources.ApplyResources(this.lb_score_lose, "lb_score_lose");
            this.lb_score_lose.Name = "lb_score_lose";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lb_high_score
            // 
            resources.ApplyResources(this.lb_high_score, "lb_high_score");
            this.lb_high_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.lb_high_score.Name = "lb_high_score";
            // 
            // label_high_score_store
            // 
            resources.ApplyResources(this.label_high_score_store, "label_high_score_store");
            this.label_high_score_store.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.label_high_score_store.Name = "label_high_score_store";
            // 
            // Man_hinh_game
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_bird.Properties.Resources.pxfuel;
            this.Controls.Add(this.label_high_score_store);
            this.Controls.Add(this.lb_high_score);
            this.Controls.Add(this.Game_lose);
            this.Controls.Add(this.pic_enemy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.score_text);
            this.Controls.Add(this.pic_Ong_duoi);
            this.Controls.Add(this.pic_Ong_tren);
            this.Controls.Add(this.pic_Nen_dat);
            this.Controls.Add(this.pic_Bird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Man_hinh_game";
            this.Load += new System.EventHandler(this.Man_hinh_game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nen_dat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ong_tren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ong_duoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_enemy)).EndInit();
            this.Game_lose.ResumeLayout(false);
            this.Game_lose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_replay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Bird;
        private System.Windows.Forms.PictureBox pic_Nen_dat;
        private System.Windows.Forms.PictureBox pic_Ong_tren;
        private System.Windows.Forms.PictureBox pic_Ong_duoi;
        private System.Windows.Forms.Label score_text;
        private System.Windows.Forms.Timer Thoi_gian_cua_ong;
        private System.Windows.Forms.PictureBox life_1;
        private System.Windows.Forms.PictureBox life_2;
        private System.Windows.Forms.PictureBox life_3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_enemy;
        private System.Windows.Forms.GroupBox Game_lose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_score_lose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_high_score_lose;
        private System.Windows.Forms.PictureBox pic_replay;
        private System.Windows.Forms.PictureBox pic_home;
        private System.Windows.Forms.Label lb_high_score;
        private System.Windows.Forms.Label label_high_score_store;
    }
}