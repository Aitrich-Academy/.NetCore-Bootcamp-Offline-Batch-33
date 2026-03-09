using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_OOP.Interface
{
    public  interface ISeeker
    {
        public void RegisterJobSeeker();
        public void LoginJobSeeker();
        public void ShowJobSeekerMenu();
        public void ApplyJob();
        public void SaveJob();
        public void ViewProfile();
        public void Logout();
        public void ShowMainMenu();

    }
}
