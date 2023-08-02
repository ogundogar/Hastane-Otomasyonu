
namespace HastaneOtomasyonu.UI
{
    partial class Muayene
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
            this.lbl_HastaAdi = new System.Windows.Forms.Label();
            this.lbl_Randevu = new System.Windows.Forms.Label();
            this._HastaAdi = new System.Windows.Forms.TextBox();
            this._tarih = new System.Windows.Forms.TextBox();
            this._bolum = new System.Windows.Forms.TextBox();
            this.lbl_Bolum = new System.Windows.Forms.Label();
            this.lbl_DoktorGorusu = new System.Windows.Forms.Label();
            this._info = new System.Windows.Forms.RichTextBox();
            this.bttn_email = new System.Windows.Forms.Button();
            this.bttn_PDF = new System.Windows.Forms.Button();
            this.bttn_Onayla = new System.Windows.Forms.Button();
            this.lbl_ayel = new System.Windows.Forms.Label();
            this._doktoradi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._saat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_HastaAdi
            // 
            this.lbl_HastaAdi.AutoSize = true;
            this.lbl_HastaAdi.Location = new System.Drawing.Point(154, 113);
            this.lbl_HastaAdi.Name = "lbl_HastaAdi";
            this.lbl_HastaAdi.Size = new System.Drawing.Size(59, 13);
            this.lbl_HastaAdi.TabIndex = 0;
            this.lbl_HastaAdi.Text = "Hasta Adı :";
            // 
            // lbl_Randevu
            // 
            this.lbl_Randevu.AutoSize = true;
            this.lbl_Randevu.Location = new System.Drawing.Point(390, 93);
            this.lbl_Randevu.Name = "lbl_Randevu";
            this.lbl_Randevu.Size = new System.Drawing.Size(86, 13);
            this.lbl_Randevu.TabIndex = 1;
            this.lbl_Randevu.Text = "Randevu Tarihi :";
            // 
            // _HastaAdi
            // 
            this._HastaAdi.Location = new System.Drawing.Point(219, 110);
            this._HastaAdi.Name = "_HastaAdi";
            this._HastaAdi.ReadOnly = true;
            this._HastaAdi.Size = new System.Drawing.Size(121, 20);
            this._HastaAdi.TabIndex = 2;
            // 
            // _tarih
            // 
            this._tarih.Location = new System.Drawing.Point(480, 86);
            this._tarih.Name = "_tarih";
            this._tarih.ReadOnly = true;
            this._tarih.Size = new System.Drawing.Size(111, 20);
            this._tarih.TabIndex = 3;
            // 
            // _bolum
            // 
            this._bolum.Location = new System.Drawing.Point(480, 139);
            this._bolum.Name = "_bolum";
            this._bolum.ReadOnly = true;
            this._bolum.Size = new System.Drawing.Size(111, 20);
            this._bolum.TabIndex = 5;
            // 
            // lbl_Bolum
            // 
            this.lbl_Bolum.AutoSize = true;
            this.lbl_Bolum.Location = new System.Drawing.Point(432, 143);
            this.lbl_Bolum.Name = "lbl_Bolum";
            this.lbl_Bolum.Size = new System.Drawing.Size(42, 13);
            this.lbl_Bolum.TabIndex = 4;
            this.lbl_Bolum.Text = "Bölüm :";
            // 
            // lbl_DoktorGorusu
            // 
            this.lbl_DoktorGorusu.AutoSize = true;
            this.lbl_DoktorGorusu.Location = new System.Drawing.Point(127, 185);
            this.lbl_DoktorGorusu.Name = "lbl_DoktorGorusu";
            this.lbl_DoktorGorusu.Size = new System.Drawing.Size(76, 13);
            this.lbl_DoktorGorusu.TabIndex = 6;
            this.lbl_DoktorGorusu.Text = "Doktor Görüşü";
            // 
            // _info
            // 
            this._info.Location = new System.Drawing.Point(130, 201);
            this._info.Name = "_info";
            this._info.Size = new System.Drawing.Size(532, 132);
            this._info.TabIndex = 7;
            this._info.Text = "";
            // 
            // bttn_email
            // 
            this.bttn_email.Location = new System.Drawing.Point(480, 348);
            this.bttn_email.Name = "bttn_email";
            this.bttn_email.Size = new System.Drawing.Size(100, 45);
            this.bttn_email.TabIndex = 8;
            this.bttn_email.Text = "Email";
            this.bttn_email.UseVisualStyleBackColor = true;
            this.bttn_email.Click += new System.EventHandler(this.bttn_email_Click);
            // 
            // bttn_PDF
            // 
            this.bttn_PDF.Location = new System.Drawing.Point(350, 348);
            this.bttn_PDF.Name = "bttn_PDF";
            this.bttn_PDF.Size = new System.Drawing.Size(100, 45);
            this.bttn_PDF.TabIndex = 9;
            this.bttn_PDF.Text = "PDF";
            this.bttn_PDF.UseVisualStyleBackColor = true;
            this.bttn_PDF.Click += new System.EventHandler(this.bttn_PDF_Click);
            // 
            // bttn_Onayla
            // 
            this.bttn_Onayla.Location = new System.Drawing.Point(218, 348);
            this.bttn_Onayla.Name = "bttn_Onayla";
            this.bttn_Onayla.Size = new System.Drawing.Size(100, 45);
            this.bttn_Onayla.TabIndex = 11;
            this.bttn_Onayla.Text = "Onayla";
            this.bttn_Onayla.UseVisualStyleBackColor = true;
            this.bttn_Onayla.Click += new System.EventHandler(this.bttn_Onayla_Click);
            // 
            // lbl_ayel
            // 
            this.lbl_ayel.AutoSize = true;
            this.lbl_ayel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ayel.Location = new System.Drawing.Point(265, 21);
            this.lbl_ayel.Name = "lbl_ayel";
            this.lbl_ayel.Size = new System.Drawing.Size(259, 31);
            this.lbl_ayel.TabIndex = 12;
            this.lbl_ayel.Text = "AYEL HASTANESİ";
            // 
            // _doktoradi
            // 
            this._doktoradi.Location = new System.Drawing.Point(219, 136);
            this._doktoradi.Name = "_doktoradi";
            this._doktoradi.ReadOnly = true;
            this._doktoradi.Size = new System.Drawing.Size(121, 20);
            this._doktoradi.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Doktor Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "ID :";
            // 
            // _saat
            // 
            this._saat.Location = new System.Drawing.Point(480, 113);
            this._saat.Name = "_saat";
            this._saat.ReadOnly = true;
            this._saat.Size = new System.Drawing.Size(111, 20);
            this._saat.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Randevu Saati :";
            // 
            // _id
            // 
            this._id.Location = new System.Drawing.Point(218, 84);
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            this._id.Size = new System.Drawing.Size(121, 20);
            this._id.TabIndex = 51;
            // 
            // Muayene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._saat);
            this.Controls.Add(this._doktoradi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ayel);
            this.Controls.Add(this.bttn_Onayla);
            this.Controls.Add(this.bttn_PDF);
            this.Controls.Add(this.bttn_email);
            this.Controls.Add(this._info);
            this.Controls.Add(this.lbl_DoktorGorusu);
            this.Controls.Add(this._bolum);
            this.Controls.Add(this.lbl_Bolum);
            this.Controls.Add(this._tarih);
            this.Controls.Add(this._HastaAdi);
            this.Controls.Add(this.lbl_Randevu);
            this.Controls.Add(this.lbl_HastaAdi);
            this.Name = "Muayene";
            this.Text = "Muayene";
            this.Load += new System.EventHandler(this.Muayene_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_HastaAdi;
        private System.Windows.Forms.Label lbl_Randevu;
        private System.Windows.Forms.TextBox _HastaAdi;
        private System.Windows.Forms.TextBox _tarih;
        private System.Windows.Forms.TextBox _bolum;
        private System.Windows.Forms.Label lbl_Bolum;
        private System.Windows.Forms.Label lbl_DoktorGorusu;
        private System.Windows.Forms.RichTextBox _info;
        private System.Windows.Forms.Button bttn_email;
        private System.Windows.Forms.Button bttn_PDF;
        private System.Windows.Forms.Button bttn_Onayla;
        private System.Windows.Forms.Label lbl_ayel;
        private System.Windows.Forms.TextBox _doktoradi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _saat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _id;
    }
}