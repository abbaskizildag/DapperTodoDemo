﻿using AutoMapper;
using DapperTodoDemo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTodoDemo.Application
{
    public class TodoItemAutoMapperProfile : Profile
    {
        public TodoItemAutoMapperProfile()
        {
            CreateMap<TodoItem, TodoItemDto>();

            CreateMap<CreateUpdateTodoItemDto, TodoItem>();
        }
    }
}
