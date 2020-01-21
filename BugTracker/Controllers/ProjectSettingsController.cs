using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BugTracker.Data;
using BugTracker.Models;

namespace BugTracker.Controllers
{
    public class ProjectSettingsController : Controller
    {
        private readonly ProjectSettingsContext _context;

        public ProjectSettingsController(ProjectSettingsContext context)
        {
            _context = context;
        }

        // GET: ProjectSettings
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectSettings.ToListAsync());
        }

        // GET: ProjectSettings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectSettingsModel = await _context.ProjectSettings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectSettingsModel == null)
            {
                return NotFound();
            }

            return View(projectSettingsModel);
        }

        // GET: ProjectSettings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectSettings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProjectId,ProjectName,Owner,DateStart,DateEnd,ProjectOverview")] ProjectSettingsModel projectSettingsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectSettingsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectSettingsModel);
        }

        // GET: ProjectSettings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectSettingsModel = await _context.ProjectSettings.FindAsync(id);
            if (projectSettingsModel == null)
            {
                return NotFound();
            }
            return View(projectSettingsModel);
        }

        // POST: ProjectSettings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProjectId,ProjectName,Owner,DateStart,DateEnd,ProjectOverview")] ProjectSettingsModel projectSettingsModel)
        {
            if (id != projectSettingsModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectSettingsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectSettingsModelExists(projectSettingsModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(projectSettingsModel);
        }

        // GET: ProjectSettings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectSettingsModel = await _context.ProjectSettings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectSettingsModel == null)
            {
                return NotFound();
            }

            return View(projectSettingsModel);
        }

        // POST: ProjectSettings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectSettingsModel = await _context.ProjectSettings.FindAsync(id);
            _context.ProjectSettings.Remove(projectSettingsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectSettingsModelExists(int id)
        {
            return _context.ProjectSettings.Any(e => e.Id == id);
        }
    }
}
