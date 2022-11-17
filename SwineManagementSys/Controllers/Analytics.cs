using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwineManagementSys.Controllers
{
    public class Analytics : Controller
    {
        // GET: Analytics
        public ActionResult Weather()
        {
            return View();
        }
        public ActionResult Feeds()
        {
            return View();
        }
        public ActionResult Sales()
        {
            return View();
        }
    }
}
