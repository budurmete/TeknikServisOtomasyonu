
namespace TeknikServisOtomasyonu
{
    partial class frmTeknikKayit
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
            this.dataGridViewMusteri = new System.Windows.Forms.DataGridView();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerTSLM = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.evet = new System.Windows.Forms.RadioButton();
            this.hayir = new System.Windows.Forms.RadioButton();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnISLEMgit = new System.Windows.Forms.Button();
            this.btnTeknikKayıt = new System.Windows.Forms.Button();
            this.btnAna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMusteri
            // 
            this.dataGridViewMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteri.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMusteri.Name = "dataGridViewMusteri";
            this.dataGridViewMusteri.RowHeadersWidth = 51;
            this.dataGridViewMusteri.RowTemplate.Height = 24;
            this.dataGridViewMusteri.Size = new System.Drawing.Size(607, 159);
            this.dataGridViewMusteri.TabIndex = 0;
            // 
            // txtProblem
            // 
            this.txtProblem.Location = new System.Drawing.Point(124, 254);
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(201, 22);
            this.txtProblem.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Problem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teslim Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Açıklama:";
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(438, 247);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(100, 22);
            this.txtDurum.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Durum:";
            // 
            // dateTimePickerTSLM
            // 
            this.dateTimePickerTSLM.Location = new System.Drawing.Point(124, 293);
            this.dateTimePickerTSLM.Name = "dateTimePickerTSLM";
            this.dateTimePickerTSLM.Size = new System.Drawing.Size(201, 22);
            this.dateTimePickerTSLM.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Garantisi Var mı: ";
            // 
            // evet
            // 
            this.evet.AutoSize = true;
            this.evet.Location = new System.Drawing.Point(124, 338);
            this.evet.Name = "evet";
            this.evet.Size = new System.Drawing.Size(57, 21);
            this.evet.TabIndex = 16;
            this.evet.TabStop = true;
            this.evet.Text = "Evet";
            this.evet.UseVisualStyleBackColor = true;
            // 
            // hayir
            // 
            this.hayir.AutoSize = true;
            this.hayir.Location = new System.Drawing.Point(201, 336);
            this.hayir.Name = "hayir";
            this.hayir.Size = new System.Drawing.Size(62, 21);
            this.hayir.TabIndex = 17;
            this.hayir.TabStop = true;
            this.hayir.Text = "Hayır";
            this.hayir.UseVisualStyleBackColor = true;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(438, 308);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(201, 130);
            this.txtAciklama.TabIndex = 18;
            this.txtAciklama.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Marka:";
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Location = new System.Drawing.Point(124, 378);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMarka.TabIndex = 21;
            // 
            // btnKayit
            // 
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.Color.Red;
            this.btnKayit.Location = new System.Drawing.Point(278, 468);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(158, 34);
            this.btnKayit.TabIndex = 22;
            this.btnKayit.Text = "Kayıt Oluştur";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(0, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(619, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Müşterinin ID Seçmek İçin Tablodan İşlem Yapmak istediğiniz Satırı Seçin";
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(125, 421);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(120, 22);
            this.txtmoney.TabIndex = 27;
            this.txtmoney.Text = ",00";
            // 
            // btnMusteri
            // 
            this.btnMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMusteri.Location = new System.Drawing.Point(701, 12);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(178, 72);
            this.btnMusteri.TabIndex = 28;
            this.btnMusteri.Text = "Müşteri Kayıt ekranına Git";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnISLEMgit
            // 
            this.btnISLEMgit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnISLEMgit.ForeColor = System.Drawing.Color.Green;
            this.btnISLEMgit.Location = new System.Drawing.Point(701, 104);
            this.btnISLEMgit.Name = "btnISLEMgit";
            this.btnISLEMgit.Size = new System.Drawing.Size(178, 34);
            this.btnISLEMgit.TabIndex = 29;
            this.btnISLEMgit.Text = "İşlem Ekranına Git";
            this.btnISLEMgit.UseVisualStyleBackColor = true;
            this.btnISLEMgit.Click += new System.EventHandler(this.btnISLEMgit_Click);
            // 
            // btnTeknikKayıt
            // 
            this.btnTeknikKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeknikKayıt.ForeColor = System.Drawing.Color.Green;
            this.btnTeknikKayıt.Location = new System.Drawing.Point(701, 155);
            this.btnTeknikKayıt.Name = "btnTeknikKayıt";
            this.btnTeknikKayıt.Size = new System.Drawing.Size(178, 60);
            this.btnTeknikKayıt.TabIndex = 30;
            this.btnTeknikKayıt.Text = "Teknik Kayıtların Ekranına Git";
            this.btnTeknikKayıt.UseVisualStyleBackColor = true;
            this.btnTeknikKayıt.Click += new System.EventHandler(this.btnTeknikKayıt_Click);
            // 
            // btnAna
            // 
            this.btnAna.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAna.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAna.Location = new System.Drawing.Point(701, 222);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(178, 52);
            this.btnAna.TabIndex = 31;
            this.btnAna.Text = "Ansayfaya Dön";
            this.btnAna.UseVisualStyleBackColor = false;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // frmTeknikKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 543);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.btnTeknikKayıt);
            this.Controls.Add(this.btnISLEMgit);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.txtmoney);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.hayir);
            this.Controls.Add(this.evet);
            this.Controls.Add(this.dateTimePickerTSLM);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProblem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewMusteri);
            this.Name = "frmTeknikKayit";
            this.Text = "frmTeknikKayit";
            this.Load += new System.EventHandler(this.frmTeknikKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMusteri;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerTSLM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton evet;
        private System.Windows.Forms.RadioButton hayir;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnISLEMgit;
        private System.Windows.Forms.Button btnTeknikKayıt;
        private System.Windows.Forms.Button btnAna;
    }
}