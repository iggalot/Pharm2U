using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Pharm2U.Services.Data
{
    /// <summary>
    /// Abstract class for IDataService class, that generates the data collection information for a given data object type
    /// </summary>
    /// <typeparam name="T">The object data model to implement the servife for</typeparam>
    public abstract class IDataService<T> where T : class, new()
    {
        #region Public Properties

        // A singleton instance of our data object collection for the specified type
        public ObservableCollection<T> Data { get; set; } = new ObservableCollection<T>();

        #endregion

        #region Public Methods
        /// <summary>
        /// Declares how to get the data
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<T> LoadData() { return Data; }


        /// <summary>
        /// Declares how to save the data
        /// </summary>
        /// <param name="data"></param>
        public void SaveData(ObservableCollection<T> data)
        {
            if (data != null)
                Data = data;

            return;
        }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            // Add our item to the collection
            Data.Add(item);
        }

        /// <summary>
        /// Deletes (removes) an item from a collection
        /// </summary>
        /// <param name="item"></param>
        public void Delete(T item)
        {
            // Delete an item from our collection
            Data.Remove(item);
        }

        /// <summary>
        /// Counts the number of entries in the collection
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return Data.Count;
        }


        // Generic display function for our IDataService object
        public string Display()
        {
            string str = string.Empty;

            for(int i=0; i<Data.Count; i++)
            {
                str += Data[i].ToString();
            }

            return str;
        }

        #endregion
    }
}
