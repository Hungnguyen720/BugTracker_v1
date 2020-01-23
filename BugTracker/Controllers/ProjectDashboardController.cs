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
            var result =  _tcontext.Task.Where(t => t.ProjectId == projectid).Where(t => t.DateEnd < DateTime.Now).GroupBy(t => t.AssignedTo).ToList();

            /*
            int _TeamStatusTasksOverdue = _tcontext.Task.Where(t => t.ProjectId == projectid).Where(t => t.DateEnd < DateTime.Now).Count();
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
                //Tasks = await _tcontext.Task.ToListAsync(),
               // Bugs = await _bcontext.Project_Bugs.ToListAsync()

            };

            return model;

        } 

    }
}