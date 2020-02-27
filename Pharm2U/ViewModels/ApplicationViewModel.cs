using Pharm2U.Models;
using Pharm2U.Services.Data;
using Pharm2U.Services.Data.EntityFramework;
using Pharm2U.Services.Data.MockData;
using Pharm2U.Utilities;
using Pharm2U.ViewModels.OrderDataViewModels;
using System;
using System.Collections.ObjectModel;

namespace Pharm2U.ViewModels
{
    public class ApplicationViewModel : ObservableObject
    {
        #region Private Members

        // The OrderListviewModel controlled by this application
        private OrderListViewModel _orderListVM;
        private CustomerListViewModel _customerListVM;
 //       private OrderFoodListViewModel _orderFoodListVM;
        private OrderListViewModel _currentOrderListVM;

        /// <summary>
        /// Is this view model currently in edit mnode
        /// </summary>
        bool _mIsEditMode;
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
        /// The customer list view model controlled by this application
        /// </summary>
        public CustomerListViewModel CustomerListVM
        {
            get => _customerListVM;
            set { OnPropertyChanged(ref _customerListVM, value); }
        }

        /// <summary>
        ///  The current order list view
        /// </summary>
        public OrderListViewModel CurrentOrderListVM
        {
            get => _currentOrderListVM;
            set { OnPropertyChanged(ref _currentOrderListVM, value); }
        }

        /// <summary>
        /// A name for our Application View Model
        /// </summary>
        public string Name { get; set; } = "Application View Model";

        /// <summary>
        /// Our data model data service
        /// </summary>
        public IDataTables DataTables { get; set; }


        /// <summary>
        /// A flag to indicate whether the application is editing a document or should be viewing it.
        /// </summary>
        public bool IsEditMode
        {
            get => _mIsEditMode;
            set
            {
                // If the value has not change...do nothing
                if (value == _mIsEditMode)
                    return;

                // Otherwise
                _mIsEditMode = value;

                // Signal that this property has changed ti the UI.
                OnPropertyChanged("IsEditMode");


            }
        }

        #endregion

        #region Default Constructor

        /// <summary>
        /// Constructor for our ApplicationViewModel
        /// </summary>
        public ApplicationViewModel()
        {

            // Load our order Data
            DataTables = new MockDataService();

            // Create our order list view model for our data set
            OrderListVM = new OrderListViewModel(DataTables.OrderData);
            CustomerListVM = new CustomerListViewModel(DataTables.CustomerData);

            // Set our current order list
            CurrentOrderListVM = OrderListVM;

            Console.WriteLine(DataTables.Display());

            IsEditMode = false;
        }

        #endregion
    }
}
