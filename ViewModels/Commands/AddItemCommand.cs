using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Todo_MVVM.ViewModels.Commands
{
    public class AddItemCommand : ICommand
    {
        Action<object> ExecuteMethod;
        Func<object, bool> CanExecuteMethod;

        public AddItemCommand(Action<object> executeMethod, Func<object, bool> canExecuteMethod)
        {
            this.ExecuteMethod = executeMethod;
            this.CanExecuteMethod = canExecuteMethod;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            ExecuteMethod(parameter);
        }
    }
}
