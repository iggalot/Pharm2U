using Pharm2U.Models;
using System.Collections.ObjectModel;

namespace Pharm2U.Services.Data.EntityFramework
{
    /// <summary>
    /// Controls interaction with the EntityFramework package and its
    /// communication with the SQLSERVER 2019.
    /// </summary>
    public abstract class EntityFrameworkDataService<T> : IDataService<T> 
        where T : class, new()
    {

    }
}
