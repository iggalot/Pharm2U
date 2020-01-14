using Pharm2U.ViewModels;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Pharm2U.ValueConverters
{
    public class ApplicationToDataModelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ApplicationViewModel viewmodel = IoC.IoCContainer.Get<ApplicationViewModel>();

            return viewmodel;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
