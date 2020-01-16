using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientWindowsForms.TcknServiceReference;
namespace ClientWindowsForms
{
    public partial class TcknDogrula : Form
    {
        public TcknDogrula()
        {
            InitializeComponent();
        }

        private void TcknDogrula_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            long tckn = Convert.ToInt64(mskTckn.Text);
            string isim = txtIsim.Text.ToUpper();
            string soyisim = txtSoyisim.Text.ToUpper();
            int dogumyili = Convert.ToInt32(txtDogumYili.Text);

            KPSPublicSoap client=new KPSPublicSoapClient();
            bool sonuc = client.TCKimlikNoDogrula(tckn, isim, soyisim,dogumyili);
            if (sonuc)
            {
                MessageBox.Show("Tckn doğru");
            }
            else
            {
                MessageBox.Show("tckn yanlış");
            }


        }
    }
}
