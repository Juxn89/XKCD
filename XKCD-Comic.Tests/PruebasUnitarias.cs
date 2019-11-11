using System;
using Xunit;
// MIS REFERENCIAS
using XKCD_Comic.BLL;

namespace XKCD_Comic.Tests
{
    public class PruebasUnitarias
    {
        public Comic _comic;

        public PruebasUnitarias() {
            _comic = new Comic();
        }

        [Fact]
        public void Get_Todays_Comic()
        {
            var data = _comic.TodaysComic();

            Assert.NotNull(data.Result);
            Assert.NotEmpty(data.Result.alt);
            Assert.NotEmpty(data.Result.title);
            Assert.NotEmpty(data.Result.img);
        }

        [Fact]
        public void Get_Previous_Comic()
        {
            Random random = new Random();
            int numComic = random.Next(1, 2226);

            var data = _comic.PreviousComic(numComic);

            Assert.NotNull(data.Result);
            Assert.NotEmpty(data.Result.alt);
            Assert.NotEmpty(data.Result.title);
            Assert.NotEmpty(data.Result.img);
        }

        [Fact]
        public void Validar_Comic_Que_No_Existe()
        {
            var data = _comic.PreviousComic(404);

            Assert.NotNull(data.Result);
            Assert.NotEmpty(data.Result.alt);
            Assert.Null(data.Result.title);            
            Assert.NotEmpty(data.Result.img);
            Assert.True(data.Result.img == "../assets/img/404.jpg");
            Assert.True(data.Result.httpStatus == 404);
        }
    }
}
