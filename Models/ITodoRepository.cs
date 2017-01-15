using System.Collections.Generic;

namespace TodoApi.Models
{
    // This interface defines base GRUD(Create, Read, Update, Delete) operations.
    public interface ITodoRepository
    {
         void Add(TodoItem item);
         IEnumerable<TodoItem> GetAll();
         TodoItem Find(string key);
         TodoItem Remove(string key);
         void Update(TodoItem item);
    }
}