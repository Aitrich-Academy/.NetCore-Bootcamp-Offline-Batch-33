using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Interfaces
{
    internal interface IJobProvider
    {
        public void PostJob(Job job);
        public Job[] GetJobs();
    }
}
