using Microsoft.EntityFrameworkCore.Storage;

namespace BaseLibrary.EntityFramework
{
    public class DatabaseTransaction : IDatabaseTransaction
    {
        private readonly PlantLogsheetsContext _context;
        private IDbContextTransaction _transaction;
        public DatabaseTransaction(PlantLogsheetsContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public IDbContextTransaction BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
            return _transaction;
        }

        public void Commit()
        {
            _transaction?.Commit();
        }

        public void Dispose()
        {
            _transaction?.Dispose();
        }

        public void Rollback()
        {
            _transaction?.Rollback();
        }
    }
}
