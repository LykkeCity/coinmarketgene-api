using Microsoft.AspNetCore.Mvc;

namespace cmg_hosting_api.Controllers
{
    [Route("/api/[controller]")]
    public class ExchangesController : Controller
    {

        [HttpGet("/api/[controller]/list")]
        public IActionResult Index()
        {
            var items = new[]
            {
                new
                {
                    img = "/images/exchange/binance-coin-logo-png-transparent.png",
                    exchange = "Binance",
                    volume = 833746525,
                    effectiveprice = 833746525,
                    depth = 833746525,
                    totalcost = 9.91,
                    chartimg = "/images/chart.png"
                }
            };


            return Json(new
            {
                items
            });
        }
    }
}