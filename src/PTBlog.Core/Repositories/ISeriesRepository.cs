using PTBlog.Core.Domain.Content;
using PTBlog.Core.Models;
using PTBlog.Core.Models.Content;
using PTBlog.Core.SeedWorks;

namespace PTBlog.Core.Repositories
{
    public interface ISeriesRepository : IRepository<Series, Guid>
    {
        Task<PagedResult<SeriesInListDto>> GetAllPaging(string? keyword, int pageIndex = 1, int pageSize = 10);
        Task AddPostToSeries(Guid seriesId, Guid postId, int sortOrder);
        Task RemovePostToSeries(Guid seriesId, Guid postId);
        Task<List<PostInListDto>> GetAllPostsInSeries(Guid seriesId);
        Task<PagedResult<PostInListDto>> GetAllPostsInSeries(string slug, int pageIndex = 1, int pageSize = 10);
        Task<SeriesDto> GetBySlug(string slug);
        Task<bool> IsPostInSeries(Guid seriesId, Guid postId);
        Task<bool> HasPost(Guid seriesId);
    }
}
