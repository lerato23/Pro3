using UploadPicture.Infrastructures;
using UploadPicture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
namespace Pro3.Controllers
{
    public class UploadPictureController : Controller
    {
        private readonly ICloudinaryUploadPicture _uploadPicture;
        public UploadPictureController(ICloudinaryUploadPicture uploadPicture)
        {
              _uploadPicture = uploadPicture;
        }
        // GET: UploadPicture
        public ActionResult Index()
        {
            

            var model = new UploadPictureModel();
            
            return View(model);
        }

        [HttpPost]

        public async Task<ActionResult> UploadPicture(UploadPictureModel model)
        {

            await _uploadPicture.UploadPicture(model);
            return RedirectToAction("Index", "Gallery");

        }
    }
}