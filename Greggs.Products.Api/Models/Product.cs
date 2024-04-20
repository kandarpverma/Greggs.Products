using Greggs.Products.Api.Constants;

namespace Greggs.Products.Api.Models;

public class Product
{
    public string Name { get; set; }

    private decimal _PriceInPounds;
    public decimal PriceInPounds
    {
        get { return _PriceInPounds; }
        set
        {
            _PriceInPounds = value;
            PriceInEuros = value * PriceConstants.GbpToEur;
        }
    }
    public decimal PriceInEuros { get; set; }
}