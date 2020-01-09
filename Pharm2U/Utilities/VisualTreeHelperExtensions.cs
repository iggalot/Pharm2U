using System.Windows;
using System.Windows.Media;

namespace Pharm2U.Utilities
{
    /// <summary>
    /// Climb up the visual tree to retrieve until we reach the first specified dependency object
    /// USAGE: var gbview = VisualTreeHelperExtensions.FindAncestor<GoldenButton.Views.GBView>(button);
    /// </summary>
    public static class VisualTreeHelperExtensions
    {
        public static T FindAncestor<T>(DependencyObject dependencyObject)
            where T : class
        {
            DependencyObject target = dependencyObject;

            while (target != null && !(target is T))
            {
                target = VisualTreeHelper.GetParent(target);
            }

            return target as T;
        }
    }
}
