using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Exclusão de Categoria");
            Console.WriteLine("---------------------");

            Console.WriteLine("Identificador: ");
            var id = int.Parse(Console.ReadLine());

            Delete(id);

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Categoria excluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}