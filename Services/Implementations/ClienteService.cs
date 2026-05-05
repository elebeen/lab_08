using lab_08.Models;
using lab_08.Repository;
using System.Collections;

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
}