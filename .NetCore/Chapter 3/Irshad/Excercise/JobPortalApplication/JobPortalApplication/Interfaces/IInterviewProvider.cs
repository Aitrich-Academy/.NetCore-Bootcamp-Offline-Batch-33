using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Interfaces
{
    internal interface IInterviewProvider
    {
        public void ScheduleInterview(Interview interview);
        Interview[] GetInterviews();
    }
}
