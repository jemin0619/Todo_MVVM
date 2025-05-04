using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo_MVVM.ViewModels.Bases;
using Todo_MVVM.Models;
using Todo_MVVM.Models.Mappers;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Controls.Primitives;
using Todo_MVVM.ViewModels;

public class MainViewModel : ViewModelBase
{
    private ObservableCollection<TodoItem>? _items;
    public ObservableCollection<TodoItem>? Items
    {
        get => _items;
        set => SetProperty(ref _items, value);
    }

    private AddingItem? _addingItem;
    public AddingItem? AddingItem
    {
        get => _addingItem;
        set => SetProperty(ref _addingItem, value);
    }

    private AddingItemTodoItemMapper AddingItemTodoItemMapper { get; set; } = new AddingItemTodoItemMapper();

    private ICommand _addButtonICommand;
    public ICommand AddButtonICommand
    {
        get
        {
            if (_addButtonICommand == null)
            {
                _addButtonICommand = new RelayCommand(AddButtonClicked,
                    _ => AddingItem != null && AddingItem.IsValid());
            }
            return _addButtonICommand;
        }
    }

    private void AddButtonClicked(object? obj)
    {
        TodoItem newITem = AddingItemTodoItemMapper.Map(AddingItem);
        Items?.Add(newITem);
    }

    public MainViewModel()
    {
        Items = new ObservableCollection<TodoItem> {
            new TodoItem() { Name = "Item 1", Category = "Category 1", IsCompleted = false },
        };
        AddingItem = new AddingItem();
    }
}

