using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_MVVM.Models.Mappers
{
    public class AddingItemTodoItemMapper : IBaseMapper<AddingItem, TodoItem>
    {
        public AddingItem Map(TodoItem b)
        {
            return new AddingItem
            {
                Name = b.Name,
                Category = b.Category
            };
        }

        public TodoItem Map(AddingItem a)
        {
            return new TodoItem
            {
                Name = a.Name,
                Category = a.Category,
                IsCompleted = false
            };
        }
    }
}
