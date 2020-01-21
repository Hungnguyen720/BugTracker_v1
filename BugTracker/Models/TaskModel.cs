using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Task
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string TaskList { get; set; }
        public string Description { get; set; }
        public string TaskName { get; set; }
        public string Owner { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Priority { get; set; }

    }
}
