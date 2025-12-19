using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mechinetestoop.Manager
{
    internal class secureEmployee
    {
        private decimal salary;
        public decimal Getsalary(string role)
        {
            decimal salary = 0;
            if (role == "HR" || role == "manager")
            {
                return salary;

            }
            else
            {
                Console.WriteLine("not authersised");
                return 0;
            }
        }


    }
}
