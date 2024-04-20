using Greggs.Products.Api.Controllers;
using Greggs.Products.Api.DataAccess;
using Greggs.Products.Api.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Greggs.Products.Api.Services;

public class ProductService : IProductService
{
    private readonly ILogger<ProductService> _logger;
    private readonly IDataAccess<Product> _productAccess;

    public ProductService(ILogger<ProductService> logger, IDataAccess<Product> productAccess)
    {
        _logger = logger;
        _productAccess = productAccess;
    }

    public IEnumerable<Product> ProductList(int pageStart, int pageSize)
    {
        try
        {
            return _productAccess.List(pageStart, pageSize);
        }
        catch(Exception ex)
        {
            _logger.LogError(ex.Message);
            return Enumerable.Empty<Product>();
        }
    }


}