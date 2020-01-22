using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Controllers
{
    public class ProjectDashboardController : Controller
    {
        private readonly ProjectSettingsContext _context;

        public ProjectDashboardController(ProjectSettingsContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public async Task<IActionResult> Index(int projectid)
        {
            var results = await _context.ProjectSettings.ToListAsync();

            return View(results);
        }

    }
}