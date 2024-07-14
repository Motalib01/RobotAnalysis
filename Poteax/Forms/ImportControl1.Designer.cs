namespace Poteax.Forms
{
    partial class ImportControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewPoteux = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoteux)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPoteux
            // 
            this.dataGridViewPoteux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoteux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPoteux.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPoteux.Name = "dataGridViewPoteux";
            this.dataGridViewPoteux.RowHeadersWidth = 51;
            this.dataGridViewPoteux.RowTemplate.Height = 24;
            this.dataGridViewPoteux.Size = new System.Drawing.Size(809, 634);
            this.dataGridViewPoteux.TabIndex = 0;
            // 
            // ImportControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewPoteux);
            this.Name = "ImportControl1";
            this.Size = new System.Drawing.Size(809, 634);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoteux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPoteux;
    }
}
