using lab_08.Models;


namespace lab_08.Repository;

public interface IOrderRepository
{
    public IEnumerable<object> GetOrdersDetails();
    public IEnumerable<Order> GetOrdersByDate(DateTime date);
    public int GetTotalProducts(int id);
    public IEnumerable<dynamic> GetOrderDetails(int id);
}