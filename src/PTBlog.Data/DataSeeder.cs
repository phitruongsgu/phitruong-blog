using Microsoft.AspNetCore.Identity;
using PTBlog.Core.Domain.Identity;

namespace PTBlog.Data
{
    public class DataSeeder
    {
        public async Task SeedAsync(PTBlogContext context)
        {
            var passwordHasher = new PasswordHasher<AppUser>();

            var rootAdminRoleId = Guid.NewGuid();
            if (!context.Roles.Any()) // chưa có
            {
                await context.Roles.AddAsync(new AppRole()
                {
                    Id = rootAdminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    DisplayName = "Quản trị viên"
                });
                await context.SaveChangesAsync();
            }

            if (!context.Users.Any())
            {
                var userId = Guid.NewGuid();
                var user = new AppUser()
                {
                    Id = userId,
                    FirstName = "Truong",
                    LastName = "Nguyen",
                    Email = "truongnvp@gmail.com",
                    NormalizedEmail = "TRUONGNVP@GMAIL.COM",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    IsActive = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    LockoutEnabled = false,
                    DateCreated = DateTime.Now
                };
                user.PasswordHash = passwordHasher.HashPassword(user, "Abcd1234$");
                await context.Users.AddAsync(user);

                await context.UserRoles.AddAsync(new IdentityUserRole<Guid>()
                {
                    RoleId = rootAdminRoleId,
                    UserId = userId,
                });
                await context.SaveChangesAsync();
            }
        }
    }
}
