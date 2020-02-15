using Pharm2U.Services.Printing;
using System.Windows.Controls;

namespace Pharm2U.Views.Orders
{
    /// <summary>
    /// Interaction logic for OrdersView.xaml
    /// </summary>
    public partial class OrderDetailsView : UserControl
    {
        public OrderDetailsView()
        {
            InitializeComponent();
        }

        private void PrintPreview_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            PrintWindow pwin = new PrintWindow(fixeddoc);
            pwin.Show();

        }

    //    private void Print_Click(object sender, System.Windows.RoutedEventArgs e)
    //    {

    //        //var str = XamlWriter.Save(fixeddoc);
    //        //var stringReader = new StringReader(str);
    //        //var xmlReader = XmlReader.Create(stringReader);
    //       // var CloneDoc = XamlReader.Load(xmlReader) as FlowDocument;

    //        PrintDialog dialog = new PrintDialog();
    //        if (dialog.ShowDialog().Value)
    //        {
    //            //CloneDoc.PageHeight = dialog.PrintableAreaHeight;
    //            //CloneDoc.PageWidth = dialog.PrintableAreaWidth;
    //            IDocumentPaginatorSource idocument = fixeddoc;
    ////            IDocumentPaginatorSource idocument = CloneDoc as IDocumentPaginatorSource;
    //            MessageBox.Show(idocument.DocumentPaginator.PageCount.ToString());
 
    //            dialog.PrintDocument(idocument.DocumentPaginator, "Printing FlowDocument");


    //        }
    //        return;

    //        //DoThePrint(flowdoc);

    //        //// Set up our paginator
    //        //DocumentPaginator paginator = ((IDocumentPaginatorSource)flowdoc).DocumentPaginator;
    //        //dialog.PrintDocument(paginator, "Printed manifest");

    //    }

    //    private void DoThePrint(System.Windows.Documents.FlowDocument document)
    //    {
    //        // Clone the source document's content into a new FlowDocument.
    //        // This is because the pagination for the printer needs to be
    //        // done differently than the pagination for the displayed page.
    //        // We print the copy, rather that the original FlowDocument.
    //        System.IO.MemoryStream s = new System.IO.MemoryStream();
    //        TextRange source = new TextRange(document.ContentStart, document.ContentEnd);
    //        source.Save(s, DataFormats.Xaml);
    //        FlowDocument copy = new FlowDocument();
    //        TextRange dest = new TextRange(copy.ContentStart, copy.ContentEnd);
    //        dest.Load(s, DataFormats.Xaml);

    //        // Create a XpsDocumentWriter object, implicitly opening a Windows common print dialog,
    //        // and allowing the user to select a printer.

    //        // get information about the dimensions of the seleted printer+media.
    //        PrintDocumentImageableArea ia = null;
    //        System.Windows.Xps.XpsDocumentWriter docWriter = PrintQueue.CreateXpsDocumentWriter(ref ia);

    //        if (docWriter != null && ia != null)
    //        {
    //            DocumentPaginator paginator = ((IDocumentPaginatorSource)copy).DocumentPaginator;

    //            // Change the PageSize and PagePadding for the document to match the CanvasSize for the printer device.
    //            paginator.PageSize = new Size(ia.MediaSizeWidth, ia.MediaSizeHeight);
    //            Thickness t = new Thickness(72);  // copy.PagePadding;
    //            copy.PagePadding = new Thickness(
    //                             Math.Max(ia.OriginWidth, t.Left),
    //                               Math.Max(ia.OriginHeight, t.Top),
    //                               Math.Max(ia.MediaSizeWidth - (ia.OriginWidth + ia.ExtentWidth), t.Right),
    //                               Math.Max(ia.MediaSizeHeight - (ia.OriginHeight + ia.ExtentHeight), t.Bottom));

    //            copy.ColumnWidth = double.PositiveInfinity;
    //            //copy.PageWidth = 528; // allow the page to be the natural with of the output device

    //            // Send content to the printer.
    //            docWriter.Write(paginator);
    //        }

    //    }


    }
}
