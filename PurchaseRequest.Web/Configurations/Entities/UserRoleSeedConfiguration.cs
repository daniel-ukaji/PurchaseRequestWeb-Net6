using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PurchaseRequest.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                    UserId = "d0eab64d-0036-4a8c-8faf-dd9c3951abc8"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                    UserId = "7335585a-1cea-4e49-a326-e626848b6afd"
                }
            );
        }
    }
}