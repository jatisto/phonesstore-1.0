using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MyFirstMVC.Models;

namespace MyFirstMVC.Controllers
{
    public class ValidationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ValidationController(ApplicationDbContext context)
        {
            _context = context;
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult CheckName(string name)
        {
            List<Company> companies = _context.Companies.ToList();

            // var companies = _context.Companies.Include(c => c._Company);

            foreach (var company in companies)
            {
                if (company.Name == name)
                {
                    return Json(false);
                }
            }
            
//            foreach (var company in companies)
//            {
//                if (company.Name.Any(c => name.Contains(c, StringComparison.OrdinalIgnoreCase)))
//                {
//                    return Json(false);
//                }
//            }

            return Json(true);
        }
    }
}