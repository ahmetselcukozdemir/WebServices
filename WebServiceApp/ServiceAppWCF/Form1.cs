using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService.ProductServiceReference;
namespace ServiceAppWCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            ProductServiceClient client=new ProductServiceClient();
            string message = client.DoWork();
            MessageBox.Show(message);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductServiceClient client=new ProductServiceClient();
            dataGridView1.DataSource = client.ProductList();
            client.Close();
        }
    }
}
