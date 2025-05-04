using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo_MVVM.ViewModels.Bases;
using Todo_MVVM.Models;

namespace Todo_MVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IList<TodoItem>? _items;
        public IList<TodoItem>? Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public MainViewModel()
        {
            Items = new List<TodoItem>
            {
                new TodoItem { Name = "Task 1", Category = "Work", IsCompleted = false },
                new TodoItem { Name = "Task 2", Category = "Personal", IsCompleted = true },
                new TodoItem { Name = "Task 3", Category = "Work", IsCompleted = false }
            };

        }
    }
}
