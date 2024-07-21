using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PTBlog.Data
{
    public class PTBlogContextFactory : IDesignTimeDbContextFactory<PTBlogContext>
    {
        public PTBlogContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json") // đọc file appsettings
                 .Build();
            var builder = new DbContextOptionsBuilder<PTBlogContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new PTBlogContext(builder.Options);
        }
    }
}
