using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace WordPad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolStripControlHost tb = new ToolStripControlHost(trackBar1);
            statusStrip1.Items.Insert(8,tb);

            foreach (FontFamily f in FontFamily.Families)
                cbYaziTipi.Items.Add(f.Name);
            cbYaziTipi.Text = richTextBox1.Font.Name;
            cbYaziBuyuklugu.Items.AddRange(new object[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 24, 28, 32, 48, 72 });
            cbYaziBuyuklugu.Text = richTextBox1.Font.Size.ToString();


            Guncelle();
        }

        Font sf {         
            get { return richTextBox1.SelectionFont; }
            set { richTextBox1.SelectionFont = value; }
        }

        void Guncelle()
        {
            btnKopyala.Enabled = btnKes.Enabled = (richTextBox1.SelectionLength > 0) ;

            btnKoyu.Checked = (sf!=null) ? sf.Bold:false;
            btnItalik.Checked = (sf != null) ? sf.Italic : false;
            btnAltiçizili.Checked = (sf != null) ? sf.Underline : false;
            btnUstuCizili.Checked = (sf != null) ? sf.Strikeout : false;

            btnSagaHizala.Checked = (richTextBox1.SelectionAlignment == HorizontalAlignment.Right) ? true : false;
            btnSolaHizala.Checked = richTextBox1.SelectionAlignment == HorizontalAlignment.Left;
            btnOrtala.Checked = richTextBox1.SelectionAlignment == HorizontalAlignment.Center;

            btnMaddeIsareti.Checked = richTextBox1.SelectionBullet;
            btnSozcukKaydir.Checked= richTextBox1.WordWrap;

            int ix = richTextBox1.SelectionStart;
            lblSatir.Text = "Str: " + (richTextBox1.GetLineFromCharIndex(ix) + 1);
            Point p = richTextBox1.GetPositionFromCharIndex(ix);
            if (p.X == 1)
                lblSutun.Text = "Stn: 1";
            else
            {
                p.X = 0;
                int ix2 = richTextBox1.GetCharIndexFromPosition(p);
                lblSutun.Text = "Stn: " + (ix - ix2 + 1);
            }

            cbYaziTipi.Text = (sf != null) ? sf.Name : richTextBox1.Font.Name;
            cbYaziBuyuklugu.Text = (sf != null) ? sf.Size.ToString():richTextBox1.Font.Size.ToString();



        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void YeniBirDosya(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void btnYinele_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void btnKoyu_Click(object sender, EventArgs e)
        {
            if (sf.Bold)           
                sf = new Font(sf.Name,sf.Size,sf.Style & ~FontStyle.Bold);
            else
                sf = new Font(sf.Name,sf.Size,sf.Style | FontStyle.Bold);
        }

        private void btnItalik_Click(object sender, EventArgs e)
        {
            if (sf.Italic)
                sf = new Font(sf.Name, sf.Size, sf.Style & ~FontStyle.Italic);
            else
                sf = new Font(sf.Name, sf.Size, sf.Style | FontStyle.Italic);
        }

        private void btnAlticizili_Click(object sender, EventArgs e)
        {
            if (sf.Underline)
                sf = new Font(sf.Name, sf.Size, sf.Style & ~FontStyle.Underline);
            else
                sf = new Font(sf.Name, sf.Size, sf.Style | FontStyle.Underline);
        }

        private void btnUstuCizili_Click(object sender, EventArgs e)
        {
            if (sf.Strikeout)
                sf = new Font(sf.Name, sf.Size, sf.Style & ~FontStyle.Strikeout);
            else
                sf = new Font(sf.Name, sf.Size, sf.Style | FontStyle.Strikeout);
        }

        private void btnStilSil_Click(object sender, EventArgs e)
        {
            if (sf != null)
                sf = new Font(sf.FontFamily, sf.Size, FontStyle.Regular);
            else
                sf = richTextBox1.Font;
        }

        private void btnSolaHizala_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            Guncelle();
        }

        private void btnOrtala_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            Guncelle();
        }

        private void btnSagaHizala_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            Guncelle();
        }

        private void btnMaddeIsareti_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void btnSozcukKaydir_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = !richTextBox1.WordWrap;
        }

        private void btnGirintiArttir_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent += 20;
        }

        private void btnGirintiAzalt_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent -= 20;
        }

        private void btnAltSimge_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionCharOffset == 0)
            {
                richTextBox1.SelectionCharOffset = -(int)(sf.Size / 2);
                sf = new Font(sf.FontFamily, sf.Size / 2);
            }
            else
            {
                richTextBox1.SelectionCharOffset = 0;
                sf = new Font(sf.FontFamily, sf.Size * 2);
            }
        }

        private void btnUstSimge_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionCharOffset == 0)
            {
                richTextBox1.SelectionCharOffset = (int)(sf.Size / 2);
                sf = new Font(sf.FontFamily,sf.Size/2);
            }else
            {
                richTextBox1.SelectionCharOffset = 0;
                sf = new Font(sf.FontFamily,sf.Size*2);
            }
        }

        int sco {  
            get { return richTextBox1.SelectionCharOffset; }
            set{ richTextBox1.SelectionCharOffset = value; } 
        }

        private void mnSatirAraligi1_00_Click(object sender, EventArgs e)
        {
            sco = 0;
        }

        private void mnSatirAraligi1_25_Click(object sender, EventArgs e)
        {
            sco = (int)(sf.Size * 0.25);
        }

        private void mnSatirAraligi1_50_Click(object sender, EventArgs e)
        {
            sco = (int)(sf.Size * 0.5);
        }

        private void mnSatirAraligi2_00_Click(object sender, EventArgs e)
        {
            sco = (int)(sf.Size * 1);
        }

        
        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            lblCAPS.Text = Console.CapsLock ? "CAPS":""; // Control.IsKeyLocked(Keys.CapsLock)
            lblNUM.Text = Console.NumberLock ? "NUM" : ""; 
            lblINS.Text = Control.IsKeyLocked(Keys.Insert) ? "OVR" : "INS";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = (trackBar1.Value / 100f);
            lblZoom.Text = "%" + richTextBox1.ZoomFactor * 100;
        }

        private void btnUzaklastir_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value >= 20)
                trackBar1.Value -= 10;
            else
                trackBar1.Value = 10;
            trackBar1_Scroll(null, null);
        }

        private void btnYakınlastir_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value <= 490)
                trackBar1.Value += 10;
            else
                trackBar1.Value = 500;
            trackBar1_Scroll(null, null);
        }

        
        private void btnAc_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Zengin Metin Dosyası|*.rtf| Metin Dosyası |*.txt| MYO Metin Dosyası|*.myo";
            var sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                FileInfo dosya = new FileInfo(openFileDialog1.FileName);
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                if (dosya.Extension == ".txt")
                    richTextBox1.Text = oku.ReadToEnd();
                else
                    richTextBox1.Rtf = oku.ReadToEnd();
                oku.Close();
                DosyaAdiAyarla(dosya.FullName);
            }
        }

        string DosyaAdi = null;
        void DosyaAdiAyarla(string dosya) //Form header değiştiriyoruz
        {
            DosyaAdi = dosya;
            this.Text = "MYO WordPad - (" + DosyaAdi + ")";
        }

        private void btnKaydet_ButtonClick(object sender, EventArgs e)
        {
            if (DosyaAdi == null)
                btnFarkliKaydet_Click(null, null);
            else
                DosyayiKaydet();
        }
        private void btnFarkliKaydet_Click(object sender, EventArgs e)
        {
            var sonuc = saveFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                DosyaAdiAyarla(saveFileDialog1.FileName);
                DosyayiKaydet();
            }
        }
        private void DosyayiKaydet()
        {
            StreamWriter yaz = new StreamWriter(DosyaAdi);
            FileInfo dosya = new FileInfo(DosyaAdi);
            if (dosya.Extension ==".txt")
                yaz.Write(richTextBox1.Text);
            else
                yaz.Write(richTextBox1.Rtf);
            yaz.Close();
        }

        private void btnYaziTipi_Click(object sender, EventArgs e)
        {
            var sonuc = fontDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                sf = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color; 
            }
        }

        private void cbYaziTipi_TextChanged(object sender, EventArgs e)
        {
            if (sf == null)
                sf = richTextBox1.Font;
            else
                sf = new Font(cbYaziTipi.Text,sf.Size,sf.Style);
        }

        private void cbYaziBuyuklugu_TextChanged(object sender, EventArgs e)
        {
            if (sf == null)
                sf = richTextBox1.Font;
            else
            {
                float boyut;
                float.TryParse(cbYaziBuyuklugu.Text, out boyut);
                sf = new Font(sf.FontFamily,boyut>0 ? boyut:12,sf.Style);
            }
        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            
        }

        private void btnYaziRengi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVurguRengi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSayfaRengi_Click(object sender, EventArgs e)
        {
                        
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTumunuSec_Click(object sender, EventArgs e)
        {
            
        }


        private void btnYardim_Click(object sender, EventArgs e)
        {
            
        }

        
        private void btnBul_Click(object sender, EventArgs e)
        {
            
        }

        
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            

        }
    }
}

