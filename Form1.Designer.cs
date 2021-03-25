
namespace Racunala
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGraficka = new System.Windows.Forms.Button();
            this.btnProcesor = new System.Windows.Forms.Button();
            this.btnMaticna = new System.Windows.Forms.Button();
            this.btnNapajanje = new System.Windows.Forms.Button();
            this.btnRam = new System.Windows.Forms.Button();
            this.btnPohrana = new System.Windows.Forms.Button();
            this.btnKonfiguracija = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGraficka
            // 
            this.btnGraficka.Location = new System.Drawing.Point(508, 13);
            this.btnGraficka.Name = "btnGraficka";
            this.btnGraficka.Size = new System.Drawing.Size(182, 90);
            this.btnGraficka.TabIndex = 1;
            this.btnGraficka.Text = "Grafičke kartice";
            this.btnGraficka.UseVisualStyleBackColor = true;
            // 
            // btnProcesor
            // 
            this.btnProcesor.Location = new System.Drawing.Point(508, 155);
            this.btnProcesor.Name = "btnProcesor";
            this.btnProcesor.Size = new System.Drawing.Size(182, 90);
            this.btnProcesor.TabIndex = 2;
            this.btnProcesor.Text = "Procesori";
            this.btnProcesor.UseVisualStyleBackColor = true;
            this.btnProcesor.Click += new System.EventHandler(this.btnProcesor_Click);
            // 
            // btnMaticna
            // 
            this.btnMaticna.Location = new System.Drawing.Point(508, 293);
            this.btnMaticna.Name = "btnMaticna";
            this.btnMaticna.Size = new System.Drawing.Size(182, 90);
            this.btnMaticna.TabIndex = 3;
            this.btnMaticna.Text = "Matične ploće";
            this.btnMaticna.UseVisualStyleBackColor = true;
            // 
            // btnNapajanje
            // 
            this.btnNapajanje.Location = new System.Drawing.Point(749, 13);
            this.btnNapajanje.Name = "btnNapajanje";
            this.btnNapajanje.Size = new System.Drawing.Size(182, 90);
            this.btnNapajanje.TabIndex = 4;
            this.btnNapajanje.Text = "Napajanja";
            this.btnNapajanje.UseVisualStyleBackColor = true;
            // 
            // btnRam
            // 
            this.btnRam.Location = new System.Drawing.Point(749, 155);
            this.btnRam.Name = "btnRam";
            this.btnRam.Size = new System.Drawing.Size(182, 90);
            this.btnRam.TabIndex = 5;
            this.btnRam.Text = "Radna Memorija";
            this.btnRam.UseVisualStyleBackColor = true;
            // 
            // btnPohrana
            // 
            this.btnPohrana.Location = new System.Drawing.Point(749, 293);
            this.btnPohrana.Name = "btnPohrana";
            this.btnPohrana.Size = new System.Drawing.Size(182, 90);
            this.btnPohrana.TabIndex = 6;
            this.btnPohrana.Text = "Pohrana podataka";
            this.btnPohrana.UseVisualStyleBackColor = true;
            // 
            // btnKonfiguracija
            // 
            this.btnKonfiguracija.Location = new System.Drawing.Point(623, 429);
            this.btnKonfiguracija.Name = "btnKonfiguracija";
            this.btnKonfiguracija.Size = new System.Drawing.Size(182, 90);
            this.btnKonfiguracija.TabIndex = 7;
            this.btnKonfiguracija.Text = "Konfiguracija Računala";
            this.btnKonfiguracija.UseVisualStyleBackColor = true;
            this.btnKonfiguracija.Click += new System.EventHandler(this.btnKonfiguracija_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 613);
            this.Controls.Add(this.btnKonfiguracija);
            this.Controls.Add(this.btnPohrana);
            this.Controls.Add(this.btnRam);
            this.Controls.Add(this.btnNapajanje);
            this.Controls.Add(this.btnMaticna);
            this.Controls.Add(this.btnProcesor);
            this.Controls.Add(this.btnGraficka);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGraficka;
        private System.Windows.Forms.Button btnProcesor;
        private System.Windows.Forms.Button btnMaticna;
        private System.Windows.Forms.Button btnNapajanje;
        private System.Windows.Forms.Button btnRam;
        private System.Windows.Forms.Button btnPohrana;
        private System.Windows.Forms.Button btnKonfiguracija;
    }
}

