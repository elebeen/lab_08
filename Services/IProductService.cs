using lab_08.Models;

namespace lab_08.Services;

public interface IProductService
{
    public IEnumerable<Product> GetProductsSinDescrip();
    public decimal PromedioProducts();
    public Product GetProductCaro();
    public IEnumerable<Product> GetProductsGt20();
}