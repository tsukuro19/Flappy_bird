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
            this.Nut_Restart = new System.Windows.Forms.PictureBox();
            this.life_1 = new System.Windows.Forms.PictureBox();
            this.life_2 = new System.Windows.Forms.PictureBox();
            this.life_3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nen_dat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ong_tren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ong_duoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nut_Restart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Bird
            // 
            this.pic_Bird.BackColor = System.Drawing.Color.Transparent;
            this.pic_Bird.Image = global::Flappy_bird.Properties.Resources._3933c213d43ed004e381fefdb9ec0605_w200;
            this.pic_Bird.Location = new System.Drawing.Point(179, 250);
            this.pic_Bird.Name = "pic_Bird";
            this.pic_Bird.Size = new System.Drawing.Size(51, 50);
            this.pic_Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Bird.TabIndex = 0;
            this.pic_Bird.TabStop = false;
            // 
            // pic_Nen_dat
            // 
            this.pic_Nen_dat.Image = global::Flappy_bird.Properties.Resources.ground;
            this.pic_Nen_dat.Location = new System.Drawing.Point(-2, 561);
            this.pic_Nen_dat.Name = "pic_Nen_dat";
            this.pic_Nen_dat.Size = new System.Drawing.Size(841, 123);
            this.pic_Nen_dat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Nen_dat.TabIndex = 1;
            this.pic_Nen_dat.TabStop = false;
            // 
            // pic_Ong_tren
            // 
            this.pic_Ong_tren.BackColor = System.Drawing.Color.Transparent;
            this.pic_Ong_tren.Image = global::Flappy_bird.Properties.Resources.pipedown;
            this.pic_Ong_tren.Location = new System.Drawing.Point(646, 0);
            this.pic_Ong_tren.Name = "pic_Ong_tren";
            this.pic_Ong_tren.Size = new System.Drawing.Size(100, 186);
            this.pic_Ong_tren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Ong_tren.TabIndex = 2;
            this.pic_Ong_tren.TabStop = false;
            // 
            // pic_Ong_duoi
            // 
            this.pic_Ong_duoi.BackColor = System.Drawing.Color.Transparent;
            this.pic_Ong_duoi.Image = global::Flappy_bird.Properties.Resources.pipe;
            this.pic_Ong_duoi.Location = new System.Drawing.Point(537, 343);
            this.pic_Ong_duoi.Name = "pic_Ong_duoi";
            this.pic_Ong_duoi.Size = new System.Drawing.Size(100, 223);
            this.pic_Ong_duoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Ong_duoi.TabIndex = 3;
            this.pic_Ong_duoi.TabStop = false;
            // 
            // score_text
            // 
            this.score_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.score_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_text.Location = new System.Drawing.Point(12, 590);
            this.score_text.Name = "score_text";
            this.score_text.Size = new System.Drawing.Size(171, 48);
            this.score_text.TabIndex = 4;
            this.score_text.Text = "Score: 0";
            // 
            // Thoi_gian_cua_ong
            // 
            this.Thoi_gian_cua_ong.Enabled = true;
            this.Thoi_gian_cua_ong.Interval = 20;
            this.Thoi_gian_cua_ong.Tick += new System.EventHandler(this.Game_timer_event);
            // 
            // Nut_Restart
            // 
            this.Nut_Restart.Image = ((System.Drawing.Image)(resources.GetObject("Nut_Restart.Image")));
            this.Nut_Restart.Location = new System.Drawing.Point(321, 170);
            this.Nut_Restart.Name = "Nut_Restart";
            this.Nut_Restart.Size = new System.Drawing.Size(185, 185);
            this.Nut_Restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nut_Restart.TabIndex = 5;
            this.Nut_Restart.TabStop = false;
            this.Nut_Restart.Click += new System.EventHandler(this.RestartClickEvent);
            // 
            // life_1
            // 
            this.life_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.life_1.Image = global::Flappy_bird.Properties.Resources.life;
            this.life_1.Location = new System.Drawing.Point(579, 606);
            this.life_1.Name = "life_1";
            this.life_1.Size = new System.Drawing.Size(32, 32);
            this.life_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.life_1.TabIndex = 6;
            this.life_1.TabStop = false;
            // 
            // life_2
            // 
            this.life_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.life_2.Image = global::Flappy_bird.Properties.Resources.life;
            this.life_2.Location = new System.Drawing.Point(617, 606);
            this.life_2.Name = "life_2";
            this.life_2.Size = new System.Drawing.Size(32, 32);
            this.life_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.life_2.TabIndex = 7;
            this.life_2.TabStop = false;
            // 
            // life_3
            // 
            this.life_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.life_3.Image = global::Flappy_bird.Properties.Resources.life;
            this.life_3.Location = new System.Drawing.Point(655, 606);
            this.life_3.Name = "life_3";
            this.life_3.Size = new System.Drawing.Size(32, 32);
            this.life_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.life_3.TabIndex = 8;
            this.life_3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Flappy_bird.Properties.Resources._3933c213d43ed004e381fefdb9ec0605_w200;
            this.pictureBox1.Location = new System.Drawing.Point(179, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Man_hinh_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_bird.Properties.Resources.pxfuel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 770);
            this.Controls.Add(this.life_3);
            this.Controls.Add(this.life_2);
            this.Controls.Add(this.life_1);
            this.Controls.Add(this.score_text);
            this.Controls.Add(this.Nut_Restart);
            this.Controls.Add(this.pic_Ong_duoi);
            this.Controls.Add(this.pic_Ong_tren);
            this.Controls.Add(this.pic_Nen_dat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic_Bird);
            this.Name = "Man_hinh_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dong_man_hinh_game);
            this.Load += new System.EventHandler(this.Man_hinh_game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nen_dat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ong_tren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ong_duoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nut_Restart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Bird;
        private System.Windows.Forms.PictureBox pic_Nen_dat;
        private System.Windows.Forms.PictureBox pic_Ong_tren;
        private System.Windows.Forms.PictureBox pic_Ong_duoi;
        private System.Windows.Forms.Label score_text;
        private System.Windows.Forms.Timer Thoi_gian_cua_ong;
        private System.Windows.Forms.PictureBox Nut_Restart;
        private System.Windows.Forms.PictureBox life_1;
        private System.Windows.Forms.PictureBox life_2;
        private System.Windows.Forms.PictureBox life_3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}