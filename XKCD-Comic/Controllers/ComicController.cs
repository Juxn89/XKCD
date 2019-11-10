using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// MIS REFERENCIAS
using XKCD_Comic.BLL;

namespace XKCD_Comic.Controllers
{
    public class ComicController : Controller
    {
        public IComic _comic;
        public ComicController(IComic comic) {
            _comic = comic;
        }

        [HttpGet("Comic/{id}")]
        public IActionResult Index(int id)
        {
            if (id == 404) {
                return RedirectToAction("Index", new { id = 405});
            }

            var data = _comic.PreviousComic(id);
            return View(data);
        }
    }
}