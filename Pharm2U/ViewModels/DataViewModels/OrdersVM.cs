using Pharm2U.Models;
using Pharm2U.Services.Data;
using Pharm2U.Utilities;
using System.Collections.ObjectModel;

namespace Pharm2U.ViewModels.DataViewModels
{

    public class OrdersVM : ObservableObject
    {
        #region Private Members

        /// <summary>
        /// The currently selected order
        /// </summary>
        private OrderModel _selectedOrder;

        /// <summary>
        /// The data service that was used to create this view model
        /// </summary>
        private IDataService<OrderModel> _dataService;

        #endregion


        #region Public Methods
        /// <summary>
        /// The currently selected order from the list
        /// </summary>
        public OrderModel SelectedOrder
        {
            get => _selectedOrder;
            set
            {
                OnPropertyChanged(ref _selectedOrder, value);
            }
        }

        /// <summary>
        /// The collection of orders for this list
        /// </summary>
        public ObservableCollection<OrderModel> Orders { get; set; }

        #endregion

        #region Private Methods
        public void LoadOrders(ObservableCollection<OrderModel> orders)
        {
            Orders = new ObservableCollection<OrderModel>(orders);
            OnPropertyChanged("Orders");
        }
        #endregion

        #region Default Constructor
        public OrdersVM(IDataService<OrderModel> dataservice)
        {
            _dataService = dataservice;
        }

        #endregion
    }
}
