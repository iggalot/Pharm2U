using Pharm2U.Services.Data;
using Pharm2U.Services.Data.EntityFramework;
using Pharm2U.Utilities;
using System.Collections.ObjectModel;

namespace Pharm2U.ViewModels.DataViewModels
{
    public class CustomersVM : ObservableObject
    {
        #region Private Members

        /// <summary>
        /// The currently selected order
        /// </summary>
        private P2U_Customer _selectedCustomer;

        /// <summary>
        /// The data service that was used to create this view model
        /// </summary>
        private IDataService<P2U_Customer> _dataService;

        #endregion


        #region Public Methods
        /// <summary>
        /// The currently selected customer from the list
        /// </summary>
        public P2U_Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                OnPropertyChanged(ref _selectedCustomer, value);
            }
        }

        /// <summary>
        /// The collection of orders for this list
        /// </summary>
        public ObservableCollection<P2U_Customer> Customers { get; set; }

        #endregion

        #region Private Methods
        public void LoadCustomers(ObservableCollection<P2U_Customer> customers)
        {
            Customers = new ObservableCollection<P2U_Customer>(customers);
            OnPropertyChanged("Customers");
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructorfor this view model
        /// </summary>
        /// <param name="dataservice"></param>
        public CustomersVM(IDataService<P2U_Customer> dataservice)
        {
            _dataService = dataservice;
        }

        #endregion
    }
}
