using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class TeamTaskStatusModel
    {
        public string User { get; set; }
        public int Open { get; set; }
        public int Overdue { get; set; }
        public int Today { get; set; }
    }
}
