using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatikaClassWork1.Entity.Concrete;

namespace PatikaClassWork1.DataAccess.Concrete.Mappings
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");
            builder.Property(a => a.Name).IsRequired();
            builder.Property(a => a.Surname).IsRequired();
            builder.Property(a => a.DateOfBirth).IsRequired();
        }
    }
}