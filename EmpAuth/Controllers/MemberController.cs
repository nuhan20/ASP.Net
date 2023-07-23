using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmpAuth.Models;
using EmpAuth.Repository;
using System.Web.Security;

namespace EmpAuth.Controllers
{
    public class MemberController : Controller
    {
        MemberRepo repo;

        public MemberController()
        {
            this.repo = new MemberRepo();
        }
        // GET: Instructor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddMember()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMember(MemberModel member)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                var count = repo.AddMember(member);
                if (count > 0)
                {
                    ViewBag.Okay = "Data Added";
                }
            }
            return View();

        }

        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(MemberModel member)
        {

            var check = repo.VarifyMember(member);
            if (check>0)
            {
                FormsAuthentication.SetAuthCookie(member.Name, false);
                return RedirectToAction("GetAll", "Employee");
            }

            ViewBag.msg = "log in credentials not valid";
            ModelState.Clear();
            return View();
        }
        
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LogIn");
        }
    }
}