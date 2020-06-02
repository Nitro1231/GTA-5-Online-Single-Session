using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GTA_5_Online_Single_Session {
    public partial class Tab : UserControl {
        
        private int index;
        private int color;
        public bool selected = false;
        private Color selectedColor = Color.FromArgb(26, 188, 156);

        public Tab(int index, int color, Image img) {
            InitializeComponent();
            this.index = index;
            this.color = color;
            BackColor = Color.FromArgb(color, color, color);
            picBox.Image = img;
        }

        public void select(bool selected) {
            this.selected = selected;
            if (selected)
                BackColor = selectedColor;
            else
                BackColor = Color.FromArgb(color, color, color);
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler TabClick;

        private void picBox_Click(object sender, EventArgs e) {
            Status.tabIndex = index;
            TabClick?.Invoke(this, e);
        }
    }
}
