using Pharm2U.Services.Data;
using Pharm2U.Services.Data.EntityFramework;
using Pharm2U.Utilities;
using System;
using System.Windows.Input;

namespace Pharm2U.ViewModels.OrderDataViewModels
{
    public class CustomerListViewModel : ObservableObject
    {
        #region Private Members

        private IDataService<P2U_Customer> _dataService;

        /// <summary>
        /// The orders view model
        /// </summary>
        private CustomersVM _customersVM;

        #endregion

        #region Public Properties

        public CustomersVM CustomersVM
        {
            get => _customersVM;
            set { OnPropertyChanged(ref _customersVM, value); }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="orderdata">IDataService type for this view model</param>
        public CustomerListViewModel(IDataService<P2U_Customer> customerdataservice)
        {
            _dataService = customerdataservice;

            CustomersVM = new CustomersVM(customerdataservice);

            // Create our commands associated with this view model
            LoadCustomersCommand = new RelayCommand(LoadCustomers);

        }

        /// <summary>
        /// Loads the orders to the list
        /// </summary>
        private void LoadCustomers(object obj)
        {
            CustomersVM.LoadCustomers(_dataService.LoadData());
        }

        #endregion


        #region Commands
        public ICommand LoadCustomersCommand { get; private set; }
        #endregion


        #region Private Methods


        #endregion

        #region Public Methods

        /// <summary>
        /// Helper function for displaying the contents of our data service
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string str = String.Empty;

            foreach (P2U_Customer item in _dataService.LoadData())
            {
                str += "Item found....";
                //str += item.Display() + "\n";
            }

            return str;
        }


        #endregion

    }
}
