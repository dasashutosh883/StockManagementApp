using System.Data;

namespace SMA.Infrastructure.Data.Factory
{
    public interface IConnectionFactory
    {
        public IDbConnection GetConnection { get; }
    }
}