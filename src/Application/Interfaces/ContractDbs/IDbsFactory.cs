using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces.ContractDbs
{
    public interface IDbsFactory : IDisposable
    {
        DbContext GetContext();

        bool CanConnect();
    }
}
