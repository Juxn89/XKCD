using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// MIS REFERENCIAS
using XKCD_Comic.Models;

namespace XKCD_Comic.BLL
{
    public interface IComic
    {
        public Task<ComicModel> TodaysComic();

        public Task<ComicModel> PreviousComic(int numComic);
    }
}
