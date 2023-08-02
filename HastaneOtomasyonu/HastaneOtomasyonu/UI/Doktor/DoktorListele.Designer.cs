
namespace HastaneOtomasyonu.UI.Doktor
{
    partial class DoktorListele
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.cbx = new System.Windows.Forms.ComboBox();
            this.lbl_Brans = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(263, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor Listesi";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(62, 124);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(665, 194);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(560, 327);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(119, 48);
            this.guncelle.TabIndex = 2;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(560, 381);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(119, 48);
            this.sil.TabIndex = 3;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // cbx
            // 
            this.cbx.FormattingEnabled = true;
            this.cbx.Items.AddRange(new object[] {
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
            this.cbx.Location = new System.Drawing.Point(346, 404);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(121, 21);
            this.cbx.TabIndex = 25;
            // 
            // lbl_Brans
            // 
            this.lbl_Brans.AutoSize = true;
            this.lbl_Brans.Location = new System.Drawing.Point(300, 407);
            this.lbl_Brans.Name = "lbl_Brans";
            this.lbl_Brans.Size = new System.Drawing.Size(40, 13);
            this.lbl_Brans.TabIndex = 24;
            this.lbl_Brans.Text = "Branş :";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(291, 358);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefon.TabIndex = 22;
            this.lbl_telefon.Text = "Telefon :";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(116, 407);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 20;
            this.lbl_email.Text = "Email :";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(160, 378);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(121, 20);
            this.ad.TabIndex = 19;
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Location = new System.Drawing.Point(95, 385);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(59, 13);
            this.lbl_AdSoyad.TabIndex = 18;
            this.lbl_AdSoyad.Text = "Ad Soyad :";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(160, 404);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(121, 20);
            this.email.TabIndex = 26;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(346, 355);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(121, 20);
            this.tel.TabIndex = 27;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(346, 380);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(121, 20);
            this.sifre.TabIndex = 29;
            this.sifre.UseSystemPasswordChar = true;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(306, 380);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(34, 13);
            this.lbl_sifre.TabIndex = 28;
            this.lbl_sifre.Text = "Şifre :";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(160, 352);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(121, 20);
            this.ID.TabIndex = 31;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(130, 358);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(24, 13);
            this.lbl_ID.TabIndex = 30;
            this.lbl_ID.Text = "ID :";
            // 
            // DoktorListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.cbx);
            this.Controls.Add(this.lbl_Brans);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.lbl_AdSoyad);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Name = "DoktorListele";
            this.Text = "DoktorListele";
            this.Load += new System.EventHandler(this.DoktorListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.Label lbl_Brans;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label lbl_ID;
    }
}