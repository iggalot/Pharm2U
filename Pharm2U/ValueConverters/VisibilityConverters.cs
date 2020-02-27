using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Pharm2U.ValueConverters
{
    /// <summary>
    /// A Boolean to visibility value converter.  Takes a boolean and returns the visibility or collapsed.
    /// TRUE = Visile
    /// FALSE = Collapsed
    /// </summary>
    public class BoolToCollapsedVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolValue = (bool)value;

            if (boolValue)
                return Visibility.Visible;

            return Visibility.Collapsed;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// A Boolean to visibility value converter.  Takes a boolean and returns a collapsed or visible setting.
    /// TRUE = Collapsed
    /// FALSE = Visible
    /// </summary>
    public class InvertedBoolToCollapsedVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolValue = (bool)value;

            if (boolValue)
                return Visibility.Collapsed;

            return Visibility.Visible;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// A Boolean to visibility value converter.  Takes a boolean and returens a hidden or visible setting.
    /// TRUE = Visible
    /// FALSE = Hidden
    /// </summary>
    public class BoolToHiddenVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolValue = (bool)value;

            if (boolValue)
                return Visibility.Visible;

            return Visibility.Hidden;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// A Boolean to visibility value converter.  Takes a boolean and returens a hidden or visible setting.
    /// TRUE = Hidden
    /// FALSE = Visible
    /// </summary>
    public class InvertedBoolToHiddenVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolValue = (bool)value;

            if (boolValue)
                return Visibility.Hidden;

            return Visibility.Visible;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// A null object to visibility converter.  If the object is null, it hides the visibility.
    /// </summary>
    public class NullToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
                return Visibility.Visible;

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
