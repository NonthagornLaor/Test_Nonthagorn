﻿using Application.Interfaces;
using Application.Interfaces.Repositories.StoredProcedures;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Serilog;


namespace Application.Contract.Queries.UpdateProductByIDQuery
{
    public class UpdateProductByIDQueryHandler : IProcessHandler<UpdateProductByIDQuery, UpdateProductByIDQueryModel>
    {
        private readonly Serilog.ILogger _logger;
        private readonly IStoredProcedure _storedProcedure;
        private readonly IMapper _mapper;

        public UpdateProductByIDQueryHandler(Serilog.ILogger logger, IStoredProcedure storedProcedure, IMapper mapper)
        {
            _logger = logger;
            _storedProcedure = storedProcedure;
            _mapper = mapper;
        }
        public async Task<UpdateProductByIDQueryModel> Handle(UpdateProductByIDQuery query, CancellationToken cancellationToken)
        {
            var result = new UpdateProductByIDQueryModel();

            try
            {
                var items = await _storedProcedure.UpdateProductByIDQueryAsync(query.id,query.product_name, query.product_decription, query.product_price);

                if (items != null)
                {
                    var mappedItems = _mapper.Map<List<UpdateProductByIDQueryData>>(items);
                    result.Data = mappedItems;
                    result.ReturnMsg = HttpStatusCode.OK.ToString();
                    result.ReturnCode = (int)HttpStatusCode.OK;
                }
                else
                {
                    result.Data = null;
                    result.ReturnMsg = HttpStatusCode.NotFound.ToString();
                    result.ReturnCode = (int)HttpStatusCode.NotFound;
                }

            }
            catch (Exception ex)
            {
                result.ReturnCode = (int)HttpStatusCode.InternalServerError;
                result.ReturnMsg = $"Error : {ex.Message}";
            }

            return result;
        }
    }
}
