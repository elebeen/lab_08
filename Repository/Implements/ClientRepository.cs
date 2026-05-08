using lab_08.Models;

namespace lab_08.Repository.Implements;

public class ClientRepository : IClientRepository
{
    private readonly Context _context;
    
    public ClientRepository(Context context)
    {
        _context = context;
    }

    public IEnumerable<Client> GetClientsByName(string name)
    {
        var names = _context.Clients.Where(e => e.Name == name).ToList();
        return names;
    }

    public dynamic GetClientConMasPedidos()
    {
        return _context.Orders
            .GroupBy(o => o.Clientid)
            .Select(grupo => new
            {
                IdCliente = grupo.Key,
                Total = grupo.Count()
            })
            .OrderByDescending(x => x.Total)
            .FirstOrDefault();
    }

    public List<string> GetProductsByClientId(int clientId)
    {
        return _context.Orders
            .Where(o => o.Clientid == clientId)
            .SelectMany(o => o.Orderdetails)
            .Select(od => od.Product.Name)
            .Distinct()
            .ToList();
    }

    public List<string> GetClientsByProduct(int id)
    {
        return _context.Orderdetails
            .Where(od => od.Productid == id)
            .Select(od => od.Order.Client.Name)
            .Distinct()
            .ToList();
    }
}