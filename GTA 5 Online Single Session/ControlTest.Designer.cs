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
            this.toggleButton2 = new GTA_5_Online_Single_Session.User_Control.ToggleButton();
            this.toggleButton1 = new GTA_5_Online_Single_Session.User_Control.ToggleButton();
            this.flatButton1 = new GTA_5_Online_Single_Session.User_Control.FlatButton();
            this.trackBar1 = new GTA_5_Online_Single_Session.User_Control.TrackBar();
            this.trackBar2 = new GTA_5_Online_Single_Session.User_Control.TrackBar();
            this.SuspendLayout();
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
            // toggleButton1
            // 
            this.toggleButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton1.ForeColor = System.Drawing.Color.White;
            this.toggleButton1.Location = new System.Drawing.Point(135, 97);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(60, 30);
            this.toggleButton1.TabIndex = 3;
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
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.trackBar1.DialSize = 24;
            this.trackBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackBar1.ForeColor = System.Drawing.Color.White;
            this.trackBar1.LabelDisplay = true;
            this.trackBar1.Location = new System.Drawing.Point(12, 12);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(275, 30);
            this.trackBar1.TabIndex = 5;
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.trackBar2.CurrentValue = 10;
            this.trackBar2.DialSize = 24;
            this.trackBar2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackBar2.ForeColor = System.Drawing.Color.White;
            this.trackBar2.LabelDisplay = true;
            this.trackBar2.Location = new System.Drawing.Point(12, 48);
            this.trackBar2.Max = 16;
            this.trackBar2.Min = 6;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(275, 30);
            this.trackBar2.TabIndex = 6;
            // 
            // ControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(292, 177);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.toggleButton2);
            this.Controls.Add(this.toggleButton1);
            this.Controls.Add(this.flatButton1);
            this.Name = "ControlTest";
            this.Text = "ControlTest";
            this.ResumeLayout(false);

        }

        #endregion
        private User_Control.FlatButton flatButton1;
        private User_Control.ToggleButton toggleButton1;
        private User_Control.ToggleButton toggleButton2;
        private User_Control.TrackBar trackBar1;
        private User_Control.TrackBar trackBar2;
    }
}