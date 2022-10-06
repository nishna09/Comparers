using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Order : IComparable
    {
        public string SubmittedBy;
        public int OrderId;
        public DateTime OrderDate;

        public Order(string submittedBy, int orderId, DateTime orderDate)
        {
            SubmittedBy = submittedBy;
            OrderId = orderId;
            OrderDate = orderDate;
        }

        public int CompareTo(object obj)
        {
            return OrderDate.CompareTo((obj as Order).OrderDate);
        }
    }
}
