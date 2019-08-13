﻿namespace WpfMVVMdemo.ViewModels
    {

    using System;
    using System.Diagnostics;
    using System.Windows.Input;
    using WpfMVVMdemo.Commands;
    using WpfMVVMdemo.Models;
    using WpfMVVMdemo.Views;


    internal class CustomerViewModel
        {

        private Customer customer;
        private CustomerInfoViewModel childViewModel;


        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class
        /// </summary>
        public CustomerViewModel()
            {
            customer = new Customer("David");
            childViewModel = new CustomerInfoViewModel();
            UpdateCommand = new UpdateCustomerCommand(this);
            }


        /// <summary>
        /// Gets the customer instance
        /// </summary>
        public Customer Customer { get { return customer; } }


        #region ICommand Members

        /// <summary>
        /// Gets the UpdateCommand for the ViewModel
        /// </summary>
        public ICommand UpdateCommand { get; private set; }


        /// <summary>
        /// Saves changes made to the Customer Instance
        /// </summary>
        public void SaveChanges()
            {

            CustomerInfoView view = new CustomerInfoView()
                { DataContext = childViewModel };

            childViewModel.Info = Customer.Name + " was updated in the database.";

            view.ShowDialog();
            }

        #endregion

        }
    }

