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
            this.Bat_dau_game_bt = new System.Windows.Forms.Button();
            this.Huong_dan_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBangXephang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bat_dau_game_bt
            // 
            this.Bat_dau_game_bt.BackColor = System.Drawing.Color.Turquoise;
            this.Bat_dau_game_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bat_dau_game_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bat_dau_game_bt.Location = new System.Drawing.Point(319, 270);
            this.Bat_dau_game_bt.Name = "Bat_dau_game_bt";
            this.Bat_dau_game_bt.Size = new System.Drawing.Size(203, 63);
            this.Bat_dau_game_bt.TabIndex = 0;
            this.Bat_dau_game_bt.Text = "Bắt đầu chơi";
            this.Bat_dau_game_bt.UseVisualStyleBackColor = false;
            this.Bat_dau_game_bt.Click += new System.EventHandler(this.Load_game);
            // 
            // Huong_dan_bt
            // 
            this.Huong_dan_bt.BackColor = System.Drawing.Color.Turquoise;
            this.Huong_dan_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Huong_dan_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Huong_dan_bt.Location = new System.Drawing.Point(319, 369);
            this.Huong_dan_bt.Name = "Huong_dan_bt";
            this.Huong_dan_bt.Size = new System.Drawing.Size(203, 63);
            this.Huong_dan_bt.TabIndex = 1;
            this.Huong_dan_bt.Text = "Hướng dẫn";
            this.Huong_dan_bt.UseVisualStyleBackColor = false;
            this.Huong_dan_bt.Click += new System.EventHandler(this.Load_help);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Level";
            // 
            // cbbLevel
            // 
            this.cbbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Items.AddRange(new object[] {
            "Dễ ",
            "Trung Bình ",
            "Khó"});
            this.cbbLevel.Location = new System.Drawing.Point(381, 174);
            this.cbbLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(108, 26);
            this.cbbLevel.TabIndex = 3;
            this.cbbLevel.SelectedIndexChanged += new System.EventHandler(this.cbbLevel_SelectedIndexChanged);
            // 
            // txtPlayer
            // 
            this.txtPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer.Location = new System.Drawing.Point(354, 214);
            this.txtPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayer.Multiline = true;
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(170, 32);
            this.txtPlayer.TabIndex = 5;
            this.txtPlayer.TextChanged += new System.EventHandler(this.txtPlayer_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Người Chơi";
            // 
            // btnBangXephang
            // 
            this.btnBangXephang.BackColor = System.Drawing.Color.Turquoise;
            this.btnBangXephang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBangXephang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangXephang.Location = new System.Drawing.Point(321, 456);
            this.btnBangXephang.Name = "btnBangXephang";
            this.btnBangXephang.Size = new System.Drawing.Size(203, 63);
            this.btnBangXephang.TabIndex = 7;
            this.btnBangXephang.Text = "Bảng xếp hạng";
            this.btnBangXephang.UseVisualStyleBackColor = false;
            this.btnBangXephang.Click += new System.EventHandler(this.btnBangXephang_Click);
            // 
            // Man_hinh_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_bird.Properties.Resources._9MX2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 770);
            this.Controls.Add(this.btnBangXephang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.cbbLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Huong_dan_bt);
            this.Controls.Add(this.Bat_dau_game_bt);
            this.Name = "Man_hinh_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dong_man_hinh_game);
            this.Load += new System.EventHandler(this.Man_hinh_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bat_dau_game_bt;
        private System.Windows.Forms.Button Huong_dan_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLevel;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBangXephang;
    }
}

