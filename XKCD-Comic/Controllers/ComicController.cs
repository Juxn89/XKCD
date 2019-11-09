using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace XKCD_Comic.Controllers
{
    public class ComicController : Controller
    {
        public ComicController() {

        }

        [HttpGet("Comic/{id}")]
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}