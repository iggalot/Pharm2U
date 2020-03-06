using Pharm2U.Models.Data;
using Pharm2U.Services.Data;
using Pharm2U.Services.Data.EntityFramework;
using Pharm2U.ViewModels.InfoiViewModels;
using System.Windows;

namespace Pharm2U.ViewModels.EditorViewModels
{
    public class EditPharmacyVM : BaseEditorViewModel<EditPharmacyVM>
    {
        #region Private Members
        private string _mEditName;
        private string _mEditAddress;
        private string _mEditPhone;
        private string _mEditZip;
        private AddressDataViewModel _mAddressInfo;
        #endregion

        #region Public Members
        /// <summary>
        /// The pharmacy object linked to this viewmodel
        /// </summary>
        public Pharmacy EditPharmacy { get; set; }

        public string EditName
        {
            get => _mEditName;
            set
            {
                if (_mEditName == value)
                    return;

                _mEditName = value;

                DataHasChanged = true;
            }
        }
        public string EditAddress
        {
            get => _mEditAddress;
            set
            {
                if (_mEditAddress == value)
                    return;

                _mEditAddress = value;

                DataHasChanged = true;
            }
        }
        public string EditZip
        {
            get => _mEditZip;
            set
            {
                if (_mEditZip == value)
                    return;

                _mEditZip = value;

                //search for the new information for the zip
                EditAddressInfo = new AddressDataViewModel(EditAddress, EditZip);

                DataHasChanged = true;
            }
        }
        public string EditPhone
        {
            get => _mEditPhone;
            set
            {
                if (_mEditPhone== value)
                    return;

                _mEditPhone = value;

                DataHasChanged = true;
            }
        }

        public AddressDataViewModel EditAddressInfo
        {
            get => _mAddressInfo;
            set
            {
                if (_mAddressInfo == value)
                    return;

                _mAddressInfo = value;

                DataHasChanged = true;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Generic parameterless constructor -- used by the base class generic implementation
        /// </summary>
        public EditPharmacyVM()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pharmacy"></param>
        public EditPharmacyVM(Pharmacy pharmacy)
        {
            EditPharmacy = pharmacy;
            Instance = this;

            // Signal that the application is in edit mode
            IoC.IoCContainer.Get<ApplicationViewModel>().IsEditMode = true;

            // Load our temporary data
            EditName = pharmacy.Name;
            EditAddress = pharmacy.Address;
            EditPhone = pharmacy.Phone;
            EditZip = pharmacy.Zip;
            EditAddressInfo = pharmacy.AddressInfo;

            // Signal that no data has initially been changed
            DataHasChanged = false;

        }
        #endregion

        #region Public Methods
        // save our data back to the view model
        public override void SaveData() 
        {
            // If data hasn't changed, do nothing
            if (!DataHasChanged)
                return;
            
            MessageBox.Show("Saving Data");

            MessageBox.Show(EditName);

            EditPharmacy.Name = EditName;
            EditPharmacy.Address = EditAddress;
            EditPharmacy.Phone = EditPhone;
            EditPharmacy.Zip = EditZip;
            EditPharmacy.AddressInfo = EditAddressInfo;

            var context = IoC.IoCContainer.Get<ApplicationViewModel>().DataTables;

            foreach(P2U_Pharmacy item in context.PharmacyData.Data)
            {
                if(EditPharmacy.ItemID == item.ItemID)
                {
                    if(item.Name != EditName)
                    {
                        item.Name = EditName;
                        OnPropertyChanged(ref _mEditName, EditName);
                    }

                    if(item.Address != EditAddress)
                    {
                        item.Address = EditAddress;
                        OnPropertyChanged(ref _mEditAddress, EditAddress);
                    }

                    if (item.Phone != EditPhone)
                    {
                        item.Phone = EditPhone;
                        OnPropertyChanged(ref _mEditPhone, EditPhone);
                    }

                    if(item.Zip != EditZip)
                    {
                        item.Zip = EditZip;
                        EditPharmacy.AddressInfo = EditAddressInfo;
                        OnPropertyChanged(ref _mEditZip, EditZip);
                        OnPropertyChanged(ref _mAddressInfo, EditAddressInfo);
                    }
                    OnPropertyChanged("FullSelectedOrder");
                    OnPropertyChanged("CurrentOrderListVM");
                    OnPropertyChanged("OrdersVM");
                    OnPropertyChanged("CurrentOrderListVM.OrdersVM");
                    OnPropertyChanged("CurrentOrderListVM.OrdersVM.FullSelectedOrder");

                    break;
                }

                // Turn off editing mode in the application
                IoC.IoCContainer.Get<ApplicationViewModel>().IsEditMode = false;


            }

            // Reset the flag
            DataHasChanged = false;
        }

        /// <summary>
        /// Cancel the edits and reset the values.
        /// </summary>
        public override void CancelEdits()
        {
            // Reload our temporary data
            EditName = EditPharmacy.Name;
            EditAddress = EditPharmacy.Address;
            EditPhone = EditPharmacy.Phone;
            EditZip = EditPharmacy.Zip;
            EditAddressInfo = EditPharmacy.AddressInfo;

            // signify that the data has been reset
            DataHasChanged = false;

            // Turn off editing mode in the application
            IoC.IoCContainer.Get<ApplicationViewModel>().IsEditMode = false;
        }
        #endregion
    }
}
