namespace GTA_5_Online_Single_Session {
    partial class Main {
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
            this.components = new System.ComponentModel.Container();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.minPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.processChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // exitPanel
            // 
            this.exitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.exitPanel.Location = new System.Drawing.Point(300, 2);
            this.exitPanel.Margin = new System.Windows.Forms.Padding(1);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(18, 18);
            this.exitPanel.TabIndex = 1;
            this.exitPanel.Click += new System.EventHandler(this.exitPanel_Click);
            // 
            // minPanel
            // 
            this.minPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.minPanel.Location = new System.Drawing.Point(278, 2);
            this.minPanel.Name = "minPanel";
            this.minPanel.Size = new System.Drawing.Size(18, 18);
            this.minPanel.TabIndex = 2;
            this.minPanel.Click += new System.EventHandler(this.minPanel_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(30, 120);
            this.sidePanel.TabIndex = 3;
            // 
            // tabPanel
            // 
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabPanel.Location = new System.Drawing.Point(30, 0);
            this.tabPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(290, 120);
            this.tabPanel.TabIndex = 4;
            // 
            // processChecker
            // 
            this.processChecker.Enabled = true;
            this.processChecker.Interval = 1000;
            this.processChecker.Tick += new System.EventHandler(this.processChecker_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(320, 120);
            this.Controls.Add(this.minPanel);
            this.Controls.Add(this.exitPanel);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.sidePanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "GTA 5 Online Single Session";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel exitPanel;
        private System.Windows.Forms.Panel minPanel;
        private System.Windows.Forms.FlowLayoutPanel sidePanel;
        private System.Windows.Forms.FlowLayoutPanel tabPanel;
        private System.Windows.Forms.Timer processChecker;
    }
}

