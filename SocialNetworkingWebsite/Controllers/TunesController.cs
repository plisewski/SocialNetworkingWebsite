using Microsoft.AspNet.Identity;
using SocialNetworkingWebsite.Models;
using SocialNetworkingWebsite.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace SocialNetworkingWebsite.Controllers
{
    public class TunesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TunesController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new TuneFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(TuneFormViewModel viewModel)
        {
            var tune = new Tune
            {
                ArtistId = User.Identity.GetUserId(),                
                DateTime = viewModel.DateTime,
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };

            _context.Tunes.Add(tune);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}