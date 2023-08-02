
namespace HastaneOtomasyonu.UI.Doktor
{
    partial class DoktorGiris
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
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.bttn_tamam = new System.Windows.Forms.Button();
            this.lbl_hata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(257, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "Doktor Giriş";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(350, 238);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(121, 20);
            this.txt_sifre.TabIndex = 12;
            this.txt_sifre.Text = "00";
            this.txt_sifre.UseSystemPasswordChar = true;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(306, 215);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 11;
            this.lbl_email.Text = "Email :";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(350, 212);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(121, 20);
            this.txt_email.TabIndex = 10;
            this.txt_email.Text = "b@hotmail";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(306, 241);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(34, 13);
            this.lbl_sifre.TabIndex = 9;
            this.lbl_sifre.Text = "Şifre :";
            // 
            // bttn_tamam
            // 
            this.bttn_tamam.Location = new System.Drawing.Point(372, 264);
            this.bttn_tamam.Name = "bttn_tamam";
            this.bttn_tamam.Size = new System.Drawing.Size(75, 23);
            this.bttn_tamam.TabIndex = 14;
            this.bttn_tamam.Text = "Giriş Yap";
            this.bttn_tamam.UseVisualStyleBackColor = true;
            this.bttn_tamam.Click += new System.EventHandler(this.bttn_tamam_Click);
            // 
            // lbl_hata
            // 
            this.lbl_hata.AutoSize = true;
            this.lbl_hata.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_hata.Location = new System.Drawing.Point(369, 184);
            this.lbl_hata.Name = "lbl_hata";
            this.lbl_hata.Size = new System.Drawing.Size(57, 13);
            this.lbl_hata.TabIndex = 15;
            this.lbl_hata.Text = "Hatalı Giriş";
            // 
            // DoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_hata);
            this.Controls.Add(this.bttn_tamam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_sifre);
            this.Name = "DoktorGiris";
            this.Text = "DoktorGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Button bttn_tamam;
        private System.Windows.Forms.Label lbl_hata;
    }
}