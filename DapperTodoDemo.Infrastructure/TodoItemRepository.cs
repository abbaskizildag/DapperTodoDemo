using Dapper;
using DapperTodoDemo.Domain;
using DapperTodoDemo.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTodoDemo.Infrastructure
{
    public class TodoItemRepository : ITodoItemRepository
    {
        private readonly string _connectionString = "Data Source=DESKTOP-QO90D8M\\SQLEXPRESS;Initial Catalog=DapperTodoDemo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public async Task<List<TodoItem>> GetListAsync()
        {
            await using var connection = new SqlConnection(_connectionString);

            return (await connection.QueryAsync<TodoItem>("SELECT * from dbo.TodeItems")).AsList();
        }

        public async Task<TodoItem> GetAsync(Guid id)
        {
            await using var connection = new SqlConnection(_connectionString);

            return await connection.QueryFirstAsync<TodoItem>($"SELECT * from dbo.TodeItems WHERE ='{id}'");
        }

        public async Task<TodoItem> InsertAsync(TodoItem todeItem)
        {
            await using var connection = new SqlConnection(_connectionString);

            var query = $"INSERT INTO dbo.TodeItems VALUES('{todeItem.Id}','{todeItem.Title}','{todeItem.Description}',{(int)todeItem.Status})";

            await connection.ExecuteAsync(query);

            return todeItem;
        }

        public async Task<TodoItem> UpdateAsync(Guid id, TodoItem todoItem)
        {
            await using var connection = new SqlConnection(_connectionString);

            await connection.ExecuteAsync($"UPDATE dbo.TodeItems SET{nameof(TodoItem.Title)}='{todoItem.Title}', {nameof(TodoItem.Description)}='{todoItem.Description}',{nameof(TodoItem.Status)} = {(int)todoItem.Status} WHERE Id = '{id}'");

            return todoItem;
        }

        public async Task DeleteAsync(Guid id)
        {
            await using var connection = new SqlConnection(_connectionString);

            await connection.ExecuteAsync($"DELETE FROM dbo.TodoItems WHERE Id = '{id}'");
        }
    }
}
