namespace Poteax.Forms
{
    partial class Importe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ImporterBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewPoteux = new System.Windows.Forms.DataGridView();
            this.ResultatsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoteux)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImporterBtn,
            this.ResultatsBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ImporterBtn
            // 
            this.ImporterBtn.Font = new System.Drawing.Font("DokChampa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporterBtn.Name = "ImporterBtn";
            this.ImporterBtn.Size = new System.Drawing.Size(81, 39);
            this.ImporterBtn.Text = "Importer";
            this.ImporterBtn.Click += new System.EventHandler(this.ImporterBtn_Click);
            // 
            // dataGridViewPoteux
            // 
            this.dataGridViewPoteux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoteux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPoteux.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPoteux.Location = new System.Drawing.Point(0, 43);
            this.dataGridViewPoteux.Name = "dataGridViewPoteux";
            this.dataGridViewPoteux.RowHeadersWidth = 51;
            this.dataGridViewPoteux.RowTemplate.Height = 24;
            this.dataGridViewPoteux.Size = new System.Drawing.Size(990, 555);
            this.dataGridViewPoteux.TabIndex = 1;
            // 
            // ResultatsBtn
            // 
            this.ResultatsBtn.Name = "ResultatsBtn";
            this.ResultatsBtn.Size = new System.Drawing.Size(82, 39);
            this.ResultatsBtn.Text = "Resultats";
            this.ResultatsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ResultatsBtn.Click += new System.EventHandler(this.ResultatsBtn_Click);
            // 
            // Importe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 598);
            this.Controls.Add(this.dataGridViewPoteux);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Importe";
            this.Text = "Importe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoteux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ImporterBtn;
        private System.Windows.Forms.DataGridView dataGridViewPoteux;
        private System.Windows.Forms.ToolStripMenuItem ResultatsBtn;
    }
}