using lab_08.Models;
using lab_08.Services;
using Microsoft.AspNetCore.Mvc;

namespace lab_08.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;
    
    public  ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpGet]
    public IEnumerable<Client> GetClients(string name)
    {
        var x = _clientService.GetClientsByName(name);
        return x;
    }

    [HttpGet]
    [Route("Maspedidos")]
    public dynamic MasPedidos()
    {
        return _clientService.GetClientConMasPedidos();
    }

    [HttpGet]
    [Route("clientesquecompran")]
    public List<string> ProductosDelCliente(int id)
    {
        return _clientService.GetClientsByProduct(id);
    }

    [HttpGet]
    [Route("productosvendidos")]
    public List<string> ProductosVendidos(int id)
    {
        return _clientService.GetProductsByClientId(id);
    }
}