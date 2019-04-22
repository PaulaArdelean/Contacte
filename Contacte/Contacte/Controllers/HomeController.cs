using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Contacte.Models;
using Contacte.Data;
using Contacte.Models.Entities;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Contacte.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if(User.Claims.Count() == 0)
            {
                return View(new List<Contact>());
            }
            var model = _context.Contacts.Where(d => d.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value);
            return View(model);
        }

        public IActionResult Create()
        {
            var model = new Contact();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(string FirstName, string LastName, string Email, string CNP, string PhoneNumber, string Address)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(new Contact() { FirstName = FirstName, LastName = LastName, Email = Email, CNP = CNP, PhoneNumber = PhoneNumber, Address = Address, UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value });
                _context.SaveChanges();
            }
            return RedirectToAction("index");
        }

        public IActionResult Edit(int? id)
        {
            var contact = _context.Contacts.SingleOrDefault(c => c.Id == id);
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, string FirstName, string LastName, string Email, string CNP, string PhoneNumber, string Address)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contact = _context.Contacts.SingleOrDefault(c => c.Id == id);
            contact.FirstName = FirstName;
            contact.LastName = LastName;
            contact.Email = Email;
            contact.CNP = CNP;
            contact.PhoneNumber = PhoneNumber;
            contact.Address = Address;
            _context.Update(contact);
            _context.SaveChanges();
            return RedirectToAction("Details", new { id = contact.Id });
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contact = _context.Contacts.SingleOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contact =  _context.Contacts.SingleOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var contact = _context.Contacts.SingleOrDefault(c => c.Id == id);
            _context.Remove(contact);
            _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
