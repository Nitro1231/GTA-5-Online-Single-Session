using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GTA_5_Online_Single_Session.User_Control {
    public partial class ToggleButton : UserControl {

        private bool isToggled = false;

        [Category("Value"), DefaultValue(false)]
        public bool Value {
            get { return isToggled; }
            set {
                isToggled = value;
                update();
            }
        }

        [Browsable(true)]
        [Category("Action")]
        public event EventHandler OnValueChanged;

        public ToggleButton() {
            InitializeComponent();
        }

        private void ToggleButton_Load(object sender, EventArgs e) {
            update();
        }

        private void ToggleButton_Resize(object sender, EventArgs e) {
            update();
        }

        private void dialPanel_Click(object sender, EventArgs e) {
            isToggled = !isToggled;
            update();
            OnValueChanged?.Invoke(this, e);
        }

        private void update() {
            Size = new Size(Height * 2, Height);
            backPanel.Size = new Size(Width - (Height - 4), Height / 2);
            backPanel.Location = new Point((Width - backPanel.Width) / 2, (Height - backPanel.Height) / 2);
            Utils.smoothBorder(backPanel, backPanel.Height);

            dialPanel.Size = new Size(Height - 4, Height - 4);
            if (isToggled)
                dialPanel.Location = new Point(Width - dialPanel.Width, (Height - dialPanel.Height) / 2);
            else
                dialPanel.Location = new Point(0, (Height - dialPanel.Height) / 2);

            Utils.smoothBorder(dialPanel, Height - 4);
            Refresh();
        }

        private void dialPanel_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, dialPanel.Width, dialPanel.Height);
            Brush b;
            if (isToggled)
                b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(90, 130, 230), Color.FromArgb(55, 210, 220), 65f);
            else
                b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(230, 90, 100), Color.FromArgb(220, 55, 160), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
