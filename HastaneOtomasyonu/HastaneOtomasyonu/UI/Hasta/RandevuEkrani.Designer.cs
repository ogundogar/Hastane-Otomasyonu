
namespace HastaneOtomasyonu.UI.Hasta
{
    partial class RandevuEkrani
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
            this.bttn_Kaydet = new System.Windows.Forms.Button();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doktoradi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bolum = new System.Windows.Forms.ComboBox();
            this.saat = new System.Windows.Forms.ComboBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_Kaydet
            // 
            this.bttn_Kaydet.Location = new System.Drawing.Point(323, 411);
            this.bttn_Kaydet.Name = "bttn_Kaydet";
            this.bttn_Kaydet.Size = new System.Drawing.Size(121, 27);
            this.bttn_Kaydet.TabIndex = 27;
            this.bttn_Kaydet.Text = "Kaydet";
            this.bttn_Kaydet.UseVisualStyleBackColor = true;
            this.bttn_Kaydet.Click += new System.EventHandler(this.bttn_Kaydet_Click);
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Hasta.Location = new System.Drawing.Point(295, 22);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(225, 55);
            this.lbl_Hasta.TabIndex = 26;
            this.lbl_Hasta.Text = "Randevu";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(219, 367);
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            this.tel.Size = new System.Drawing.Size(121, 20);
            this.tel.TabIndex = 25;
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(164, 370);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefon.TabIndex = 24;
            this.lbl_telefon.Text = "Telefon :";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(219, 341);
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(121, 20);
            this.email.TabIndex = 23;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(175, 344);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 22;
            this.lbl_email.Text = "Email :";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(219, 315);
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            this.ad.Size = new System.Drawing.Size(121, 20);
            this.ad.TabIndex = 21;
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Location = new System.Drawing.Point(154, 322);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(59, 13);
            this.lbl_AdSoyad.TabIndex = 20;
            this.lbl_AdSoyad.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bolum :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Randevu Saati :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Randevu Tarihi :";
            // 
            // doktoradi
            // 
            this.doktoradi.Location = new System.Drawing.Point(467, 371);
            this.doktoradi.Name = "doktoradi";
            this.doktoradi.Size = new System.Drawing.Size(121, 20);
            this.doktoradi.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Doktor Adı :";
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
            this.bolum.Location = new System.Drawing.Point(467, 344);
            this.bolum.Name = "bolum";
            this.bolum.Size = new System.Drawing.Size(121, 21);
            this.bolum.TabIndex = 36;
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
            this.saat.Location = new System.Drawing.Point(467, 317);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(121, 21);
            this.saat.TabIndex = 37;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(468, 289);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(120, 20);
            this.tarih.TabIndex = 38;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(79, 80);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(665, 194);
            this.dgv.TabIndex = 39;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(219, 289);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(121, 20);
            this.ID.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "ID :";
            // 
            // RandevuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.bolum);
            this.Controls.Add(this.doktoradi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttn_Kaydet);
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.lbl_AdSoyad);
            this.Name = "RandevuEkrani";
            this.Text = "RandevuEkrani";
            this.Load += new System.EventHandler(this.RandevuEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Kaydet;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox doktoradi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bolum;
        private System.Windows.Forms.ComboBox saat;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label5;
    }
}