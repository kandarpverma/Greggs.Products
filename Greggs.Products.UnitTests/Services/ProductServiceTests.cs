using Greggs.Products.Api.Services;
using System.Linq;
using Xunit;

namespace Greggs.Products.UnitTests.Services;

public class ProductServiceTests
{
    //Since we are not connecting to any database, we are not using any Stubs for the test cases
    //The test cases have been written accoring to current implementation of Data Access Layer
    private readonly IProductService _productService;

    public ProductServiceTests()
    {
        _productService = Helper.GetRequiredService<IProductService>();
    }

    [Fact]
    public void ProductListSuccess()
    {
        var products = _productService.ProductList(0, 5);
        Assert.True(products.ToList().Count > 0);
    }

    [Fact]
    public void ProductListSuccessEmptyList()
    {
        var products = _productService.ProductList(10, 5);
        Assert.True(products.ToList().Count == 0);
    }
}