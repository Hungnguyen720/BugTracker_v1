﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class ProjectDashboardViewModel
    {
        public IEnumerable<Bugs> Bugs { get; set; }
        public IEnumerable<Task> Tasks { get; set; }

    }
}
