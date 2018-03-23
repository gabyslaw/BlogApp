using BlogApp.Model;
using System.Data.Entity.ModelConfiguration;

namespace BlogApp
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            this.Property(a => a.FullName).HasMaxLength(250);
        }
    }
}