
namespace HastaneOtomasyonu.UI.Doktor
{
    partial class HastaListesi
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
            this.lbl_HastaListesi = new System.Windows.Forms.Label();
            this.cbx_Listele = new System.Windows.Forms.ComboBox();
            this.hasta_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevu_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevu_saati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttn_HastayıGör = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hasta_ID,
            this.hasta_Adi,
            this.randevu_tarihi,
            this.randevu_saati,
            this.hasta_info,
            this.tel_no,
            this.e_mail,
            this.bolum});
            this.dataGridView1.Location = new System.Drawing.Point(63, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_HastaListesi
            // 
            this.lbl_HastaListesi.AutoSize = true;
            this.lbl_HastaListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_HastaListesi.Location = new System.Drawing.Point(285, 38);
            this.lbl_HastaListesi.Name = "lbl_HastaListesi";
            this.lbl_HastaListesi.Size = new System.Drawing.Size(245, 42);
            this.lbl_HastaListesi.TabIndex = 1;
            this.lbl_HastaListesi.Text = "Hasta Listesi";
            // 
            // cbx_Listele
            // 
            this.cbx_Listele.FormattingEnabled = true;
            this.cbx_Listele.Items.AddRange(new object[] {
            "Hepsi",
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
            this.cbx_Listele.Location = new System.Drawing.Point(597, 94);
            this.cbx_Listele.Name = "cbx_Listele";
            this.cbx_Listele.Size = new System.Drawing.Size(121, 21);
            this.cbx_Listele.TabIndex = 8;
            // 
            // hasta_ID
            // 
            this.hasta_ID.HeaderText = "ID";
            this.hasta_ID.Name = "hasta_ID";
            // 
            // hasta_Adi
            // 
            this.hasta_Adi.HeaderText = "Hasta Adı";
            this.hasta_Adi.Name = "hasta_Adi";
            // 
            // randevu_tarihi
            // 
            this.randevu_tarihi.HeaderText = "Randevu Tarihi";
            this.randevu_tarihi.Name = "randevu_tarihi";
            // 
            // randevu_saati
            // 
            this.randevu_saati.HeaderText = "Randevu Saati";
            this.randevu_saati.Name = "randevu_saati";
            // 
            // hasta_info
            // 
            this.hasta_info.HeaderText = "Doktor Görüşü ve Tahliller";
            this.hasta_info.Name = "hasta_info";
            // 
            // tel_no
            // 
            this.tel_no.HeaderText = "Telefon Numarası";
            this.tel_no.Name = "tel_no";
            // 
            // e_mail
            // 
            this.e_mail.HeaderText = "Email";
            this.e_mail.Name = "e_mail";
            // 
            // bolum
            // 
            this.bolum.HeaderText = "Bölüm";
            this.bolum.Name = "bolum";
            // 
            // bttn_HastayıGör
            // 
            this.bttn_HastayıGör.Location = new System.Drawing.Point(597, 342);
            this.bttn_HastayıGör.Name = "bttn_HastayıGör";
            this.bttn_HastayıGör.Size = new System.Drawing.Size(121, 41);
            this.bttn_HastayıGör.TabIndex = 9;
            this.bttn_HastayıGör.Text = "İncele";
            this.bttn_HastayıGör.UseVisualStyleBackColor = true;
            // 
            // HastaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_HastayıGör);
            this.Controls.Add(this.cbx_Listele);
            this.Controls.Add(this.lbl_HastaListesi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HastaListesi";
            this.Text = "HastaListesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_HastaListesi;
        private System.Windows.Forms.ComboBox cbx_Listele;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevu_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevu_saati;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolum;
        private System.Windows.Forms.Button bttn_HastayıGör;
    }
}