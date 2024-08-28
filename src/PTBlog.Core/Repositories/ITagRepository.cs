using PTBlog.Core.Domain.Content;
using PTBlog.Core.Models.Content;
using PTBlog.Core.SeedWorks;

namespace PTBlog.Core.Repositories
{
    public interface ITagRepository : IRepository<Tag, Guid>
    {
        Task<TagDto> GetBySlug(string slug);
    }
}
