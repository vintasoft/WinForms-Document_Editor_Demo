using DemosCommonCode;
using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;

using System;
using System.IO;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.Decoders;
using Vintasoft.Imaging.Office.DocumentEditor.UI;
using Vintasoft.Imaging.Office.OpenXml;
using Vintasoft.Imaging.Office.UI;
using Vintasoft.Imaging.Office.Vmf.UI;

namespace DocumentEditorDemo
{
    /// <summary>
    /// Main form of Document Editor Demo.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Fields

        /// <summary>
        /// The document converter.
        /// </summary>
        DocumentConverter _documentConverter;

        /// <summary>
        /// The document layout settings manager.
        /// </summary>
        ImageCollectionDocxLayoutSettingsManager _layoutSettingsManager;

        /// <summary>
        /// A value indicating whether the layout settings are initialized.
        /// </summary>
        bool _isLayoutSettingsInitialized = true;

        /// <summary>
        /// Help panel.
        /// </summary>
        HelpPanel _helpPanel;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // set CustomFontProgramsController for all opened documents
            CustomFontProgramsController.SetDefaultFontProgramsController();

            InitializeComponent();

            Text = "VintaSoft Document Editor Demo v" + ImagingGlobalSettings.ProductVersion;

            // set current user name
            DocumentVisualEditor.CurrentUserName = Environment.UserName;

            _documentConverter = new DocumentConverter();
            _layoutSettingsManager = new ImageCollectionDocxLayoutSettingsManager(_documentConverter.Images);
            _layoutSettingsManager.LayoutSettings = new DocxDocumentLayoutSettings();

            // set file filter for file dialog
            CodecsFileFilters.SetSaveFileDialogFilter(exportFileDialog, false, false);
            exportFileDialog.Filter += "|HTML files|*.html";

            string[] filters = exportFileDialog.Filter.Split('|');
            // for each file filter
            for (int i = 1; i < filters.Length; i++)
            {
                // if filter represents PDF encoder
                if (filters[i].ToUpperInvariant().Contains("PDF"))
                    // specify that PDF format must be used as the default export format
                    exportFileDialog.FilterIndex = i / 2 + 1;
            }

            // set folder with test files as initial folder for the file dialog
            DemosTools.SetTestFilesFolder(openDocumentFileDialog);

            // subscribe to the DocumentVisualEditor events
            VisualEditor.NeedLayoutChanged += VisualEditor_NeedLayoutChanged;
            VisualEditor.DocumentChanged += VisualEditor_DocumentChanged;
            VisualEditor.UriOpen += VisualEditor_UriOpen;
            VisualEditor.FocusedHyperlinkChanged += VisualEditor_FocusedHyperlinkChanged;
            VisualEditor.InitializationStarted += VisualEditor_Initialization;
            VisualEditor.InitializationFinished += VisualEditor_Initialization;
            VisualEditor.SynchronizationException += VisualEditor_SynchronizationException;

