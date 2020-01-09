using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Pharm2U.Utilities
{
    /// <summary>
    /// Base class for an on observable object definition using INotifiyPRopertyChanged
    /// </summary>
    public class ObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Registers a properry changed event
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Registers a property changed event
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="backingField">private membber that is being changed</param>
        /// <param name="value">the value of the new change</param>
        /// <param name="propertyName">the name to register the change.</param>
        /// <returns></returns>
        protected virtual bool OnPropertyChanged<T>(ref T backingField, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))
                return false;

            backingField = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }

}
