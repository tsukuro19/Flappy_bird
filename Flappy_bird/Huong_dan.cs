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
        private Man_hinh_menu menuForm;
        private Size initialSize;
        private Point initialLocation;
        public Huong_dan(Man_hinh_menu formMenu)
        {
            InitializeComponent();
            menuForm = formMenu;
            //Đặt form đến centerscreen khi chuyển form từ menu sang form hướng dẫn 
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            initialSize = this.Size;
            initialLocation = this.Location;
        }

        private void Return_start_menu(object sender, FormClosedEventArgs e)
        {
            menuForm.Show(); // Sử dụng tham chiếu menuForm để hiển thị lại form Man_hinh_menu
            this.Size = menuForm.Size; // Áp dụng kích thước của form Man_hinh_menu cho form Huong_dan
            this.Hide();
        }

        public void Full_screen()
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            // Di chuyển và căn giữa Label
            int labelX = (tutorial_label.Width) / 2;
            int labelY = (tutorial_label.Height - pic_tutorial.Height) / 2;
            tutorial_label.Location = new Point(labelX, labelY);

            // Di chuyển pic_tutorial xuống dưới Label
            int picX = (pic_tutorial.Width) / 2 + labelX;
            int picY = labelY + tutorial_label.Height;
            pic_tutorial.Location = new Point(picX, picY);

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        public void Window_screen()
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            Size = initialSize;
            Location = initialLocation;
        }
        private void Huong_dan_Load(object sender, EventArgs e)
        {
            if (Setting.IsFullScreen)
            {
                Full_screen();
            }
            else
            {
                Window_screen();
            }
        }

        private void pic_back_Click_1(object sender, EventArgs e)
        {
            Return_start_menu(this, new FormClosedEventArgs(CloseReason.None));
        }
    }
}
