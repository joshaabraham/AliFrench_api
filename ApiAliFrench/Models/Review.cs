using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAliFrench.Models
{
    public class Review
    {
        public string avatar { get; set; }
        public string author { get; set; }
        public int rating { get; set; }
        public DateTime date { get; set; }
        public string text { get; set; }


    }
}
