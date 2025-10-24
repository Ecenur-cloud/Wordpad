
namespace WordPad2
{
    partial class FrmDegistir
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
            this.chkTamEslesme = new System.Windows.Forms.CheckBox();
            this.chkBuyukKucukHarfEslestir = new System.Windows.Forms.CheckBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtYeniDeger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnTumunuDegistir = new System.Windows.Forms.Button();
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
            this.txtAranan.Location = new System.Drawing.Point(135, 16);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(300, 26);
            this.txtAranan.TabIndex = 1;
            // 
            // btnSonrakiniBul
            // 
            this.btnSonrakiniBul.Location = new System.Drawing.Point(440, 14);
            this.btnSonrakiniBul.Name = "btnSonrakiniBul";
            this.btnSonrakiniBul.Size = new System.Drawing.Size(197, 35);
            this.btnSonrakiniBul.TabIndex = 2;
            this.btnSonrakiniBul.Text = "Sonrakini Bul";
            this.btnSonrakiniBul.UseVisualStyleBackColor = true;
            this.btnSonrakiniBul.Click += new System.EventHandler(this.btnSonrakiniBul_Click);
            // 
            // chkTamEslesme
            // 
            this.chkTamEslesme.AutoSize = true;
            this.chkTamEslesme.Location = new System.Drawing.Point(17, 130);
            this.chkTamEslesme.Name = "chkTamEslesme";
            this.chkTamEslesme.Size = new System.Drawing.Size(242, 24);
            this.chkTamEslesme.TabIndex = 3;
            this.chkTamEslesme.Text = "Sadece tam sözcükleri eşleştir";
            this.chkTamEslesme.UseVisualStyleBackColor = true;
            // 
            // chkBuyukKucukHarfEslestir
            // 
            this.chkBuyukKucukHarfEslestir.AutoSize = true;
            this.chkBuyukKucukHarfEslestir.Location = new System.Drawing.Point(17, 160);
            this.chkBuyukKucukHarfEslestir.Name = "chkBuyukKucukHarfEslestir";
            this.chkBuyukKucukHarfEslestir.Size = new System.Drawing.Size(204, 24);
            this.chkBuyukKucukHarfEslestir.TabIndex = 4;
            this.chkBuyukKucukHarfEslestir.Text = "Büyük küçük harf eşleştir";
            this.chkBuyukKucukHarfEslestir.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(440, 153);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(197, 35);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtYeniDeger
            // 
            this.txtYeniDeger.Location = new System.Drawing.Point(135, 57);
            this.txtYeniDeger.Name = "txtYeniDeger";
            this.txtYeniDeger.Size = new System.Drawing.Size(300, 26);
            this.txtYeniDeger.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yeni değer:";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(440, 59);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(197, 35);
            this.btnDegistir.TabIndex = 8;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnTumunuDegistir
            // 
            this.btnTumunuDegistir.Location = new System.Drawing.Point(440, 105);
            this.btnTumunuDegistir.Name = "btnTumunuDegistir";
            this.btnTumunuDegistir.Size = new System.Drawing.Size(197, 35);
            this.btnTumunuDegistir.TabIndex = 9;
            this.btnTumunuDegistir.Text = "Tümünü Değiştir";
            this.btnTumunuDegistir.UseVisualStyleBackColor = true;
            this.btnTumunuDegistir.Click += new System.EventHandler(this.btnTumunuDegistir_Click);
            // 
            // FrmDeğiştir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 207);
            this.Controls.Add(this.btnTumunuDegistir);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.txtYeniDeger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.chkBuyukKucukHarfEslestir);
            this.Controls.Add(this.chkTamEslesme);
            this.Controls.Add(this.btnSonrakiniBul);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDeğiştir";
            this.Text = "Değiştir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Button btnSonrakiniBul;
        private System.Windows.Forms.CheckBox chkTamEslesme;
        private System.Windows.Forms.CheckBox chkBuyukKucukHarfEslestir;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtYeniDeger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnTumunuDegistir;
    }
}