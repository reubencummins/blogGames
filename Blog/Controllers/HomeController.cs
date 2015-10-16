using Blog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //this is fake data for now
            Models.Blog newBlog = new Models.Blog { BlogTitle = "Bad Blog", BlogAuthor = "A. Laa" };
            Models.Blog newerBlog = new Models.Blog
            {
                BlogTitle = "Worse Blog",
                BlogAuthor = "W. Ho",
                BlogPosts = new List<Models.Post>
                {
                    new Models.Post { PostTitle = "Local Idiot Ruins Everything", PostContent = "Lipsum would be nice." },
                    new Models.Post { PostTitle ="Old Man Yells at Cloud", PostContent="1,2,3,4,5,6,7..." }
                }
            };

            BlogViewModel bvm = new BlogViewModel { TheBlogs = new List<Models.Blog> { newBlog, newerBlog }, NumberOfBlogs = 2 /*That's not right*/ };

            return View(bvm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details(string id)
        {
            //this is fake data for now
            Models.Blog newBlog = new Models.Blog { BlogTitle = "Bad Blog", BlogAuthor = "A. Laa" };
            Models.Blog newerBlog = new Models.Blog
            {
                BlogTitle = "Worse Blog",
                BlogAuthor = "W. Ho",
                BlogPosts = new List<Models.Post>
                {
                    new Models.Post { PostTitle = "Local Idiot Ruins Everything", PostContent = "Lipsum would be nice." },
                    new Models.Post { PostTitle ="Old Man Yells at Cloud", PostContent="1,2,3,4,5,6,7..." }
                }
            };

            BlogViewModel bvm = new BlogViewModel { TheBlogs = new List<Models.Blog> { newBlog, newerBlog }, NumberOfBlogs = 2 /*That's not right*/ };


            foreach (Models.Blog blg in bvm.TheBlogs)
            {
                if (blg.BlogTitle==id)
                {
                    return (View(blg));
                }
            }
            return View();
        }
    }
}