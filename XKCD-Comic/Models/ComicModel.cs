using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XKCD_Comic.Models
{
    public class ComicModel
    {
        public int num { get; set; }
        public string alt { get; set; }
        public string img { get; set; }
        public string title { get; set; }
        public int prev_num { get; set; }
    }
}
 