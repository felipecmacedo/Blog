using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreen;

namespace Blog.Screens.UserScreen
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo usuário");

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

            Create(new User
            {
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
        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection!);
                repository.Create(user);
                Console.WriteLine("Usuário criado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível criar um usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}