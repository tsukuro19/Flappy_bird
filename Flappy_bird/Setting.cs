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
    public partial class Setting : Form
    {
        private Man_hinh_menu menuForm;
        public Setting(Man_hinh_menu formMenu)
        {
            InitializeComponent();
            menuForm = formMenu;
        }

        public static bool IsFullScreen { get; private set; }
        public static bool IsLanguage { get; private set; }

        private void pic_close_setting_Click(object sender, EventArgs e)
        {
            menuForm.BringToFront();
            this.Hide();
        }

        private void cb_screen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_screen.SelectedIndex == 0)
            {
                Setting.IsFullScreen = false;
            }
            else if (cb_screen.SelectedIndex == 1)
            {
                Setting.IsFullScreen = true;
            }

            menuForm.UpdateFormMode(Setting.IsFullScreen);
        }

        private void track_bar_volume_Scroll(object sender, EventArgs e)
        {
            Man_hinh_menu.wplayer.controls.play();
            btn_sound.Image = Properties.Resources.sound_on;
            Man_hinh_menu.wplayer.settings.volume = track_bar_volume.Value;
            if (track_bar_volume.Value == 0)
            {
                btn_sound.Image = Properties.Resources.sound_off;
            }
        }
    }
}
