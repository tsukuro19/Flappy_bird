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
    public partial class Huong_dan : Form
    {
        public Huong_dan()
        {
            InitializeComponent();
        }

        private void Return_start_menu(object sender, FormClosedEventArgs e)
        {
            Man_hinh_menu man_hinh_menu=new Man_hinh_menu();
            man_hinh_menu.Show();
            this.Hide();
        }

        private void Huong_dan_Load(object sender, EventArgs e)
        {
            Console.Write("abc");
        }
    }
}
