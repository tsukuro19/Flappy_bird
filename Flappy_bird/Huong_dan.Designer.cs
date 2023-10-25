namespace Flappy_bird
{
    partial class Huong_dan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Huong_dan));
            this.tutorial_label = new System.Windows.Forms.Label();
            this.pic_tutorial = new System.Windows.Forms.PictureBox();
            this.pic_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tutorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorial_label
            // 
            resources.ApplyResources(this.tutorial_label, "tutorial_label");
            this.tutorial_label.BackColor = System.Drawing.Color.Transparent;
            this.tutorial_label.Name = "tutorial_label";
            // 
            // pic_tutorial
            // 
            resources.ApplyResources(this.pic_tutorial, "pic_tutorial");
            this.pic_tutorial.BackColor = System.Drawing.Color.Transparent;
            this.pic_tutorial.Image = global::Flappy_bird.Properties.Resources._3933c213d43ed004e381fefdb9ec0605_w200;
            this.pic_tutorial.Name = "pic_tutorial";
            this.pic_tutorial.TabStop = false;
            // 
            // pic_back
            // 
            resources.ApplyResources(this.pic_back, "pic_back");
            this.pic_back.BackColor = System.Drawing.Color.Transparent;
            this.pic_back.Image = global::Flappy_bird.Properties.Resources.icons8_back_48;
            this.pic_back.Name = "pic_back";
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click_1);
            // 
            // Huong_dan
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_bird.Properties.Resources.pxfuel;
            this.Controls.Add(this.pic_back);
            this.Controls.Add(this.pic_tutorial);
            this.Controls.Add(this.tutorial_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Huong_dan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Return_start_menu);
            this.Load += new System.EventHandler(this.Huong_dan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_tutorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tutorial_label;
        private System.Windows.Forms.PictureBox pic_tutorial;
        private System.Windows.Forms.PictureBox pic_back;
    }
}