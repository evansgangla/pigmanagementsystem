using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwineManagementSys.Controllers
{
    public class Configurations : Controller
    {
        // GET: Configurations
        public ActionResult CullingReasons()
        {
            return View();
        }

        // GET: Configurations/Details/5
        public ActionResult Users(int id)
        {
            return View();
        }

        // GET: Configurations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Configurations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Configurations/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Configurations/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Configurations/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Configurations/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
