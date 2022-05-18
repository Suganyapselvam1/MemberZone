using RestaurantData.Interface;
using RestaurantData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberZoneFrontend.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantData db;
        // GET: Restaurant
        public RestaurantController(IRestaurantData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
        public ActionResult Details(int Id)
        {
            var model = db.Get(Id);
            if (model==null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                db.Add(restaurant);
                return RedirectToAction("Details" , new { id=restaurant.ID});
            }
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var model = db.Get(Id);
            if (model==null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                db.Update(restaurant);
                return RedirectToAction("Details", new { id = restaurant.ID });
            }
            return View(restaurant);
        }
    }
}