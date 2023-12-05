using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace valentinPrueba_n3_leon.Controllers
{
    public class MusicaController : Controller
    {

        private readonly AppDbContext _context;

        public MusicaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Musica()
        {
            return View(_context.Musica.ToList());
        }
    }
}