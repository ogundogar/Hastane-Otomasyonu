
namespace HastaneOtomasyonu.UI.Personel
{
    partial class PersonelListesi
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
            this.lbl_PersonelListesi = new System.Windows.Forms.Label();
            this.dGv = new System.Windows.Forms.DataGridView();
            this.hasta_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PersonelListesi
            // 
            this.lbl_PersonelListesi.AutoSize = true;
            this.lbl_PersonelListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_PersonelListesi.Location = new System.Drawing.Point(295, 53);
            this.lbl_PersonelListesi.Name = "lbl_PersonelListesi";
            this.lbl_PersonelListesi.Size = new System.Drawing.Size(298, 42);
            this.lbl_PersonelListesi.TabIndex = 11;
            this.lbl_PersonelListesi.Text = "Personel Listesi";
            // 
            // dGv
            // 
            this.dGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hasta_ID,
            this.personel_Adi,
            this.tel_no});
            this.dGv.Location = new System.Drawing.Point(73, 136);
            this.dGv.Name = "dGv";
            this.dGv.Size = new System.Drawing.Size(655, 215);
            this.dGv.TabIndex = 10;
            // 
            // hasta_ID
            // 
            this.hasta_ID.HeaderText = "ID";
            this.hasta_ID.Name = "hasta_ID";
            // 
            // personel_Adi
            // 
            this.personel_Adi.HeaderText = "Personel Adı";
            this.personel_Adi.Name = "personel_Adi";
            // 
            // tel_no
            // 
            this.tel_no.HeaderText = "Telefon Numarası";
            this.tel_no.Name = "tel_no";
            // 
            // PersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_PersonelListesi);
            this.Controls.Add(this.dGv);
            this.Name = "PersonelListesi";
            this.Text = "PersonelListesi";
            ((System.ComponentModel.ISupportInitialize)(this.dGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_PersonelListesi;
        private System.Windows.Forms.DataGridView dGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_no;
    }
}