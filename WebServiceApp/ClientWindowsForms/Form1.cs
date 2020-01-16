using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientWindowsForms.ProductServiceReference;
namespace ClientWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductServiceSoapClient client=new ProductServiceSoapClient();
            string message = client.HelloWorld();
            MessageBox.Show(message);
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            ProductServiceSoapClient client=new ProductServiceSoapClient();
            dataGridView1.DataSource = client.ProductList();
        }
    }
}
