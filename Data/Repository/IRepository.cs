using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Data.Repository
{
    public interface IRepository
    {
        IEnumerable<TodoItem> GetAllItems();

        void AddTodo(string todoName);
        void ValueChanged(TodoItem changedItem);
        void DeleteItem(int id);
    }
}
