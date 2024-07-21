using PTBlog.Core.Domain.Royalty;
using PTBlog.Core.Models;
using PTBlog.Core.Models.Royalty;
using PTBlog.Core.SeedWorks;

namespace PTBlog.Core.Repositories
{
    public interface ITransactionRepository : IRepository<Transaction, Guid>
    {
        Task<PagedResult<TransactionDto>> GetAllPaging(string? userName,
         int fromMonth, int fromYear, int toMonth, int toYear, int pageIndex = 1, int pageSize = 10);
    }
}
