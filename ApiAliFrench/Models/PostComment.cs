using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAliFrench.Models
{
    public class PostComment
    {

        public string avatar { get; set; }
        public string author { get; set; }
        public DateTime date { get; set; }
        public string text { get; set; }
        public List<PostComment> children { get; set; }


    }
}
