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
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nen_dat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ong_tren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ong_duoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nut_Restart)).BeginInit();
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
            this.pic_Nen_dat.Location = new System.Drawing.Point(-2, 614);
            this.pic_Nen_dat.Name = "pic_Nen_dat";
            this.pic_Nen_dat.Size = new System.Drawing.Size(841, 70);
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
            this.pic_Ong_duoi.Location = new System.Drawing.Point(484, 393);
            this.pic_Ong_duoi.Name = "pic_Ong_duoi";
            this.pic_Ong_duoi.Size = new System.Drawing.Size(100, 223);
            this.pic_Ong_duoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Ong_duoi.TabIndex = 3;
            this.pic_Ong_duoi.TabStop = false;
            // 
            // score_text
            // 
            this.score_text.BackColor = System.Drawing.Color.Transparent;
            this.score_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_text.Location = new System.Drawing.Point(12, 9);
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
            // Man_hinh_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_bird.Properties.Resources.pxfuel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 770);
            this.Controls.Add(this.Nut_Restart);
            this.Controls.Add(this.score_text);
            this.Controls.Add(this.pic_Ong_duoi);
            this.Controls.Add(this.pic_Ong_tren);
            this.Controls.Add(this.pic_Nen_dat);
            this.Controls.Add(this.pic_Bird);
            this.Name = "Man_hinh_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dong_man_hinh_game);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nen_dat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ong_tren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ong_duoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nut_Restart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Bird;
        private System.Windows.Forms.PictureBox pic_Nen_dat;
        private System.Windows.Forms.PictureBox pic_Ong_tren;
        private System.Windows.Forms.PictureBox pic_Ong_duoi;
        private System.Windows.Forms.Label score_text;
        private System.Windows.Forms.Timer Thoi_gian_cua_ong;
        private System.Windows.Forms.PictureBox Nut_Restart;
    }
}