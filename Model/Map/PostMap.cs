using BlogApp.Model;
using System.Data.Entity.ModelConfiguration;

namespace BlogApp
{
    public class PostMap : EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            this.Property(a => a.Title).HasMaxLength(250);
            this.Property(a => a.Body).HasMaxLength(25000);
        }
    }
}