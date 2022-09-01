using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatikaClassWork1.Entity.Concrete;

namespace PatikaClassWork1.DataAccess.Concrete.Mappings
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.Property(a => a.Name).IsRequired();
            builder.Property(a => a.Description).IsRequired();
            builder.Property(a => a.PublishDate).IsRequired();
        }
    }
}