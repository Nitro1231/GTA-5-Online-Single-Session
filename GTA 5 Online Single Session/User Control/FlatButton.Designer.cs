namespace GTA_5_Online_Single_Session.User_Control {
    partial class FlatButton {
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
            this.textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(0, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(100, 50);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "text";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textLabel.Click += new System.EventHandler(this.textLabel_Click);
            // 
            // FlatButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.textLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FlatButton";
            this.Size = new System.Drawing.Size(100, 50);
            this.SizeChanged += new System.EventHandler(this.FlatButton_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FlatButton_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
    }
}
