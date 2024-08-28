using PTBlog.Core.Models;
using PTBlog.Core.Models.Content;

namespace PTBlog.WebApp.Models
{
    public class PostListByTagViewModel
    {
        public TagDto Tag { get; set; }
        public PagedResult<PostInListDto> Posts { get; set; }
    }
}
