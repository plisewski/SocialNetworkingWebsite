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

        public ActionResult Create()
        {
            var viewModel = new TuneFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }
    }
}