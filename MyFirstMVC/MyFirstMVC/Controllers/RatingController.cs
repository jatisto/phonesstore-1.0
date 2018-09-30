using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public IActionResult Index()
        {
            List<RatingModel> ratingModels = _context.RatingModels.ToList();
            return View(ratingModels);
        }
        
        public IActionResult Create()
        {
            ViewData["Star"] = new SelectList(_context.RatingModels, "Star", "Id");
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