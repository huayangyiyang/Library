using BLL;
using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class BookController : Controller
    {
        protected IBookBLL boookbll = new BookBLL();
        // GET: Book
        public ActionResult List()
        {
            return View(boookbll.GetAll());
        }
    }
}