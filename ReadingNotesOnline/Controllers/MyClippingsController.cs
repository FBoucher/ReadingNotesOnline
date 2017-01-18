using ReadingNotesOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReadingNotesOnline.Controllers
{
    public partial class MyClippingsController : Controller
    {
        // GET: MyClippings
        public virtual ActionResult Index()
        {
            return View(Views.Upload);
        }


        public virtual ActionResult Upload(MyClippings model) {

            if (ModelState.IsValid)
            {
                return RedirectToAction(Views.Upload, Controllers.HomeController.NameConst);
            }

            if (model.UploadFile.ContentLength <= 0)
            {
                // Add Error
            }



            return RedirectToAction(MVC.Home.Index());
        }
    }
}