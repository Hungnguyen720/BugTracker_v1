using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class ProjectDashboardViewModel
    {
        public int TaskOpen { get; set; }
        public int TaskClosed { get; set; }
        public int BugOpen { get; set; }
        public int BugClosed { get; set; }
        public int TeamStatusTasksOverdue { get; set; }
        public int TeamStatusBugsOverdue { get; set; }
        public int TeamStatusTasksTodays { get; set; }
        public int TeamStatusBugsTodays { get; set;  }
        public int TeamStatusAllOpen { get; set; }
        public int TeamStatusBugsAllOpen { get; set; }
        public IEnumerable<Bugs> Bugs { get; set; }
        public IEnumerable<Task> Tasks { get; set; }


    }
}
