using lab_08.Models;
using lab_08.Repository;

namespace lab_08.Services.Implementations;

public class OrderService : IOrderService
{
    private readonly IUnitOfWork _unitOfWork;
    
    public OrderService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IEnumerable<dynamic> GetOrderDetails(int id)
    {
        return _unitOfWork.OrderRepository.GetOrderDetails(id);
    }

    public int GetTotalProducts(int id)
    {
        return _unitOfWork.OrderRepository.GetTotalProducts(id);
    }

    public IEnumerable<Order> GetOrdersByDate(DateTime date)
    {
        return _unitOfWork.OrderRepository.GetOrdersByDate(date);
    }

    public IEnumerable<object> GetOrdersDetails()
    {
        return _unitOfWork.OrderRepository.GetOrdersDetails();
    }
}