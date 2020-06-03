using System;
using System.Windows.Forms;

namespace GTA_5_Online_Single_Session.Tabs {
    public partial class SettingTab : UserControl {
        public SettingTab() {
            InitializeComponent();
            SettingTab_VisibleChanged(null, null);
        }

        private void onSettingChanged(object sender, EventArgs e) {
            Settings.time = trackBar1.CurrentValue;
            Settings.floatingMode = toggleButton1.Value;
            Settings.saveSetting();
        }

        private void SettingTab_VisibleChanged(object sender, EventArgs e) {
            trackBar1.CurrentValue = Settings.time;
            toggleButton1.Value = Settings.floatingMode;
        }

        private void SettingTab_MouseMove(object sender, MouseEventArgs e) {
            Utils.mouseMove(Program.main.Handle);
        }
    }
}
