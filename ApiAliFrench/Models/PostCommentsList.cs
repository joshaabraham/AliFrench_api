using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAliFrench.Models
{
    public class PostCommentsList
    {
        public int count { get; set; }
        public List<PostComment> commentList { get; set; }
    }
}
