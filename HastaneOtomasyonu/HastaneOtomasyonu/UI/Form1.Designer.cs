
namespace HastaneOtomasyonu
{
    partial class Form1
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
            this.bttn_Doktor = new System.Windows.Forms.Button();
            this.bttn_Personel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn_Doktor
            // 
            this.bttn_Doktor.Location = new System.Drawing.Point(258, 242);
            this.bttn_Doktor.Name = "bttn_Doktor";
            this.bttn_Doktor.Size = new System.Drawing.Size(284, 81);
            this.bttn_Doktor.TabIndex = 5;
            this.bttn_Doktor.Text = "Doktor";
            this.bttn_Doktor.UseVisualStyleBackColor = true;
            this.bttn_Doktor.Click += new System.EventHandler(this.bttn_Doktor_Click_1);
            // 
            // bttn_Personel
            // 
            this.bttn_Personel.Location = new System.Drawing.Point(258, 128);
            this.bttn_Personel.Name = "bttn_Personel";
            this.bttn_Personel.Size = new System.Drawing.Size(284, 81);
            this.bttn_Personel.TabIndex = 4;
            this.bttn_Personel.Text = "Personel";
            this.bttn_Personel.UseVisualStyleBackColor = true;
            this.bttn_Personel.Click += new System.EventHandler(this.bttn_Personel_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_Doktor);
            this.Controls.Add(this.bttn_Personel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_Doktor;
        private System.Windows.Forms.Button bttn_Personel;
    }
}

