﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GTA_5_Online_Single_Session.User_Control {
    public partial class TrackBar : UserControl {

        [Category("Min Value")]
        public int min { get; set; } = 0;

        [Category("Max Value")]
        public int max { get; set; } = 100;

        [Category("Value")]
        public int cValue { get; set; } = 50;

        [Category("Thickness")]
        public int thickness { get; set; } = 6;

        [Category("Dial Size")]
        public int dialSize { get; set; } = 26;

        [Category("Display Label")]
        public bool labelDisplay { get; set; } = false;

        private Point MouseDownLocation;

        public TrackBar() {
            InitializeComponent();
            displayLabel.BackColor = Color.Transparent;
        }

        private void TrackBar_Load(object sender, EventArgs e) {
            displayLabel.Text = cValue.ToString();
            update();
        }

        private void TrackBar_Resize(object sender, EventArgs e) {
            update();
        }

        private void update() {
            displayLabel.Visible = labelDisplay;

            backPanel.Size = new Size(Width - dialSize - 4, thickness);
            backPanel.Location = new Point((Width - backPanel.Width) / 2, (Height - backPanel.Height) / 2);
            Utils.smoothBorder(backPanel, backPanel.Height);

            dialPanel.Size = new Size(dialSize, dialSize);
            dialPanel.Location = new Point(backPanel.Left + (int)(backPanel.Width / (double)(max - min) * (cValue - min)) - dialSize / 2, (Height - dialPanel.Height) / 2);
            Utils.smoothBorder(dialPanel, dialSize);
        }

        private void dialPanel_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, dialPanel.Width, dialPanel.Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(90, 130, 230), Color.FromArgb(55, 210, 220), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void dialPanel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
                MouseDownLocation = e.Location;
        }

        private void dialPanel_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
                dialPanel.Left += (e.X - MouseDownLocation.X);
        }

        private void dialPanel_MouseUp(object sender, MouseEventArgs e) {
            if (dialPanel.Left > Width - dialSize)
                dialPanel.Left = Width - dialSize;
            else if (dialPanel.Left < dialSize / 2)
                dialPanel.Left = 0;
            updateValue();
        }

        private void updateValue() {
            cValue = (int)((dialPanel.Left + (dialSize / 2) - backPanel.Left) / (double)backPanel.Width * (max - min)) + min;
            displayLabel.Text = cValue.ToString();
        }
    }
}