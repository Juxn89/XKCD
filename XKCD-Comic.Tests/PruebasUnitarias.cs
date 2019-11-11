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
    }
}
