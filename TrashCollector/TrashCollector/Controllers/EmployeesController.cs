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
    public class EmployeesController : Controller
    {
        private ApplicationDbContext db { get; }
        public EmployeesController(ApplicationDbContext db)
        {
            this.db = db;
        }
        //GET: EmployeesController
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Employee employee = db.Employees.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            if (employee != null)
            {
                var pickups = db.Customers.Where(c => c.PickupDay == DateTime.Today.DayOfWeek.ToString() && c.ZipCode == employee.ZipCode);
                return View(pickups);
            }
            else
            {
                return RedirectToAction(nameof(Create));
            }
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var EmployeeInDB = db.Employees.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            return View(EmployeeInDB);
            //list of todays pickups determined by EMPLOYEE ZIP CODE
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = userId;
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            Employee employee = db.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
            return View(employee);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            try
            {
                db.Employees.Update(employee);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
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
