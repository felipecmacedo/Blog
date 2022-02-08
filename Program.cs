using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    internal class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=your_password;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();

            // ReadUsers(connection);
            // ReadRole(connection);
            // ReadUser();
            // CreateUser();
            // UpdateUser();
            // DeleteUser();

            connection.Close();
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var users = repository.Get();

            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }

        public static void ReadRole(SqlConnection connection)
        {
            var repository = new RoleRepository(connection);
            var roles = repository.Get();

            foreach (var role in roles)
            {
                Console.WriteLine(role.Name);
            }
        }
    }
}