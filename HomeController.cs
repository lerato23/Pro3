using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Pro3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UploadPicture()
        {
            return View();
        }

        public ActionResult UploadPicture(HttpPostedFileBase[] files)
        {
            if(ModelState.IsValid)
            {
                foreach (HttpPostedFileBase file in files)
                {
                    if (file != null)
                    {
                        var InputFileName = Path.GetFileName(file.FileName);
                        var ServerSavePath = Path.Combine(Server.MapPath("~/UploadPicture/") + InputFileName);
                        file.SaveAs(ServerSavePath);
                        ViewBag.UploadStatus = files.Count().ToString() + "files have been uploades successfully!";
                    }
                }
            }
            return View();
        }
    }
    
}