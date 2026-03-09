using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp5.Manager
{
    internal class JobManager
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Exp exp { get; set; }
        public string Company { get; set; }
        public string Locaton { get; set; }
        public string SalaryRange { get; set; }
        public string JobType { get; set; }
    }
}
