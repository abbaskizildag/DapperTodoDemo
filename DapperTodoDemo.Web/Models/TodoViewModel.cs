using DapperTodoDemo.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperTodoDemo.Web.Models
{
    public class TodoViewModel
    {
        public List<TodoItemDto> TodoItems { get; set; }
    }
}
