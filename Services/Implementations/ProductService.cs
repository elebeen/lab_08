using lab_08.Models;
using lab_08.Repository;

namespace lab_08.Services.Implementations;

public class ProductService : IProductService
{   
    private readonly IUnitOfWork _unitOfWork;
    
    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IEnumerable<Product> GetProductsGt20()
    {
        return _unitOfWork.ProductRepository.GetProductsGt20();
    }

    public Product GetProductCaro()
    {
        return _unitOfWork.ProductRepository.GetProductCaro();
    }

    public decimal PromedioProducts()
    {
        return _unitOfWork.ProductRepository.PromedioProducts();
    }

    public IEnumerable<Product> GetProductsSinDescrip()
    {
        return _unitOfWork.ProductRepository.GetProductsSinDescrip();
    }
}