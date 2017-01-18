using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReadingNotesOnline.Models
{
    public class ReadingNoteDraft
    {
        [Display(Name = "File name")]
        public string FileName { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Tags")]
        public string Tags { get; set; }

        [Display(Name = "Notes")]
        public Dictionary<string, List<Note>> Notes { get; set; }


        public static ReadingNoteDraft CreateFromString(string DeserializeObj)
        {
            var temp = Newtonsoft.Json.JsonConvert.DeserializeObject<ReadingNoteDraft>(DeserializeObj);
            var deserializeList = new Dictionary<string, List<Note>>();

            var keys = temp.Notes.Keys;

            foreach (var category in keys)
            {
                var notestemp = temp.Notes[category];

                var lstNotes = temp.Notes[category];
                deserializeList[category] = lstNotes;
            }
            temp.Notes = deserializeList;
            return temp;
        }
    }
}