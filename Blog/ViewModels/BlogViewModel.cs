using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.ViewModels
{
    //a representation of a particular subset of the database
    public class BlogViewModel
    {
        public int NumberOfBlogs { get; set; }
        public List<Models.Blog> TheBlogs { get; set; }
    }
}