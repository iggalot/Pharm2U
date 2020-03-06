using Pharm2U.Utilities;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Pharm2U.ViewModels.EditorViewModels
{
    public abstract class BaseEditorViewModel<T> : ObservableObject
        where T : class, new()
    {
        #region Public Properties

        /// <summary>
        /// Indicate whether any data has changed in the view model
        /// </summary>
        public bool DataHasChanged { get; set; } = false;


        /// <summary>
        /// A singleton object for storing the viewmodel associated with this editor
        /// </summary>
        /// <returns></returns>
        public static T Instance { get; set; }

        /// <summary>
        /// The save data method for each of our editor view models.
        /// See invidual editor view models for implementation
        /// </summary>
        public abstract void SaveData();
        public abstract void CancelEdits();

        #endregion

        #region Commands
        /// <summary>
        /// The command that will save our edits.
        /// </summary>
        public ICommand SaveChangesCommand { get; set; }

        /// <summary>
        /// The command that will cancel any edits
        /// </summary>
        public ICommand CancelChangesCommand { get; set; }
        #endregion


        #region Constructor
        /// <summary>
        /// Our default constructor
        /// </summary>
        public BaseEditorViewModel()
        {
            // Set up our commands for hte buttons on the editor window
            SaveChangesCommand = new RelayCommand(SaveChanges);
            CancelChangesCommand = new RelayCommand(CancelChanges);
        }

        #endregion

        #region Private Methods

        private void CancelChanges(object obj)
        {
            this.CancelEdits();
            MessageBox.Show("Cancelling Edits");
        }

        private void SaveChanges(object obj)
        {
            this.SaveData();
        }

        #endregion


    }
}
