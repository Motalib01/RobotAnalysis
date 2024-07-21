namespace Poutres.Controls
{
    partial class ImportControlBeam
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
            this.dataGridViewImportBeam = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportBeam)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImportBeam
            // 
            this.dataGridViewImportBeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImportBeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImportBeam.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewImportBeam.Name = "dataGridViewImportBeam";
            this.dataGridViewImportBeam.RowHeadersWidth = 51;
            this.dataGridViewImportBeam.RowTemplate.Height = 24;
            this.dataGridViewImportBeam.Size = new System.Drawing.Size(1006, 691);
            this.dataGridViewImportBeam.TabIndex = 0;
            // 
            // ImportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewImportBeam);
            this.Name = "ImportControl";
            this.Size = new System.Drawing.Size(1006, 691);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportBeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewImportBeam;
    }
}
