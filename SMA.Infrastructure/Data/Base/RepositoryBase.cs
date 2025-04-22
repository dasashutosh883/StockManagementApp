using System.Data;
using SMA.Infrastructure.Data.Factory;

namespace Esigner.Infrastructure.Data.Base
{
    public class RepositoryBase : IDisposable
    {
        protected IDbConnection Connection;
        private bool _disposed;

        protected RepositoryBase(IConnectionFactory connectionFactory)
        {
            Connection = connectionFactory.GetConnection;
        }

        // Implement the Dispose method to release resources
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected Dispose method with disposing flag
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources
                    Connection?.Dispose();
                }

                // Release any unmanaged resources here, if needed
                _disposed = true;
            }
        }

        // Destructor to ensure disposal if Dispose is not called
        ~RepositoryBase()
        {
            Dispose(false);
        }
    }
}