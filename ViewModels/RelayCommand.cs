﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Todo_MVVM.ViewModels
{
    public class RelayCommand : ICommand
    {
        private readonly Predicate<object>? _canExecute;
        private readonly Action<object> _execute;

        public RelayCommand(Action<object> execute) 
            : this(execute, null)
        {
        }

        public RelayCommand(Action<object> execute, Predicate<object>? canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return (_canExecute == null) || _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
