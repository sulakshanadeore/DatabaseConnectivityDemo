using BusinessLogicLayerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnectivityDemo
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderDetailsBAL bal = new OrderDetailsBAL();
            DataTable ordersDetails= bal.GetOrderList(Convert.ToInt32(textBox1.Text),out double finalPrice);
            finalPrice=Math.Round(finalPrice, 2);
            MessageBox.Show(finalPrice.ToString());
            dataGridView1.DataSource = ordersDetails;
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }
    }
}
