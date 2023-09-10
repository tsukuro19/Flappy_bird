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
            this.SuspendLayout();
            // 
            // Bat_dau_game_bt
            // 
            this.Bat_dau_game_bt.BackColor = System.Drawing.Color.Turquoise;
            this.Bat_dau_game_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bat_dau_game_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bat_dau_game_bt.Location = new System.Drawing.Point(319, 244);
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
            this.Huong_dan_bt.Location = new System.Drawing.Point(319, 403);
            this.Huong_dan_bt.Name = "Huong_dan_bt";
            this.Huong_dan_bt.Size = new System.Drawing.Size(203, 63);
            this.Huong_dan_bt.TabIndex = 1;
            this.Huong_dan_bt.Text = "Hướng dẫn";
            this.Huong_dan_bt.UseVisualStyleBackColor = false;
            this.Huong_dan_bt.Click += new System.EventHandler(this.Load_help);
            // 
            // Man_hinh_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_bird.Properties.Resources._9MX2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 770);
            this.Controls.Add(this.Huong_dan_bt);
            this.Controls.Add(this.Bat_dau_game_bt);
            this.Name = "Man_hinh_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dong_man_hinh_game);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bat_dau_game_bt;
        private System.Windows.Forms.Button Huong_dan_bt;
    }
}

