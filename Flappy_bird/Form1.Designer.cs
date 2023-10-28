namespace Flappy_bird
{
    partial class Man_hinh_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Man_hinh_menu));
            this.Bat_dau_game_bt = new System.Windows.Forms.Button();
            this.Huong_dan_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.bt_setting = new System.Windows.Forms.Button();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.wmp_background = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel_background = new System.Windows.Forms.Panel();
            this.cb_player = new System.Windows.Forms.ComboBox();
            this.lb_player = new System.Windows.Forms.Label();
            this.btn_rank = new System.Windows.Forms.Button();
            this.cb_language = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_background)).BeginInit();
            this.panel_background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bat_dau_game_bt
            // 
            this.Bat_dau_game_bt.BackColor = System.Drawing.Color.Turquoise;
            resources.ApplyResources(this.Bat_dau_game_bt, "Bat_dau_game_bt");
            this.Bat_dau_game_bt.Name = "Bat_dau_game_bt";
            this.Bat_dau_game_bt.UseVisualStyleBackColor = false;
            this.Bat_dau_game_bt.Click += new System.EventHandler(this.Load_game);
            this.Bat_dau_game_bt.MouseLeave += new System.EventHandler(this.Bat_dau_game_bt_MouseLeave);
            this.Bat_dau_game_bt.MouseHover += new System.EventHandler(this.Bat_dau_game_bt_MouseHover);
            // 
            // Huong_dan_bt
            // 
            this.Huong_dan_bt.BackColor = System.Drawing.Color.Turquoise;
            resources.ApplyResources(this.Huong_dan_bt, "Huong_dan_bt");
            this.Huong_dan_bt.Name = "Huong_dan_bt";
            this.Huong_dan_bt.UseVisualStyleBackColor = false;
            this.Huong_dan_bt.Click += new System.EventHandler(this.Load_help);
            this.Huong_dan_bt.MouseLeave += new System.EventHandler(this.Huong_dan_bt_MouseLeave);
            this.Huong_dan_bt.MouseHover += new System.EventHandler(this.Huong_dan_bt_MouseHover);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Name = "label1";
            // 
            // cbbLevel
            // 
            resources.ApplyResources(this.cbbLevel, "cbbLevel");
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Items.AddRange(new object[] {
            resources.GetString("cbbLevel.Items"),
            resources.GetString("cbbLevel.Items1"),
            resources.GetString("cbbLevel.Items2")});
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.SelectedIndexChanged += new System.EventHandler(this.cbbLevel_SelectedIndexChanged);
            // 
            // bt_setting
            // 
            this.bt_setting.BackColor = System.Drawing.Color.Turquoise;
            resources.ApplyResources(this.bt_setting, "bt_setting");
            this.bt_setting.Name = "bt_setting";
            this.bt_setting.UseVisualStyleBackColor = false;
            this.bt_setting.Click += new System.EventHandler(this.bt_setting_Click);
            this.bt_setting.MouseLeave += new System.EventHandler(this.bt_setting_MouseLeave);
            this.bt_setting.MouseHover += new System.EventHandler(this.bt_setting_MouseHover);
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Transparent;
            this.pic_close.Image = global::Flappy_bird.Properties.Resources.icons8_close_48;
            resources.ApplyResources(this.pic_close, "pic_close");
            this.pic_close.Name = "pic_close";
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // wmp_background
            // 
            resources.ApplyResources(this.wmp_background, "wmp_background");
            this.wmp_background.Name = "wmp_background";
            this.wmp_background.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_background.OcxState")));
            // 
            // panel_background
            // 
            this.panel_background.BackColor = System.Drawing.Color.Transparent;
            this.panel_background.Controls.Add(this.cb_player);
            this.panel_background.Controls.Add(this.lb_player);
            this.panel_background.Controls.Add(this.btn_rank);
            this.panel_background.Controls.Add(this.cb_language);
            this.panel_background.Controls.Add(this.cbbLevel);
            this.panel_background.Controls.Add(this.label1);
            this.panel_background.Controls.Add(this.Bat_dau_game_bt);
            this.panel_background.Controls.Add(this.bt_setting);
            this.panel_background.Controls.Add(this.Huong_dan_bt);
            resources.ApplyResources(this.panel_background, "panel_background");
            this.panel_background.Name = "panel_background";
            // 
            // cb_player
            // 
            resources.ApplyResources(this.cb_player, "cb_player");
            this.cb_player.FormattingEnabled = true;
            this.cb_player.Items.AddRange(new object[] {
            resources.GetString("cb_player.Items"),
            resources.GetString("cb_player.Items1")});
            this.cb_player.Name = "cb_player";
            this.cb_player.SelectedIndexChanged += new System.EventHandler(this.cb_player_SelectedIndexChanged);
            // 
            // lb_player
            // 
            resources.ApplyResources(this.lb_player, "lb_player");
            this.lb_player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lb_player.Name = "lb_player";
            // 
            // btn_rank
            // 
            this.btn_rank.BackColor = System.Drawing.Color.Turquoise;
            resources.ApplyResources(this.btn_rank, "btn_rank");
            this.btn_rank.Name = "btn_rank";
            this.btn_rank.UseVisualStyleBackColor = false;
            this.btn_rank.Click += new System.EventHandler(this.btn_rank_Click);
            // 
            // cb_language
            // 
            resources.ApplyResources(this.cb_language, "cb_language");
            this.cb_language.FormattingEnabled = true;
            this.cb_language.Items.AddRange(new object[] {
            resources.GetString("cb_language.Items"),
            resources.GetString("cb_language.Items1")});
            this.cb_language.Name = "cb_language";
            this.cb_language.SelectedIndexChanged += new System.EventHandler(this.cb_language_SelectedIndexChanged);
            // 
            // Man_hinh_menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_bird.Properties.Resources._9MX2;
            this.Controls.Add(this.panel_background);
            this.Controls.Add(this.wmp_background);
            this.Controls.Add(this.pic_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Man_hinh_menu";
            this.Load += new System.EventHandler(this.Man_hinh_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_background)).EndInit();
            this.panel_background.ResumeLayout(false);
            this.panel_background.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bat_dau_game_bt;
        private System.Windows.Forms.Button Huong_dan_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLevel;
        private System.Windows.Forms.Button bt_setting;
        private System.Windows.Forms.PictureBox pic_close;
        private AxWMPLib.AxWindowsMediaPlayer wmp_background;
        private System.Windows.Forms.Panel panel_background;
        private System.Windows.Forms.ComboBox cb_language;
        private System.Windows.Forms.Label lb_player;
        private System.Windows.Forms.Button btn_rank;
        public System.Windows.Forms.ComboBox cb_player;
    }
}

