using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toystore.Models;

namespace Toystore.Controllers
{
    public class HomeController : Controller
    {

        ToystoreDBContext db = new ToystoreDBContext();

        public ActionResult Index()
        {
            return View(db.Toys);
        }


        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.ToyId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            order.Date = DateTime.Now;
            db.Orders.Add(order);
            db.SaveChanges();
            return $"Спасибо за покупку, {order.CustomerName}!";
        }

        [HttpGet]
        public string Summation(int a, int b)
        {
            return $"<h2>Сумма {a} и {b} равна {a + b}.</h2>";
        } 

        public FileResult GetPrice()
        {
            string fname = "Прайс лист.xlsx";
            string fpath = Server.MapPath($"~/Files/{fname}");
            string ftype = "application/xlsx";
            return File(fpath, ftype, fname);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult GetAuthors()
        {
            string[] authors = new string[] { "Пушкин А.С.", "Лермонтов М.Ю.", "Снегов С.А." };
            return PartialView(authors);
        }

    }
}