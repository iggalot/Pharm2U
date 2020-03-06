using Pharm2U.Models.Data;
using System.Collections.ObjectModel;

namespace Pharm2U.ViewModels.EditorViewModels
{
    public class EditOrderOTCMedsVM : BaseEditorViewModel<EditOrderOTCMedsVM>
    {
        #region Constructors

        /// <summary>
        /// Generic parameterless constructor -- used by the base class generic implementation
        /// </summary>
        public EditOrderOTCMedsVM()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pharmacy"></param>
        public EditOrderOTCMedsVM(ObservableCollection<OTCMed> list)
        {
            Instance = this;
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
