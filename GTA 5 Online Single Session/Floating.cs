using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GTA_5_Online_Single_Session {
    public partial class Floating : Form {
        public Floating() {
            InitializeComponent();
        }

        private void Floating_Load(object sender, EventArgs e) {
            Size = new Size(70, 70);
            floatingPic.Location = new Point((Width - floatingPic.Width) / 2, (Height - floatingPic.Height) / 2);
            floatingPic.BackColor = Color.Transparent;
            Utils.smoothBorder(this, Width);
        }

        private void Floating_DoubleClick(object sender, EventArgs e) {
            Hide();
            Program.main.Location = Location;
            Program.main.Show();
        }

        private void Floating_MouseMove(object sender, MouseEventArgs e) {
            Utils.mouseMove(Handle);
        }

        private void Floating_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(90, 130, 230), Color.FromArgb(55, 210, 220), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
