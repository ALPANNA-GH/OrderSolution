using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Repos.RepoMain;

namespace UI.Controllers
{
    public class OrderHeadsController : Controller
    {
        private readonly StoreContext _context;

        public OrderHeadsController(StoreContext context)
        {
            _context = context;
        }

        // GET: OrderHeads
        public async Task<IActionResult> Index()
        {
              return _context.OrderHead != null ? 
                          View(await _context.OrderHead.ToListAsync()) :
                          Problem("Entity set 'StoreContext.OrderHead'  is null.");
        }

        // GET: OrderHeads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OrderHead == null)
            {
                return NotFound();
            }

            var orderHead = await _context.OrderHead
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderHead == null)
            {
                return NotFound();
            }

            return View(orderHead);
        }

        // GET: OrderHeads/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrderHeads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerName,Address,PhonNum,Date")] OrderHead orderHead)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderHead);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orderHead);
        }

        // GET: OrderHeads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OrderHead == null)
            {
                return NotFound();
            }

            var orderHead = await _context.OrderHead.FindAsync(id);
            if (orderHead == null)
            {
                return NotFound();
            }
            return View(orderHead);
        }

        // POST: OrderHeads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CustomerName,Address,PhonNum,Date")] OrderHead orderHead)
        {
            if (id != orderHead.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderHead);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderHeadExists(orderHead.Id))
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
            return View(orderHead);
        }

        // GET: OrderHeads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OrderHead == null)
            {
                return NotFound();
            }

            var orderHead = await _context.OrderHead
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderHead == null)
            {
                return NotFound();
            }

            return View(orderHead);
        }

        // POST: OrderHeads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OrderHead == null)
            {
                return Problem("Entity set 'StoreContext.OrderHead'  is null.");
            }
            var orderHead = await _context.OrderHead.FindAsync(id);
            if (orderHead != null)
            {
                _context.OrderHead.Remove(orderHead);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderHeadExists(int id)
        {
          return (_context.OrderHead?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
