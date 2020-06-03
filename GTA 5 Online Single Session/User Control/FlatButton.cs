using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GTA_5_Online_Single_Session.User_Control {
    public partial class FlatButton : UserControl {

        int round = 0;

        public FlatButton() {
            InitializeComponent();
            textLabel.BackColor = Color.Transparent;
        }

        [Category("Text"), Description("text")]
        public string LabelText {
            get { return textLabel.Text; }
            set { textLabel.Text = value; }
        }

        [Category("Round"), Description("Button Round")]
        public int ButtonRound {
            get { return round; }
            set {
                if (AutoRound)
                    round = Height;
                else
                    round = value;
                Utils.smoothBorder(this, round);
            }
        }

        [Category("Auto Round"), Description("Applying Button Round Automatically")]
        public bool AutoRound { get; set; } = false;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;

        private void textLabel_Click(object sender, EventArgs e) {
            ButtonClick?.Invoke(this, e);
        }

        private void FlatButton_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(90, 130, 230), Color.FromArgb(55, 210, 220), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void FlatButton_SizeChanged(object sender, EventArgs e) {
            if(AutoRound)
                Utils.smoothBorder(this, Height);
        }
    }
}
