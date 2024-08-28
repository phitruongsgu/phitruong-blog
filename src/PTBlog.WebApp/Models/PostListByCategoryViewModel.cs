using PTBlog.Core.Models;
using PTBlog.Core.Models.Content;

namespace PTBlog.WebApp.Models
{
    public class PostListByCategoryViewModel
    {
        public PostCategoryDto Category { get; set; }
        public PagedResult<PostInListDto> Posts { get; set; }
    }
}
