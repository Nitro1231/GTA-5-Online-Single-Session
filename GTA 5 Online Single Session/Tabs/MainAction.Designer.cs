namespace GTA_5_Online_Single_Session {
    partial class MainAction {
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
            this.action = new System.Windows.Forms.Label();
            this.statusDisplay1 = new GTA_5_Online_Single_Session.User_Control.StatusDisplay();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Location = new System.Drawing.Point(10, 5);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(151, 13);
            this.titleText.TabIndex = 5;
            this.titleText.Text = "GTA 5 Online Single Session";
            this.titleText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainAction_MouseMove);
            // 
            // action
            // 
            this.action.AutoSize = true;
            this.action.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action.Location = new System.Drawing.Point(67, 26);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(169, 47);
            this.action.TabIndex = 6;
            this.action.Text = "Loading...";
            this.action.SizeChanged += new System.EventHandler(this.action_SizeChanged);
            this.action.Click += new System.EventHandler(this.action_Click);
            this.action.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainAction_MouseMove);
            // 
            // statusDisplay1
            // 
            this.statusDisplay1.BackColor = System.Drawing.Color.Transparent;
            this.statusDisplay1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDisplay1.ForeColor = System.Drawing.Color.White;
            this.statusDisplay1.Location = new System.Drawing.Point(192, 2);
            this.statusDisplay1.Name = "statusDisplay1";
            this.statusDisplay1.Size = new System.Drawing.Size(18, 18);
            this.statusDisplay1.TabIndex = 7;
            // 
            // MainAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.statusDisplay1);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.action);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MainAction";
            this.Size = new System.Drawing.Size(295, 120);
            this.Load += new System.EventHandler(this.MainAction_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainAction_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainAction_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label action;
        private User_Control.StatusDisplay statusDisplay1;
    }
}
