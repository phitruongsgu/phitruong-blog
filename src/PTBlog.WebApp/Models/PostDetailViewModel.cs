using PTBlog.Core.Models.Content;

namespace PTBlog.WebApp.Models
{
    public class PostDetailViewModel
    {
        public PostDto Post { get; set; }
        public PostCategoryDto Category { get; set; }
        public List<TagDto> Tags { get; set; }
    }
}
