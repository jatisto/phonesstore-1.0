﻿using System;using System.Collections.Generic;using System.Linq;using System.Threading.Tasks;using Microsoft.AspNetCore.Mvc;using Microsoft.AspNetCore.Mvc.Rendering;using Microsoft.EntityFrameworkCore;using MyFirstMVC.Models;using MyFirstMVC.ViewModels;namespace MyFirstMVC.Controllers{    public class PhonesController : Controller    {        private readonly ApplicationDbContext _context;        public PhonesController(ApplicationDbContext context)        {            _context = context;        }        // GET: Phones        public async Task<IActionResult> Index(int? companyId, string name, bool check)        {            List<Company> companies = _context.Companies.ToList();            var phones = _context.Phones.Include(p => p.Category).Include(p => p.Company).ToList();            IndexViewModel ivm = new IndexViewModel();            if (companyId.HasValue)            {                phones = phones.Where(p => p.Company.Id == companyId.Value).ToList();                ivm.Company = companies.FirstOrDefault(c => c.Id == companyId.Value);            }            if (!string.IsNullOrWhiteSpace(name))            {                phones = phones.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();                ivm.Name = name;            }            ivm.Companies = companies;            ivm.Phones = phones;            CurrencyMethod(out var exchangeRateKgs);            return View(ivm);        }        public void CurrencyMethod(out ExchangeRate exchangeRateKgs)        {            exchangeRateKgs = _context.ExchangeRates.FirstOrDefault(x => x._currencyCode == "KGS");            if (exchangeRateKgs != null) ViewBag.RateKgs = exchangeRateKgs._currencyRate;        }        // GET: Phones/Details/5        public async Task<IActionResult> Details(int? id)        {            if (id == null)            {                return NotFound();            }            var phone = await _context.Phones                .Include(p => p.Category)                .FirstOrDefaultAsync(m => m.Id == id);            if (phone == null)            {                return NotFound();            }            return View(phone);        }        // GET: Phones/Create        public IActionResult Create()        {            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id");            return View();        }        // POST: Phones/Create        // To protect from overposting attacks, please enable the specific properties you want to bind to, for         // more details see http://go.microsoft.com/fwlink/?LinkId=317598.        [HttpPost]        [ValidateAntiForgeryToken]        public async Task<IActionResult> Create([Bind("Id,Name,Company,Price,CategoryId")]            Phone phone)        {            if (ModelState.IsValid)            {                _context.Add(phone);                await _context.SaveChangesAsync();                return RedirectToAction(nameof(Index));            }            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", phone.CategoryId);            return View(phone);        }        // GET: Phones/Edit/5        public async Task<IActionResult> Edit(int? id)        {            if (id == null)            {                return NotFound();            }            var phone = await _context.Phones.FindAsync(id);            if (phone == null)            {                return NotFound();            }            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", phone.CategoryId);            return View(phone);        }        [HttpPost]        [ValidateAntiForgeryToken]        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Company,Price,CategoryId")]            Phone phone)        {            if (id != phone.Id)            {                return NotFound();            }            if (ModelState.IsValid)            {                try                {                    _context.Update(phone);                    await _context.SaveChangesAsync();                }                catch (DbUpdateConcurrencyException)                {                    if (!PhoneExists(phone.Id))                    {                        return NotFound();                    }                    else                    {                        throw;                    }                }                return RedirectToAction(nameof(Index));            }            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", phone.CategoryId);            return View(phone);        }        // GET: Phones/Delete/5        public async Task<IActionResult> Delete(int? id)        {            if (id == null)            {                return NotFound();            }            var phone = await _context.Phones                .Include(p => p.Category)                .FirstOrDefaultAsync(m => m.Id == id);            if (phone == null)            {                return NotFound();            }            return View(phone);        }        // POST: Phones/Delete/5        [HttpPost, ActionName("Delete")]        [ValidateAntiForgeryToken]        public async Task<IActionResult> DeleteConfirmed(int id)        {            var phone = await _context.Phones.FindAsync(id);            _context.Phones.Remove(phone);            await _context.SaveChangesAsync();            return RedirectToAction(nameof(Index));        }        private bool PhoneExists(int id)        {            return _context.Phones.Any(e => e.Id == id);        }    }}