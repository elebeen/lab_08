using lab_08.Models;

namespace lab_08.Services;

public interface IClientService
{
    public IEnumerable<Client> GetClientsByName(string name);
}