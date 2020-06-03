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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new GTA_5_Online_Single_Session.User_Control.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.titleText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingTab_MouseMove);
            // 
            // toggleButton1
            // 
            this.toggleButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton1.ForeColor = System.Drawing.Color.White;
            this.toggleButton1.Location = new System.Drawing.Point(207, 57);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(52, 26);
            this.toggleButton1.TabIndex = 8;
            this.toggleButton1.Value = false;
            this.toggleButton1.OnValueChanged += new System.EventHandler(this.onSettingChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "5";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingTab_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "15";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingTab_MouseMove);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.trackBar1.CurrentValue = 8;
            this.trackBar1.DialSize = 22;
            this.trackBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackBar1.ForeColor = System.Drawing.Color.White;
            this.trackBar1.LabelDisplay = true;
            this.trackBar1.Location = new System.Drawing.Point(13, 58);
            this.trackBar1.Max = 15;
            this.trackBar1.Min = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(166, 25);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Thickness = 6;
            this.trackBar1.OnValueChanged += new System.EventHandler(this.onSettingChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Time Interval";
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingTab_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Floating Button";
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingTab_MouseMove);
            // 
            // SettingTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toggleButton1);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.trackBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SettingTab";
            this.Size = new System.Drawing.Size(295, 120);
            this.VisibleChanged += new System.EventHandler(this.SettingTab_VisibleChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingTab_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleText;
        private User_Control.ToggleButton toggleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private User_Control.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
