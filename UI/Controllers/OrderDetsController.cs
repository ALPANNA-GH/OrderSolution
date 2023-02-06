using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace UI.Controllers
{
    public class OrderDetsController : Controller
    {
        private readonly StoreContext _context;

        public OrderDetsController(StoreContext context)
        {
            _context = context;
        }

        // GET: OrderDets
        public async Task<IActionResult> Index()
        {
              return _context.OrderDet != null ? 
                          View(await _context.OrderDet.ToListAsync()) :
                          Problem("Entity set 'StoreContext.OrderDet'  is null.");
        }

        // GET: OrderDets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OrderDet == null)
            {
                return NotFound();
            }

            var orderDet = await _context.OrderDet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderDet == null)
            {
                return NotFound();
            }

            return View(orderDet);
        }

        // GET: OrderDets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrderDets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OrderId,ItemDsc,Quantity,Price,Total")] OrderDet orderDet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderDet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orderDet);
        }

        // GET: OrderDets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OrderDet == null)
            {
                return NotFound();
            }

            var orderDet = await _context.OrderDet.FindAsync(id);
            if (orderDet == null)
            {
                return NotFound();
            }
            return View(orderDet);
        }

        // POST: OrderDets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OrderId,ItemDsc,Quantity,Price,Total")] OrderDet orderDet)
        {
            if (id != orderDet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderDet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderDetExists(orderDet.Id))
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
            return View(orderDet);
        }

        // GET: OrderDets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OrderDet == null)
            {
                return NotFound();
            }

            var orderDet = await _context.OrderDet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderDet == null)
            {
                return NotFound();
            }

            return View(orderDet);
        }

        // POST: OrderDets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OrderDet == null)
            {
                return Problem("Entity set 'StoreContext.OrderDet'  is null.");
            }
            var orderDet = await _context.OrderDet.FindAsync(id);
            if (orderDet != null)
            {
                _context.OrderDet.Remove(orderDet);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderDetExists(int id)
        {
          return (_context.OrderDet?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
