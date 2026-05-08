using lab_08.Models;
using lab_08.Repository;

namespace lab_08.Services.Implementations;

public class ClienteService : IClientService
{
    private readonly IUnitOfWork _unitOfWork;

    public ClienteService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IEnumerable<Client> GetClientsByName(string name)
    {
        var clients = _unitOfWork.ClientRepository.GetClientsByName(name);

        return clients;
    }

    public dynamic GetClientConMasPedidos()
    {
        return _unitOfWork.ClientRepository.GetClientConMasPedidos();
    }

    public List<string> GetProductsByClientId(int clientId)
    {
        return _unitOfWork.ClientRepository.GetProductsByClientId(clientId);
    }

    public List<string> GetClientsByProduct(int id)
    {
        return _unitOfWork.ClientRepository.GetClientsByProduct(id);
    }
}