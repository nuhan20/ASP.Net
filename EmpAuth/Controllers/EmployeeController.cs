using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmpAuth.Repository;
using EmpAuth.Models;

namespace EmpAuth.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        EmployeeRepo repo;
        public EmployeeController()
        {
            this.repo = new EmployeeRepo();
        }
        
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(EmployeeModel emp)
        {
            
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                var count = repo.AddEmployee(emp);
                if (count > 0)
                {
                    ViewBag.Okay = "Data Added";
                    //return View("GetAll");
                }
            }
            return View();
        }

        public ActionResult GetAll()
        {
            var data = repo.GetAllData();
            return View(data);
        }

        public ActionResult Details(int id)
        {
            var data = repo.GetDetails(id);
            return View(data);
        }

        public ActionResult Edit(int id)
        {
          
            var data = repo.GetDetails(id);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(int id, EmployeeModel student)
        {


            if (ModelState.IsValid)
            {
                ModelState.Clear();
                var count = repo.UpdateData(id, student);

                return RedirectToAction("GetAll");

            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var data = repo.DeleteData(id);
            return RedirectToAction("GetAll");
        }

    }
}