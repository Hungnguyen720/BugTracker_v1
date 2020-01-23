using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class TeamStatusModel
    {
        public string User { get; set; }
        public int TeamStatusTasksOverdue { get; set; }
        public int TeamStatusBugsOverdue { get; set; }
        public int TeamStatusTasksTodays { get; set; }
        public int TeamStatusBugsTodays { get; set; }
        public int TeamStatusAllOpen { get; set; }
        public int TeamStatusBugsAllOpen { get; set; }
        
    }
}
