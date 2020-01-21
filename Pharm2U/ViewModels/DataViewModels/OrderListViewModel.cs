using Pharm2U.Models;
using Pharm2U.Services.Data;
using Pharm2U.Utilities;
using System;
using System.Windows.Input;

namespace Pharm2U.ViewModels.DataViewModels
{
    public class OrderListViewModel : ObservableObject
    {
        #region Private Members

        private IDataService<OrderModel> _dataService;

        /// <summary>
        /// The orders view model
        /// </summary>
        private OrdersVM _ordersVM;

        #endregion

        #region Public Properties

        public OrdersVM OrdersVM
        {
            get => _ordersVM;
            set { OnPropertyChanged(ref _ordersVM, value); }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="orderdata">IDataService type for this view model</param>
        public OrderListViewModel(IDataService<OrderModel> orderdataservice)
        {
            _dataService = orderdataservice;

            OrdersVM = new OrdersVM(orderdataservice);

            // Create our commands associated with this view model
            LoadOrdersCommand = new RelayCommand(LoadOrders);

        }

        /// <summary>
        /// Loads the orders to the list
        /// </summary>
        private void LoadOrders(object obj)
        {
            OrdersVM.LoadOrders(_dataService.LoadData());
        }

        #endregion


        #region Commands
        public ICommand LoadOrdersCommand { get; private set; }
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

            foreach(OrderModel item in _dataService.LoadData())
            {
                str += item.Display() + "\n";
            }

            return str;
        }


        #endregion

    }
}
