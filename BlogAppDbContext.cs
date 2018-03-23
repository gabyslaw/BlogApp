using BlogApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp
{
    public class BlogAppDbContext : DbContext
    {
        public BlogAppDbContext() : base("BlogAppDbContext")
        {
           // Database.SetInitializer(new BlogAppDbInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new PostMap());
            modelBuilder.Configurations.Add(new BlogMap());
            modelBuilder.Configurations.Add(new AuthorMap());
        }
    }
}
