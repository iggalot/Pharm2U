using Pharm2U.Models.OrderDataViewModels;
using Pharm2U.Services.Data;
using Pharm2U.Services.Data.EntityFramework;
using Pharm2U.Utilities;
using System.Collections.ObjectModel;

namespace Pharm2U.ViewModels.OrderDataViewModels
{

    public class OrdersVM : ObservableObject
    {
        #region Private Members

        /// <summary>
        /// The currently selected order
        /// </summary>
        private P2U_Order _selectedOrder;
        private OrderDetailsViewModel _selectedFullOrder;

        /// <summary>
        /// The data service that was used to create this view model
        /// </summary>
        private IDataService<P2U_Order> _dataService;

        #endregion


        #region Public Methods
        /// <summary>
        /// The currently selected order from the list
        /// </summary>
        public OrderDetailsViewModel FullSelectedOrder
        {
            get
            {
                return _selectedFullOrder;
            }

            set
            {
                // If no order, do nothing
                if ((value==null)||(SelectedOrder == null))
                    return;

                // Load our full order information from the order ID
                _selectedFullOrder = new OrderDetailsViewModel(SelectedOrder.ItemID);

                // Signal that we have changed the selected order from the list
                OnPropertyChanged(ref _selectedFullOrder, value);
                OnPropertyChanged("FullSelectedOrder");
            }
        }


        /// <summary>
        /// The currently selected order from the list
        /// </summary>
        public P2U_Order SelectedOrder
        {
            get => _selectedOrder;
            set
            {
                // If no order, do nothing
                if (value == null)
                    return;

                _selectedOrder = value;
                //MessageBox.Show("Order #" + value.ItemID + " selected");

                // Load our full order information from the order ID
                _selectedFullOrder = new OrderDetailsViewModel(value.ItemID);

                // Signal that we have changed the selected order from the list
                OnPropertyChanged(ref _selectedOrder, value);
                OnPropertyChanged("FullSelectedOrder");
            }
        }

        /// <summary>
        /// The collection of orders for this list
        /// </summary>
        public ObservableCollection<P2U_Order> Orders { get; set; }

        #endregion

        #region Private Methods
        /// <summary>
        /// Loads the specified orders from the order list view model
        /// </summary>
        /// <param name="orders"></param>
        public void LoadOrders(ObservableCollection<P2U_Order> orders)
        {
            Orders = new ObservableCollection<P2U_Order>(orders);
            OnPropertyChanged("Orders");
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Our default constructor for the current dataservice
        /// </summary>
        /// <param name="dataservice"></param>
        public OrdersVM(IDataService<P2U_Order> dataservice)
        {
            _dataService = dataservice;
            FullSelectedOrder = null;
            SelectedOrder = null;
        }
        #endregion
    }
}
