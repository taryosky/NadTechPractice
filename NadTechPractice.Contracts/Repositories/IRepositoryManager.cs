using System.Threading.Tasks;

namespace NadTechPractice.Contracts.Repositories
{
    public interface IRepositoryManager
    {
        ICustomerRepository Customers { get; }
        IOrderRepository Orders { get; }
        Task<bool> Save();
    }
}
