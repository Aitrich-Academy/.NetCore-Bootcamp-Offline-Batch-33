using ADMIN_JOB.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADMIN_JOB.Manager
{
    public class JobManager : iJob
    {
        private int numberOfJobs = 0;
        private Job[] Jobs = new Job[100]; 
    }
}
