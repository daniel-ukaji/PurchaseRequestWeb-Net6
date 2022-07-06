using PurchaseRequest.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;

namespace PurchaseRequest.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                    Email = "admin1@test.com",
                    NormalizedEmail = "ADMIN1@TEST.COM",
                    NormalizedUserName = "ADMIN1@TEST.COM",
                    UserName = "admin1@test.com",
                    Firstname = "Danny",
                    Lastname = "John",
                    PasswordHash = hasher.HashPassword(null, "Okey2012+"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "7335585a-1cea-4e49-a326-e626848b6afd",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    UserName = "user@localhost.com",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "Okey2012+"),
                    EmailConfirmed = true
                }
            );
        }
    }
}