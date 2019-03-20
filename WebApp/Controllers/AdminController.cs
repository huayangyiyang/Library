using BLL;
using DAL;
using IBLL;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class AdminController : Controller
    {        
        private IUserBLL userBLL = new UserBLL();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(LAdmin user)
        {
            userBLL.Add(user);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View( userBLL.GetById(id) );
        }

        [HttpPost]
        public ActionResult Edit(LAdmin newUser)
        {
            userBLL.Modify(newUser , "adminname", "adminpassword", "adminroles");
            return RedirectToAction("List");
        }

        public ActionResult Delete( int id )
        {
            userBLL.DeleteById(id);
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            // return View();
            return View(userBLL.GetAll());
        }
    }
}