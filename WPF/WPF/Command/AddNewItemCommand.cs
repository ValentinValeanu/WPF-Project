using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Assignment5.ViewModel;

namespace Assignment5.Command
{
    public class AddNewItemCommand : ICommand
    {
        public MainViewModel viewModel;

        public AddNewItemCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.addNewItem();
        }
    }
}
