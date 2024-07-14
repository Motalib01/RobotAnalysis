namespace Poteax.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ImporteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultatsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImporteBtn,
            this.ResultatsBtn});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ImporteBtn
            // 
            this.ImporteBtn.Name = "ImporteBtn";
            this.ImporteBtn.Size = new System.Drawing.Size(76, 24);
            this.ImporteBtn.Text = "Importe";
            this.ImporteBtn.Click += new System.EventHandler(this.ImporteBtn_Click);
            // 
            // ResultatsBtn
            // 
            this.ResultatsBtn.Name = "ResultatsBtn";
            this.ResultatsBtn.Size = new System.Drawing.Size(82, 24);
            this.ResultatsBtn.Text = "Resultats";
            this.ResultatsBtn.Click += new System.EventHandler(this.ResultatsBtn_Click);
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Location = new System.Drawing.Point(0, 28);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(1006, 693);
            this.MainContentPanel.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ImporteBtn;
        private System.Windows.Forms.ToolStripMenuItem ResultatsBtn;
        private System.Windows.Forms.Panel MainContentPanel;
    }
}