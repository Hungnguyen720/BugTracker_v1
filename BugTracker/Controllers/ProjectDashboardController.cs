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

            var _TeamStatusAllOpen = _tcontext.Task.Where(b => b.Status == "Open").Where(b => b.ProjectId == projectid).GroupBy(a => new { a.AssignedTo })
                .Select(c => new
                {
                    User = c.Key,
                    openTasks = c.Count()
                });

            var _TeamStatusAllClosed = _tcontext.Task.Where(b => b.Status == "Closed").Where(b => b.ProjectId == projectid).GroupBy(a => a.AssignedTo )
                .Select(c => new
                {
                    User = c.Key,
                    closedTasks = c.Count()
                });



            /*
            int _TeamStatusBugsOverdue = _bcontext.Project_Bugs.Where(t => t.ProjectID == projectid).Where(t => t.DueDate < DateTime.Now).Count();
            int _TeamStatusTasksTodays = _tcontext.Task.Where(t => t.ProjectId == projectid).Where(t => t.Status == "Open" ).Where(t => t.DateEnd == DateTime.Today).Count();
            int _TeamStatusBugsTodays = _bcontext.Project_Bugs.Where(t => t.ProjectID == projectid).Where(t => t.Status == "Open").Where(t => t.DueDate == DateTime.Today).Count();
            int _TeamStatusAllOpen = _tcontext.Task.Where(t => t.ProjectId == projectid).Where(t => t.Status == "Open").Count();
            int _TeamStatusBugsAllOpen = _bcontext.Project_Bugs.Where(t => t.ProjectID == projectid).Where(t => t.Status == "Open").Count();
            */
            var model = new ProjectDashboardViewModel()
            {

                BugOpen = _BugOpen,
                BugClosed = _BugClosed,
                TaskOpen = _TaskOpen,
                TaskClosed = _TaskClosed,

                /*
                TeamStatusTasksOverdue = _TeamStatusTasksOverdue,
                TeamStatusBugsOverdue = _TeamStatusBugsOverdue,
                TeamStatusTasksTodays = _TeamStatusTasksTodays,
                TeamStatusBugsTodays = _TeamStatusBugsTodays,
                TeamStatusAllOpen = _TeamStatusAllOpen,
                TeamStatusBugsAllOpen = _TeamStatusBugsAllOpen,
                */

            };

            return Json(_TeamStatusAllClosed);

        } 

    }
}