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
            this.customTrackBar1 = new GTA_5_Online_Single_Session.User_Control.TrackBar();
            this.flatButton1 = new GTA_5_Online_Single_Session.User_Control.FlatButton();
            this.SuspendLayout();
            // 
            // customTrackBar1
            // 
            this.customTrackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customTrackBar1.cValue = 50;
            this.customTrackBar1.dialSize = 26;
            this.customTrackBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTrackBar1.ForeColor = System.Drawing.Color.White;
            this.customTrackBar1.Location = new System.Drawing.Point(12, 25);
            this.customTrackBar1.max = 100;
            this.customTrackBar1.min = 0;
            this.customTrackBar1.Name = "customTrackBar1";
            this.customTrackBar1.Size = new System.Drawing.Size(240, 30);
            this.customTrackBar1.TabIndex = 0;
            this.customTrackBar1.thickness = 6;
            // 
            // flatButton1
            // 
            this.flatButton1.AutoRound = true;
            this.flatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flatButton1.ButtonRound = 0;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton1.ForeColor = System.Drawing.Color.White;
            this.flatButton1.LabelText = "text";
            this.flatButton1.Location = new System.Drawing.Point(12, 61);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Size = new System.Drawing.Size(117, 50);
            this.flatButton1.TabIndex = 1;
            // 
            // ControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(577, 298);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.customTrackBar1);
            this.Name = "ControlTest";
            this.Text = "ControlTest";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Control.TrackBar customTrackBar1;
        private User_Control.FlatButton flatButton1;
    }
}