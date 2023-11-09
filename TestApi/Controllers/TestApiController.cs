using Microsoft.AspNetCore.Mvc;
using Serilog;
using WebApp.Contract;
using TestApi.Models;
using Application.Contract.Queries.GetProductQuery;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TestApiController : Controller
    {
        private readonly Serilog.ILogger _logger;
        private readonly IProcessor _processor;
        public TestApiController(Serilog.ILogger logger, IProcessor processor)
        {
            _logger = logger;
            _processor = processor;
        }
        [HttpGet]
        public async Task<ActionResult> GetProduct([FromBody] getProductRequest request)
        {
            try
            {
                if (request.id != null)
                { 
                    var result = await _processor.ExecuteAsync<GetProductQueryModel>(new GetProductQuery());
                    
                }
            }
            catch (Exception ex)
            {
                Log.Error("GetProduct error: " + ex.Message);
                return null;
            }
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetAllProduct()
        {
            try
            {
                var result = await _processor.ExecuteAsync<GetProductQueryModel>(new GetProductQuery());
            }
            catch (Exception ex)
            {
                Log.Error("GetProduct error: " + ex.Message);
                return null;
            }
            return Ok();
        }       
    }
}
