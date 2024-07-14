namespace Poteax.Controls
{
    partial class ResultatsControl
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
            this.dataGridViewResultats = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultats)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResultats
            // 
            this.dataGridViewResultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultats.Location = new System.Drawing.Point(45, 152);
            this.dataGridViewResultats.Name = "dataGridViewResultats";
            this.dataGridViewResultats.RowHeadersWidth = 51;
            this.dataGridViewResultats.RowTemplate.Height = 24;
            this.dataGridViewResultats.Size = new System.Drawing.Size(451, 192);
            this.dataGridViewResultats.TabIndex = 0;
            // 
            // ResultatsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewResultats);
            this.Name = "ResultatsControl";
            this.Size = new System.Drawing.Size(1006, 691);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewResultats;
    }
}
