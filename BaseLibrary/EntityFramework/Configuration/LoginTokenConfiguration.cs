using BaseLibrary.EntityFramework.PlantLogsheetsDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BaseLibrary.EntityFramework.Configuration
{
    public class LoginTokenConfiguration : IEntityTypeConfiguration<LoginToken>
    {
        public void Configure(EntityTypeBuilder<LoginToken> builder)
        {
            builder.ToTable("LoginToken", "kns");

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.Property(e => e.RefreshToken)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CS_AS");

            builder.Property(e => e.RefreshTokenExpiryTime).HasColumnType("datetime");

            builder.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CS_AS");


            builder.HasData(
                new LoginToken
                {
                    CreatedDate = DateTime.Now,
                    RefreshToken = "dummy",
                    RefreshTokenExpiryTime = DateTime.Now,
                    UserName = "username"
                });
        }
    }
}
