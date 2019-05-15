using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlytaloMvc.Controllers
{
    public class SaunaController : Controller
    {
        // GET: Sauna
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult SaunaStatus()
        //{
        //    ProjektitDBCareEntities saunaOnOff = new ProjektitDBCareEntities();

            

        //    saunaOnOff.Dispose();

         
        //}


        // GET: Sauna/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sauna/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sauna/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sauna/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sauna/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sauna/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sauna/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
