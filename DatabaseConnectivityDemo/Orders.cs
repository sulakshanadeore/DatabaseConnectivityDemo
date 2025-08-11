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
            double finalPrice=bal.GetOrderList(Convert.ToInt32(textBox1.Text));
            MessageBox.Show(finalPrice.ToString());
        }
    }
}
