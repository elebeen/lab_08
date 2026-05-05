using lab_08.Models;

namespace lab_08.Repository;

public interface IClientRepository
{
    public IEnumerable<Client> GetClientsByName(string name);
}