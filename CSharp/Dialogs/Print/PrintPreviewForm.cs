using System;
using System.IO;
using System.Windows.Forms;

using Vintasoft.Imaging.Print;

namespace DocumentEditorDemo
{
    /// <summary>
    /// A form that allows to preview and print DOCX document.
    /// </summary>
    public partial class PrintPreviewForm : Form
    {

        #region Fields

        /// <summary>
        /// Print manager.
        /// </summary>
        PrintManager _printManager;

        /// <summary>
        /// Page setup dialog.
        /// </summary>
        PageSetupDialog _pageSetupDialog;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PrintPreviewForm"/> class.
        /// </summary>
        /// <param name="fileStream">A stream that contains DOCX file.</param>
        /// <param name="imagePrintDocument">The image print document.</param>
        /// <param name="printDialog">Print dialog.</param>
        /// <param name="pageSetupDialog">Page setup dialog.</param>
        public PrintPreviewForm(Stream fileStream, ImagePrintDocument imagePrintDocument, PrintDialog printDialog, PageSetupDialog pageSetupDialog)
        {
            if (fileStream == null)
                throw new ArgumentNullException("fileStream");
            if (imagePrintDocument == null)
                throw new ArgumentNullException("imagePrintDocument");
            if (printDialog == null)
                throw new ArgumentNullException("printDialog");
            if (pageSetupDialog == null)
                throw new ArgumentNullException("pageSetupDialog");

            InitializeComponent();

            _printManager = new PrintManager(fileStream, imagePrintDocument, printDialog);
            _pageSetupDialog = pageSetupDialog;

            printPreviewControl1.Document = imagePrintDocument;

            // initialize the page selector
            previewPageIndexNumericUpDown.Minimum = 1;
            previewPageIndexNumericUpDown.Maximum = _printManager.PrintingImages.Count;
            previewPageCountLabel.Text = string.Format("from {0} pages", _printManager.PrintingImages.Count);

            // set 100% zoom in preview
            previewZoomComboBox.SelectedIndex = 3;
        }

        #endregion



        #region Methods

        /// <summary>
        /// "Print" button is clicked.
        /// </summary>
        private void printButton_Click(object sender, EventArgs e)
        {
            _printManager.Print();
        }

        /// <summary>
        /// "Page settings" button is clicked.
        /// </summary>
        private void pageSettingsButton_Click(object sender, EventArgs e)
        {
            // show dialog with page setup setings
            if (_pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                // invalidate the print preview control
                printPreviewControl1.InvalidatePreview();
            }
        }

        /// <summary>
        /// Preview page is changed.
        /// </summary>
        private void previewPageIndexNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            printPreviewControl1.StartPage = (int)previewPageIndexNumericUpDown.Value - 1;
        }

        /// <summary>
        /// Preview zoom is changed.
        /// </summary>
        private void previewZoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (previewZoomComboBox.SelectedIndex)
            {
                case 0:
                    printPreviewControl1.Zoom = 0.2;
                    break;
                case 1:
                    printPreviewControl1.Zoom = 0.5;
                    break;
                case 2:
                    printPreviewControl1.Zoom = 0.75;
                    break;
                case 3:
                    printPreviewControl1.Zoom = 1;
                    break;
                case 4:
                    printPreviewControl1.Zoom = 1.25;
                    break;
                case 5:
                    printPreviewControl1.Zoom = 1.5;
                    break;
                case 6:
                    printPreviewControl1.Zoom = 2;
                    break;
                case 7:
                    printPreviewControl1.Zoom = 3;
                    break;
                case 8:
                    printPreviewControl1.Zoom = 4;
                    break;
            }
        }

        #endregion

    }
}
