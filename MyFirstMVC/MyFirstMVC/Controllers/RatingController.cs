using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFirstMVC.Models;

namespace MyFirstMVC.Controllers
{
    public class RatingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RatingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET
//        public IActionResult Index()
//        {
//            List<RatingModel> ratingModels = _context.RatingModels.ToList();
//            return View(ratingModels);
//        }

        public IActionResult Index()
        {
            var rating = _context.RatingModels.Include(r => r.Id == r.SymbolStarlId);
            return View(rating);
        }

        public IActionResult Create()
        {
            ViewData["_starSymbolId"] = new SelectList(_context.StarSymbols, "id", "_starSymbolId");
            ViewData["PhoneId"] = new SelectList(_context.Phones, "Id", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RatingModel rating)
        {
            if (ModelState.IsValid)
            {
                _context.RatingModels.Add(rating);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["PhoneId"] = new SelectList(_context.Phones, "Id", "Id", rating.PhoneId);
            return View(rating);
        }
    }
}