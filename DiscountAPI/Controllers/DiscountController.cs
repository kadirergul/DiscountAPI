using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DiscountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly ILogger<DiscountController> _logger;

        public DiscountController(ILogger<DiscountController> logger)
        {
            _logger = logger;
        }

        [HttpPost("GetDiscountAppliedInvoice")]
        public ActionResult<Invoice> GetDiscountAppliedInvoice([FromBody]Invoice request)
        {
            //_logger.Log(LogLevel.Information, Request.QueryString.Value);

            return Ok("Hello API");
        }
    }
}
