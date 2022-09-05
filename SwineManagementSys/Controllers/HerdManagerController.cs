using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwineManagementSys.Controllers
{
    public class HerdManagerController : Controller
    {
        // GET: HerdManagerController
        public ActionResult HerdComposition()
        {
            return View();
        }

    }
}
