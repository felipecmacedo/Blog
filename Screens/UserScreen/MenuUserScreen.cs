using Blog.Screens.UserScreen;

namespace Blog.Screens.TagScreen
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de usuários");
            Console.WriteLine("------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar usuários");
            Console.WriteLine("2 - Criar um novo usuário");
            Console.WriteLine("3 - Atualizar um usuário");
            Console.WriteLine("4 - Excluir um usuário");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");
            var option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 1: 
                    ListUserScreen.Load();
                    break;
                case 2: 
                    CreateUserScreen.Load();
                    break;
                case 3: 
                    UpdateUserScreen.Load();
                    break;
                case 4: 
                    Console.WriteLine("Excluir");
                    break;
                default: 
                    Load();
                    break; 
            }
        }
    }
}