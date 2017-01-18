using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReadingNotesOnline.Models
{
    public class BasicBlobInfo
    {
        
        [Display(Name = "File name")]
        public string FileName { get; set; }
    }
}