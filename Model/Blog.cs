using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Name { get; set; }


        public virtual List<Post> Posts { get; set; }
    }
}
