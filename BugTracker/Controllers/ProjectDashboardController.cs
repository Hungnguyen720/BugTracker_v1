using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Data;
using BugTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task = BugTracker.Models.Task;

namespace BugTracker.Controllers
{
    public class ProjectDashboardController : Controller
    {
        private readonly ProjectSettingsContext _context;
        private readonly BugContext _bcontext;
        private readonly TaskContext _tcontext;

        public class test
        { 
        public string User { get; set; }
            public int openTasks { get; set; }
        }


        public ProjectDashboardController(ProjectSettingsContext context, BugContext bcontext, TaskContext tcontext)
        {
            _context = context;
            _bcontext = bcontext;
            _tcontext = tcontext;
        }

        [HttpGet()]
        public  ActionResult Index(int projectid)
        {
            int _BugOpen = _bcontext.Project_Bugs.Where(b => b.ProjectID == projectid).Where(b => b.Status == "Open").Count();
            int _BugClosed = _bcontext.Project_Bugs.Where(b => b.ProjectID == projectid).Where(b => b.Status == "Closed").Count();
            int _TaskOpen =  _tcontext.Task.Where(t => t.ProjectId == projectid).Where(t => t.Status == "Open").Count();
            int _TaskClosed = _tcontext.Task.Where(t => t.ProjectId == projectid).Where(t => t.Status == "Closed").Count();
            var Tasks = _tcontext.Task.ToList();
            var Bugs = _bcontext.Project_Bugs.ToList();

            var _TeamTaskStatus = _tcontext.Task.Where(a => a.ProjectId == projectid).GroupBy(a => a.AssignedTo )
                .Select(c => new TeamTaskStatusModel
                {
                    User = c.Key,
                    Open = c.Count(x => x.Status == "Open"),
                    Overdue = c.Count(x => x.DateEnd < DateTime.Now),
                    Today = c.Count(x => x.DateEnd == DateTime.Today)
                }).ToList();

            var _TeamBugStatus = _bcontext.Project_Bugs.Where(a => a.ProjectID == projectid).GroupBy(a => a.AssignedTo)
                .Select(c => new TeamBugStatusModel
                {
                    User = c.Key,
                    Open = c.Count(x => x.Status == "Open"),
                    Overdue = c.Count(x => x.DueDate < DateTime.Now),
                    Today = c.Count(x => x.DueDate == DateTime.Today)
                }).ToList();

            var model = new ProjectDashboardViewModel
            {

                BugOpen = _BugOpen,
                BugClosed = _BugClosed,
                TaskOpen = _TaskOpen,
                TaskClosed = _TaskClosed,
                TeamTasksStatus = _TeamTaskStatus,
                TeamBugsStatus = _TeamBugStatus

            };

            return View(model);

        } 

    }
}