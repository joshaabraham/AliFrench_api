using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAliFrench.Models
{
    public class Post
    {
        public string title { get; set; }
        public string image { get; set; }
        public List<Categorie> categories { get; set; } 
        public DateTime date { get; set; }
    }
}
