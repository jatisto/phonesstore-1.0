using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFirstMVC.Models;

namespace MyFirstMVC.Controllers
{
    public class CommentController : Controller
    {
        
        private readonly ApplicationDbContext _context;

        public CommentController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        // GET
        public async Task<IActionResult> Index()
        {
            var comments = _context.Comments.Include(c => c.Phone);
            return View(await comments.ToListAsync());
        }
        
                
        public IActionResult Create()
        {
            ViewData["PhoneId"] = new SelectList(_context.Phones, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                _context.Comments.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["PhoneId"] = new SelectList(_context.Phones, "Id", "Id", comment.PhoneId);
            return View(comment);
        }
    }
}