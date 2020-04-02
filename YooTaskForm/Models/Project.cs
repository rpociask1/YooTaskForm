using System;
using System.Collections.Generic;
using System.Text;

namespace YooTaskForm.Models
{
    public class Project
    {
        public string authorId { get; set; }
        public string company { get; set; }
        public string creationDate { get; set; }
        public string id { get; set; }
        public List<Note> notes { get; set; }
        public string password { get; set; }
        public List<Section> sections { get; set; }
        public string title { get; set; }
        public List<string> viewersId { get; set; }
    }
}
