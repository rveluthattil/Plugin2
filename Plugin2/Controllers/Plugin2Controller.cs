using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Plugin2.Models;
using System.ComponentModel.Composition;

namespace Plugin2.Controllers
{
    [Export("Plugin2",typeof(IController))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Plugin2Controller : Controller
    {
        // GET: Plugin2
        public ActionResult Index()
        {
            ShopOrderModel mdl = new ShopOrderModel
            {
                CustomerId = 1,
                CustomerName = "Test",
                ShopOrderId = 1,
                sessionInfo = Session["test"].ToString()
            };
            ViewBag.shoporder = mdl;
            return View();
        }
    }
}