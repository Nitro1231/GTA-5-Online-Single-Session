using GTA_5_Online_Single_Session.Tabs;
using System;
using System.Windows.Forms;

namespace GTA_5_Online_Single_Session {
    public partial class Main : Form {

        Floating floating = new Floating();
        MainAction mainAction = new MainAction();
        Overlay overlay = new Overlay();
        SettingTab setting = new SettingTab();

        Tab mainTab = new Tab(0, 40, Properties.Resources.satellite_solid);
        Tab overlayButton = new Tab(1, 50, Properties.Resources.layer_group_solid);
        Tab settingTab = new Tab(2, 60, Properties.Resources.cog_solid);
        Tab infoTab = new Tab(3, 70, Properties.Resources.info_solid);

        public Main() {
            InitializeComponent();

            // Updating location and finish initialize.
            floating.Show();
            floating.Hide();
        }

        private void Main_Load(object sender, EventArgs e) {
            Utils.smoothBorder(this, 10);
            Utils.smoothBorder(sidePanel, 10);
            Utils.smoothBorder(minPanel, minPanel.Width);
            Utils.smoothBorder(exitPanel, minPanel.Width);

            tabPanel.Controls.Add(mainAction);
            tabPanel.Controls.Add(overlay);
            tabPanel.Controls.Add(setting);

            tabClicked(null, null);

            sidePanel.Controls.Add(mainTab);
            sidePanel.Controls.Add(overlayButton);
            sidePanel.Controls.Add(settingTab);
            sidePanel.Controls.Add(infoTab);
            mainTab.TabClick += new EventHandler(tabClicked);
            overlayButton.TabClick += new EventHandler(tabClicked);
            settingTab.TabClick += new EventHandler(tabClicked);
            infoTab.TabClick += new EventHandler(tabClicked);

            ControlTest ct = new ControlTest();
            ct.Show();
        }

        void tabClicked(object sender, EventArgs e) {
            mainTab.select(false);
            overlayButton.select(false);
            settingTab.select(false);
            infoTab.select(false);
            mainAction.Visible = false;
            overlay.Visible = false;
            setting.Visible = false;

            switch (Status.tabIndex) {
                case 0:
                    mainTab.select(true);
                    mainAction.Visible = true;
                    break;
                case 1:
                    overlayButton.select(true);
                    overlay.Visible = true;
                    break;
                case 2:
                    settingTab.select(true);
                    setting.Visible = true;
                    break;
                case 3:
                    infoTab.select(true);
                    break;
            }
        }

        private void exitPanel_Click(object sender, EventArgs e) {
            if (!Status.applying) {
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
            if (Settings.floatingMode || Status.overlay) {
                floating.Location = Location;
                Hide();
                floating.Show();
            } else {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void processChecker_Tick(object sender, EventArgs e) {
            Status.updateGameStatus();
        }
    }
}
