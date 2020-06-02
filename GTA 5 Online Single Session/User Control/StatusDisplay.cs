using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTA_5_Online_Single_Session.User_Control {
    public partial class StatusDisplay : UserControl {
        public StatusDisplay() {
            InitializeComponent();
        }

        private void StatusDisplay_Load(object sender, EventArgs e) {
            BackColor = Color.Transparent;
            try {
                Settings.onGameStatusUpdate += new EventHandler(updateDisplay);
            } catch {
                throw;
            }
        }

        void updateDisplay(object sender, EventArgs e) {
            if (!Settings.applying) {
                if (Settings.isGameRunning)
                    statusPic.Image = Properties.Resources.link_solid;
                else
                    statusPic.Image = Properties.Resources.unlink_solid;
            }
        }

        private void statusPic_MouseMove(object sender, MouseEventArgs e) {
            Utils.mouseMove(Program.main.Handle);
        }
    }
}
