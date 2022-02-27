using Blog.Models;
using Blog.Repositories;
using Blog.Screens.CategoryScreen;

namespace Blog.Screen.CategoryScreen
{
    public static class CreateCategoryScreen
    {

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Criar categorias");
            Console.WriteLine("----------------");

            Console.Write("Nome da categoria: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Category
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
        private static void Create(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Create(category);
                Console.WriteLine("Categoria criada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível criar categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}