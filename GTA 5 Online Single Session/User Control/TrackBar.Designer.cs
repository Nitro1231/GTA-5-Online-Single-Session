namespace GTA_5_Online_Single_Session.User_Control {
    partial class TrackBar {
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
            this.backPanel = new System.Windows.Forms.Panel();
            this.dialPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.backPanel.Location = new System.Drawing.Point(2, 12);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(146, 6);
            this.backPanel.TabIndex = 0;
            // 
            // dialPanel
            // 
            this.dialPanel.BackColor = System.Drawing.Color.White;
            this.dialPanel.Location = new System.Drawing.Point(31, 1);
            this.dialPanel.Name = "dialPanel";
            this.dialPanel.Size = new System.Drawing.Size(26, 26);
            this.dialPanel.TabIndex = 1;
            this.dialPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dialPanel_Paint);
            this.dialPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dialPanel_MouseDown);
            this.dialPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dialPanel_MouseMove);
            this.dialPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dialPanel_MouseUp);
            // 
            // CustomTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.dialPanel);
            this.Controls.Add(this.backPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CustomTrackBar";
            this.Size = new System.Drawing.Size(150, 30);
            this.Load += new System.EventHandler(this.TrackBar_Load);
            this.Resize += new System.EventHandler(this.TrackBar_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Panel dialPanel;
    }
}
