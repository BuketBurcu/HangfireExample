using HangfireExample.Schedules;
using Microsoft.AspNetCore.Mvc;

namespace HangfireExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
           // RecurringJobs.RecurringExample();
           // FireAndForget.FireAndForgetExample();
            ContinuationsJob.ContinuationExamp();
            DelayedJobs.DelayedExample();

            return null;
        }
    }
}
