
namespace WpfMVVMdemo.Commands
    {
    using System.Windows.Input;
    using WpfMVVMdemo.ViewModels;

    internal class UpdateCustomerCommand : ICommand
        {

        private CustomerViewModel viewModel;

        /// <summary>
        /// Initializes a new instance of the UpdateCustomerCommand class.
        /// </summary>
        /// <param name="viewModel"></param>
        public UpdateCustomerCommand(CustomerViewModel viewModel)
            {
            this.viewModel = viewModel;
            }

        

        #region ICommand Members
        public event System.EventHandler CanExecuteChanged
            {
            add { CommandManager.RequerySuggested += value; }

            remove { CommandManager.RequerySuggested -= value; }
            }

        public bool CanExecute(object parameter)
            {
            return string.IsNullOrWhiteSpace(viewModel.Customer.Error);
            }

        public void Execute(object parameter)
            {
            viewModel.SaveChanges();
            }
        #endregion

        }
    }
