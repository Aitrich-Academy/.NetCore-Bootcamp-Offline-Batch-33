using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise3.Models;

namespace exercise3.Interfaces
{
    public interface IApplicationProvider
    {
        void AddApplication(Application application);
        Application[] GetApplications();

    }
}
