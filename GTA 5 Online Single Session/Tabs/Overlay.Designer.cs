namespace GTA_5_Online_Single_Session.Tabs {
    partial class Overlay {
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
            this.flatButton1 = new GTA_5_Online_Single_Session.User_Control.FlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.statusDisplay1 = new GTA_5_Online_Single_Session.User_Control.StatusDisplay();
            this.titleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flatButton1
            // 
            this.flatButton1.AutoRound = true;
            this.flatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flatButton1.ButtonRound = 50;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton1.ForeColor = System.Drawing.Color.White;
            this.flatButton1.LabelText = "Start Overlay";
            this.flatButton1.Location = new System.Drawing.Point(190, 81);
            this.flatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Size = new System.Drawing.Size(100, 34);
            this.flatButton1.TabIndex = 0;
            this.flatButton1.ButtonClick += new System.EventHandler(this.flatButton1_ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "You also can display this program in the game.\r\n(Not supporting full screen yet.)" +
    "";
            // 
            // statusDisplay1
            // 
            this.statusDisplay1.BackColor = System.Drawing.Color.Transparent;
            this.statusDisplay1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDisplay1.ForeColor = System.Drawing.Color.White;
            this.statusDisplay1.Location = new System.Drawing.Point(192, 3);
            this.statusDisplay1.Name = "statusDisplay1";
            this.statusDisplay1.Size = new System.Drawing.Size(18, 18);
            this.statusDisplay1.TabIndex = 9;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Location = new System.Drawing.Point(10, 5);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(151, 13);
            this.titleText.TabIndex = 8;
            this.titleText.Text = "GTA 5 Online Single Session";
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.statusDisplay1);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flatButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Overlay";
            this.Size = new System.Drawing.Size(295, 120);
            this.Load += new System.EventHandler(this.Overlay_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Control.FlatButton flatButton1;
        private System.Windows.Forms.Label label1;
        private User_Control.StatusDisplay statusDisplay1;
        private System.Windows.Forms.Label titleText;
    }
}
