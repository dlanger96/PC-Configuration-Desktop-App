
namespace Racunala
{
    partial class formKonfiguracijaRac
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
            this.dgvKonfiguracija = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonfiguracija)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKonfiguracija
            // 
            this.dgvKonfiguracija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKonfiguracija.Location = new System.Drawing.Point(12, 22);
            this.dgvKonfiguracija.Name = "dgvKonfiguracija";
            this.dgvKonfiguracija.Size = new System.Drawing.Size(1191, 150);
            this.dgvKonfiguracija.TabIndex = 0;
            // 
            // formKonfiguracijaRac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 707);
            this.Controls.Add(this.dgvKonfiguracija);
            this.Name = "formKonfiguracijaRac";
            this.Text = "fromKonfiguracijaRac";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonfiguracija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKonfiguracija;
    }
}