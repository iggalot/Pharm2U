using Pharm2U.Models.OrderDataViewModels;
using Pharm2U.Services.Printing;
using Pharm2U.ViewModels;
using Pharm2U.ViewModels.EditorViewModels;
using Pharm2U.Views.Editors;
using Pharm2U.Windows;
using System.Windows;
using System.Windows.Controls;

namespace Pharm2U.Views.Orders
{
    /// <summary>
    /// Interaction logic for OrdersView.xaml
    /// </summary>
    public partial class OrderDetailsView : UserControl
    {
        public OrderDetailsView()
        {
            InitializeComponent();
        }

        private void PrintPreview_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            PrintWindow pwin = new PrintWindow(fixeddoc);
            pwin.Show();

        }

        /// <summary>
        /// Engage the editor for a specific item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoEdit_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            if (sender == null)
                return;

            // check if we are already in editing mode
            if (IoC.IoCContainer.Get<ApplicationViewModel>().IsEditMode == true)
                return;

            Button btn = sender as Button;

            // Grab our data context for the button that was clicked.
            OrderDetailsViewModel context = btn.DataContext as OrderDetailsViewModel;

            EditWindowViewModel vm = new EditWindowViewModel(context, btn.Name);           
        }

    }
}