            // set default page print settings
            imagePrintDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);

            // add custom panels to the MainMenuPanel
            AddCustomPanels();
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets the document visual editor.
        /// </summary>
        internal DocumentVisualEditor VisualEditor
        {
            get
            {
                return documentEditor1.VisualEditor;
            }
        }

        #endregion



        #region Methods

        #region Document Visual Editor

        /// <summary>
        /// Handles the UriOpen event of the VisualEditor.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DocumentUriEventArgs"/> instance containing the event data.</param>
        private void VisualEditor_UriOpen(object sender, DocumentUriEventArgs e)
        {
            try
            {
                Uri uri = new Uri(e.Uri);
                DemosTools.OpenBrowser(uri.AbsoluteUri);
            }
            catch
            {
                DemosTools.ShowWarningMessage("The URI is not valid: " + e.Uri);
            }
        }

        /// <summary>
        /// Handles the SynchronizationException event of the VisualEditor.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ExceptionEventArgs"/> instance containing the event data.</param>
        private void VisualEditor_SynchronizationException(object sender, ExceptionEventArgs e)
        {
            DemosTools.ShowErrorMessage(e.Exception);
        }

        /// <summary>
        /// Handles the Initialization event of the VisualEditor.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void VisualEditor_Initialization(object sender, EventArgs e)
        {
            UpdateVisualEditorStatus();
        }

        /// <summary>
        /// Handles the NeedLayoutChanged event of the VisualEditor.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void VisualEditor_NeedLayoutChanged(object sender, EventArgs e)
        {
            UpdateVisualEditorStatus();
        }

        /// <summary>
        /// Handles the FocusedHyperlinkChanged event of the VisualEditor.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Vintasoft.Imaging.PropertyChangedEventArgs{VmfContentHyperlinkInfo}"/> instance containing the event data.</param>
        private void VisualEditor_FocusedHyperlinkChanged(object sender, Vintasoft.Imaging.PropertyChangedEventArgs<VmfContentHyperlinkInfo> e)
        {
            UpdateVisualEditorStatus();
        }

        /// <summary>
        /// Handles the DocumentChanged event of the VisualEditor.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void VisualEditor_DocumentChanged(object sender, EventArgs e)
        {
            UpdateFileInfoUI();
        }

        /// <summary>
        /// Updates the user interface with file information.
        /// </summary>
        private void UpdateFileInfoUI()
        {
            string fileName = documentEditor1.MainMenuPanel.FilePanel.Filename;
            Text = "VintaSoft Document Editor Demo v" + ImagingGlobalSettings.ProductVersion;
            if (fileName != null)
                Text = Text + " - " + fileName;
            if (VisualEditor.IsDocumentChanged)
                Text = Text + "*";
        }

        /// <summary>
        /// Updates the status of document visual editor.
        /// </summary>
        private void UpdateVisualEditorStatus()
        {
            if (VisualEditor.EditorSource == null)
                viewerStatusLabel.Text = "";
            else if (VisualEditor.IsInitializing)
                viewerStatusLabel.Text = "Initializing...";
            else if (VisualEditor.FocusedHyperlink != null)
                viewerStatusLabel.Text = "Link: " + VisualEditor.FocusedHyperlink.Uri;
            else if (VisualEditor.NeedLayout)
                viewerStatusLabel.Text = "Processing...";
            else
                viewerStatusLabel.Text = "Ready";
        }

        #endregion


        #region Document Editor Control

        /// <summary>
        /// Handles the ExportFile event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_ExportFile(object sender, EventArgs e)
        {
            exportFileDialog.FileName = Path.GetFileNameWithoutExtension(documentEditor1.MainMenuPanel.FilePanel.Filename);
            if (exportFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string extension = Path.GetExtension(exportFileDialog.FileName);

                    if (!InitLayoutSettings())
                        return;

                    // create a temporary stream
                    using (MemoryStream tempStream = new MemoryStream())
                    {
                        // save DOCX file to a temporary stream
                        VisualEditor.SaveDocumentTo(tempStream);

                        // if document must be exported to the HTML format
                        if (Path.GetExtension(exportFileDialog.FileName).ToUpperInvariant().StartsWith(".HTM"))
                        {
                            // convert document to the HTML format
                            using (Stream outputStream = File.Create(exportFileDialog.FileName))
                            {
                                HtmlConverterSettings htmlSettings = new HtmlConverterSettings();
                                htmlSettings.EmbedResources = true;
                                OpenXmlDocumentConverter.ConvertDocxToHtml(tempStream, outputStream, htmlSettings);
                            }
                        }
                        else
                        {
                            // add DOCX file to the image collection of document converter
                            _documentConverter.Images.Add(tempStream);

                            // create dialog that displays progress for document conversion process
                            using (ActionProgressForm dlg = new ActionProgressForm(ExportDocument, 1, "Export document"))
                            {
                                // specify that dialog should be closed when conversion is finished
                                dlg.CloseAfterComplete = true;
                                // show dialog and run conversion process
                                dlg.RunAndShowDialog(this.FindForm());
                            }

                            // clear image collection of document converter
                            _documentConverter.Images.ClearAndDisposeItems();
                        }
                    }

                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
            }
        }

        /// <summary>
        /// Handles the VisualEditorError event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Vintasoft.Imaging.ExceptionEventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_VisualEditorError(object sender, Vintasoft.Imaging.ExceptionEventArgs e)
        {
            DemosTools.ShowErrorMessage(e.Exception);
        }

        /// <summary>
        /// Handles the SaveChangesRequest event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ActionRequestEventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_SaveChangesRequest(object sender, ActionRequestEventArgs e)
        {
            DialogResult result = MessageBox.Show("Current document is changed. Do you want to save changes?", "New Document", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            switch (result)
            {
                case DialogResult.Yes:
                    e.AllowAction = true;
                    break;

                case DialogResult.No:
                    break;

                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        /// <summary>
        /// Handles the SaveAsRequest event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FilenameEventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_SaveAsRequest(object sender, FilenameEventArgs e)
        {
            saveDocumentFileDialog.FileName = documentEditor1.MainMenuPanel.FilePanel.Filename;
            if (saveDocumentFileDialog.ShowDialog() == DialogResult.OK)
            {
                e.Filename = saveDocumentFileDialog.FileName;
                e.AllowAction = true;
            }
            else
            {
                e.Filename = null;
                e.AllowAction = false;
            }
        }

        /// <summary>
        /// Handles the OpenFileRequest event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Vintasoft.Imaging.Office.UI.FilenameEventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_OpenFileRequest(object sender, Vintasoft.Imaging.Office.UI.FilenameEventArgs e)
        {
            e.Filename = null;
            e.AllowAction = false;

            // show dialog for opening the DOCX file
            if (openDocumentFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get file path from open dialog
                string filename = openDocumentFileDialog.FileName;

                e.Filename = filename;
                e.AllowAction = true;
            }
        }

        /// <summary>
        /// Handles the FilenameChanged event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_FilenameChanged(object sender, EventArgs e)
        {
            UpdateFileInfoUI();
        }

        /// <summary>
        /// Handles the ShowVisualEditorOptions event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_ShowVisualEditorOptions(object sender, EventArgs e)
        {
            DocumentVisualEditorSettingsForm.ShowDialog(VisualEditor);
        }

        /// <summary>
        /// Handles the ShowBookmarkDialog event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_ShowBookmarkDialog(object sender, EventArgs e)
        {
            BookmarksForm.ShowDialog(VisualEditor);
        }

        /// <summary>
        /// Handles the ColorRequest event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ColorEventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_ColorRequest(object sender, ColorEventArgs e)
        {
            colorDialog1.Color = e.Color;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                e.Color = colorDialog1.Color;
                e.AllowAction = true;
            }
        }

        /// <summary>
        /// Handles the TextPropertiesRequest event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_TextPropertiesRequest(object sender, EventArgs e)
        {
            TextPropertiesForm.ShowDialog(VisualEditor);
        }

        /// <summary>
        /// Handles the ParagraphPropertiesRequest event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_ParagraphPropertiesRequest(object sender, EventArgs e)
        {
            ParagraphPropertiesForm.ShowDialog(VisualEditor);
        }

        /// <summary>
        /// Handles the ViewPropertiesRequest event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_ViewPropertiesRequest(object sender, EventArgs e)
        {
            DocumentVisualEditorViewPropertiesForm.ShowDialog(VisualEditor);
        }

        /// <summary>
        /// Handles the ShowDocumentInfo event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_ShowDocumentInfo(object sender, EventArgs e)
        {
            DocumentInfoForm.ShowDialog(VisualEditor);
        }

        /// <summary>
        /// Handles the ShowPageSettingsOptions event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_ShowPageSettingsOptions(object sender, EventArgs e)
        {
            PageSettingsForm.ShowDialog(VisualEditor);
        }

        /// <summary>
        /// Handles the ShowColumnsSettingsOptions event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_ShowColumnsSettingsOptions(object sender, EventArgs e)
        {
            PageColumnsSettingsForm.ShowDialog(VisualEditor);
        }

        /// <summary>
        /// Handles the ShowPrintLayoutSettings event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_ShowPrintLayoutSettings(object sender, EventArgs e)
        {
            if (_layoutSettingsManager.EditLayoutSettingsUseDialog())
                _isLayoutSettingsInitialized = true;
        }

        /// <summary>
        /// Handles the ShowPrintPageSettings event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_ShowPrintPageSettings(object sender, EventArgs e)
        {
            // show dialog with page setup settings
            pageSetupDialog1.ShowDialog();
        }

        /// <summary>
        /// Handles the ShowPrintPreview event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_ShowPrintPreview(object sender, EventArgs e)
        {
            try
            {
                if (!InitLayoutSettings())
                    return;

                // create a temporary stream
                using (MemoryStream tempStream = new MemoryStream())
                {
                    // save DOCX file to a temporary stream
                    VisualEditor.SaveDocumentTo(tempStream);

                    // create a dialog that allows to preview and print DOCX document
                    using (PrintPreviewForm dlg = new PrintPreviewForm(tempStream, imagePrintDocument1, printDialog1, pageSetupDialog1))
                    {
                        // show the dialog
                        dlg.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the PrintDocument event of the DocumentEditor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DocumentEditor_PrintDocument(object sender, EventArgs e)
        {
            PrintDocument();
        }

        /// <summary>
        /// Prints the  document.
        /// </summary>
        private bool PrintDocument()
        {
            if (VisualEditor.EditorSource == null)
                return false;
            try
            {
                if (!InitLayoutSettings())
                    return true;

                // create a temporary stream
                using (MemoryStream tempStream = new MemoryStream())
                {
                    // save DOCX file to a temporary stream
                    VisualEditor.SaveDocumentTo(tempStream);

                    // create print manager
                    using (PrintManager printManager = new PrintManager(tempStream, imagePrintDocument1, printDialog1))
                    {
                        // print DOCX document
                        printManager.Print();
                    }
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            return true;
        }

        #endregion


        #region Common

        /// <summary>
        /// Adds custom panels to the <see cref="MainMenuPanel"/>.
        /// </summary>
        private void AddCustomPanels()
        {
            // add "Help" tab to the MainMenuPanel
            documentEditor1.MainMenuPanel.AddTab("Help", "Help");

            // create "Help" panel
            _helpPanel = new HelpPanel();
            _helpPanel.Margin = new Padding(1, 2, 2, 1);
            _helpPanel.Dock = DockStyle.Fill;
            // add "Help" panel to the "Help" tab of MainMenuPanel
            documentEditor1.MainMenuPanel.AddTabItem("Help", _helpPanel);
        }

        /// <summary>
        /// Exports the document.
        /// </summary>
        /// <param name="progressController">Progress controller.</param>
        private void ExportDocument(Vintasoft.Imaging.Utils.IActionProgressController progressController)
        {
            // set progress controller for document converter
            _documentConverter.ProgressController = progressController;

            // convert document to the selected format            
            _documentConverter.Convert(exportFileDialog.FileName);
        }


        /// <summary>
        /// Initializes the layout settings of DOCX document.
        /// </summary>
        private bool InitLayoutSettings()
        {
            // if layout settings are not initialized
            if (!_isLayoutSettingsInitialized)
            {
                // set layout settings
                if (_layoutSettingsManager.EditLayoutSettingsUseDialog())
                    _isLayoutSettingsInitialized = true;
                else
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Handles the KeyDown event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                // Ctrl+O
                if (e.Control && e.KeyCode == Keys.O)
                {
                    documentEditor1.MainMenuPanel.FilePanel.OpenDocument();
                    e.Handled = true;
                }

                // Ctrl+N
                if (e.Control && e.KeyCode == Keys.N)
                {
                    documentEditor1.MainMenuPanel.FilePanel.NewDocument();
                    e.Handled = true;
                }

                // Ctrl+S
                if (e.Control && e.KeyCode == Keys.S)
                {
                    documentEditor1.MainMenuPanel.FilePanel.SaveDocumentChanges();
                    e.Handled = true;
                }

                // Ctrl+Shift+S
                if (e.Control && e.Shift && e.KeyCode == Keys.S)
                {
                    if (documentEditor1.MainMenuPanel.FilePanel.SaveDocumentAs())
                        e.Handled = true;
                }

                // Ctrl+P
                if (e.Control && e.KeyCode == Keys.P)
                {
                    if (PrintDocument())
                        e.Handled = true;
                }

                // F1
                if (e.KeyCode == Keys.F1)
                {
                    _helpPanel.ShowAboutDialog();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the Shown event of MainForm object.
        /// </summary>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            string[] appArgs = Environment.GetCommandLineArgs();

            if (appArgs.Length == 2)
            {
                Application.DoEvents();

                try
                {
                    documentEditor1.MainMenuPanel.FilePanel.OpenDocument(appArgs[1]);
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
            }
        }

        #endregion

        #endregion

    }
}
