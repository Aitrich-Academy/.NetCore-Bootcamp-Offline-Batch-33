using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Models
{
    internal class Interview
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Post { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public string Time { get; set; }
    }
}
