using Blog.Models;
using Blog.Repositories;

namespace Blog.Screen.PostScreen
{
    public static class ListPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Tags");
            Console.WriteLine("-------------");
            List();
        }
        private static void List()
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                var posts = repository.Get();
                foreach(var item in posts)
                {
                    Console.WriteLine($"{item.Id} - {item.Title}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível listar os posts");
                Console.WriteLine(ex.Message);
            }
        }
    }
}