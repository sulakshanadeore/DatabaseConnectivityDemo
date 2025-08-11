using DataAccessLayerLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayerLibrary
{
    public class OrderDetailsBAL
    {
        OrderDetailsOperations operations = new OrderDetailsOperations();
        public double GetOrderList(int orderid)
        {
            double finalPrice = 0;
            DataTable dt1=operations.GetOrderList(orderid, out finalPrice);


            return finalPrice;

        }
    }
}
