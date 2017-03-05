using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plugin2.Models
{
    public class ShopOrderModel
    {
        public int ShopOrderId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public string sessionInfo { get; set; }
    }
}