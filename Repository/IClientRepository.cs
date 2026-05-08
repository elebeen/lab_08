using lab_08.Models;

namespace lab_08.Repository;

public interface IClientRepository
{
    public List<string> GetClientsByProduct(int id); 
    public List<string> GetProductsByClientId(int clientId);
    public dynamic GetClientConMasPedidos();
    public IEnumerable<Client> GetClientsByName(string name);
}