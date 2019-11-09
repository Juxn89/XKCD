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
                }
            }
            return comic;
        }

        public Task<ComicModel> PreviousComic(int numComic)
        {
            throw new NotImplementedException();
        }
    }
}
