using System;
using System.Collections.Generic;
using System.Text;

namespace YooTaskForm.Models
{
    public class AcceptanceBlock
    {
        public List<Comment> comments { get; set; }
        public bool condition { get; set; }
        public string content { get; set; }
        public int id { get; set; }
        public string title { get; set; }
    }
}
