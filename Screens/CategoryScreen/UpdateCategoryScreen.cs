using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
    public static class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar Categoria");
            Console.WriteLine("-------------------");
            
            Console.Write("Identificador: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Category
            {
                Id = id,
                Name = name,
                Slug = slug,
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
        private static void Update(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Update(category);
                Console.WriteLine("Categoria atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar");
                Console.WriteLine(ex.Message);
            }
        }
    }
}