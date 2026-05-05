using lab_08.Models;

namespace lab_08.Repository.Implements;

public class ClientRepository : IClientRepository
{
    private readonly Context _context;
    private readonly IUnitOfWork _unitOfWork;
    
    public ClientRepository(Context context, IUnitOfWork unitOfWork)
    {
        _context = context;
        _unitOfWork = unitOfWork;
    }

    public IEnumerable<Client> GetClientsByName(string name)
    {
        var names = _context.Clients.Where(e => e.Name == name).ToList<Client>();
        return names;
    }
}