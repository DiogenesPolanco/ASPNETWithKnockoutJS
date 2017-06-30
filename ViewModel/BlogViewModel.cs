using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class BlogViewModel
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public virtual List<PostViewModel> Posts { get; set; }
    }
}
