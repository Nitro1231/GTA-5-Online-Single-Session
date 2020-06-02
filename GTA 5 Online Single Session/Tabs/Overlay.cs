using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GTA_5_Online_Single_Session.Tabs {
    public partial class Overlay : UserControl {

        #region Get window position
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        public struct Rect {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }
        #endregion

        Point loc;

        public Overlay() {
            InitializeComponent();
        }
        private void Overlay_Load(object sender, EventArgs e) {
            statusDisplay1.Location = new Point(Width - (18 * 3 + 12), 2);
        }

        private void Overlay_MouseMove(object sender, MouseEventArgs e) {
            Utils.mouseMove(Program.main.Handle);
        }

        private void flatButton1_ButtonClick(object sender, EventArgs e) {
            if (Status.overlay) { // Stop Overlay
                if (Status.isGameRunning) {
                    flatButton1.LabelText = "Start Overlay";
                    Status.overlay = false;
                    Program.main.TopMost = true;
                    Program.main.Opacity = 1;
                    Program.main.Location = loc;
                } else {
                    MessageBox.Show(
                    this,
                    "Cannot find GTA5 process! Please start the GAT5 and join the public session first, then try again.",
                    "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            } else {
                flatButton1.LabelText = "End Overlay";
                Status.overlay = true;
                Program.main.TopMost = true;
                Program.main.Opacity = 0.8;
                loc = Program.main.Location;
                Rect gameLocation = new Rect();
                GetWindowRect(Status.gameProcess.Handle, ref gameLocation);
                Program.main.Location = new Point(gameLocation.Left + 20, gameLocation.Top + 20);
            }
        }
    }
}
