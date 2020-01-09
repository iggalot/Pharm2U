using Pharm2U.Models;
using Pharm2U.Services.Data;
using Pharm2U.Services.Data.MockData;
using System;

namespace Pharm2U.ViewModels
{
    public class ApplicationViewModel
    {
        /// <summary>
        /// Our order model dataservice
        /// </summary>
        public IDataService<OrderModel> OrderData;

        /// <summary>
        /// Constructor for our ApplicationViewModel
        /// </summary>
        public ApplicationViewModel()
        {
            // Load our order Data
            OrderData = new MockOrderDataService();

            Console.WriteLine(OrderData.Display());
        }
    }
}
