using Blog.Models;
using Blog.Repositories;
using Blog.Screens.CategoryScreen;

namespace Blog.Screen.CategoryScreen
{
    public static class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Listas de Tags");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuCategoryScreen.Load();

        }
        private static void List()
        {
            var repository = new Repository<Category>(Database.Connection);
            var categories = repository.Get();
            foreach(var item in categories)
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
            }
        }
    }
}