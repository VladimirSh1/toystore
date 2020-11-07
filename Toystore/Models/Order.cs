using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Toystore.Models
{
    public class Order
    {
        public int OrderId { set; get; }
        public string CustomerName { set; get; }
        public string Address { set; get; }
        public DateTime Date { set; get; }
        public int ToyId { set; get; }
    }
}