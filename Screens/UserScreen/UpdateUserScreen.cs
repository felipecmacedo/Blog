using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreen;

namespace Blog.Screens.UserScreen
{
    public static class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar usuário");
            Console.WriteLine("-----------------");
            
            Console.Write("Identificador: ");
            var id = Console.ReadLine();

            Console.Write("Digite o nome do usuário: ");
            var name = Console.ReadLine();

            Console.Write("Digite o e-mail do usuário: ");
            var email = Console.ReadLine();

            var password = "HASH";

            Console.Write("Digite uma biografia: ");
            var bio = Console.ReadLine();

            var img = "https://...";

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new User
            {
                Id = int.Parse(id),
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = img,
                Slug = slug
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        private static void Update(User user)
        {
            try 
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);
                Console.WriteLine("Cadastro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}