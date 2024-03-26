using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Wycieczki.Models;
using Wycieczki.ViewModels;

namespace Wycieczki.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEnumerable<TravelDetailsViewModels> _wycieczki
            = new List<TravelDetailsViewModels>
            {
                new TravelDetailsViewModels
                {
                    Id= 1,
                    City="Barcelona",
                    Country="Hiszpania",
                    PricePerPerson="5300zl",
                    NumberOfDays=5,
                    Description="Hotel położony jest w centrum Barcelony. Spacer do znanej ulicy handlowej Rambla i portu zajmuje tylko kilka minut. Liczne inne sklepy i miejsca rozrywki, a także restauracje i bary znajdują się w bezpośrednim sąsiedztwie. Odległość do lotniska w Barcelonie wynosi około 16 km.\r\n",
                    ImgUrl = "https://barcelona-cityguide.com/wp-content/uploads/2023/01/27C53801-1F1C-43DC-8FCA-826D005CB26B-640x427.jpeg"
                },
                new TravelDetailsViewModels
                {
                    Id= 2,
                    City="Wenecja",
                    Country="Włochy",
                    PricePerPerson="200 euro",
                    NumberOfDays=4,
                    Description="Niezwykła architektura, piękne ogrody i klimatyczne uliczki",
                    ImgUrl = "https://i.wpimg.pl/O/640x427/d.wpimg.pl/1527542728-733009040/wenecja_g215%20shutterstock_219076456.jpg"


                },
                new TravelDetailsViewModels
                {
                     Id= 3,
                    City="Marsa Alam",
                    Country="Egipt",
                    PricePerPerson="1000 euro",
                    NumberOfDays=7,
                    Description="Hotel Casa Mare Resort (ex. Royal Tulip Beach Resort)",
                    ImgUrl ="https://i.wpimg.pl/O/640x427/d.wpimg.pl/2017916735-1299865369/szarm-el-szejk.jpg"

                },
            };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_wycieczki);
        }
        public IActionResult Details(int id)
        {
            var wycieczki = _wycieczki.FirstOrDefault(b => b.Id == id);
            return View(wycieczki);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
