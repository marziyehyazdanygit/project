using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProject.Controllers
{
    public class orderController : Controller
    {
        // GET: order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectData(int? id)
        {
            var T = Models.orderS.SelectData(id);
            return View(T);
        }

        public ActionResult InsertData(string customer_id, string item_list, string item_count, string date, string price, string description)
        {
            var T = Models.orderS.InsertData(customer_id, item_list, item_count, date, price, description);
            return View(T);
        }


        public ActionResult UpdateData(string id, string customer_id, string item_list, string item_count, string date, string price, string description)
        {
            var T = Models.orderS.UpdateData(id, customer_id, item_list, item_count, date, price, description);
            return View(T);
        }


        public ActionResult DeleteData(string id)
        {
            var T = Models.orderS.DeleteData(id);
            return View(T);
        }
    }
}