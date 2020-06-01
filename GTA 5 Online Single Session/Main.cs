using System;
using System.Windows.Forms;

namespace GTA_5_Online_Single_Session {
    public partial class Main : Form {
        Floating floating;
        public Main() {
            InitializeComponent();
            floating = new Floating();

            // Updating location and finish initialize.
            floating.Show();
            floating.Hide();
        }

        private void Main_Load(object sender, EventArgs e) {
            Utils.smoothBorder(this, 10);
            Utils.smoothBorder(sidePanel, 10);
            Utils.smoothBorder(minPanel, minPanel.Width);
            Utils.smoothBorder(exitPanel, minPanel.Width);

            MainAction mainAction = new MainAction(Handle);
            tabPanel.Controls.Add(mainAction);

            Tab mainTab = new Tab(0, 40, Properties.Resources.satellite_solid);
            Tab overlayButton = new Tab(1, 50, Properties.Resources.layer_group_solid);
            Tab settingTab = new Tab(2, 60, Properties.Resources.cog_solid);
            Tab infoTab = new Tab(3, 70, Properties.Resources.info_solid);
            sidePanel.Controls.Add(mainTab);
            sidePanel.Controls.Add(overlayButton);
            sidePanel.Controls.Add(settingTab);
            sidePanel.Controls.Add(infoTab);
        }

        private void exitPanel_Click(object sender, EventArgs e) {
            if (!Settings.applying) {
                Close();
            } else {
                MessageBox.Show(
                    this,
                    "Cannot exit the program while job is in progress. Please try again after applying is done.",
                    "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void minPanel_Click(object sender, EventArgs e) {
            if (Settings.floatingMode) {
                floating.Location = Location;
                Hide();
                floating.Show();
            } else {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void processChecker_Tick(object sender, EventArgs e) {

        }
    }
}
