
namespace WordPad2
{
    partial class FrmBul
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
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.btnSonrakiniBul = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.chkBuyukKucukHarfEslestir = new System.Windows.Forms.CheckBox();
            this.chkTamEslesme = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranan:";
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(102, 16);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(311, 26);
            this.txtAranan.TabIndex = 1;
            // 
            // btnSonrakiniBul
            // 
            this.btnSonrakiniBul.Location = new System.Drawing.Point(429, 12);
            this.btnSonrakiniBul.Name = "btnSonrakiniBul";
            this.btnSonrakiniBul.Size = new System.Drawing.Size(140, 35);
            this.btnSonrakiniBul.TabIndex = 2;
            this.btnSonrakiniBul.Text = "Sonrakini Bul";
            this.btnSonrakiniBul.UseVisualStyleBackColor = true;
            this.btnSonrakiniBul.Click += new System.EventHandler(this.btnSonrakiniBul_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(429, 57);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(140, 35);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // chkBuyukKucukHarfEslestir
            // 
            this.chkBuyukKucukHarfEslestir.AutoSize = true;
            this.chkBuyukKucukHarfEslestir.Location = new System.Drawing.Point(17, 124);
            this.chkBuyukKucukHarfEslestir.Name = "chkBuyukKucukHarfEslestir";
            this.chkBuyukKucukHarfEslestir.Size = new System.Drawing.Size(204, 24);
            this.chkBuyukKucukHarfEslestir.TabIndex = 7;
            this.chkBuyukKucukHarfEslestir.Text = "Büyük küçük harf eşleştir";
            this.chkBuyukKucukHarfEslestir.UseVisualStyleBackColor = true;
            // 
            // chkTamEslesme
            // 
            this.chkTamEslesme.AutoSize = true;
            this.chkTamEslesme.Location = new System.Drawing.Point(17, 94);
            this.chkTamEslesme.Name = "chkTamEslesme";
            this.chkTamEslesme.Size = new System.Drawing.Size(242, 24);
            this.chkTamEslesme.TabIndex = 6;
            this.chkTamEslesme.Text = "Sadece tam sözcükleri eşleştir";
            this.chkTamEslesme.UseVisualStyleBackColor = true;
            // 
            // FrmBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 160);
            this.Controls.Add(this.chkBuyukKucukHarfEslestir);
            this.Controls.Add(this.chkTamEslesme);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSonrakiniBul);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBul";
            this.Text = "Bul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Button btnSonrakiniBul;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.CheckBox chkBuyukKucukHarfEslestir;
        private System.Windows.Forms.CheckBox chkTamEslesme;
    }
}