using System.Drawing;
using System.Windows.Forms;

namespace GTA_5_Online_Single_Session {
    public partial class Tab : UserControl {
        public int index;
        int color;
        public Tab(int index, int color, Image img) {
            InitializeComponent();
            this.index = index;
            this.color = color;
            BackColor = Color.FromArgb(color, color, color);
            picBox.Image = img;
        }
    }
}
