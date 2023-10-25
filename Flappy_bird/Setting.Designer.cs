namespace Flappy_bird
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.track_bar_volume = new System.Windows.Forms.TrackBar();
            this.cb_screen = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pic_close_setting = new System.Windows.Forms.PictureBox();
            this.btn_sound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.track_bar_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close_setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sound)).BeginInit();
            this.SuspendLayout();
            // 
            // track_bar_volume
            // 
            resources.ApplyResources(this.track_bar_volume, "track_bar_volume");
            this.track_bar_volume.Maximum = 100;
            this.track_bar_volume.Name = "track_bar_volume";
            this.track_bar_volume.Scroll += new System.EventHandler(this.track_bar_volume_Scroll);
            // 
            // cb_screen
            // 
            resources.ApplyResources(this.cb_screen, "cb_screen");
            this.cb_screen.FormattingEnabled = true;
            this.cb_screen.Items.AddRange(new object[] {
            resources.GetString("cb_screen.Items"),
            resources.GetString("cb_screen.Items1")});
            this.cb_screen.Name = "cb_screen";
            this.cb_screen.SelectedIndexChanged += new System.EventHandler(this.cb_screen_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Image = global::Flappy_bird.Properties.Resources.icons8_screen_48;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pic_close_setting
            // 
            resources.ApplyResources(this.pic_close_setting, "pic_close_setting");
            this.pic_close_setting.Image = global::Flappy_bird.Properties.Resources.icons8_close_48;
            this.pic_close_setting.Name = "pic_close_setting";
            this.pic_close_setting.TabStop = false;
            this.pic_close_setting.Click += new System.EventHandler(this.pic_close_setting_Click);
            // 
            // btn_sound
            // 
            resources.ApplyResources(this.btn_sound, "btn_sound");
            this.btn_sound.Image = global::Flappy_bird.Properties.Resources.sound_on;
            this.btn_sound.Name = "btn_sound";
            this.btn_sound.TabStop = false;
            // 
            // Setting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.cb_screen);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pic_close_setting);
            this.Controls.Add(this.track_bar_volume);
            this.Controls.Add(this.btn_sound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.track_bar_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close_setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_sound;
        private System.Windows.Forms.TrackBar track_bar_volume;
        private System.Windows.Forms.PictureBox pic_close_setting;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cb_screen;
    }
}