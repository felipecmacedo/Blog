using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    internal class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=Ghfkgurhg@8683;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);

            var repositoryUsers = new Repository<User>(connection);
            var repositoryRoles = new Repository<Role>(connection);
            var repositoryTags = new Repository<Tag>(connection);

            connection.Open();

            ReadUsers(connection);
            // CreateUsers(repositoryUsers);
            // DeleteUsers(repositoryUsers);
            // UpdateUsers(repositoryUsers);

            // CreateRoles(repositoryRoles);
            // UpdateRole(repositoryRoles);
            // DeleteRole(repositoryRoles);
            // ReadRoles(connection);

            // ReadTags(connection);
            // CreateTags(repositoryTags);
            // UpdateTags(repositoryTags);
            // DeleteTags(repositoryTags);

            connection.Close();
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var items = repository.GetWithRoles();

            foreach (var item in items)
            {
                Console.WriteLine($" - {item.Name}");

                foreach (var role in item.Roles)
                {
                    Console.WriteLine($" - {role.Name}");
                }
            }
        }
        public static void CreateUsers(Repository<User> repository)
        {
            var user = new User
            {
                Bio = "8x Microsoft MVP",
                Email = "email@balta.io",
                Image = "https://balta.io/andrebaltieri.jpg",
                Name = "André Baltieri",
                Slug = "felipe-macedo",
                PasswordHash = Guid.NewGuid().ToString()
            };

            repository.Create(user);
        }
        public static void UpdateUsers(Repository<User> repository)
        {
            var user = repository.Get(1002);
            user.Email = "hello@balta.io";
            repository.Update(user);

            Console.WriteLine(user?.Email);
        }
        public static void DeleteUsers(Repository<User> repository)
        {
            var user = new User();

            user.Id = 1;

            repository.Delete(user.Id);

            Console.WriteLine("Exclusão feita com sucesso");
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);
        }
        public static void CreateRoles(Repository<Role> repository)
        {
            var role = new Role
            {
                Name = "Backend",
                Slug = "back-end"
            };
            repository.Create(role);
        }
        public static void UpdateRole(Repository<Role> repository)
        {
            var role = repository.Get(2);
            role.Name = "BackEnd";
            repository.Update(role);

            Console.WriteLine(role?.Name);
        }
        public static void DeleteRole(Repository<Role> repository)
        {
            var role = new Role();
            role.Id = 2;
            repository.Delete(role.Id);
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public static void ReadTags(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var items = repository.Get();

            foreach (var item in items)

                Console.WriteLine(item.Name);
        }
        public static void CreateTags(Repository<Tag> repository)
        {
            var tag = new Tag
            {
                Name = "FrontEnd",
                Slug = "front-end"
            };

            repository.Create(tag);

            Console.WriteLine("Inclusão efetuada com sucesso");
        }
        public static void UpdateTags(Repository<Tag> repository)
        {
            var tag = repository.Get(2);
            tag.Name = "frontend";
            repository.Update(tag);

            Console.WriteLine(tag?.Name);
        }
        public static void DeleteTags(Repository<Tag> repository)
        {
            var tag = new Tag();
            tag.Id = 2;
            repository.Delete(tag.Id);
            Console.WriteLine("Exclusão efetuada com sucesso");
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------
    }
}