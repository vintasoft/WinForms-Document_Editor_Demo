using System;
using System.IO;
using System.Windows.Forms;
using Vintasoft.Imaging;
using Vintasoft.Imaging.Print;

namespace DocumentEditorDemo
{
    /// <summary>
    /// Allows to print DOCX document.
    /// </summary>
    internal class PrintManager : IDisposable
    {

        #region Fields

        /// <summary>
        /// The image print document.
        /// </summary>
        ImagePrintDocument _imagePrintDocument;

        /// <summary>
        /// Print dialog.
        /// </summary>
        PrintDialog _printDialog;

        /// <summary>
        /// The number of the first page to print.
        /// </summary>
        int _fromPageIndex;
        /// <summary>
        /// The number of the last page to print.
        /// </summary>
        int _toPageIndex;

        /// <summary>
        /// A zero-based index of printing image.
        /// </summary>
        int _printingImageIndex;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PrintManager"/> class.
        /// </summary>
        /// <param name="fileStream">A stream that contains XLSX file.</param>
        /// <param name="imagePrintDocument">Image print document.</param>
        /// <param name="printDialog">Print dialog.</param>
        public PrintManager(Stream fileStream, ImagePrintDocument imagePrintDocument, PrintDialog printDialog)
        {
            if (fileStream == null)
                throw new ArgumentNullException("fileStream");
            if (imagePrintDocument == null)
                throw new ArgumentNullException("imagePrintDocument");
            if (printDialog == null)
                throw new ArgumentNullException("printDialog");

            // add stream to an image collection that should be printed
            _printingImages.Add(fileStream);
            _fromPageIndex = 1;
            _toPageIndex = _printingImages.Count;

            _imagePrintDocument = imagePrintDocument;
            _printDialog = printDialog;

            // specify that each image must be resized to fit within the page margins, image proportions are not changed
            _imagePrintDocument.PrintScaleMode = PrintScaleMode.BestFit;

            // subscribe to the BeginPrint and PrintImage events
            _imagePrintDocument.BeginPrint += ImagePrintDocument1_BeginPrint;
            _imagePrintDocument.PrintImage += ImagePrintDocument_PrintImage;
        }

        #endregion



        #region Properties

        ImageCollection _printingImages = new ImageCollection();
        /// <summary>
        /// An image collection to print.
        /// </summary>
        public ImageCollection PrintingImages
        {
            get { return _printingImages; }
        }

        #endregion



        #region Methods

        public void Print()
        {
            _printDialog.PrinterSettings.FromPage = _fromPageIndex;
            _printDialog.PrinterSettings.ToPage = _toPageIndex;

            // show dialog with printer settings
            if (_printDialog.ShowDialog() == DialogResult.OK)
            {
                switch (_printDialog.PrinterSettings.PrintRange)
                {
                    case System.Drawing.Printing.PrintRange.AllPages:
                        break;

                    case System.Drawing.Printing.PrintRange.SomePages:
                        _fromPageIndex = _printDialog.PrinterSettings.FromPage;
                        _toPageIndex = _printDialog.PrinterSettings.ToPage;
                        break;
                }

                // print the document
                _imagePrintDocument.Print();
            }
        }

        public void Dispose()
        {
            // unsubscribe from the BeginPrint and PrintImage events
            _imagePrintDocument.BeginPrint -= ImagePrintDocument1_BeginPrint;
            _imagePrintDocument.PrintImage -= ImagePrintDocument_PrintImage;

            // clear image collection with printed images
            _printingImages.ClearAndDisposeItems();
        }


        /// <summary>
        /// The printing is beginning.
        /// </summary>
        private void ImagePrintDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _printingImageIndex = _fromPageIndex - 1;
        }

        /// <summary>
        /// Printer needs new image to print.
        /// </summary>
        private void ImagePrintDocument_PrintImage(object sender, Vintasoft.Imaging.Print.PrintImageEventArgs e)
        {
            // specify new image to print
            e.Image = _printingImages[_printingImageIndex];

            // increase index of printing image
            _printingImageIndex++;

            // specify a value indicating whether there is more images to print
            e.HasMoreImages = _printingImageIndex < _toPageIndex;
        }

        #endregion

    }
}
