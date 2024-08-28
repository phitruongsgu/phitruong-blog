using PTBlog.Core.Models;
using PTBlog.Core.Models.Content;

namespace PTBlog.WebApp.Models
{
    public class SeriesDetailViewModel
    {
        public SeriesDto Series { get; set; }

        public PagedResult<PostInListDto> Posts { get; set; }
    }
}
