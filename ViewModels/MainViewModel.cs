using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo_MVVM.ViewModels.Bases;
using Todo_MVVM.Models;
using Todo_MVVM.ViewModels.Commands;
using Todo_MVVM.Models.Mappers;
using System.Windows;
using System.Collections.ObjectModel;

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

    private AddItemCommand? _addItemC;
    public AddItemCommand? AddItemC
    {
        get => _addItemC;
        set => SetProperty(ref _addItemC, value);
    }

    private AddingItemTodoItemMapper AddingItemTodoItemMapper { get; set; } = new AddingItemTodoItemMapper();

    public MainViewModel()
    {
        Items = new ObservableCollection<TodoItem> {
            new TodoItem() { Name = "Item 1", Category = "Category 1", IsCompleted = false },
        };
        AddingItem = new AddingItem();
        AddItemC = new AddItemCommand(AddItem, CanAddItem);
    }

    public void AddItem(object? obj)
    {
        TodoItem newItem = AddingItemTodoItemMapper.AtoB(AddingItem);

        Items?.Add(newItem);
    }

    public bool CanAddItem(object? obj)
    {
        return true;
    }
}

