using RestaurantData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberZoneFrontend.Controllers
{
    public class RestaurantController : Controller
    {
        IRestaurantData db;
        // GET: Restaurant
        public RestaurantController()
        {
            db = new InMemoryRestaurantData();
        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
    }
}