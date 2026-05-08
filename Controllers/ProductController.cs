using lab_08.Models;
using lab_08.Services;
using Microsoft.AspNetCore.Mvc;

namespace lab_08.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    [Route("GetProductMayores20")]
    public IEnumerable<Product> GetProductsGt20()
    {
        return _productService.GetProductsGt20();
    }

    [HttpGet]
    [Route("GetProductCaro")]
    public Product GetProductCaro()
    {
        return _productService.GetProductCaro();
    }

    [HttpGet]
    [Route("promedio")]
    public decimal GetPromedio()
    {
        return _productService.PromedioProducts();
    }

    [HttpGet]
    [Route("sinDescrip")]
    public IEnumerable<Product> GetProductsSinDescrip()
    {
        return _productService.GetProductsSinDescrip();
    }
}