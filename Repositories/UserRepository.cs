using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class UserRepository
    {
        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<User> Get()
            => _connection.GetAll<User>(); //expression body, ou seja, é o mesmo de return _connection.GetAll<User>();

        public User Get(int id)
            => _connection.Get<User>(id); //expression body, ou seja, é o mesmo de return _connection.Get<User>();

        public void Crate(User user)
            => _connection.Insert<User>(user); //expression body, ou seja, é o mesmo de _connection.Insert<User>();
    }
}