namespace Blog.Screens.PostScreen
{
    public static class MenuPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Posts");
            Console.WriteLine("---------------");
            Console.WriteLine("1 - Listar Posts");
            Console.WriteLine("2 - Criar Post");
            Console.WriteLine("3 - Atualizar Post");
            Console.WriteLine("4 - Excluir Post");
            Console.WriteLine();
            Console.Write("Opção: ");
            var option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine("Listar");
                    break;
                case 2:
                    Console.WriteLine("Criar");
                    break;
                case 3:
                    Console.WriteLine("Atualizar");
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