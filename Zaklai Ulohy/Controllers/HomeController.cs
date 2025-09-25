using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Zaklai_Ulohy.Models;

namespace Zaklai_Ulohy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<UserModel> userList { get; set; } = new List<UserModel>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //public IActionResult Uloha2()
        //{
        //    return View();
        //}

        //public IActionResult Uloha3()
        //{
        //    return View();
        //}

        //public IActionResult Uloha7()
        //{
        //    return View();
        //}
        //public IActionResult Uloha8()
        //{
        //    return View();
        //}

        public IActionResult form()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form() {
            return View(new UserModel());
        }

        [HttpPost]
        public IActionResult Form(UserModel user)
        {
            userList.Add(user);
            return RedirectToAction("Detail", user);
            //return View();

        }

        [HttpGet]
        public IActionResult Detail()
        {
            return View(userList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
