using Pharm2U.Models;
using Pharm2U.Services.Data;
using System;

namespace Pharm2U.ViewModels.DataViewModels
{
    public class OrderViewModel
    {
        /// <summary>
        /// Order data model associated with this view model
        /// </summary>
        public IDataService<OrderModel> OrderData { get; private set; }

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="orderdata">IDataService type for this view model</param>
        public OrderViewModel(IDataService<OrderModel> orderdata)
        {
            OrderData = orderdata;
        }
        #endregion

        #region Public Methods

        public string Display()
        {
            string str = String.Empty;

            foreach(OrderModel item in OrderData.GetData())
            {
                str += item.Display() + "\n";
            }

            return str;
        }


        #endregion

    }
}
