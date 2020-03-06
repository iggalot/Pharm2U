using Pharm2U.ViewModels;
using System.Windows.Controls;

namespace Pharm2U.Controls
{
    /// <summary>
    /// Interaction logic for PharmacyInfoControl.xaml
    /// </summary>
    public partial class PharmacyInfoControl : UserControl
    {
        public PharmacyInfoControl()
        {
            InitializeComponent();

  //          DataContext = IoC.IoCContainer.Get<ApplicationViewModel>().CurrentOrderListVM.OrdersVM.FullSelectedOrder;
        }
    }
}
