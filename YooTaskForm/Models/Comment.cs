using System;
using System.Collections.Generic;
using System.Text;

namespace YooTaskForm.Models
{
    public class Comment
    {
        public string authorId { get; set; }
        public string date { get; set; }
        public int id { get; set; }
        public string message { get; set; }
    }
}
