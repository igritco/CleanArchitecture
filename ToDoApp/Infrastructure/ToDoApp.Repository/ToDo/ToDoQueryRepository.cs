﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using ToDoApp.Application.Interfaces;
using ToDoApp.Entity.Entities;

namespace ToDoApp.Repository.ToDo
{
    public class ToDoQueryRepository : IToDoQueryRepository
    {
        private readonly ToDoDataContext _toDoDataContext;

        public ToDoQueryRepository(ToDoDataContext toDoDataContext)
        {
            _toDoDataContext = toDoDataContext;
            _toDoDataContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }


        public async Task<ToDoItem> GetToDo(Guid id, string username)
        {
            return await _toDoDataContext.ToDoItems.Where(x => x.Id.Equals(id) && x.Username.Equals(username)).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<ToDoItem>> GetToDoList(string username)
        {
            return await _toDoDataContext.ToDoItems.Where(x => x.Username.Equals(username)).ToListAsync();
        }
    }
}
