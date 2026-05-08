using lab_08.Models;
using lab_08.Services;
using Microsoft.AspNetCore.Mvc;

namespace lab_08.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;
    
    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet,Route("ordenDetalle")]
    public IEnumerable<dynamic> GetOrderDetails(int id)
    {
        return  _orderService.GetOrderDetails(id);
    }

    [HttpGet,Route("totalProductosOrden")]
    public int GetTotalProducts(int id)
    {
        return _orderService.GetTotalProducts(id);
    }

    [HttpGet]
    [Route("ordenesPorFecha")]
    public IEnumerable<Order> GetOrdersByDate(DateTime date)
    {
        return _orderService.GetOrdersByDate(date);
    }
    
    [HttpGet]
    [Route("ordenesDetalle")]
    public IEnumerable<dynamic> GetOrdersDetails()
    {
        return _orderService.GetOrdersDetails();
    }
}