using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.IO;

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
        //public ContentResult TestPost()
        //{
            
        //    StreamReader sw = new StreamReader(@"e:\iotext.txt", Encoding.UTF8);
        //    return Content("<div>" + sw + "</div>");
        //    sw.Close();
            
        //}
        //static void Main(string[] args)
        //{
        //    using (FileStream fs = new FileStream(@"D:\sql.txt", FileMode.Open, FileAccess.Read))
        //    {
        //        StreamReader sr = new StreamReader(fs);
        //        string line1 = sr.ReadLine();
        //        Console.WriteLine(line1);       //输出 111111111111
        //    }

        //    Console.ReadKey();
        //}



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