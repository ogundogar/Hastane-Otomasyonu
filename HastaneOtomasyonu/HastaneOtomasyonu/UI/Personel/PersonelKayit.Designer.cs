
namespace HastaneOtomasyonu.UI
{
    partial class PersonelKayit
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
            this.lbl_PersonelKayit = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_personel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttn_Kaydet
            // 
            this.bttn_Kaydet.Location = new System.Drawing.Point(347, 317);
            this.bttn_Kaydet.Name = "bttn_Kaydet";
            this.bttn_Kaydet.Size = new System.Drawing.Size(121, 27);
            this.bttn_Kaydet.TabIndex = 19;
            this.bttn_Kaydet.Text = "Kaydet";
            this.bttn_Kaydet.UseVisualStyleBackColor = true;
            this.bttn_Kaydet.Click += new System.EventHandler(this.bttn_Kaydet_Click);
            // 
            // lbl_PersonelKayit
            // 
            this.lbl_PersonelKayit.AutoSize = true;
            this.lbl_PersonelKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_PersonelKayit.Location = new System.Drawing.Point(236, 97);
            this.lbl_PersonelKayit.Name = "lbl_PersonelKayit";
            this.lbl_PersonelKayit.Size = new System.Drawing.Size(347, 55);
            this.lbl_PersonelKayit.TabIndex = 18;
            this.lbl_PersonelKayit.Text = "Personel Kayıt";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(347, 239);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(121, 20);
            this.tel.TabIndex = 15;
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(292, 242);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefon.TabIndex = 14;
            this.lbl_telefon.Text = "Telefon :";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(347, 213);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(121, 20);
            this.email.TabIndex = 13;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(303, 216);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 12;
            this.lbl_email.Text = "Email :";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(347, 187);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(121, 20);
            this.ad.TabIndex = 11;
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Location = new System.Drawing.Point(282, 194);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(59, 13);
            this.lbl_AdSoyad.TabIndex = 10;
            this.lbl_AdSoyad.Text = "Ad Soyad :";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(347, 265);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(121, 20);
            this.sifre.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Şifre :";
            // 
            // txt_personel
            // 
            this.txt_personel.Location = new System.Drawing.Point(347, 291);
            this.txt_personel.Name = "txt_personel";
            this.txt_personel.ReadOnly = true;
            this.txt_personel.Size = new System.Drawing.Size(121, 20);
            this.txt_personel.TabIndex = 23;
            this.txt_personel.Text = "Personel";
            // 
            // PersonelKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_personel);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn_Kaydet);
            this.Controls.Add(this.lbl_PersonelKayit);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.lbl_AdSoyad);
            this.Name = "PersonelKayit";
            this.Text = "PersonelKayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Kaydet;
        private System.Windows.Forms.Label lbl_PersonelKayit;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_personel;
    }
}