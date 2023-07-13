using Microsoft.AspNetCore.Mvc;
using Tourism.DataAccess;

namespace Tourism.Controllers
{
    public class StatesController : Controller
    {
        private readonly TourismContext _context;

        public StatesController(TourismContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var states = _context.States.ToList();
            return View(states);
        }

        [Route("/states/{id:int}")]
        public IActionResult Show(int id)
        {
            var state = _context.States.Find(id);

            return View(state);
        }
    }
}
