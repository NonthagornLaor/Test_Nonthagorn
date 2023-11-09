using Application.Interfaces.Repositories.StoredProcedures;
using Infrastructure.ContractDbs;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Domain.Entities.api;

namespace Infrastructure.Repositories.StoredProcedures
{
    public class StoredProcedure : IStoredProcedure
    {
        private readonly DbsContext _context;

        public StoredProcedure(DbsContext context)
        {
            _context = context;
        }
       
        public async Task<IEnumerable<GetProductQueryResult>> GetProductQueryAsync(int? id)
        {
            try
            {
                string cmd = "EXEC [dbo].[GetProduct] @id";
                var sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@id", id)
            };

                var result = await _context.GetProductQueryResults.FromSqlRaw(cmd, sqlParameters.ToArray()).ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                Log.Information("GetProductQueryAsync Error :" + ex.Message);
                Log.Error("GetProductQueryAsync Error :" + ex.Message);
                return null;
            }
        }
        public async Task<IEnumerable<GetAllProductQueryResult>> GetAllProductQueryAsync()
        {
            try
            {
                string cmd = "EXEC [dbo].[GetAllProduct]";
              
                var result = await _context.GetAllProductQueryResults.FromSqlRaw(cmd).ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                Log.Information("GetAllProductQueryAsync Error :" + ex.Message);
                Log.Error("GetAllProductQueryAsync Error :" + ex.Message);
                return null;
            }
        }
        public async Task<IEnumerable<AddProductQueryResult>> AddProductQueryAsync(string? product_name, string? product_decription, string? product_price)
        {
            try
            {
                string cmd = "EXEC [dbo].[AddProduct] @product_name,@product_decription,@product_price";
                var sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@product_name", product_name),
                new SqlParameter("@product_decription", product_decription),
                new SqlParameter("@product_price", product_price)
            };

                var result = await _context.AddProductQueryResults.FromSqlRaw(cmd, sqlParameters.ToArray()).ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                Log.Information("AddProductQueryAsync Error :" + ex.Message);
                Log.Error("AddProductQueryAsync Error :" + ex.Message);
                return null;
            }
        }
        public async Task<IEnumerable<UpdateProductByIDQueryResult>> UpdateProductByIDQueryAsync(int? id, string? product_name, string? product_decription, string? product_price)
        {
            try
            {
                string cmd = "EXEC [dbo].[UpdateProductByID] @id,@product_name,@product_decription,@product_price";
                var sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@id", id),
                new SqlParameter("@product_name", product_name),
                new SqlParameter("@product_decription", product_decription),
                new SqlParameter("@product_price", product_price)
            };

                var result = await _context.UpdateProductByIDQueryResults.FromSqlRaw(cmd, sqlParameters.ToArray()).ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                Log.Information("UpdateProductByIDQueryAsync Error :" + ex.Message);
                Log.Error("UpdateProductByIDQueryAsync Error :" + ex.Message);
                return null;
            }
        }
        public async Task<IEnumerable<DeleteProductQueryResult>> DeleteProductQueryAsync(int? id)
        {
            try
            {
                string cmd = "EXEC [dbo].[DeleteProduct] @id";
                var sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@id", id)
            };

                var result = await _context.DeleteProductQueryResults.FromSqlRaw(cmd, sqlParameters.ToArray()).ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                Log.Information("DeleteProductQueryAsync Error :" + ex.Message);
                Log.Error("DeleteProductQueryAsync Error :" + ex.Message);
                return null;
            }
        }
    }
}
