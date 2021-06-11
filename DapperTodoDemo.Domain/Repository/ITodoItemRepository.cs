using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTodoDemo.Domain.Repository
{
    public interface ITodoItemRepository
    {
        Task<List<TodoItem>> GetListAsync();
        Task<TodoItem> GetAsync(Guid id);
        Task<TodoItem> InsertAsync(TodoItem todeItem);
        Task<TodoItem> UpdateAsync(Guid id, TodoItem todeItem);
        Task DeleteAsync(Guid id);
    }
}
