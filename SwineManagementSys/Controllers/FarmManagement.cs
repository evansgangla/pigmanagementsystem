using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwineManagementSys.Models;

namespace SwineManagementSys.Controllers
{
    public class FarmManagement : Controller
    {
        private epigsContext _db;
        public FarmManagement(ILogger<HomeController> logger, epigsContext ctx)
        {
            _db = ctx;
        }
        // GET: FarmManagement
        public ActionResult ManageFarms()
        {
            return View(_db.PmmFarmsMasters.ToList());
        }
        public ActionResult AddFarms()
        {
            return View();
        }
        public ActionResult HerdPens()
        {
            return View();
        }
        public ActionResult Stores()
        {
            return View();
        }
        public ActionResult TaskLists()
        {
            return View();
        }
        public ActionResult ManageTasks()
        {
            return View();
        }
        public ActionResult PendingTasks()
        {
            return View();
        }
        public ActionResult OverdueTasks()
        {
            return View();
        }
        #region HTTP POST Requests
        [HttpPost]
        public JsonResult RegisterFarm(PmmFarmsMaster farmDetails)
        {
            try
            {
                var _farmData = new PmmFarmsMaster
                {
                    CreatedOn = DateTime.Now,
                    FarmContactPerson = farmDetails.FarmContactPerson,
                    FarmActive = true,
                    FarmAddress = farmDetails.FarmAddress,
                    FarmCountry = farmDetails.FarmCountry,
                    FarmCounty = farmDetails.FarmCounty,
                    FarmEmail = farmDetails.FarmEmail,
                    FarmLocation = farmDetails.FarmLocation,
                    MainFarmId = farmDetails.MainFarmId,
                    FarmTelephone = farmDetails.FarmTelephone,
                    GeoTag = farmDetails.GeoTag,
                    FarmName = farmDetails.FarmName,
                    ManagerFirstName = farmDetails.ManagerFirstName,
                    ManagerAlternateEmail = farmDetails.ManagerAlternateEmail,
                    ManagerEmailAddress = farmDetails.ManagerEmailAddress,
                    ManagerLastName = farmDetails.ManagerLastName,
                    ManagerMiddleName = farmDetails.ManagerMiddleName,
                    ManagerPhoneNumber = farmDetails.ManagerPhoneNumber,
                    TatooPrefix =  farmDetails.TatooPrefix,
                    TatooLength = farmDetails.TatooLength,
                    SvcStatus = "true",
                    FarmTown = farmDetails.FarmTown,
                    FarmId = farmDetails.FarmId,    
                    FarmStore = farmDetails.FarmStore,
                    UniqueId = Guid.NewGuid(),
                    Size = farmDetails.Size,
                    UoM =   farmDetails.UoM
                };
                using var db = new epigsContext();
                db.PmmFarmsMasters.Add(_farmData);
                db.SaveChanges();
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }
        #endregion
    }
}
