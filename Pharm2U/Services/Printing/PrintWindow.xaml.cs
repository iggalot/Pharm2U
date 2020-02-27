using Pharm2U.Utilities;
using System;
using System.IO;
using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Xps;
using System.Windows.Xps.Packaging;

namespace Pharm2U.Services.Printing
{
    /// <summary>
    /// Interaction logic for PrintWindow.xaml
    /// </summary>
    public partial class PrintWindow : Window
    {
        //private FixedDocumentSequence _document;
        private IDocumentPaginatorSource _source;

        /// <summary>
        /// Our XPS document for this preview window.
        /// </summary>
        public FixedDocumentSequence Document { get; set; }

        public PrintWindowViewModel PrintWindowVM { get; set; }

        public PrintWindow(IDocumentPaginatorSource source)
        {
            // Save our source for this print preview window
            _source = source;

            InitializeComponent();

            PrintDialog dialog = new PrintDialog();
            PrintQueue pq = dialog.PrintQueue;

            bool? result = dialog.ShowDialog();
            if(result != true)
                return;

            // Create an XPS Document of our control...
            if (File.Exists("printPreview.xps"))
            {
                File.Delete("printPreview.xps");
            }
            var xpsDocument = new XpsDocument("printPreview.xps", FileAccess.ReadWrite);
            XpsDocumentWriter writer = XpsDocument.CreateXpsDocumentWriter(xpsDocument);

            // Write the XPS file
            writer.Write(_source.DocumentPaginator);

            Document = xpsDocument.GetFixedDocumentSequence();
            xpsDocument.Close();

            // Update the preview fields


            PrintWindowVM = new PrintWindowViewModel(_source);
            this.DataContext = PrintWindowVM;

            PreviewDocument.Document = Document;
        }


        void fixedPage_Loaded(object sender, RoutedEventArgs e)
        {
            var fixedDocument = sender as FixedPage;
           // CalculateSize(fixedDocument);
        }
        private void CalculateSize(FixedPage fixedPage)
        {
            PrintQueue printQueue = LocalPrintServer.GetDefaultPrintQueue();
            PrintCapabilities capabilities = printQueue.GetPrintCapabilities();

            //get scale of the print wrt to screen of WPF visual
            double scale = Math.Min(capabilities.PageImageableArea.ExtentWidth / fixedPage.ActualWidth, capabilities.PageImageableArea.ExtentHeight / fixedPage.ActualHeight);

            //Transform the Visual to scale
            fixedPage.LayoutTransform = new ScaleTransform(scale, scale);

            //get the size of the printer page
            var sz = new Size(capabilities.PageImageableArea.ExtentWidth, capabilities.PageImageableArea.ExtentHeight);

            //update the layout of the visual to the printer page size.
            fixedPage.Measure(sz);
            double x = capabilities.PageImageableArea.OriginWidth;
            double y = capabilities.PageImageableArea.OriginHeight;
            fixedPage.Arrange(new Rect(new Point(x, y), sz));
            fixedPage.UpdateLayout();
        }
    }
}
