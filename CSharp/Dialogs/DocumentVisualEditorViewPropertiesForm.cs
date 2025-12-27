using System.Windows.Forms;

using Vintasoft.Imaging.Office.DocumentEditor.UI;

namespace DocumentEditorDemo
{
    /// <summary>
    /// A form that allows to view and change the page view settings of document editor.
    /// </summary>
    public partial class DocumentVisualEditorViewPropertiesForm : Form
    {

        #region Fields

        /// <summary>
        /// The document visual editor.
        /// </summary>
        DocumentVisualEditor _visualEditor;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentVisualEditorViewPropertiesForm"/> class.
        /// </summary>
        public DocumentVisualEditorViewPropertiesForm()
        {
            InitializeComponent();

            viewModeComboBox.Items.Add(DocumentViewMode.Vertical);
            viewModeComboBox.Items.Add(DocumentViewMode.Horizontal);
        }

        #endregion



        #region Methods

        /// <summary>
        /// Shows this form with current settings of document visual editor.
        /// </summary>
        /// <param name="visualEditor">The document visual editor.</param>
        public static DialogResult ShowDialog(DocumentVisualEditor visualEditor)
        {
            using (DocumentVisualEditorViewPropertiesForm form = new DocumentVisualEditorViewPropertiesForm())
            {
                form.SetVisualEditor(visualEditor);
                return form.ShowDialog();
            }
        }


        /// <summary>
        /// Sets the settings of document visual editor to this form UI.
        /// </summary>
        /// <param name="visualEditor">The document visual editor.</param>
        private void SetVisualEditor(DocumentVisualEditor visualEditor)
        {
            _visualEditor = visualEditor;
            UpdateUI();
        }

        /// <summary>
        /// Updates the user interface.
        /// </summary>
        private void UpdateUI()
        {
            viewModeComboBox.SelectedItem = _visualEditor.ViewMode;
            pagesNumericUpDown.Value = _visualEditor.PagesInLine;
            pagePaddingNumericUpDown.Value = _visualEditor.PagePadding;
        }

        /// <summary>
        /// Sets the settings.
        /// </summary>
        private void SetSettings()
        {
            _visualEditor.ViewMode = (DocumentViewMode)viewModeComboBox.SelectedItem;
            _visualEditor.PagesInLine = (int)pagesNumericUpDown.Value;
            _visualEditor.PagePadding = (int)pagePaddingNumericUpDown.Value;
        }

        /// <summary>
        /// "Ok" button is clicked.
        /// </summary>
        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            SetSettings();
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// "Cancel" button is clicked.
        /// </summary>
        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion

    }
}
