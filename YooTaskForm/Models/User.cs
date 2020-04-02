using System;
using System.Collections.Generic;
using System.Text;

namespace YooTaskForm.Models
{
    public class User
    {
        public string id { get; set; }
        public string email { get; set; }
        public List<string> roles { get; set; }
    }
}