﻿using System.Threading.Tasks;

using ToDoApp.Application.Interfaces;
using ToDoApp.Entity.Entities;

namespace ToDoApp.Repository.ToDo
{
    public class ToDoCommandRepository : IToDoCommandRepository
    {
        private readonly ToDoDataContext _toDoDataContext;

        public ToDoCommandRepository(ToDoDataContext toDoDataContext)
        {
            _toDoDataContext = toDoDataContext;
        }

        public async Task CreateToDo(ToDoItem toDo)
        {
            _toDoDataContext.Add(toDo);
            await _toDoDataContext.SaveChangesAsync();
        }

        public async Task UpdateToDo(ToDoItem toDo)
        {
            _toDoDataContext.Update(toDo);
            await _toDoDataContext.SaveChangesAsync();
        }
    }
}
