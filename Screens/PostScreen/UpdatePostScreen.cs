namespace Blog.Screens.PostScreen
{
    public static class UpdatePostScreen
    {
        public static void Load()
        {

        }
        private static void Update()
        {
            try
            {
                Console.WriteLine("Post atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o Post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}