using lab_08.Models;

namespace lab_08.Repository.Implements;

public class OrderRepository : IOrderRepository
{
    private readonly Context _context;
    public OrderRepository(Context context)
    {
        _context = context;
    }

    public IEnumerable<dynamic> GetOrderDetails(int id)
    {
        return _context.Orderdetails
            .Where(o => o.Orderid == id)
            .Select(o => new
            {
                NombreProducto = o.Product.Name,
                Cantidad = o.Quantity
            }).ToList();
    }

    public int GetTotalProducts(int id)
    {
        return _context.Orderdetails
            .Where(o => o.Orderid == 1)
            .Select(o => o.Quantity)
            .Sum();
    }

    public IEnumerable<Order> GetOrdersByDate(DateTime date)
    {
        return _context.Orders
            .Where(o => o.Orderdate > date)
            .ToList();
    }

    public IEnumerable<object> GetOrdersDetails()
    {
        return _context.Orderdetails
            .Select(od => new 
            {
                OrderId = od.Orderid,
                ProductName = od.Product.Name,
                Quantity = od.Quantity
            })
            .ToList();
    }
}