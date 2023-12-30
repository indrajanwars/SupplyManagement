using API.Contracts;
using API.Data;
using API.Models;

namespace API.Repositories;

public class RoleRepository : GeneralRepository<Role>, IRoleRepository
{
    public RoleRepository(SMDbContext context) : base(context) { }

    public Guid? GetDefaultGuid()
    {
        return _context.Set<Role>().FirstOrDefault(r => r.Name == "vendor")?.Guid;
    }
}
