
namespace TeknikServisOtomasyonu
{
    partial class frmKayitEkranı
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKYTgit = new System.Windows.Forms.Button();
            this.btnISLEMgit = new System.Windows.Forms.Button();
            this.btnAna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(782, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(24, 364);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 64);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Kayıt  Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKYTgit
            // 
            this.btnKYTgit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKYTgit.Location = new System.Drawing.Point(502, 366);
            this.btnKYTgit.Name = "btnKYTgit";
            this.btnKYTgit.Size = new System.Drawing.Size(131, 62);
            this.btnKYTgit.TabIndex = 2;
            this.btnKYTgit.Text = "Kayıt Ekranına Git";
            this.btnKYTgit.UseVisualStyleBackColor = true;
            this.btnKYTgit.Click += new System.EventHandler(this.btnKYTgit_Click);
            // 
            // btnISLEMgit
            // 
            this.btnISLEMgit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnISLEMgit.Location = new System.Drawing.Point(657, 366);
            this.btnISLEMgit.Name = "btnISLEMgit";
            this.btnISLEMgit.Size = new System.Drawing.Size(131, 62);
            this.btnISLEMgit.TabIndex = 3;
            this.btnISLEMgit.Text = "İşlem Ekranına Git";
            this.btnISLEMgit.UseVisualStyleBackColor = true;
            this.btnISLEMgit.Click += new System.EventHandler(this.btnISLEMgit_Click);
            // 
            // btnAna
            // 
            this.btnAna.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAna.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAna.Location = new System.Drawing.Point(380, 366);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(116, 67);
            this.btnAna.TabIndex = 32;
            this.btnAna.Text = "Ansayfaya Dön";
            this.btnAna.UseVisualStyleBackColor = false;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // frmKayitEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.btnISLEMgit);
            this.Controls.Add(this.btnKYTgit);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKayitEkranı";
            this.Text = "frmKayitEkranı";
            this.Load += new System.EventHandler(this.frmKayitEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKYTgit;
        private System.Windows.Forms.Button btnISLEMgit;
        private System.Windows.Forms.Button btnAna;
    }
}