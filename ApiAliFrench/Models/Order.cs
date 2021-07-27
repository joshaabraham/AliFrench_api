using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAliFrench.Models
{
    public class Order
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string status { get; set; }
        public List<Item> items { get; set; }

        public List<AdditionalLines> additionalLines { get; set; }

        public int quantity { get; set; }
        public int subtotal { get; set; }
        public double total { get; set; }
        public string paymentMethod { get; set; }

        public Address shippingAddress { get; set; }
        public Address billingAddress {get;set;}

    }


    public class Partial<Order>
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string status { get; set; }
        public double total { get; set; }
        public int quantity { get; set; }
    }


}
