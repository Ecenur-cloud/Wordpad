using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad2
{
    public partial class FrmBul : Form
    {
        public FrmBul()
        {
            InitializeComponent();
        }

        public string ArananMetin
        {
            get { return txtAranan.Text; }
            set { txtAranan.Text = value; }
        }
        public bool TamEslesme { get { return chkTamEslesme.Checked; } }
        public bool BuyukKucukEslestir { get { return chkBuyukKucukHarfEslestir.Checked; } }

        private void btnSonrakiniBul_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            
        }


    }
}
