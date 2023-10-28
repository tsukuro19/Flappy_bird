namespace Flappy_bird
{
    partial class Rank_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rank_form));
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_rank = new System.Windows.Forms.DataGridView();
            this.id_player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.Dell_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_rank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dtgv_rank
            // 
            this.dtgv_rank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_rank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_player,
            this.Player,
            this.Score});
            resources.ApplyResources(this.dtgv_rank, "dtgv_rank");
            this.dtgv_rank.Name = "dtgv_rank";
            this.dtgv_rank.RowTemplate.Height = 24;
            // 
            // id_player
            // 
            resources.ApplyResources(this.id_player, "id_player");
            this.id_player.Name = "id_player";
            // 
            // Player
            // 
            resources.ApplyResources(this.Player, "Player");
            this.Player.Name = "Player";
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Score, "Score");
            this.Score.Name = "Score";
            // 
            // pic_close
            // 
            this.pic_close.Image = global::Flappy_bird.Properties.Resources.icons8_close_48;
            resources.ApplyResources(this.pic_close, "pic_close");
            this.pic_close.Name = "pic_close";
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // Dell_bt
            // 
            this.Dell_bt.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.Dell_bt, "Dell_bt");
            this.Dell_bt.ForeColor = System.Drawing.Color.White;
            this.Dell_bt.Name = "Dell_bt";
            this.Dell_bt.UseVisualStyleBackColor = false;
            this.Dell_bt.Click += new System.EventHandler(this.Dell_bt_Click);
            // 
            // Rank_form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.Controls.Add(this.Dell_bt);
            this.Controls.Add(this.dtgv_rank);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rank_form";
            this.Load += new System.EventHandler(this.Rank_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_rank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.DataGridView dtgv_rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_player;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.Button Dell_bt;
    }
}