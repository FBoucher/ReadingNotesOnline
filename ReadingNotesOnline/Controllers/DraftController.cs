using Microsoft.WindowsAzure.Storage.Blob;
using ReadingNotesOnline.Helpers;
using ReadingNotesOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReadingNotesOnline.Controllers
{
    public partial class DraftController : Controller
    {
        // GET: Draft
        public virtual ActionResult Index()
        {
            List<BasicBlobInfo> blobs = StorageHelper.GetFilesInContainer("jsonreadingnotes");
            return View(Views.jsonReadingNotesList, blobs);
        }

        public virtual ActionResult Edit(string fileName) {

            ReadingNoteDraft readNotes = ReadingNoteDraft.CreateFromString(StorageHelper.GetJSonReadingNotes(fileName));
            readNotes.FileName = fileName;

            return View(Views.ReadingNoteDraftEdit, readNotes);
        }

        public virtual ActionResult Save(ReadingNoteDraft readNotes)
        {
            StorageHelper.SaveJSonReadingNotesToStorage(Newtonsoft.Json.JsonConvert.SerializeObject(readNotes), readNotes.FileName);

            return RedirectToAction(MVC.Draft.Index());
        }

        public virtual ActionResult ReProcess(string fileName) {

            var rnClient = new ReadingNotesServices.ReadingNotesApiApp();

            var result = rnClient.ReadingNotes.ReProcessJSonReadingNotesWithOperationResponseAsync(fileName);

            return RedirectToAction(MVC.Draft.Index());

        }
    }
}