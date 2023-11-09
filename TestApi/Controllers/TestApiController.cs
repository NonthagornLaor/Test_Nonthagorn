using Microsoft.AspNetCore.Mvc;
using Serilog;
using WebApp.Contract;
using TestApi.Models;
using Application.Contract.Queries.GetProductQuery;
using Application.Contract.Queries.GetAllProductQuery;
using Application.Contract.Queries.AddProductQuery;
using Application.Contract.Queries.UpdateProductByIDQuery;

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
                    var result = await _processor.ExecuteAsync<GetProductQueryModel>(new GetProductQuery() 
                    { 
                        id = request.id
                    });
                    
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
                var result = await _processor.ExecuteAsync<GetAllProductQueryModel>(new GetAllProductQuery());
            }
            catch (Exception ex)
            {
                Log.Error("GetAllProduct error: " + ex.Message);
                return null;
            }
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] addProductRequest request)
        {
            try
            {
                var result = await _processor.ExecuteAsync<AddProductQueryModel>(new AddProductQuery()
                {
                    product_name = request.product_name,
                    product_decription  = request.product_decription,
                    product_price = request.product_price
                });
            }
            catch (Exception ex)
            {
                Log.Error("AddProduct error: " + ex.Message);
                return null;
            }
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> UpdateProductByID([FromBody] updateProductById request)
        {
            try
            {
                var result = await _processor.ExecuteAsync<UpdateProductByIDQueryModel>(new UpdateProductByIDQuery()
                {
                    id = request.id,
                    product_name = request.product_name,
                    product_decription = request.product_decription,
                    product_price = request.product_price
                });
            }
            catch (Exception ex)
            {
                Log.Error("UpdateProductByID error: " + ex.Message);
                return null;
            }
            return Ok();
        }
    }
}
