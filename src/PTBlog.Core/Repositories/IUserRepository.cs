using PTBlog.Core.Domain.Identity;
using PTBlog.Core.SeedWorks;

namespace PTBlog.Core.Repositories
{
    public interface IUserRepository : IRepository<AppUser, Guid>
    {
        Task RemoveUserFromRoles(Guid userId, string[] roles);
    }
}
