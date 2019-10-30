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
    public class CesantiasController : Controller
    {
        private readonly DataContext _context;

        public CesantiasController(DataContext context)
        {
            _context = context;
        }

        // GET: Cesantias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cesantias.ToListAsync());
        }

        // GET: Cesantias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cesantia = await _context.Cesantias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cesantia == null)
            {
                return NotFound();
            }

            return View(cesantia);
        }

        // GET: Cesantias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cesantias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Value,typeCesantia")] Cesantia cesantia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cesantia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cesantia);
        }

        // GET: Cesantias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cesantia = await _context.Cesantias.FindAsync(id);
            if (cesantia == null)
            {
                return NotFound();
            }
            return View(cesantia);
        }

        // POST: Cesantias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Value,typeCesantia")] Cesantia cesantia)
        {
            if (id != cesantia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cesantia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CesantiaExists(cesantia.Id))
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
            return View(cesantia);
        }

        // GET: Cesantias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cesantia = await _context.Cesantias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cesantia == null)
            {
                return NotFound();
            }

            return View(cesantia);
        }

        // POST: Cesantias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cesantia = await _context.Cesantias.FindAsync(id);
            _context.Cesantias.Remove(cesantia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CesantiaExists(int id)
        {
            return _context.Cesantias.Any(e => e.Id == id);
        }
    }
}
