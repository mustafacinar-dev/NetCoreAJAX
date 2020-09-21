using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreAJAX.Models;
using System.Diagnostics;
using System.Threading;

namespace NetCoreAJAX.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            //Arayüzdeki loader componentinin gözükmesi için threadi uyuttum çünkü, normal şartlarda işlem milisaniyeler içerisinde tamamlanıyor.
            Thread.Sleep(2000);
            return Json(UserDb.List());
        }

        public IActionResult GetUser(int id)
        {
            var user = UserDb.GetUser(id);
            return Json(user);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            UserDb.AddUser(user);
            return Json(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
