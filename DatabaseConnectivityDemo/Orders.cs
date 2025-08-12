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
            var result = (from row in ordersDetails.AsEnumerable()
                       //  where row.Field<int>("Orderid") == Convert.ToInt32(textBox1.Text)
                         select new
                         {
                             Productid = row.Field<int>("Productid"),
                             Qty = row.Field<short>("Quantity"),
                             Price = row.Field<decimal>("UnitPrice"),
                             Dis = row.Field<float>("Discount"),

                         }).ToList();
            dataGridView1.DataSource = result;
            //orderid,productid,qty,price,discount

            //dataGridView1.DataSource = ordersDetails;
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }
    }
}
