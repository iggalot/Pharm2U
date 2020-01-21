using Pharm2U.Models;
using Pharm2U.Models.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Pharm2U.Services.Data.MockData
{

    public class MockOrderDataService : IDataService<OrderModel>
    {

        #region Constructor
        /// <summary>
        /// Default Constructor for our mock data service
        /// </summary>
        public MockOrderDataService()
        {
            Data = new ObservableCollection<OrderModel>()
            {
                new OrderModel
                (
                1000,
                new Customer(1, "John", "Doe", "111 Anywhere Billing", "555-1111", "Customer1000@email.com"),
                new ObservableCollection<Food>()
                    { new Food(10, "Pears", "solid"),
                      new Food(20, "Jello", "jello")
                    },

                new ObservableCollection<OTC>()
                    { new OTC(100, "Tylenol"),
                      new OTC(200, "Bandaids")
                    },
                OrderStatus.STATUS_NEWORDER
                ),

                new OrderModel
                (
                2000,
                new Customer(2, "Jane", "Smith", "222 Anywhere Billing", "555-2222","customer2000@email.com"),
                new ObservableCollection<Food>()
                    { new Food(20, "Oranges", "solid"),
                      new Food(21, "Tea", "liquid")
                    },

                new ObservableCollection<OTC>()
                    { new OTC(200, "Tongue Depressors"),
                      new OTC(201, "Aspirin")
                    },
                OrderStatus.STATUS_PACKAGING
                ),

                new OrderModel
                (
                3000,
                new Customer(3, "John", "Smith", "333 Anywhere Billing", "555-3333", "customer3000@email.com"),
                new ObservableCollection<Food>()
                    { new Food(30, "Noodle soup", "liquid"),
                      new Food(31, "Orange juice", "liquid")
                    },

                new ObservableCollection<OTC>()
                    { new OTC(300, "Gauze"),
                      new OTC(301, "Antacid"),
                      new OTC(302, "Cough drops")

                    },
                OrderStatus.STATUS_OUT_FOR_DELIVERY
                ),

                new OrderModel
                (
                1000,
                new Customer(1, "John", "Doe", "111 Anywhere Billing", "555-1111", "customer1000@email.com"),
                new ObservableCollection<Food>()
                    { new Food(10, "Pears", "solid"),
                      new Food(20, "Jello", "jello")
                    },

                new ObservableCollection<OTC>()
                    { new OTC(100, "Tylenol"),
                      new OTC(200, "Bandaids")
                    },
                OrderStatus.STATUS_NEWORDER
                ),

                new OrderModel
                (
                2000,
                new Customer(2, "Jane", "Smith", "222 Anywhere Billing", "555-2222", "customer2000@email.com"),
                new ObservableCollection<Food>()
                    { new Food(20, "Oranges", "solid"),
                      new Food(21, "Tea", "liquid")
                    },

                new ObservableCollection<OTC>()
                    { new OTC(200, "Tongue Depressors"),
                      new OTC(201, "Aspirin")
                    },
                OrderStatus.STATUS_PACKAGING
                ),

                new OrderModel
                (
                3000,
                new Customer(3, "John", "Smith", "333 Anywhere Billing", "555-3333", "customer3000@email.com"),
                new ObservableCollection<Food>()
                    { new Food(30, "Noodle soup", "liquid"),
                      new Food(31, "Orange juice", "liquid")
                    },

                new ObservableCollection<OTC>()
                    { new OTC(300, "Gauze"),
                      new OTC(301, "Antacid"),
                      new OTC(302, "Cough drops")

                    },
                OrderStatus.STATUS_OUT_FOR_DELIVERY
                ),

                                new OrderModel
                (
                1000,
                new Customer(1, "John", "Doe", "111 Anywhere Billing", "555-1111", "Customer1000@email.com"),
                new ObservableCollection<Food>()
                    { new Food(10, "Pears", "solid"),
                      new Food(20, "Jello", "jello")
                    },

                new ObservableCollection<OTC>()
                    { new OTC(100, "Tylenol"),
                      new OTC(200, "Bandaids")
                    },
                OrderStatus.STATUS_NEWORDER
                ),

                new OrderModel
                (
                2000,
                new Customer(2, "Jane", "Smith", "222 Anywhere Billing", "555-2222","customer2000@email.com"),
                new ObservableCollection<Food>()
                    { new Food(20, "Oranges", "solid"),
                      new Food(21, "Tea", "liquid")
                    },

                new ObservableCollection<OTC>()
                    { new OTC(200, "Tongue Depressors"),
                      new OTC(201, "Aspirin")
                    },
                OrderStatus.STATUS_PACKAGING
                ),

                new OrderModel
                (
                3000,
                new Customer(3, "John", "Smith", "333 Anywhere Billing", "555-3333", "customer3000@email.com"),
                new ObservableCollection<Food>()
                    { new Food(30, "Noodle soup", "liquid"),
                      new Food(31, "Orange juice", "liquid")
                    },

                new ObservableCollection<OTC>()
                    { new OTC(300, "Gauze"),
                      new OTC(301, "Antacid"),
                      new OTC(302, "Cough drops")

                    },
                OrderStatus.STATUS_OUT_FOR_DELIVERY
                ),

                new OrderModel
                (
                1000,
                new Customer(1, "John", "Doe", "111 Anywhere Billing", "555-1111", "customer1000@email.com"),
                new ObservableCollection<Food>()
                    { new Food(10, "Pears", "solid"),
                      new Food(20, "Jello", "jello")
                    },

                new ObservableCollection<OTC>()
                    { new OTC(100, "Tylenol"),
                      new OTC(200, "Bandaids")
                    },
                OrderStatus.STATUS_NEWORDER
                ),

                new OrderModel
                (
                2000,
                new Customer(2, "Jane", "Smith", "222 Anywhere Billing", "555-2222", "customer2000@email.com"),
                new ObservableCollection<Food>()
                    { new Food(20, "Oranges", "solid"),
                      new Food(21, "Tea", "liquid")
                    },

                new ObservableCollection<OTC>()
                    { new OTC(200, "Tongue Depressors"),
                      new OTC(201, "Aspirin")
                    },
                OrderStatus.STATUS_PACKAGING
                ),

                new OrderModel
                (
                3000,
                new Customer(3, "John", "Smith", "333 Anywhere Billing", "555-3333", "customer3000@email.com"),
                new ObservableCollection<Food>()
                    { new Food(30, "Noodle soup", "liquid"),
                      new Food(31, "Orange juice", "liquid")
                    },

                new ObservableCollection<OTC>()
                    { new OTC(300, "Gauze"),
                      new OTC(301, "Antacid"),
                      new OTC(302, "Cough drops")

                    },
                OrderStatus.STATUS_OUT_FOR_DELIVERY
                )


            };

        }
        #endregion

    }
}
