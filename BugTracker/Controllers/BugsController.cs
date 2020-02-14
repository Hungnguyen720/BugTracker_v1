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
    public class BugsController : Controller
    {
        private readonly BugContext _context;

        public BugsController(BugContext context)
        {
            _context = context;
        }

        // GET: Bugs
        [Route("/projectdashboard/bugs")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Project_Bugs.ToListAsync());
        }

        // GET: Bugs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugs = await _context.Project_Bugs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bugs == null)
            {
                return NotFound();
            }

            return View(bugs);
        }

        // GET: Bugs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bugs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProjectID,Title,Description,AssignedTo,Status,DateCreated,DueDate,Severity,Flag,Comment,Reporter,Reproducible")] Bugs bugs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bugs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bugs);
        }

        // GET: Bugs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugs = await _context.Project_Bugs.FindAsync(id);
            if (bugs == null)
            {
                return NotFound();
            }
            return View(bugs);
        }

        // POST: Bugs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProjectID,Title,Description,AssignedTo,Status,DateCreated,DueDate,Severity,Flag,Comment,Reporter,Reproducible")] Bugs bugs)
        {
            if (id != bugs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bugs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BugsExists(bugs.Id))
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
            return View(bugs);
        }

        // GET: Bugs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugs = await _context.Project_Bugs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bugs == null)
            {
                return NotFound();
            }

            return View(bugs);
        }

        // POST: Bugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bugs = await _context.Project_Bugs.FindAsync(id);
            _context.Project_Bugs.Remove(bugs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BugsExists(int id)
        {
            return _context.Project_Bugs.Any(e => e.Id == id);
        }
    }
}
