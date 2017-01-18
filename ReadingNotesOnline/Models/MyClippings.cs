using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReadingNotesOnline.Models
{
    public class MyClippings
    {

        [Required]
        [Display(Name = "File name")]
        [FileExtensions]
        public HttpPostedFileBase UploadFile { get; set; }
    }
}