using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
// MIS REFERENCIAS
using XKCD_Comic.BLL;

namespace XKCD_Comic.Controllers
{
    public class HomeController : Controller
    {
        public IComic _comic;
        public HomeController(IComic comic)
        {
            _comic = comic;
        }

        public IActionResult Index()
        {
            var info = _comic.TodaysComic();
            return View(info);
        }
    }
}
