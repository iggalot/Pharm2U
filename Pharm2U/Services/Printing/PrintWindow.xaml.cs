using System.IO;
using System.Windows;
using System.Windows.Documents;
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

        public PrintWindow(IDocumentPaginatorSource source)
        {
            // Save our source for this print preview window
            _source = source;

            InitializeComponent();

            // Create an XPS Document of our control...
            if (File.Exists("printPreview.xps"))
            {
                File.Delete("printPreview.xps");
            }
            var xpsDocument = new XpsDocument("printPreview.xps", FileAccess.ReadWrite);
            XpsDocumentWriter writer = XpsDocument.CreateXpsDocumentWriter(xpsDocument);
            writer.Write(_source.DocumentPaginator);
            Document = xpsDocument.GetFixedDocumentSequence();
            xpsDocument.Close();
            
            // Update the preview field
            PreviewDocument.Document = Document;
        }
    }
}
