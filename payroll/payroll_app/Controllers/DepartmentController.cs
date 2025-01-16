using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using payroll_app.Data;
using payroll_app.Models;
// using System.Text.Encodings.Web;

namespace payroll_app.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDBContext _context;

        public DepartmentController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Department
        public async Task<IActionResult> Index()
        {
            return View(await _context.departemen.ToListAsync());
            // return "This is the Welcome action method...";
        }

        // GET: Department/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departemenEntity = await _context.departemen
                .FirstOrDefaultAsync(m => m.id == id);
            if (departemenEntity == null)
            {
                return NotFound();
            }

            return View(departemenEntity);
        }

        // GET: Department/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,address")] DepartemenEntity departemenEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(departemenEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(departemenEntity);
        }

        // GET: Department/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departemenEntity = await _context.departemen.FindAsync(id);
            if (departemenEntity == null)
            {
                return NotFound();
            }
            return View(departemenEntity);
        }

        // POST: Department/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,address")] DepartemenEntity departemenEntity)
        {
            if (id != departemenEntity.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(departemenEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartemenEntityExists(departemenEntity.id))
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
            return View(departemenEntity);
        }

        // GET: Department/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departemenEntity = await _context.departemen
                .FirstOrDefaultAsync(m => m.id == id);
            if (departemenEntity == null)
            {
                return NotFound();
            }

            return View(departemenEntity);
        }

        // POST: Department/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var departemenEntity = await _context.departemen.FindAsync(id);
            if (departemenEntity != null)
            {
                _context.departemen.Remove(departemenEntity);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartemenEntityExists(int id)
        {
            return _context.departemen.Any(e => e.id == id);
        }
    }
}
