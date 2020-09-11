using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_3_blog_kaydon_justin.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Posted { get; set; }
        public DateTime Edited { get; set; }
    }
}
