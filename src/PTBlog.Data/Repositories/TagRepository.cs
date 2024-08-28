using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PTBlog.Core.Domain.Content;
using PTBlog.Core.Models.Content;
using PTBlog.Core.Repositories;
using PTBlog.Data.SeedWorks;

namespace PTBlog.Data.Repositories
{
    public class TagRepository : RepositoryBase<Tag, Guid>, ITagRepository
    {
        private readonly IMapper _mapper;
        public TagRepository(PTBlogContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public async Task<TagDto?> GetBySlug(string slug)
        {
            var tag = await _context.Tags.FirstOrDefaultAsync(x => x.Slug == slug);
            if (tag == null)
            {
                return null;
            }
            return _mapper.Map<TagDto?>(tag);
        }
    }
}
