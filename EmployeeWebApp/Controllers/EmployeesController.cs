using System.Data.Entity;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using EmployeeWebApp.Models;
using EmployeeWebApp.Models.EF;
using System.Collections.Generic;
using EmployeeWebApp.Helper;

namespace EmployeeWebApp.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeeDB db = new EmployeeDB();
        private EmployeeModel employee = new EmployeeModel();

        // GET: Employees
        public async Task<ActionResult> Index()
        {
            var records = await db.Employees.ToListAsync();
            var viewList = new List<EmployeeModel>();
            var countries = CommonData.GetCountryList();
            var states = CommonData.GetStateList();

            foreach (var value in records)
            {
                var emp = employee.Mapper(value);
                emp.Country = countries.Find(x => x.Value == emp.CountryId.ToString()).Text;
                emp.State = states.Find(x => x.StateId == emp.StateId).StateName;
                viewList.Add(emp);
            }

            ViewBag.CountryList = new SelectList(CommonData.GetCountryList(), "Value", "Text");
            return View(viewList);
        }

        // GET: Employees/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var countries = CommonData.GetCountryList();
            var states = CommonData.GetStateList();
            employee = employee.Mapper(await db.Employees.FindAsync(id));
            employee.Country = countries.Find(x => x.Value == employee.CountryId.ToString()).Text;
            employee.State = states.Find(x => x.StateId == employee.StateId).StateName;

            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.CountryList = new SelectList(CommonData.GetCountryList(), "Value", "Text");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "EmployeeId,Name,Email,Salary,CountryId,StateId")] EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                var emp = new Employee { Name = employee.Name, Email = employee.Email, Salary = employee.Salary, CountryId = employee.CountryId, StateId = employee.StateId };
                db.Employees.Add(emp);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CountryList = new SelectList(CommonData.GetCountryList(), "Value", "Text");
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            employee = employee.Mapper(await db.Employees.FindAsync(id));

            if (employee == null)
            {
                return HttpNotFound();
            }

            ViewBag.CountryList = new SelectList(CommonData.GetCountryList(), "Value", "Text");
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "EmployeeId,Name,Email,Salary,CountryId,StateId")] EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                var emp = new Employee { EmployeeId = employee.EmployeeId, Name = employee.Name, Email = employee.Email, Salary = employee.Salary, CountryId = employee.CountryId, StateId = employee.StateId };
                db.Entry(emp).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CountryList = new SelectList(CommonData.GetCountryList(), "Value", "Text");
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            employee = employee.Mapper(await db.Employees.FindAsync(id));

            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var employee = await db.Employees.FindAsync(id);
            db.Employees.Remove(employee);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult FillState(int country)
        {
            var cities = CommonData.GetStateList();
            return Json(cities.FindAll(x => x.CountryId == country), JsonRequestBehavior.AllowGet);
        }
    }
}
