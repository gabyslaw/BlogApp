using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Model
{
    public class BlogAppDbInitializer : CreateDatabaseIfNotExists<BlogAppDbContext>
    {
        protected override void Seed(BlogAppDbContext context)
        {
            base.Seed(context);

            //context.Set<Post>().AddOrUpdate(c => c.Title, new Post()
            //{
            //    Title = "How to Program using C#",
            //    CreatedDate = DateTime.Now,
            //    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
            //    " Sed venenatis et odio nec auctor. " +
            //    "Pellentesque cursus risus lectus, rhoncus fermentum arcu pretium eu."
            //},
            //new Post()
            //{
            //    Title = "How to Design a Website",
            //    CreatedDate = DateTime.Now,
            //    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
            //    " Sed venenatis et odio nec auctor. " +
            //    "Pellentesque cursus risus lectus, rhoncus fermentum arcu pretium eu."
            //},
            // new Post()
            // {
            //     Title = "How to Build an App",
            //     CreatedDate = DateTime.Now,
            //     Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
            //    " Sed venenatis et odio nec auctor. " +
            //    "Pellentesque cursus risus lectus, rhoncus fermentum arcu pretium eu."
            // },
            //  new Post()
            //  {
            //      Title = "How to Hack a website",
            //      CreatedDate = DateTime.Now,
            //      Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
            //    " Sed venenatis et odio nec auctor. " +
            //    "Pellentesque cursus risus lectus, rhoncus fermentum arcu pretium eu."
            //  },
            //   new Post()
            //   {
            //       Title = "Phish a",
            //       CreatedDate = DateTime.Now,
            //       Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
            //    " Sed venenatis et odio nec auctor. " +
            //    "Pellentesque cursus risus lectus, rhoncus fermentum arcu pretium eu."
            //   });

            //context.Set<Blog>().AddOrUpdate(c => c.Name, new Blog()
            //{
            //    Name = "Munas Blog",
            //    Posts = new List<Post>()
            //},
            //new Blog()
            //{
            //    Name = "Gabys Blog",
            //    Posts = new List<Post>()
            //});

            //context.Set<Author>().AddOrUpdate(c => c.FullName, new Author()
            //{
            //    FullName = "Olowoniwa Ayokunle",
            //    Posts = new List<Post>()
            //},
            //new Author()
            //{
            //    FullName = "Adeyemi Gaby",
            //    Posts = new List<Post>()
            //});

            var MyfirstPost = new Post()
            {
                Title = "This is a title",
                CreatedDate = new DateTime(2018, 01, 12),
                Body = "This is the body of the first post"
            };
            var MySecondPost = new Post()
            {
                Title = "This is a second title",
                CreatedDate = new DateTime(2018, 01, 14),
                Body = "This is the body of the second post"
            };

            var MyThirdPost = new Post()
            {
                Title = "This is a third title",
                CreatedDate = new DateTime(2018, 01, 15),
                Body = "This is the body of the third post"
            };

            var MyForthPost = new Post()
            {
                Title = "This is a Forth title",
                CreatedDate = new DateTime(2018, 02, 02),
                Body = "This is the body of the Forth post"
            };

            var MyFifthPost = new Post()
            {
                Title = "This is a fifth title",
                CreatedDate = new DateTime(2018, 02, 08),
                Body = "This is the body of the fifth post"
            };
            var FirstAuthor = new Author()
            {
                FullName = "Mabi Chukwuma",
                Posts = new List<Post>()
                {
                    MyfirstPost, MySecondPost, MyThirdPost,
                }
            };

            var SecondAuthor = new Author()
            {
                FullName = "Oriahi Emmanuel",
                Posts = new List<Post>()
                {
                    MyForthPost, MyFifthPost
                }
            };

            var FirstBlog = new Blog()
            {
                Name = "Muna's Blog",
                Posts = new List<Post>()
                {
                    MyfirstPost, MySecondPost, MyThirdPost,
                }
            };

            var SecondBlog = new Blog()
            {
                Name = "Oriahi's Blog",
                Posts = new List<Post>()
                {
                    MyForthPost, MyFifthPost
                }
            };

            context.Set<Blog>().AddOrUpdate(b => b.Name, FirstBlog);
            context.Set<Blog>().AddOrUpdate(b => b.Name, SecondBlog);
            context.Set<Author>().AddOrUpdate(a => a.FullName, FirstAuthor);
            context.Set<Author>().AddOrUpdate(a => a.FullName, SecondAuthor);
            context.SaveChanges();

        }
    }
}
   