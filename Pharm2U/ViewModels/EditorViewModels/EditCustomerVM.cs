using Pharm2U.Models.Data;

namespace Pharm2U.ViewModels.EditorViewModels
{
    public class EditCustomerVM : BaseEditorViewModel<EditCustomerVM>
    {
        /// <summary>
        /// The pharmacy object linked to this viewmodel
        /// </summary>
        //public Pharmacy Pharmacy { get; set; }

        #region Constructors

        /// <summary>
        /// Generic parameterless constructor -- used by the base class generic implementation
        /// </summary>
        public EditCustomerVM()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pharmacy"></param>
        public EditCustomerVM(Customer customer)
        {
            Instance = this;
            //Pharmacy = pharmacy;

        }

        public override void CancelEdits()
        {
            throw new System.NotImplementedException();
        }
        #endregion
        public override void SaveData()
        {
            throw new System.NotImplementedException();
        }
    }
}
