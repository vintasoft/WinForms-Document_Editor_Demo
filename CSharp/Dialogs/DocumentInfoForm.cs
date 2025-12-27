using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Office.DocumentEditor.UI;

namespace DocumentEditorDemo
{
    /// <summary>
    /// A form that allows to view and change the document information.
    /// </summary>
    public partial class DocumentInfoForm : Form
    {

        #region Fields

        /// <summary>
        /// The document visual editor.
        /// </summary>
        DocumentVisualEditor _visualEditor;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentInfoForm"/> class.
        /// </summary>
        public DocumentInfoForm()
        {
            InitializeComponent();
        }

        #endregion



        #region Methods

        /// <summary>
        /// Shows this form with current document information.
        /// </summary>
        /// <param name="visualEditor">The document visual editor.</param>
        public static DialogResult ShowDialog(DocumentVisualEditor visualEditor)
        {
            using (DocumentInfoForm form = new DocumentInfoForm())
            {
                form.SetVisualEditor(visualEditor);
                return form.ShowDialog();
            }
        }


        /// <summary>
        /// Sets the document information properties to this form UI.
        /// </summary>
        /// <param name="visualEditor">The document visual editor.</param>
        private void SetVisualEditor(DocumentVisualEditor visualEditor)
        {
            _visualEditor = visualEditor;
            UpdateUI();
        }

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            DocumentInformationProperties info = _visualEditor.DocumentInformation;

            titleTextBox.Text = info.Title;
            subjectTextBox.Text = info.Subject;
            creatorTextBox.Text = info.Creator;
            categoryTextBox.Text = info.Category;
            keywordsTextBox.Text = info.Keywords;
            descriptionTextBox.Text = info.Description;
            createdTextBox.Text = info.CreatedDate.ToString();
            modifiedTextBox.Text = info.ModifiedDate.ToString();
            lastModifiedByTextBox.Text = info.LastModifiedBy;
            printedTextBox.Text = info.PrintedDate.ToString();
        }

        /// <summary>
        /// Handles the Click event of buttonOk object.
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            DocumentInformationProperties info = _visualEditor.DocumentInformation.Clone();

            info.Title = titleTextBox.Text;
            info.Subject = subjectTextBox.Text;
            info.Creator = creatorTextBox.Text;
            info.Description = descriptionTextBox.Text;
            info.Category = categoryTextBox.Text;
            info.Keywords = keywordsTextBox.Text;

            // if information is changed
            if (!Equals(info, _visualEditor.DocumentInformation))
                // set information to the document visual editor
                _visualEditor.DocumentInformation = info;

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of buttonCancel object.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion

    }
}
