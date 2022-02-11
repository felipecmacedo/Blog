using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection) => _connection = connection;

        public T Get(int id)
            => _connection.Get<T>(id);

        public void Create(T model)
        {
            role.Id = 0;
            _connection.Insert<T>(model);
        }

        public void Update(T model)
            => _connection.Update<T>(model);

        public void Delete(T model)
            => _connection.Delete<Role>(role);

        public void Delete(int id)
        {
            var model = _connection.Get<T>(id);
            _connection.Delete<T>(model);
        }
    }
}