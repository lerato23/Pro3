using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Pro3.Controllers
{
    public class AlbumController : Controller
    {
        private readonly Image _iIMageService;

        public AlbumController(Image iIMageService)
        {
            _iIMageService = iIMageService;
        }
        // GET: Album
        public ActionResult Index()
        {
            var imageList = iIMageService.GetAll();

            var model = new AlbumIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
            };
            return View();
        }
    }
}