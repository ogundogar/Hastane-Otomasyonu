﻿
namespace HastaneOtomasyonu.UI.Personel
{
    partial class PersonelListele
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
            this.sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lbl_personellistele = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(547, 387);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(119, 48);
            this.sil.TabIndex = 7;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(547, 335);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(119, 48);
            this.guncelle.TabIndex = 6;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(68, 128);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(665, 194);
            this.dgv.TabIndex = 5;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // lbl_personellistele
            // 
            this.lbl_personellistele.AutoSize = true;
            this.lbl_personellistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personellistele.Location = new System.Drawing.Point(269, 53);
            this.lbl_personellistele.Name = "lbl_personellistele";
            this.lbl_personellistele.Size = new System.Drawing.Size(298, 42);
            this.lbl_personellistele.TabIndex = 4;
            this.lbl_personellistele.Text = "Personel Listesi";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(371, 339);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 21;
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(316, 342);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefon.TabIndex = 20;
            this.lbl_telefon.Text = "Telefon :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 387);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 19;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(102, 390);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "Email :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 17;
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Location = new System.Drawing.Point(81, 368);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(59, 13);
            this.lbl_AdSoyad.TabIndex = 16;
            this.lbl_AdSoyad.Text = "Ad Soyad :";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(146, 335);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(121, 20);
            this.ID.TabIndex = 23;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(116, 342);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(24, 13);
            this.lbl_ID.TabIndex = 22;
            this.lbl_ID.Text = "ID :";
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(371, 364);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(121, 20);
            this.sifre.TabIndex = 25;
            this.sifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Şifre :";
            // 
            // PersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_AdSoyad);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbl_personellistele);
            this.Name = "PersonelListele";
            this.Text = "PersonelListele";
            this.Load += new System.EventHandler(this.PersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbl_personellistele;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label label1;
    }
}