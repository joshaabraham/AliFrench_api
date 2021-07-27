using System.Collections.Generic;

namespace ApiAliFrench.Models
{
    public class Item
    {
            public int id { get; set; }
            public string slug { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public List<Options> options { get; set; }

            public double price { get; set; }
            public int quantity { get; set; }
            public double total { get; set; }
    }
}