using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerLibrary
{
    public class OrderDetailsOperations
    {
        static string connectionString = "server=mazenet-test;" +
            "Integrated Security=true;" +
            "database=northwind;TrustServerCertificate=true";


        //DataTable is a in-memory collection
        public DataTable GetOrderList(int orderid,out double finalPrice)
        { 
            SqlConnection cn=new SqlConnection(connectionString);
            SqlCommand cmd_orders = new SqlCommand("select * from [Order Details] where Orderid=@ordid", cn);
            cn.Open();
            cmd_orders.Parameters.AddWithValue("@ordid",orderid);   
            SqlDataReader dr=cmd_orders.ExecuteReader();//datareader only read access

            DataTable dt = new DataTable();//has read/write access(both), secondly also it is in-memory object, so 
            //we have filled the data from the datareader to the datatable

             dt.Load(dr);//in memory object is created and has the data loaded into it

            cn.Close();
            cn.Dispose();

            finalPrice = 0;

            //List<OrdersDet> orderDetails = new List<OrdersDet>();

            int cnt=dt.Rows.Count;
            
            for(int i=0;i<cnt;i++)
            {

                DataRow item1 = dt.Rows[i];
                
                    if (Convert.ToDouble(item1["Discount"])!= 0)
                    {
                    Double price=Convert.ToInt32(item1["UnitPrice"]) * Convert.ToInt32(item1["Quantity"]);
                        finalPrice =  price - (price * Convert.ToDouble(item1["Discount"]));
                        finalPrice += finalPrice;

                    }
                    else
                    {
                        finalPrice += Convert.ToDouble(item1["UnitPrice"])*Convert.ToInt32(item1["Quantity"]);
                    
                    }
                }


            

        return dt;
        
        
        }

    }
}
