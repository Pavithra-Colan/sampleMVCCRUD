using sampleMVCCRUD.Models;
using System.Web.Mvc;
using sampleMVCCRUD.DAL;

namespace sampleMVCCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            ViewBag.Message = "Create new Employee";
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee collection)
        {
            try
            {
                DAL.EmployeeDAL EmployeeDataLayer = new EmployeeDAL();
                EmployeeDataLayer.AddNewEmployee(collection);

                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            DAL.EmployeeDAL editEmp = new EmployeeDAL();
            var editEmpDetails = editEmp.editEmployee(id);
            return View(editEmpDetails);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Employeelist()
        {
            DAL.EmployeeDAL DataS = new DAL.EmployeeDAL();
            var EmployeeList = DataS.EmployeeList();
            return View(EmployeeList);
        }
        
    }
}
