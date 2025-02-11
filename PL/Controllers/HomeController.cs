using Data.Context;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }
        [HttpGet("GET")]
        public async Task<ActionResult<IEnumerable<MainInfo>>> GetMainInfos()
        {
            return await _context.MainInfos.ToListAsync();
        }


        [HttpPost]

        public async Task<ActionResult<IEnumerable<MainInfo>>> AddMainInfo(MainInfo mainInfo)
        {
            _context.MainInfos.Add(mainInfo);
            await _context.SaveChangesAsync();

            return Ok();
        }



       /* public ActionResult Index()
        {
            return View();
        }
       */
    }
}
