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
        public async Task<IActionResult> Index(int projectid)
        {

            var model = new ProjectDashboardViewModel()
            {

                Tasks = await _tcontext.Task.ToListAsync(),

                Bugs = await _bcontext.Project_Bugs.ToListAsync()

            };

            return View(model);


        } 

    }
}