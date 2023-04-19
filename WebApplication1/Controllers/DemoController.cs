using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WebApp.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        protected readonly IDataService _dataService;
        public DemoController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Test(int empId, int productId)
        {
            var result = _dataService.GetData(empId, productId);
            return Ok(result);
        }
    }
}
