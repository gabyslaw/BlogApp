using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Model
{
    public class Blog : BaseModel
    {
        public String Name { get; set; }
        public List<Post> Posts { get; set; }
    }
}
