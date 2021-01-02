using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoRepository.DataAccess;
using DemoRepository.Model;
namespace MvcRepos.Controllers
{
    public class HomeController : Controller
    {
        InterfaceRepo inter = new Implemantation();
        List<XpayDetails> list = new List<XpayDetails>();

        public ActionResult Index()
        {

            //List<Student> list1 = new List<Student>();
            list = inter.Show_Record();
            return View(list);

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new XpayDetails());
        }
        [HttpPost]
        public ActionResult Create(XpayDetails xp)
        {

            inter.Insert_record(xp);
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            list = inter.Show_Record();
            XpayDetails s1 = list.FirstOrDefault(s => s.Id == id);
            return View(s1);
        }
        [HttpPost]
        public ActionResult Delete(XpayDetails xp)
        {

            inter.Dlt_Record(xp);
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            list = inter.Show_Record();
            XpayDetails s1 = list.FirstOrDefault(s => s.Id == id);
            return View(s1);
        }
        [HttpPost]
        public ActionResult Update(XpayDetails xp)
        {
            inter.Update_Record(xp);
            return RedirectToAction("index");

        }
    }
}