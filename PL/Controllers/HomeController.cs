using Data.Context;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController

      
        public ActionResult Index()
        {
            return View();
        }
    }
}
