using Microsoft.AspNetCore.Mvc;
using SwineManagementSys.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwineManagementSys.API
{
    [Route("[controller]")]
    [ApiController]
    public class FarmManagement : ControllerBase
    {
        // GET: api/<FarmManagement>
        [HttpGet]
        public IActionResult RegisterFarm(PmmFarmsMaster farmDetails)
        {
            try { return Ok(); }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}
