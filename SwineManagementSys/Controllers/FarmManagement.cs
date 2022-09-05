using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwineManagementSys.Controllers
{
    public class FarmManagement : Controller
    {
        // GET: FarmManagement
        public ActionResult ManageFarms()
        {
            return View();
        }
        public ActionResult AddFarms()
        {
            return View();
        }
    }
}
