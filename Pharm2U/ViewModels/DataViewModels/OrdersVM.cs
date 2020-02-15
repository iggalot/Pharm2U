using Pharm2U.Models;
using Pharm2U.Services.Data;
using Pharm2U.Services.Data.EntityFramework;
using Pharm2U.Services.Printing;
using Pharm2U.Utilities;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Pharm2U.ViewModels.DataViewModels
{

    public class OrdersVM : ObservableObject
    {
        #region Private Members

        /// <summary>
        /// The currently selected order
        /// </summary>
        private P2U_Order _selectedOrder;

        /// <summary>
        /// The data service that was used to create this view model
        /// </summary>
        private IDataService<P2U_Order> _dataService;

        #endregion


        #region Public Methods
        /// <summary>
        /// The currently selected order from the list
        /// </summary>
        public P2U_Order SelectedOrder
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
        public ObservableCollection<P2U_Order> Orders { get; set; }

        #endregion

        #region Private Methods
        public void LoadOrders(ObservableCollection<P2U_Order> orders)
        {
            Orders = new ObservableCollection<P2U_Order>(orders);
            OnPropertyChanged("Orders");
        }
        #endregion

        #region Default Constructor
        public OrdersVM(IDataService<P2U_Order> dataservice)
        {
            _dataService = dataservice;

            //// Set up our commands
            //PrintCommand printcommand = new PrintCommand();
            //DoPrintCommand = printcommand;
        }

        #endregion

        //#region Commands
        //public ICommand DoPrintCommand { get; set; }
        //#endregion

    }
}
