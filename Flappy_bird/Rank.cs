using Flappy_bird.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird
{
    public partial class Rank_form : Form
    {
        private List<Flappy_bird.Model.tb_rank> list_rank; // Store the list_rank as a class-level variable
        public Rank_form()
        {
            InitializeComponent();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Rank_form_Load(object sender, EventArgs e)
        {
            try
            {
                // Create a connection object
                using (DB_player context = new DB_player())
                {
                    list_rank = context.tb_ranks.ToList();

                    BindGrid(list_rank);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the rankings: " + ex.Message);
            }
        }

        private void BindGrid(List<Flappy_bird.Model.tb_rank> list_rank)
        {
            dtgv_rank.Rows.Clear();
            foreach (var rank in list_rank)
            {
                int index = dtgv_rank.Rows.Add();
                dtgv_rank.Rows[index].Cells[0].Value = rank.ID;
                dtgv_rank.Rows[index].Cells[1].Value = rank.Player;
                dtgv_rank.Rows[index].Cells[2].Value = rank.Score;
            }
        }

        private void Dell_bt_Click(object sender, EventArgs e)
        {
            if (dtgv_rank.SelectedRows.Count > 0)
            {
                int selectedIndex = dtgv_rank.SelectedRows[0].Index;
                int selectedId = Convert.ToInt32(dtgv_rank.Rows[selectedIndex].Cells[0].Value);

                try
                {
                    using (DB_player context = new DB_player())
                    {
                        var player = context.tb_ranks.FirstOrDefault(r => r.ID == selectedId);
                        if (player != null)
                        {
                            context.tb_ranks.Remove(player);
                            context.SaveChanges();

                            list_rank.Remove(player); // Remove the player from the list_rank
                            BindGrid(list_rank); // Rebind the DataGridView without the deleted player
                            Rank_form_Load(sender,e);
                        }
                    }

                    MessageBox.Show("Player deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting player: " + ex.Message);
                }
            }
        }
    }
}
