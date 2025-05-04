using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Todo_MVVM.Models
{
    public class AddingItem : ObservableObject
    {
        private string? _name;
        public string? Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        private string? _category;
        public string? Category
        {
            get => _category;
            set => SetProperty(ref _category, value);
        }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Category);
        }
    }
}
