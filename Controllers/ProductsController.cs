using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simgenfrontend.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

        public ActionResult Select()
        {
            
            return View();
        }

        public ActionResult Details()   /*为什么是Details(int id)，有问题，把其内容删除*/
        {
            return View ();
        }

       

        //public ActionResult Create()
        //{
        //    return View ();
        //} 

        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try {
        //        return RedirectToAction ("Index");
        //    } catch {
        //        return View ();
        //    }
        //}

        //public ActionResult Edit(int id)
        //{
        //    return View ();
        //}

        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try {
        //        return RedirectToAction ("Index");
        //    } catch {
        //        return View ();
        //    }
        //}

        //public ActionResult Delete(int id)
        //{
        //    return View ();
        //}

        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try {
        //        return RedirectToAction ("Index");
        //    } catch {
        //        return View ();
        //    }
        //}
    }
}