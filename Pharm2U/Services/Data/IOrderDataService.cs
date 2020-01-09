using System.Collections.Generic;

namespace Pharm2U.Services.Data
{
    public interface IOrderDataService
    {
        IEnumerable<Orders> GetOrders();

        void Save(IEnumerable<Orders> contacts);
    }
}
