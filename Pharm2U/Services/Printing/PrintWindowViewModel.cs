using Pharm2U.Utilities;
using System.Windows.Documents;

namespace Pharm2U.Services.Printing
{
    public class PrintWindowViewModel : ObservableObject
    {
        private double _gridHeight;
        private double _gridWidth;

        private double _pageHeight;
        private double _pageWidth;

        public double GridHeightDim
        {
            get => _gridHeight;
            set
            {
                _gridHeight = value;
                OnPropertyChanged(ref _gridHeight, value);
            }
        }
        public double GridWidthDim
        {
            get => _gridWidth;
            set
            {
                _gridWidth = value;
                OnPropertyChanged(ref _gridWidth, value);
            }
        }

        public double PageHeightDim
        {
            get => _pageHeight;
            set
            {
                _pageHeight = value;
                OnPropertyChanged(ref _pageHeight, value);
            }
        }
        public double PageWidthDim
        {
            get => _pageWidth;
            set
            {
                _pageWidth = value;
                OnPropertyChanged(ref _pageWidth, value);
            }
        }

        public double MarginThick { get; set; } = 20.0f;

        public PrintWindowViewModel(IDocumentPaginatorSource _source)
        {
            PageWidthDim = _source.DocumentPaginator.PageSize.Width;
            PageHeightDim = _source.DocumentPaginator.PageSize.Height;

            GridWidthDim = PageWidthDim - 2 * MarginThick;
            GridHeightDim = PageHeightDim - 2 * MarginThick;
        }
    }
}
