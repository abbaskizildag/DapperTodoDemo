using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTodoDemo.Domain
{
    public class TodoItem
    {
        public Guid Id { get;private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TodoStatus Status { get; set; }

        protected TodoItem()
        {

        }

        public TodoItem(Guid id,string title,string description)
        {
            Id = id;
            SetTile(title);
            SetDescription(description);
            Status = TodoStatus.Opened;
        }

        private void SetTile(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException($"{ nameof(Title)} can not be blank.");
            }
            Title = title;
        }

        private void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentNullException($"{ nameof(Description)} can not be blank.");
            }
            Description = description;
        }

        internal void ChangeStatus(TodoStatus status)
        {
            Status = status;
        }
    }
}
