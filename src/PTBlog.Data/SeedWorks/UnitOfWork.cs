using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PTBlog.Core.Domain.Identity;
using PTBlog.Core.Repositories;
using PTBlog.Core.SeedWorks;
using PTBlog.Data.Repositories;

namespace PTBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PTBlogContext _context;

        public UnitOfWork(PTBlogContext context, IMapper mapper, UserManager<AppUser> userManager)
        {
            _context = context;
            Posts = new PostRepository(context, mapper, userManager);
            PostCategories = new PostCategoryRepository(context, mapper);
            Series = new SeriesRepository(context, mapper);
            Transactions = new TransactionRepository(context, mapper);
            Users = new UserRepository(context);
            Tags = new TagRepository(context, mapper);
        }
        public IPostRepository Posts { get; private set; }
        public IPostCategoryRepository PostCategories { get; private set; }
        public ISeriesRepository Series { get; private set; }
        public ITransactionRepository Transactions { get; private set; }
        public IUserRepository Users { get; private set; }
        public ITagRepository Tags { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
