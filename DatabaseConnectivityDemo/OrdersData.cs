using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivityDemo
{
    public class OrdersData
    {
        public int OrderID { get; set; }
        public int Amt { get; set; }
       

        /// <summary>
        /// List of Orders, Second output totalAmt
        /// </summary>
        /// <param name="totalAmt"></param>
        /// <returns></returns>
        public List<OrdersData>  CalculateTotalAmt(out int totalAmt, out int OrderCount)
        {
            List<OrdersData> orders = new List<OrdersData>()
            { new OrdersData{OrderID=1,Amt=1000 },
                new OrdersData{OrderID=2,Amt=1000},
                new OrdersData {OrderID=3,Amt=1000},
           };

            totalAmt = 0;
            foreach (var o in orders) {
                totalAmt += o.Amt;
            
            }
            OrderCount=orders.Count();
            return orders;
        
        }

    }


}
