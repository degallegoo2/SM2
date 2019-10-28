using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SM2.Web.Data;
using SM2.Web.Data.Entities;

namespace SM2.Web.Controllers
{
    public class RepsController : Controller
    {
        private readonly DataContext _context;

        public RepsController(DataContext context)
        {
            _context = context;
        }

        // GET: Reps
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reps.ToListAsync());
        }

        // GET: Reps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rep = await _context.Reps
                .FirstOrDefaultAsync(m => m.rep_id == id);
            if (rep == null)
            {
                return NotFound();
            }

            return View(rep);
        }

        // GET: Reps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("rep_id,nombre,email,activo,tipo,pais,cedula,empresa")] Rep rep)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rep);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rep);
        }

        // GET: Reps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rep = await _context.Reps.FindAsync(id);
            if (rep == null)
            {
                return NotFound();
            }
            return View(rep);
        }

        // POST: Reps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("rep_id,nombre,email,activo,tipo,pais,cedula,empresa")] Rep rep)
        {
            if (id != rep.rep_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rep);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RepExists(rep.rep_id))
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
            return View(rep);
        }

        // GET: Reps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rep = await _context.Reps
                .FirstOrDefaultAsync(m => m.rep_id == id);
            if (rep == null)
            {
                return NotFound();
            }

            return View(rep);
        }

        // POST: Reps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rep = await _context.Reps.FindAsync(id);
            _context.Reps.Remove(rep);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RepExists(int id)
        {
            return _context.Reps.Any(e => e.rep_id == id);
        }
    }
}
