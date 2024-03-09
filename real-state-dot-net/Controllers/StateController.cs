using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealStateDotNet.Data;
using RealStateDotNet.Models;

namespace RealStateDotNet.Controllers
{
    public class StateController : Controller
    {
        private readonly RealStateDotNetContext _context;

        public StateController(RealStateDotNetContext context)
        {
            _context = context;
        }

        // GET: State
        public async Task<IActionResult> Index()
        {
            return View(await _context.State.ToListAsync());
        }

        // GET: State/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var state = await _context.State
                .FirstOrDefaultAsync(m => m.Acronym == id);
            if (state == null)
            {
                return NotFound();
            }

            return View(state);
        }

        // GET: State/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: State/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Acronym,Name")] State state)
        {
            if (ModelState.IsValid)
            {
                _context.Add(state);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(state);
        }

        // GET: State/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var state = await _context.State.FindAsync(id);
            if (state == null)
            {
                return NotFound();
            }
            return View(state);
        }

        // POST: State/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Acronym,Name")] State state)
        {
            if (id != state.Acronym)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(state);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StateExists(state.Acronym))
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
            return View(state);
        }

        // GET: State/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var state = await _context.State
                .FirstOrDefaultAsync(m => m.Acronym == id);
            if (state == null)
            {
                return NotFound();
            }

            return View(state);
        }

        // POST: State/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var state = await _context.State.FindAsync(id);
            if (state != null)
            {
                _context.State.Remove(state);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StateExists(string id)
        {
            return _context.State.Any(e => e.Acronym == id);
        }
    }
}
