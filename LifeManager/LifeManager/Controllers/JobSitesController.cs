using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LifeManager.Models;

namespace LifeManager.Controllers
{
    public class JobSitesController : Controller
    {
        private readonly LifeManagerContext _context;

        public JobSitesController(LifeManagerContext context)
        {
            _context = context;
        }

        // GET: JobSites
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobSite.ToListAsync());
        }

        // GET: JobSites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobSite = await _context.JobSite
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobSite == null)
            {
                return NotFound();
            }

            return View(jobSite);
        }

        // GET: JobSites/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobSites/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] JobSite jobSite)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobSite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobSite);
        }

        // GET: JobSites/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobSite = await _context.JobSite.FindAsync(id);
            if (jobSite == null)
            {
                return NotFound();
            }
            return View(jobSite);
        }

        // POST: JobSites/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] JobSite jobSite)
        {
            if (id != jobSite.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobSite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobSiteExists(jobSite.Id))
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
            return View(jobSite);
        }

        // GET: JobSites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobSite = await _context.JobSite
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobSite == null)
            {
                return NotFound();
            }

            return View(jobSite);
        }

        // POST: JobSites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobSite = await _context.JobSite.FindAsync(id);
            _context.JobSite.Remove(jobSite);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobSiteExists(int id)
        {
            return _context.JobSite.Any(e => e.Id == id);
        }
    }
}
