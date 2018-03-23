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

            var context2 = new BlogRepository<BlogAppDbContext, Post>();
            var query2 = context2.Add();
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Title} | {item.Body} | {item.CreatedDate}");
            }

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
            var AddPost = new Post();
            AddPost.Title = 
        }
    }
}
