using BlogApp.Model;
using System.Data.Entity.ModelConfiguration;

namespace BlogApp
{
   public class BlogMap : EntityTypeConfiguration<Blog>
    {
        public BlogMap()
        {
            this.Property(a => a.Name).HasMaxLength(250);
        }
    }
}