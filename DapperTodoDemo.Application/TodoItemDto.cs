﻿using DapperTodoDemo.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTodoDemo.Application
{
    public class TodoItemDto
    {
        public Guid Id { get; set; }

        [Required]
        [NotNull]
        public string Title { get; set; }

        [Required]
        [NotNull]
        public string Description { get; set; }

        public TodoStatus Status { get; set; }
    }
}
