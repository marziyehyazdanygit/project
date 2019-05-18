using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProject.Controllers
{
    public class order_itemController : Controller
    {
        // GET: order_item
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectData(int? id)
        {
            var T = Models.order_itemS.SelectData(id);
            return View(T);
        }

        public ActionResult InsertData(string shop_category_id, string name, string description)
        {
            var T = Models.order_itemS.InsertData(shop_category_id, name, description);
            return View(T);
        }


        public ActionResult UpdateData(string id, string shop_category_id, string name, string description)
        {
            var T = Models.order_itemS.UpdateData(id, shop_category_id, name, description);
            return View(T);
        }


        public ActionResult DeleteData(string id)
        {
            var T = Models.order_itemS.DeleteData(id);
            return View(T);
        }
    }
}