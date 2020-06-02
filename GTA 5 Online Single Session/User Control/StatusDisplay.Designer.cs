namespace GTA_5_Online_Single_Session.User_Control {
    partial class StatusDisplay {
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
            this.statusPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusPic)).BeginInit();
            this.SuspendLayout();
            // 
            // statusPic
            // 
            this.statusPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusPic.Image = global::GTA_5_Online_Single_Session.Properties.Resources.unlink_solid;
            this.statusPic.Location = new System.Drawing.Point(0, 0);
            this.statusPic.Name = "statusPic";
            this.statusPic.Size = new System.Drawing.Size(18, 18);
            this.statusPic.TabIndex = 0;
            this.statusPic.TabStop = false;
            this.statusPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.statusPic_MouseMove);
            // 
            // StatusDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.statusPic);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "StatusDisplay";
            this.Size = new System.Drawing.Size(18, 18);
            this.Load += new System.EventHandler(this.StatusDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox statusPic;
    }
}
