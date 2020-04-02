using System;
using System.Collections.Generic;
using System.Text;

namespace YooTaskForm.Models
{
    public class Section
    {
        public List<AcceptanceBlock> acceptanceBlocks { get; set; }
        public string date { get; set; }
        public int id { get; set; }
        public string imageId { get; set; }
    }
}
