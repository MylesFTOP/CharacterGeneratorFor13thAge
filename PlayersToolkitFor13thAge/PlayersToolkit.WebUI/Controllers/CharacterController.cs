using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlayersToolkit.WebUI.Data;
using PlayersToolkit.WebUI.Models;

namespace PlayersToolkit.WebUI.Controllers
{
    public class CharacterController : Controller
    {
        private readonly PlayersToolkitWebUIContext _context;

        public CharacterController(PlayersToolkitWebUIContext context)
        {
            _context = context;
        }

        // GET: Character
        public async Task<IActionResult> Index()
        {
            return View(await _context.CharacterViewModel.ToListAsync());
        }

        // GET: Character/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterViewModel = await _context.CharacterViewModel
                .FirstOrDefaultAsync(m => m.CharacterViewModelId == id);
            if (characterViewModel == null)
            {
                return NotFound();
            }

            return View(characterViewModel);
        }

        // GET: Character/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Character/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CharacterViewModelId")] CharacterViewModel characterViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(characterViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(characterViewModel);
        }

        // GET: Character/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterViewModel = await _context.CharacterViewModel.FindAsync(id);
            if (characterViewModel == null)
            {
                return NotFound();
            }
            return View(characterViewModel);
        }

        // POST: Character/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CharacterViewModelId")] CharacterViewModel characterViewModel)
        {
            if (id != characterViewModel.CharacterViewModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(characterViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharacterViewModelExists(characterViewModel.CharacterViewModelId))
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
            return View(characterViewModel);
        }

        // GET: Character/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterViewModel = await _context.CharacterViewModel
                .FirstOrDefaultAsync(m => m.CharacterViewModelId == id);
            if (characterViewModel == null)
            {
                return NotFound();
            }

            return View(characterViewModel);
        }

        // POST: Character/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var characterViewModel = await _context.CharacterViewModel.FindAsync(id);
            _context.CharacterViewModel.Remove(characterViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharacterViewModelExists(int id)
        {
            return _context.CharacterViewModel.Any(e => e.CharacterViewModelId == id);
        }
    }
}
