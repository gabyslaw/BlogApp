using System;
using System.Collections.Generic;

namespace BlogApp.Model
{
    public class Post : BaseModel
    {
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Body { get; set; }
        public List<Tag> Tags { get; set; }

    }
}