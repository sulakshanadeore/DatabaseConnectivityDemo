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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           OrdersData od=new OrdersData();
            int TotalOrderAmt;
           List<OrdersData> printAllData= od.CalculateTotalAmt(out TotalOrderAmt,out  int cnt);

            dataGridView1.DataSource = printAllData;
            textBox1.Text=TotalOrderAmt.ToString();
            MessageBox.Show(cnt.ToString());
        }
    }
}
