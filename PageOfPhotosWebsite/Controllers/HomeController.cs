using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
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

        [AllowAnonymous]
        public IActionResult Page(string id)
        {
            var slug = id ?? "id not provided";
            var pageRef = new PageRef();
            pageRef = new PageRef { Slug = slug, Name = "Bill Wilder", Description = "Something more", UserAvatarUrl = "https://pbs.twimg.com/profile_images/815748259/twitterProfilePhoto_400x400.jpg" };
            var pageContents = new PageContents();
            pageContents.pageRef = pageRef;
            pageContents.PageItems = new List<PageItem>();
            pageContents.PageItems.Add(new PageItem { PhotoName = "Bill", PhotoDescription = "Bill Wilder / @codingoutloud", PhotoThumbUrl = "https://2.gravatar.com/avatar/baf1296780d2798c1072e65aed8652d9?s=192&d=monsterid&r=G", PhotoFullUrl = "https://0.gravatar.com/avatar/baf1296780d2798c1072e65aed8652d9?size=512" });
            ViewData["Message"] = "One page of photos..";

            return View(pageContents);
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
