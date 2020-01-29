using Pharm2U.Models;
using Pharm2U.Models.Data;
using Pharm2U.Services.Data.EntityFramework;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Pharm2U.Services.Data.MockData
{

    public class MockOrderDataService : IDataService<P2U_Order>
    {

        #region Constructor
        /// <summary>
        /// Default Constructor for our mock data service
        /// </summary>
        public MockOrderDataService()
        {
            MessageBox.Show("Here");
            Data = new ObservableCollection<P2U_Order>()
            {
                //(int id, int customer_id, int pharm_id, int deliv_id, string status)
                new P2U_Order(100, 1000, 10000, 1, "New Order"),
                new P2U_Order(200, 2000, 20000, 1, "Ready For Packaging"),
                new P2U_Order(300, 3000, 30000, 1, "Ready for Delivery"),
                new P2U_Order(400, 4000, 40000, 1, "Out for Delivery"),
                new P2U_Order(500, 5000, 50000, 1, "Order Canceled"),
                new P2U_Order(600, 6000, 60000, 1, "Order Complete")
                    
                    

                //new OrderModel
                //(
                //1000,
                //new Customer(1, "John", "Doe", "111 Anywhere Billing", "555-1111", "Customer1000@email.com"),
                //new ObservableCollection<Food>()
                //    { new Food(10, "Pears", "solid"),
                //      new Food(20, "Jello", "jello")
                //    },

                //new ObservableCollection<OTC>()
                //    { new OTC(100, "Tylenol"),
                //      new OTC(200, "Bandaids")
                //    },
                //OrderStatus.STATUS_NEWORDER
                //),

                //new OrderModel
                //(
                //2000,
                //new Customer(2, "Jane", "Smith", "222 Anywhere Billing", "555-2222","customer2000@email.com"),
                //new ObservableCollection<Food>()
                //    { new Food(20, "Oranges", "solid"),
                //      new Food(21, "Tea", "liquid")
                //    },

                //new ObservableCollection<OTC>()
                //    { new OTC(200, "Tongue Depressors"),
                //      new OTC(201, "Aspirin")
                //    },
                //OrderStatus.STATUS_PACKAGING
                //),

                //new OrderModel
                //(
                //3000,
                //new Customer(3, "John", "Smith", "333 Anywhere Billing", "555-3333", "customer3000@email.com"),
                //new ObservableCollection<Food>()
                //    { new Food(30, "Noodle soup", "liquid"),
                //      new Food(31, "Orange juice", "liquid")
                //    },

                //new ObservableCollection<OTC>()
                //    { new OTC(300, "Gauze"),
                //      new OTC(301, "Antacid"),
                //      new OTC(302, "Cough drops")

                //    },
                //OrderStatus.STATUS_OUT_FOR_DELIVERY
                //),

                //new OrderModel
                //(
                //1000,
                //new Customer(1, "John", "Doe", "111 Anywhere Billing", "555-1111", "customer1000@email.com"),
                //new ObservableCollection<Food>()
                //    { new Food(10, "Pears", "solid"),
                //      new Food(20, "Jello", "jello")
                //    },

                //new ObservableCollection<OTC>()
                //    { new OTC(100, "Tylenol"),
                //      new OTC(200, "Bandaids")
                //    },
                //OrderStatus.STATUS_NEWORDER
                //),

                //new OrderModel
                //(
                //2000,
                //new Customer(2, "Jane", "Smith", "222 Anywhere Billing", "555-2222", "customer2000@email.com"),
                //new ObservableCollection<Food>()
                //    { new Food(20, "Oranges", "solid"),
                //      new Food(21, "Tea", "liquid")
                //    },

                //new ObservableCollection<OTC>()
                //    { new OTC(200, "Tongue Depressors"),
                //      new OTC(201, "Aspirin")
                //    },
                //OrderStatus.STATUS_PACKAGING
                //),

                //new OrderModel
                //(
                //3000,
                //new Customer(3, "John", "Smith", "333 Anywhere Billing", "555-3333", "customer3000@email.com"),
                //new ObservableCollection<Food>()
                //    { new Food(30, "Noodle soup", "liquid"),
                //      new Food(31, "Orange juice", "liquid")
                //    },

                //new ObservableCollection<OTC>()
                //    { new OTC(300, "Gauze"),
                //      new OTC(301, "Antacid"),
                //      new OTC(302, "Cough drops")

                //    },
                //OrderStatus.STATUS_OUT_FOR_DELIVERY
                //),

                //                new OrderModel
                //(
                //1000,
                //new Customer(1, "John", "Doe", "111 Anywhere Billing", "555-1111", "Customer1000@email.com"),
                //new ObservableCollection<Food>()
                //    { new Food(10, "Pears", "solid"),
                //      new Food(20, "Jello", "jello")
                //    },

                //new ObservableCollection<OTC>()
                //    { new OTC(100, "Tylenol"),
                //      new OTC(200, "Bandaids")
                //    },
                //OrderStatus.STATUS_NEWORDER
                //),

                //new OrderModel
                //(
                //2000,
                //new Customer(2, "Jane", "Smith", "222 Anywhere Billing", "555-2222","customer2000@email.com"),
                //new ObservableCollection<Food>()
                //    { new Food(20, "Oranges", "solid"),
                //      new Food(21, "Tea", "liquid")
                //    },

                //new ObservableCollection<OTC>()
                //    { new OTC(200, "Tongue Depressors"),
                //      new OTC(201, "Aspirin")
                //    },
                //OrderStatus.STATUS_PACKAGING
                //),

                //new OrderModel
                //(
                //3000,
                //new Customer(3, "John", "Smith", "333 Anywhere Billing", "555-3333", "customer3000@email.com"),
                //new ObservableCollection<Food>()
                //    { new Food(30, "Noodle soup", "liquid"),
                //      new Food(31, "Orange juice", "liquid")
                //    },

                //new ObservableCollection<OTC>()
                //    { new OTC(300, "Gauze"),
                //      new OTC(301, "Antacid"),
                //      new OTC(302, "Cough drops")

                //    },
                //OrderStatus.STATUS_OUT_FOR_DELIVERY
                //),

                //new OrderModel
                //(
                //1000,
                //new Customer(1, "John", "Doe", "111 Anywhere Billing", "555-1111", "customer1000@email.com"),
                //new ObservableCollection<Food>()
                //    { new Food(10, "Pears", "solid"),
                //      new Food(20, "Jello", "jello")
                //    },

                //new ObservableCollection<OTC>()
                //    { new OTC(100, "Tylenol"),
                //      new OTC(200, "Bandaids")
                //    },
                //OrderStatus.STATUS_NEWORDER
                //),

                //new OrderModel
                //(
                //2000,
                //new Customer(2, "Jane", "Smith", "222 Anywhere Billing", "555-2222", "customer2000@email.com"),
                //new ObservableCollection<Food>()
                //    { new Food(20, "Oranges", "solid"),
                //      new Food(21, "Tea", "liquid")
                //    },

                //new ObservableCollection<OTC>()
                //    { new OTC(200, "Tongue Depressors"),
                //      new OTC(201, "Aspirin")
                //    },
                //OrderStatus.STATUS_PACKAGING
                //),

                //new OrderModel
                //(
                //3000,
                //new Customer(3, "John", "Smith", "333 Anywhere Billing", "555-3333", "customer3000@email.com"),
                //new ObservableCollection<Food>()
                //    { new Food(30, "Noodle soup", "liquid"),
                //      new Food(31, "Orange juice", "liquid")
                //    },

                //new ObservableCollection<OTC>()
                //    { new OTC(300, "Gauze"),
                //      new OTC(301, "Antacid"),
                //      new OTC(302, "Cough drops")

                //    },
                //OrderStatus.STATUS_OUT_FOR_DELIVERY
                //)


            };

        }
        #endregion

    }
}
