using PTBlog.Core.Domain.Content;
using PTBlog.Core.Models;
using PTBlog.Core.Models.Content;
using PTBlog.Core.SeedWorks;

namespace PTBlog.Core.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory, Guid>
    {
        Task<PagedResult<PostCategoryDto>> GetAllPaging(string? keyword, int pageIndex = 1, int pageSize = 10);
        Task<bool> HasPost(Guid categoryId);
        Task<PostCategoryDto> GetBySlug(string slug);
    }
}
