using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HackerNews.Api;

namespace HackerNews.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var api = new HackerNewsApi();
            return View(api.GetTopStories(20));
        }
    }
}