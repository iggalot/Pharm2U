using Pharm2U.Models.Data;
using System.Collections.ObjectModel;

namespace Pharm2U.ViewModels.EditorViewModels
{
    public class EditOrderFoodVM : BaseEditorViewModel<EditOrderFoodVM>
    {
        /// <summary>
        /// The pharmacy object linked to this viewmodel
        /// </summary>
        //public Pharmacy Pharmacy { get; set; }

        #region Constructors

        /// <summary>
        /// Generic parameterless constructor -- used by the base class generic implementation
        /// </summary>
        public EditOrderFoodVM()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pharmacy"></param>
        public EditOrderFoodVM(ObservableCollection<Food> list)
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
