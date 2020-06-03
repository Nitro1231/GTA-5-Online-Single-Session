namespace GTA_5_Online_Single_Session {
    partial class ControlTest {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.toggleButton1 = new GTA_5_Online_Single_Session.User_Control.ToggleButton();
            this.trackBar1 = new GTA_5_Online_Single_Session.User_Control.TrackBar();
            this.flatButton1 = new GTA_5_Online_Single_Session.User_Control.FlatButton();
            this.customTrackBar1 = new GTA_5_Online_Single_Session.User_Control.TrackBar();
            this.toggleButton2 = new GTA_5_Online_Single_Session.User_Control.ToggleButton();
            this.SuspendLayout();
            // 
            // toggleButton1
            // 
            this.toggleButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton1.ForeColor = System.Drawing.Color.White;
            this.toggleButton1.Location = new System.Drawing.Point(135, 97);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(60, 30);
            this.toggleButton1.TabIndex = 3;
            this.toggleButton1.Value = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.trackBar1.cValue = 8;
            this.trackBar1.dialSize = 26;
            this.trackBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackBar1.ForeColor = System.Drawing.Color.White;
            this.trackBar1.labelDisplay = true;
            this.trackBar1.Location = new System.Drawing.Point(12, 61);
            this.trackBar1.max = 12;
            this.trackBar1.min = 7;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(310, 30);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.thickness = 6;
            // 
            // flatButton1
            // 
            this.flatButton1.AutoRound = true;
            this.flatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flatButton1.ButtonRound = 50;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton1.ForeColor = System.Drawing.Color.White;
            this.flatButton1.LabelText = "text";
            this.flatButton1.Location = new System.Drawing.Point(12, 97);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Size = new System.Drawing.Size(117, 50);
            this.flatButton1.TabIndex = 1;
            // 
            // customTrackBar1
            // 
            this.customTrackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customTrackBar1.cValue = 50;
            this.customTrackBar1.dialSize = 26;
            this.customTrackBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTrackBar1.ForeColor = System.Drawing.Color.White;
            this.customTrackBar1.labelDisplay = true;
            this.customTrackBar1.Location = new System.Drawing.Point(12, 25);
            this.customTrackBar1.max = 100;
            this.customTrackBar1.min = 0;
            this.customTrackBar1.Name = "customTrackBar1";
            this.customTrackBar1.Size = new System.Drawing.Size(310, 30);
            this.customTrackBar1.TabIndex = 0;
            this.customTrackBar1.thickness = 6;
            // 
            // toggleButton2
            // 
            this.toggleButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton2.ForeColor = System.Drawing.Color.White;
            this.toggleButton2.Location = new System.Drawing.Point(135, 133);
            this.toggleButton2.Name = "toggleButton2";
            this.toggleButton2.Size = new System.Drawing.Size(60, 30);
            this.toggleButton2.TabIndex = 4;
            this.toggleButton2.Value = true;
            // 
            // ControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(339, 185);
            this.Controls.Add(this.toggleButton2);
            this.Controls.Add(this.toggleButton1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.customTrackBar1);
            this.Name = "ControlTest";
            this.Text = "ControlTest";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Control.TrackBar customTrackBar1;
        private User_Control.FlatButton flatButton1;
        private User_Control.TrackBar trackBar1;
        private User_Control.ToggleButton toggleButton1;
        private User_Control.ToggleButton toggleButton2;
    }
}