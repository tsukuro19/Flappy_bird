using Flappy_bird.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird
{
    public partial class Name_player : Form
    {
        public Name_player()
        {
            InitializeComponent();
            
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Save_bt_Click(object sender, EventArgs e)
        {
            string player_name = txt_name.Text;
            try
            {
                using (DB_player context = new DB_player()) // Use "using" statement for proper disposal
                {
                    int currentId = context.tb_ranks.Count(); // Get the current count of players and add 1 for the next ID
                    context.tb_ranks.Add(new Flappy_bird.Model.tb_rank
                    {
                        ID = currentId,
                        Player = player_name,
                        Score = 0
                    });
                    context.SaveChanges();
                    this.Hide();
                }

                MessageBox.Show("Player name saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving player name: " + ex.Message);
            }
        }
    }
}
