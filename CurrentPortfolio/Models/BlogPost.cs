using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrentPortfolio.Models
{
    public class BlogPost
    {
        [Key]
        public int BlogPostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        
        public virtual User User { get; set; }
    }
}
