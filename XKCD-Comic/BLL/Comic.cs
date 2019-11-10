using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// MIS REFERENCIAS
using Newtonsoft.Json;
using System.Net.Http;
using XKCD_Comic.Models;

namespace XKCD_Comic.BLL
{
    public class Comic : IComic
    {
        public async Task<ComicModel> TodaysComic()
        {
            ComicModel comic = new ComicModel();
            using (var httpClient = new HttpClient())
            {
                using (var respuesta = await httpClient.GetAsync($"https://xkcd.com/info.0.json"))
                {
                    string json = await respuesta.Content.ReadAsStringAsync();
                    comic = JsonConvert.DeserializeObject<ComicModel>(json);

                    comic.prev_num = comic.num - 1;
                }
            }
            return comic;
        }

        public async Task<ComicModel> PreviousComic(int numComic)
        {
            ComicModel comic = new ComicModel();
            using (var httpClient = new HttpClient()) {
                using (var respuesta = await httpClient.GetAsync($"https://xkcd.com/{numComic}/info.0.json"))
                {
                    string json = await respuesta.Content.ReadAsStringAsync();
                    comic = JsonConvert.DeserializeObject<ComicModel>(json);

                    comic.prev_num = comic.num - 1;
                }
            }

            return comic;
        }
    }
}
