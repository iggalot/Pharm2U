using Pharm2U.Models.OrderDataViewModels;
using Pharm2U.Windows;
using System.Windows;

namespace Pharm2U.ViewModels.EditorViewModels
{
    public class EditWindowViewModel
    {
        /// <summary>
        /// Singleton OrderDetailsViewModel object for this view model
        /// </summary>
        public static OrderDetailsViewModel Instance { get; set; }

        #region Constructor
        public EditWindowViewModel(object obj, string name)
        {
            /// Retrieve our data object
            Instance = obj as OrderDetailsViewModel;
                
            // Create our editor window
            EditorWindow win = new EditorWindow();

            // And load the datacontext based on the info that has been clicked from the Detail View
            switch (name)
            {
                case ("EditCustomer"):
                    win.DataContext = new EditCustomerVM(Instance.Customer);
                    break;
                case ("EditPharmacy"):
                    win.DataContext = new EditPharmacyVM(Instance.Pharmacy);
                    break;
                case ("EditOrderFoods"):
                    win.DataContext = new EditOrderFoodVM(Instance.FoodList);
                    break;
                case ("EditOrderOTCMeds"):
                    win.DataContext = new EditOrderOTCMedsVM(Instance.OTCMedsList);
                    break;
                case ("EditAdditionalInfo"):
                    win.DataContext = new EditAdditionalInfoVM();
                    break;
                default:
                    MessageBox.Show("No relevant view model found");
                    break;
            }

            win.Show();

            #endregion
        }
    }
}
