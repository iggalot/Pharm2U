using Pharm2U.Models;
using Pharm2U.Services.Data;
using Pharm2U.Services.Data.MockData;
using Pharm2U.Utilities;
using Pharm2U.ViewModels.DataViewModels;
using System;

namespace Pharm2U.ViewModels
{
    public class ApplicationViewModel : ObservableObject
    {
        #region Private Members

        // The OrderListviewModel controlled by this application
        private OrderListViewModel _orderListVM;
        private OrderListViewModel _currentOrderListView;
        #endregion

        #region Public Properties
        /// <summary>
        /// The order list view model controlled by this application
        /// </summary>
        public OrderListViewModel OrderListVM
        {
            get => _orderListVM;
            set { OnPropertyChanged(ref _orderListVM, value); }
        }

        /// <summary>
        ///  The current order list view
        /// </summary>
        public OrderListViewModel CurrentOrderListVM
        {
            get => _currentOrderListView;
            set { OnPropertyChanged(ref _currentOrderListView, value); }
        }

        /// <summary>
        /// A name for our Application View Model
        /// </summary>
        public string Name { get; set; } = "Application View Model";

        /// <summary>
        /// Our order model dataservice
        /// </summary>
        public IDataService<OrderModel> OrderDataService { get; set; }

        #endregion

        #region Default Constructor

        /// <summary>
        /// Constructor for our ApplicationViewModel
        /// </summary>
        public ApplicationViewModel()
        {
            // Load our order Data
            OrderDataService = new MockOrderDataService();

            // Create our order list view model for our data set
            OrderListVM = new OrderListViewModel(OrderDataService);

            // Set our current order list
            CurrentOrderListVM = OrderListVM;

            Console.WriteLine(OrderDataService.Display());
        }

        #endregion
    }
}
