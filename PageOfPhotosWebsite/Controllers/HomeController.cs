using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PageOfPhotosWebsite.Models;

namespace PageOfPhotosWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var pageRefs = new List<PageRef>();
            pageRefs.Add(new PageRef { Slug = "codingoutloud", Name = "Bill Wilder", Description = "Something more", UserAvatarUrl = "https://pbs.twimg.com/profile_images/815748259/twitterProfilePhoto_400x400.jpg" });
            return View(pageRefs);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
