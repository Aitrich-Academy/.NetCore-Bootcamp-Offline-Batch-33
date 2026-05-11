using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum JobStatus
    {
        Draft,      // Created but not yet submitted
        Pending,    // Submitted, awaiting approval
        Active,     // Approved and live
        Closed,     // No longer accepting applications
        Archived    // Permanently stored, not visible
    }
}
