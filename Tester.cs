using BlogApp.Model;
using BlogApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp
{
    public class Tester
    {
        public static void Main()
        {
            GetAll();
            GetSingle();
            AddEdit();
            Delete();
            FindBy();

            Console.ReadLine();
        }
        public static void GetAll()
        {
            var context = new BlogRepository<BlogAppDbContext, Post>();
            var query = context.GetAll();
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Title} | {item.Body} | {item.CreatedDate}");
            }
        }
        public static void GetSingle()
        {
            var context1 = new BlogRepository<BlogAppDbContext, Blog>();
            var query1 = context1.GetSingle(2);
            Console.WriteLine($"{query1.Name} | {query1.Posts}");
        }

        public static void AddEdit()
        {
            var Post1 = new Post()
            {
                Title = "This is a new post for the Add",
                CreatedDate = DateTime.Now,
                Body = "Lorem ipsum text is what i typed here"
            };

            var Post2 = new Post()
            {
                Title = "This is the second new post for the Edit",
                CreatedDate = DateTime.Now,
                Body = "Lorem ipsum text is what i typed here"
            };

            var context3 = new BlogRepository<BlogAppDbContext, Post>();
            context3.Add(Post1);
            Post1.Title = "This is the edited title";
            context3.Edit(Post1);
        }
        private static void Delete()
        {
            var context = new BlogRepository<BlogAppDbContext, Post>();

            context.Delete(1);

        }

        private static void FindBy()
        {
            var context = new BlogRepository<BlogAppDbContext, Post>();
            var output = context.FindBy(c => c.Body.Contains("ipsum"));
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Id} | {item.Title} | {item.Body}");
            }

        }
    }
}
