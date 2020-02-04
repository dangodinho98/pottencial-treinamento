using System;
using System.Transactions;

namespace Pottencial.Invoices.Repositories.Shared
{
    public class UnitOfWork : IDisposable
    {
        private TransactionScope transactionScope;

        public UnitOfWork()
        {
            transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
        }

        public void Commit()
        {
            transactionScope.Complete();
        }

        public void Rollback()
        {
            Dispose();
        }

        public void Dispose()
        {
            transactionScope?.Dispose();
            transactionScope = null;
        }
    }
}
