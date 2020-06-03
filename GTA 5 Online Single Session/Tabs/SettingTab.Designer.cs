namespace GTA_5_Online_Single_Session.Tabs {
    partial class SettingTab {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.titleText = new System.Windows.Forms.Label();
            this.toggleButton1 = new GTA_5_Online_Single_Session.User_Control.ToggleButton();
            this.trackBar1 = new GTA_5_Online_Single_Session.User_Control.TrackBar();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Location = new System.Drawing.Point(10, 5);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(151, 13);
            this.titleText.TabIndex = 6;
            this.titleText.Text = "GTA 5 Online Single Session";
            // 
            // toggleButton1
            // 
            this.toggleButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton1.ForeColor = System.Drawing.Color.White;
            this.toggleButton1.Location = new System.Drawing.Point(34, 70);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(56, 28);
            this.toggleButton1.TabIndex = 8;
            this.toggleButton1.Value = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.trackBar1.cValue = 50;
            this.trackBar1.dialSize = 24;
            this.trackBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackBar1.ForeColor = System.Drawing.Color.White;
            this.trackBar1.labelDisplay = false;
            this.trackBar1.Location = new System.Drawing.Point(25, 34);
            this.trackBar1.max = 100;
            this.trackBar1.min = 0;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(168, 30);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.thickness = 6;
            // 
            // SettingTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.toggleButton1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.titleText);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SettingTab";
            this.Size = new System.Drawing.Size(295, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleText;
        private User_Control.TrackBar trackBar1;
        private User_Control.ToggleButton toggleButton1;
    }
}
