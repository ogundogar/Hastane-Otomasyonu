﻿
namespace HastaneOtomasyonu.UI.Hasta
{
    partial class RandevuListe
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
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.saat = new System.Windows.Forms.ComboBox();
            this.bolum = new System.Windows.Forms.ComboBox();
            this.doktoradi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.goster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(159, 392);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(121, 20);
            this.ID.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID :";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(159, 366);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(121, 20);
            this.tel.TabIndex = 34;
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(104, 369);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefon.TabIndex = 33;
            this.lbl_telefon.Text = "Telefon :";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(159, 340);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(121, 20);
            this.email.TabIndex = 32;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(115, 343);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 31;
            this.lbl_email.Text = "Email :";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(159, 314);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(121, 20);
            this.ad.TabIndex = 30;
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Location = new System.Drawing.Point(94, 321);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(59, 13);
            this.lbl_AdSoyad.TabIndex = 29;
            this.lbl_AdSoyad.Text = "Ad Soyad :";
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(596, 310);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(85, 31);
            this.sil.TabIndex = 28;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(596, 347);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(85, 31);
            this.guncelle.TabIndex = 27;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(72, 83);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(665, 194);
            this.dgv.TabIndex = 26;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(269, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 42);
            this.label1.TabIndex = 25;
            this.label1.Text = "Randevu Listesi";
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(415, 313);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(120, 20);
            this.tarih.TabIndex = 46;
            // 
            // saat
            // 
            this.saat.FormattingEnabled = true;
            this.saat.Items.AddRange(new object[] {
            "09.00",
            "10.00",
            "11.00",
            "12.00",
            "13.00",
            "14.00",
            "15.00",
            "16.00",
            "17.00"});
            this.saat.Location = new System.Drawing.Point(414, 341);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(121, 21);
            this.saat.TabIndex = 45;
            // 
            // bolum
            // 
            this.bolum.FormattingEnabled = true;
            this.bolum.Items.AddRange(new object[] {
            "Çocuk Hastalıkları",
            "Dahiliye",
            "Aile Hekimi",
            "Üroloji",
            "Kadın Doğum",
            "Kadın Hastalıkları",
            "Kulak-Burun-Boğaz",
            "Psikoloji",
            "Genel Cerrahi",
            "Kardiyoloji",
            "Cildiye",
            "Adli Tıp",
            "Alerji Hastalıkları",
            "Beyin ve Sinir Cerrahisi"});
            this.bolum.Location = new System.Drawing.Point(414, 368);
            this.bolum.Name = "bolum";
            this.bolum.Size = new System.Drawing.Size(121, 21);
            this.bolum.TabIndex = 44;
            // 
            // doktoradi
            // 
            this.doktoradi.Location = new System.Drawing.Point(414, 395);
            this.doktoradi.Name = "doktoradi";
            this.doktoradi.Size = new System.Drawing.Size(121, 20);
            this.doktoradi.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Doktor Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Bolum :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Randevu Saati :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Randevu Tarihi :";
            // 
            // goster
            // 
            this.goster.Location = new System.Drawing.Point(596, 384);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(85, 35);
            this.goster.TabIndex = 37;
            this.goster.Text = "Hastayı Göster";
            this.goster.UseVisualStyleBackColor = true;
            this.goster.Click += new System.EventHandler(this.goster_Click);
            // 
            // RandevuListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.bolum);
            this.Controls.Add(this.doktoradi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.goster);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.lbl_AdSoyad);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Name = "RandevuListe";
            this.Text = "RandevuListe";
            this.Load += new System.EventHandler(this.RandevuListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.ComboBox saat;
        private System.Windows.Forms.ComboBox bolum;
        private System.Windows.Forms.TextBox doktoradi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button goster;
    }
}