
namespace HastaneOtomasyonu.UI
{
    partial class DoktorKayit
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
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_Brans = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.brans = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_Kaydet = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Doktor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Location = new System.Drawing.Point(298, 180);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(59, 13);
            this.lbl_AdSoyad.TabIndex = 0;
            this.lbl_AdSoyad.Text = "Ad Soyad :";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(363, 173);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(121, 20);
            this.ad.TabIndex = 1;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(363, 199);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(121, 20);
            this.email.TabIndex = 3;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(319, 202);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email :";
            // 
            // lbl_Brans
            // 
            this.lbl_Brans.AutoSize = true;
            this.lbl_Brans.Location = new System.Drawing.Point(317, 254);
            this.lbl_Brans.Name = "lbl_Brans";
            this.lbl_Brans.Size = new System.Drawing.Size(40, 13);
            this.lbl_Brans.TabIndex = 6;
            this.lbl_Brans.Text = "Branş :";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(363, 225);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(121, 20);
            this.tel.TabIndex = 5;
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(308, 228);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefon.TabIndex = 4;
            this.lbl_telefon.Text = "Telefon :";
            // 
            // brans
            // 
            this.brans.FormattingEnabled = true;
            this.brans.Items.AddRange(new object[] {
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
            this.brans.Location = new System.Drawing.Point(363, 254);
            this.brans.Name = "brans";
            this.brans.Size = new System.Drawing.Size(121, 21);
            this.brans.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(270, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "Doktor Kayıt";
            // 
            // bttn_Kaydet
            // 
            this.bttn_Kaydet.Location = new System.Drawing.Point(363, 346);
            this.bttn_Kaydet.Name = "bttn_Kaydet";
            this.bttn_Kaydet.Size = new System.Drawing.Size(121, 27);
            this.bttn_Kaydet.TabIndex = 9;
            this.bttn_Kaydet.Text = "Kaydet";
            this.bttn_Kaydet.UseVisualStyleBackColor = true;
            this.bttn_Kaydet.Click += new System.EventHandler(this.bttn_Kaydet_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(363, 281);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(121, 20);
            this.sifre.TabIndex = 11;
            this.sifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre :";
            // 
            // txt_Doktor
            // 
            this.txt_Doktor.Location = new System.Drawing.Point(363, 307);
            this.txt_Doktor.Name = "txt_Doktor";
            this.txt_Doktor.ReadOnly = true;
            this.txt_Doktor.Size = new System.Drawing.Size(121, 20);
            this.txt_Doktor.TabIndex = 24;
            this.txt_Doktor.Text = "Doktor";
            // 
            // DoktorKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Doktor);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttn_Kaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brans);
            this.Controls.Add(this.lbl_Brans);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.lbl_AdSoyad);
            this.Name = "DoktorKayit";
            this.Text = "DoktorKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_Brans;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.ComboBox brans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_Kaydet;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Doktor;
    }
}