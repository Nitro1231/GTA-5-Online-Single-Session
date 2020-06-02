using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace GTA_5_Online_Single_Session {
    public partial class MainAction : UserControl {
        // Thanks to https://stackoverflow.com/questions/71257/suspend-process-in-c-sharp

        [Flags]
        public enum ThreadAccess : int {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool CloseHandle(IntPtr handle);

        bool gameCaptured = false;
        int count = 0;

        public MainAction() {
            InitializeComponent();
            SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);
        }

        private void MainAction_Load(object sender, EventArgs e) {
            try {
                Settings.onGameStatusUpdate += new EventHandler(checkGameStatus);
            } catch {
                throw;
            }

            action.Location = new Point((Width - action.Width) / 2, (Height - action.Height) / 2);
            statusDisplay1.Location = new Point(Width - (18 * 3 + 12), 2);
            action.BackColor = Color.Transparent;
            titleText.BackColor = Color.Transparent;
            //action.Text = "Click Me!";
        }

        private void action_Click(object sender, EventArgs e) {
            if (!Settings.applying)
                updateUI(suspendProcess(true));
        }

        private async void updateUI(bool successes) {
            if (successes) {
                Settings.applying = true;
                action.Text = "Applying...";
                while (count < Width) {
                    count += Settings.speed;
                    Refresh();
                    await Task.Delay(1000 * Settings.time * Settings.speed / Width);
                }
                suspendProcess(false);
                action.Text = "Done!";
                Refresh();
                count = 0;
                await Task.Delay(1000);
                action.Text = "Click Me!";
                Refresh();
                Settings.applying = false;
                return;
            } else {
                MessageBox.Show(
                    this,
                    "Cannot find GTA5 process! Please start the GAT5 and join the public session first, then try again.",
                    "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private bool suspendProcess(bool status) {
            Settings.updateGameStatus();
            if (!Settings.isGameRunning)
                return false;

            if (status) {
                foreach (ProcessThread pT in Settings.gameProcess.Threads) {
                    IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);
                    if (pOpenThread == IntPtr.Zero)
                        continue;
                    SuspendThread(pOpenThread);
                    CloseHandle(pOpenThread);
                }
            } else {
                if (Settings.gameProcess.ProcessName == string.Empty)
                    return true;
                foreach (ProcessThread pT in Settings.gameProcess.Threads) {
                    IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);
                    if (pOpenThread == IntPtr.Zero)
                        continue;
                    var suspendCount = 0;
                    do {
                        suspendCount = ResumeThread(pOpenThread);
                    } while (suspendCount > 0);
                    CloseHandle(pOpenThread);
                }
            }
            return true;
        }

        private void MainAction_MouseMove(object sender, MouseEventArgs e) {
            Utils.mouseMove(Program.main.Handle);
        }

        private void action_SizeChanged(object sender, EventArgs e) {
            action.Location = new Point((Width - action.Width) / 2, (Height - action.Height) / 2);
        }

        void checkGameStatus(object sender, EventArgs e) {
            if (!Settings.isGameRunning) {
                gameCaptured = false;
                action.Text = "Waiting for GTA5";
            } else {
                if (!gameCaptured) {
                    gameCaptured = true;
                    action.Text = "Click Me!";
                }
            }
        }

        private void MainAction_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, count, Height);
            if (count > 0) {
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(90, 130, 230), Color.FromArgb(55, 210, 220), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
        }
    }
}
