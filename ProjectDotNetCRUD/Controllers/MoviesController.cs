using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjectDotNetCRUD.Models;
using ProjectDotNetCRUD.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDotNetCRUD.Controllers
{
    public class MoviesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        { 
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //MY Action is index i retrive all data from database and 
            var movies = await _context.Movies.ToListAsync();
           // then it sends them to the view in shared.Index
            return View(movies);
        }

        public async Task<IActionResult> Create()
        {
            var viewModel = new MovieFormViewModel
            {
                Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync()
            };
            return View(viewModel);
        }
    }
}
