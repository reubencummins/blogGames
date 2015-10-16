using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Blog
    {
        public string BlogAuthor { get; set; }
        public string BlogTitle { get; set; }
        public List<Post> BlogPosts { get; set; }
    }

    public class Post
    {
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
    }
}