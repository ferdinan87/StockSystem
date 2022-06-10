using Microsoft.EntityFrameworkCore.Storage;

namespace BaseLibrary.EntityFramework
{
    public interface IDatabaseTransaction : IDisposable
    {
        IDbContextTransaction BeginTransaction();
        void Commit();
        void Rollback();
    }
}
