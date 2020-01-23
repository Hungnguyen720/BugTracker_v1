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
        public IEnumerable<TeamBugStatusModel> TeamBugsStatus { get; set; }
        public IEnumerable<TeamTaskStatusModel> TeamTasksStatus { get; set; }


    }
}
