namespace BlogApp.Migrations
{
    using BlogApp.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogApp.BlogAppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
          //  AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BlogApp.BlogAppDbContext context)
        {


            var Post1 = new Post()
            {
                Title = "This is my first title",
                CreatedDate = DateTime.Now,
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                " Sed venenatis et odio nec auctor. " +
                "Pellentesque cursus risus lectus, rhoncus fermentum arcu pretium eu."
            };
            var Post2 = new Post()
            {
                Title = "This is a second title",
                CreatedDate = DateTime.Now,
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                " Sed venenatis et odio nec auctor. " +
                "Pellentesque cursus risus lectus, rhoncus fermentum arcu pretium eu."
            };

            var Post3 = new Post()
            {
                Title = "This is a third title",
                CreatedDate = DateTime.Now,
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                " Sed venenatis et odio nec auctor. " +
                "Pellentesque cursus risus lectus, rhoncus fermentum arcu pretium eu."
            };

            var Post4 = new Post()
            {
                Title = "This is a Forth title",
                CreatedDate = DateTime.Now,
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                " Sed venenatis et odio nec auctor. " +
                "Pellentesque cursus risus lectus, rhoncus fermentum arcu pretium eu."
            };

            var Post5 = new Post()
            {
                Title = "This is a fifth title",
                CreatedDate = DateTime.Now,
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                " Sed venenatis et odio nec auctor. " +
                "Pellentesque cursus risus lectus, rhoncus fermentum arcu pretium eu."
            };
            var Author1 = new Author()
            {
                FullName = "Olowoniwa Ayokunle",
                Posts = new List<Post>()
                {
                    Post1, Post2, Post3,
                }
            };

            var Author2 = new Author()
            {
                FullName = "Munachimso Emmanuel",
                Posts = new List<Post>()
                {
                    Post4, Post5
                }
            };

            var Blog1 = new Blog()
            {
                Name = "Muna's Blog",
                Posts = new List<Post>()
                {
                    Post1, Post2, Post3,
                }
            };

            var Blog2 = new Blog()
            {
                Name = "Gaby's Blog",
                Posts = new List<Post>()
                {
                    Post4, Post5
                }
            };

            context.Set<Blog>().AddOrUpdate(b => b.Name, Blog1);
            context.Set<Blog>().AddOrUpdate(b => b.Name, Blog2);
            context.Set<Author>().AddOrUpdate(a => a.FullName, Author1);
            context.Set<Author>().AddOrUpdate(a => a.FullName, Author2);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
