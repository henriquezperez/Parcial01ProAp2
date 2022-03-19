using Microsoft.AspNetCore.Mvc;
using Parcial01PA.BusinessLogic;
using Parcial01PA.Models;
using System.Diagnostics;

namespace Parcial01PA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(ActionCajero cajero)
        {
            return View();
        }

        public IActionResult ErrorMonto(){
            return View();
        }

        public IActionResult RetirarEfectivo(ActionCajero cajero){
            CajeroBL cj = new CajeroBL();
            int res = cj.Verificar(cajero);
            if(res != 0){
                return View("ErrorMonto");
            }
            return View();
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