using lab_08.Models;

namespace lab_08.Repository.Implements;

public class ProductRepository : IProductRepository
{
    private readonly Context _context;
    public ProductRepository(Context context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetProductsGt20()
    {
        return _context.Products
            .Where(p => p.Price > 20)
            .ToList();
    }

    public Product GetProductCaro()
    {
        return _context.Products
            .OrderByDescending(p => p.Price)
            .FirstOrDefault();
    }

    public decimal PromedioProducts()
    {
        return _context.Products
            .Select(p => p.Price)
            .Average();
    }

    public IEnumerable<Product> GetProductsSinDescrip()
    {
        return _context.Products
            .Where(p => string.IsNullOrEmpty(p.Description))
            .ToList();
    }
    
    
}