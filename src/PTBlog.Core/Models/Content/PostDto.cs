using AutoMapper;
using PTBlog.Core.Domain.Content;

namespace PTBlog.Core.Models.Content
{
    public class PostDto : PostInListDto
    {
        public Guid CategoryId { get; set; }

        public string? Content { get; set; }

        public Guid AuthorUserId { get; set; }

        public string? Source { get; set; }

        public string? Tags { get; set; }

        public string? SeoDescription { get; set; }

        public DateTime? DateModified { get; set; }

        public class AutoMapperProfiles : Profile
        {
            public AutoMapperProfiles()
            {
                CreateMap<Post, PostDto>();
            }
        }
    }
}
