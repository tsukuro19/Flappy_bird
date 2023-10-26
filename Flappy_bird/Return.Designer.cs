namespace Flappy_bird
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_score = new System.Windows.Forms.Label();
            this.lb_high_score = new System.Windows.Forms.Label();
            this.pic_home = new System.Windows.Forms.PictureBox();
            this.pic_replay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_replay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lb_score
            // 
            resources.ApplyResources(this.lb_score, "lb_score");
            this.lb_score.Name = "lb_score";
            // 
            // lb_high_score
            // 
            resources.ApplyResources(this.lb_high_score, "lb_high_score");
            this.lb_high_score.Name = "lb_high_score";
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
            // Return
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.Controls.Add(this.pic_home);
            this.Controls.Add(this.pic_replay);
            this.Controls.Add(this.lb_high_score);
            this.Controls.Add(this.lb_score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return";
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_replay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_score;
        private System.Windows.Forms.Label lb_high_score;
        private System.Windows.Forms.PictureBox pic_replay;
        private System.Windows.Forms.PictureBox pic_home;
    }
}