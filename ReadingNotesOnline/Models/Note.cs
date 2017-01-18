using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReadingNotesOnline.Models
{
    public class Note
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Author")]
        public string Author { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.DateTime)]
        public string DateAdded { get; set; }

        [Display(Name = "Tags")]
        public string Tags { get; set; }

        [Required]
        [Display(Name = "Comment")]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }

        [Required]
        [Display(Name = "Url")]
        public string Url { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string Category { get; set; }
    }
}