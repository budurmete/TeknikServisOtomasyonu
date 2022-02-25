
namespace TeknikServisOtomasyonu
{
    partial class frmIslem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIslem = new System.Windows.Forms.Button();
            this.comboBoxIslemTürü = new System.Windows.Forms.ComboBox();
            this.dataGridViewTeknikKayit = new System.Windows.Forms.DataGridView();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnKayitDNS = new System.Windows.Forms.Button();
            this.btnMusteriKYT = new System.Windows.Forms.Button();
            this.btnAna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeknikKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Sayfası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "İşlem Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(111, 290);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(179, 139);
            this.txtAciklama.TabIndex = 6;
            this.txtAciklama.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ücret:";
            // 
            // btnIslem
            // 
            this.btnIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslem.Location = new System.Drawing.Point(370, 243);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(220, 42);
            this.btnIslem.TabIndex = 9;
            this.btnIslem.Text = "İşlemi Gercekleştir";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // comboBoxIslemTürü
            // 
            this.comboBoxIslemTürü.FormattingEnabled = true;
            this.comboBoxIslemTürü.Location = new System.Drawing.Point(111, 207);
            this.comboBoxIslemTürü.Name = "comboBoxIslemTürü";
            this.comboBoxIslemTürü.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIslemTürü.TabIndex = 10;
            this.comboBoxIslemTürü.SelectedIndexChanged += new System.EventHandler(this.comboBoxIslemTürü_SelectedIndexChanged);
            // 
            // dataGridViewTeknikKayit
            // 
            this.dataGridViewTeknikKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeknikKayit.Location = new System.Drawing.Point(26, 44);
            this.dataGridViewTeknikKayit.Name = "dataGridViewTeknikKayit";
            this.dataGridViewTeknikKayit.RowHeadersWidth = 51;
            this.dataGridViewTeknikKayit.RowTemplate.Height = 24;
            this.dataGridViewTeknikKayit.Size = new System.Drawing.Size(880, 144);
            this.dataGridViewTeknikKayit.TabIndex = 11;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(111, 243);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(121, 22);
            this.txtMoney.TabIndex = 12;
            // 
            // btnKayitDNS
            // 
            this.btnKayitDNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitDNS.Location = new System.Drawing.Point(734, 461);
            this.btnKayitDNS.Name = "btnKayitDNS";
            this.btnKayitDNS.Size = new System.Drawing.Size(199, 77);
            this.btnKayitDNS.TabIndex = 13;
            this.btnKayitDNS.Text = "Telefon Kayıt Ekranına Dönüş";
            this.btnKayitDNS.UseVisualStyleBackColor = true;
            this.btnKayitDNS.Click += new System.EventHandler(this.btnKayitDNS_Click);
            // 
            // btnMusteriKYT
            // 
            this.btnMusteriKYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriKYT.Location = new System.Drawing.Point(734, 371);
            this.btnMusteriKYT.Name = "btnMusteriKYT";
            this.btnMusteriKYT.Size = new System.Drawing.Size(195, 84);
            this.btnMusteriKYT.TabIndex = 14;
            this.btnMusteriKYT.Text = "Müşteri Kayıt Ekranına Dönüş";
            this.btnMusteriKYT.UseVisualStyleBackColor = true;
            this.btnMusteriKYT.Click += new System.EventHandler(this.btnMusteriKYT_Click);
            // 
            // btnAna
            // 
            this.btnAna.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAna.ForeColor = System.Drawing.Color.Red;
            this.btnAna.Location = new System.Drawing.Point(734, 313);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(195, 52);
            this.btnAna.TabIndex = 15;
            this.btnAna.Text = "Ansayfaya Dön";
            this.btnAna.UseVisualStyleBackColor = false;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // frmIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 535);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.btnMusteriKYT);
            this.Controls.Add(this.btnKayitDNS);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.dataGridViewTeknikKayit);
            this.Controls.Add(this.comboBoxIslemTürü);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmIslem";
            this.Text = "frmIslem";
            this.Load += new System.EventHandler(this.frmIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeknikKayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.ComboBox comboBoxIslemTürü;
        private System.Windows.Forms.DataGridView dataGridViewTeknikKayit;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button btnKayitDNS;
        private System.Windows.Forms.Button btnMusteriKYT;
        private System.Windows.Forms.Button btnAna;
    }
}