namespace Poteax.Controls
{
    partial class ImportControl
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
            this.dataGridViewImportBar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportBar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImportBar
            // 
            this.dataGridViewImportBar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImportBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImportBar.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewImportBar.Name = "dataGridViewImportBar";
            this.dataGridViewImportBar.RowHeadersWidth = 51;
            this.dataGridViewImportBar.RowTemplate.Height = 24;
            this.dataGridViewImportBar.Size = new System.Drawing.Size(1006, 691);
            this.dataGridViewImportBar.TabIndex = 0;
            // 
            // ImportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewImportBar);
            this.Name = "ImportControl";
            this.Size = new System.Drawing.Size(1006, 691);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewImportBar;
    }
}
