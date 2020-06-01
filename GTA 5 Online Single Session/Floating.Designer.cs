namespace GTA_5_Online_Single_Session {
    partial class Floating {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Floating));
            this.floatingPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.floatingPic)).BeginInit();
            this.SuspendLayout();
            // 
            // floatingPic
            // 
            this.floatingPic.Image = ((System.Drawing.Image)(resources.GetObject("floatingPic.Image")));
            this.floatingPic.Location = new System.Drawing.Point(0, 0);
            this.floatingPic.Name = "floatingPic";
            this.floatingPic.Size = new System.Drawing.Size(40, 40);
            this.floatingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floatingPic.TabIndex = 0;
            this.floatingPic.TabStop = false;
            this.floatingPic.DoubleClick += new System.EventHandler(this.Floating_DoubleClick);
            this.floatingPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Floating_MouseMove);
            // 
            // Floating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(120, 80);
            this.Controls.Add(this.floatingPic);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Floating";
            this.Opacity = 0.5D;
            this.ShowInTaskbar = false;
            this.Text = "GTA 5 Online Single Session";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Floating_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Floating_Paint);
            this.DoubleClick += new System.EventHandler(this.Floating_DoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Floating_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.floatingPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox floatingPic;
    }
}