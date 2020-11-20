using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext db { get; }
        public CustomersController(ApplicationDbContext db)
        {
            this.db = db;
        }
        // GET: CustomersController
        //public ActionResult Index(int id)
        //{
        //    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    var customer = db.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
        //    return View(customer);
        //}
        public ActionResult Index(int id)
        {
            CustomerEmployeeViewModel customerEmployeeViewModel = new CustomerEmployeeViewModel();
            
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Customer customer = db.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            if (customer != null)
            {
                return RedirectToAction(nameof(CustomerEmployeeViewModel));
            }
            else
            {
                return RedirectToAction(nameof(Create));
            }
            //    //is there a profile in customer table tied to this current user?
            //    //if yes - then redirect the details page ///// if no - redirect to create page
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(int id)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var customerInDB = db.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();

            return View(customerInDB);
        }

        // GET: CustomersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            try
            {
                //userId represents the primary key of the AspNetUser who is currently logged in
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = userId;
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(int id)
        {
            Customer customer = db.Customers.Where(c => c.CustomerId == id).FirstOrDefault();
            return View(customer);
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            try
            {
                db.Customers.Update(customer);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
