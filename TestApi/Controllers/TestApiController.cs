using Microsoft.AspNetCore.Mvc;
using Serilog;
using WebApp.Contract;
using TestApi.Models;
using Application.Contract.Queries.GetProductQuery;
using Application.Contract.Queries.GetAllProductQuery;
using Application.Contract.Queries.AddProductQuery;
using Application.Contract.Queries.UpdateProductByIDQuery;
using Application.Contract.Queries.DeleteProductQuery;

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
            List<GetResponse> getDataList = new List<GetResponse>();
            GetResponse getResponse = new GetResponse();
            statusResponse statusResponse = new statusResponse();
            GetData getData = new GetData();
            try
            {
                if (request.id != null)
                { 
                    var result = await _processor.ExecuteAsync<GetProductQueryModel>(new GetProductQuery() 
                    { 
                        id = request.id
                    });
                    if (result != null)
                    {
                        foreach (var value in result.Data)
                        {
                            getResponse = new GetResponse();
                            getResponse.product_id = value.product_id;
                            getResponse.product_name = value.product_name;
                            getResponse.product_price = value.product_price;
                            getResponse.product_decription = value.product_decription;
                            getResponse.create_date = value.create_date;
                            getResponse.last_update_date = value.last_update_date;
                            getDataList.Add(getResponse);
                        }
                        statusResponse = new statusResponse();
                        statusResponse.statusCode = 1;
                        statusResponse.statusMessage = "GetProduct Success";                       
                    }
                    else
                    {
                        statusResponse = new statusResponse();
                        statusResponse.statusCode = 0;
                        statusResponse.statusMessage = "GetProduct Not found";
                    }
                    getData = new GetData();
                    getData.status = statusResponse;
                    getData.Data = getDataList;
                }
            }
            catch (Exception ex)
            {
                Log.Error("GetProduct error: " + ex.Message);

                statusResponse = new statusResponse();
                statusResponse.statusCode = -1;
                statusResponse.statusMessage = "GetProduct Failed"; ;

                getData = new GetData();
                getData.status = statusResponse;
                getData.Data = null;
            }
            return Ok(getData);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllProduct()
        {
            List<GetResponse> getDataList = new List<GetResponse>();
            GetResponse getResponse = new GetResponse();
            statusResponse statusResponse = new statusResponse();
            GetData getData = new GetData();
            try
            {
                var result = await _processor.ExecuteAsync<GetAllProductQueryModel>(new GetAllProductQuery());
                if (result != null)
                {
                    foreach (var value in result.Data)
                    {
                        getResponse = new GetResponse();
                        getResponse.product_id = value.product_id;
                        getResponse.product_name = value.product_name;
                        getResponse.product_price = value.product_price;
                        getResponse.product_decription = value.product_decription;
                        getResponse.create_date = value.create_date;
                        getResponse.last_update_date = value.last_update_date;
                        getDataList.Add(getResponse);
                    }
                    statusResponse = new statusResponse();
                    statusResponse.statusCode = 1;
                    statusResponse.statusMessage = "GetAllProduct Success";
                }
                else
                {
                    statusResponse = new statusResponse();
                    statusResponse.statusCode = 0;
                    statusResponse.statusMessage = " GetAllProduct Not found";
                }
                getData = new GetData();
                getData.status = statusResponse;
                getData.Data = getDataList;
            }
            catch (Exception ex)
            {
                Log.Error("GetAllProduct error: " + ex.Message);
                statusResponse = new statusResponse();
                statusResponse.statusCode = -1;
                statusResponse.statusMessage = "GetAllProduct Failed"; ;

                getData = new GetData();
                getData.status = statusResponse;
                getData.Data = null;
            }
            return Ok(getData);
        }
        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] addProductRequest request)
        {
            statusResponse statusResponse = new statusResponse();
            try
            {
                var result = await _processor.ExecuteAsync<AddProductQueryModel>(new AddProductQuery()
                {
                    product_name = request.product_name,
                    product_decription  = request.product_decription,
                    product_price = request.product_price
                });

                var checkresult = result.Data.Select(p => p.count_addProduct).FirstOrDefault();

                if (checkresult > 0)
                {
                    statusResponse = new statusResponse();
                    statusResponse.statusCode = 1;
                    statusResponse.statusMessage = "AddProduct Success";
                }
                else
                {
                    statusResponse = new statusResponse();
                    statusResponse.statusCode = -1;
                    statusResponse.statusMessage = "AddProduct Failed";
                }
            }
            catch (Exception ex)
            {
                Log.Error("AddProduct error: " + ex.Message);

                statusResponse = new statusResponse();
                statusResponse.statusCode = -1;
                statusResponse.statusMessage = "AddProduct Failed";
            }
            return Ok(statusResponse);
        }
        [HttpPut]
        public async Task<ActionResult> UpdateProductByID([FromBody] updateProductById request)
        {
            statusResponse statusResponse = new statusResponse();
            try
            {
                var result = await _processor.ExecuteAsync<UpdateProductByIDQueryModel>(new UpdateProductByIDQuery()
                {
                    id = request.id,
                    product_name = request.product_name,
                    product_decription = request.product_decription,
                    product_price = request.product_price
                });

                var checkresult = result.Data.Select(p => p.count_updateProductById).FirstOrDefault();

                if (checkresult > 0)
                {
                    statusResponse = new statusResponse();
                    statusResponse.statusCode = 1;
                    statusResponse.statusMessage = "UpdateProductByID Success";
                }
                else
                {
                    statusResponse = new statusResponse();
                    statusResponse.statusCode = -1;
                    statusResponse.statusMessage = "UpdateProductByID Failed";
                }
            }
            catch (Exception ex)
            {
                Log.Error("UpdateProductByID error: " + ex.Message);
                statusResponse = new statusResponse();
                statusResponse.statusCode = -1;
                statusResponse.statusMessage = "UpdateProductByID Failed";
            }
            return Ok(statusResponse);
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteProduct([FromBody] deleteProductRequest request)
        {
            statusResponse statusResponse = new statusResponse();
            try
            {
                var result = await _processor.ExecuteAsync<DeleteProductQueryModel>(new DeleteProductQuery()
                {
                    id = request.id,
                });

                var checkresult = result.Data.Select(p => p.count_deleteProduct).FirstOrDefault();

                if (checkresult > 0)
                {
                    statusResponse = new statusResponse();
                    statusResponse.statusCode = 1;
                    statusResponse.statusMessage = "DeleteProduct Success";
                }
                else
                {
                    statusResponse = new statusResponse();
                    statusResponse.statusCode = -1;
                    statusResponse.statusMessage = "DeleteProduct Failed";
                }
            }
            catch (Exception ex)
            {
                Log.Error("DeleteProduct error: " + ex.Message);
                statusResponse = new statusResponse();
                statusResponse.statusCode = -1;
                statusResponse.statusMessage = "DeleteProduct Failed";
            }
            return Ok(statusResponse);
        }
    }
}
