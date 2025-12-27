using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.DocumentEditor.UI;

namespace DocumentEditorDemo
{
    /// <summary>
    /// A form that allows to view and change the settings of the document visual editor.
    /// </summary>
    public partial class DocumentVisualEditorSettingsForm : Form
    {

        #region Fields

        /// <summary>
        /// The document visual editor.
        /// </summary>
        DocumentVisualEditor _visualEditor;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentVisualEditorSettingsForm"/> class.
        /// </summary>
        public DocumentVisualEditorSettingsForm()
        {
            InitializeComponent();

            defaultUnitsComboBox.Items.Add(UnitOfMeasure.Centimeters);
            defaultUnitsComboBox.Items.Add(UnitOfMeasure.Millimeters);
            defaultUnitsComboBox.Items.Add(UnitOfMeasure.Inches);
        }

        #endregion



        #region Methods

        /// <summary>
        /// Shows this form with current settings of document visual editor.
        /// </summary>
        /// <param name="visualEditor">The document visual editor.</param>
        public static DialogResult ShowDialog(DocumentVisualEditor visualEditor)
        {
            using (DocumentVisualEditorSettingsForm form = new DocumentVisualEditorSettingsForm())
            {
                form.SetVisualEditor(visualEditor);
                return form.ShowDialog();
            }
        }


        /// <summary>
        /// Sets the visual editor settings to this form UI.
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
            asyncModeCheckBox.Checked = _visualEditor.AsyncEdit;
            textSelectionColorPanelControl.Color = VintasoftDrawingConverter.Convert(_visualEditor.ContentSelectionColor);
            backgroundColorPanelControl.Color = VintasoftDrawingConverter.Convert(_visualEditor.BackColor);
            showInvisibleTableBordersCheckBox.Checked = _visualEditor.ShowInvisibleTableBorders;
            defaultUnitsComboBox.SelectedItem = _visualEditor.UnitsConverter.DefaultUnits;
        }

        /// <summary>
        /// Sets the settings.
        /// </summary>
        private void SetSettings()
        {
            _visualEditor.AsyncEdit = asyncModeCheckBox.Checked;
            _visualEditor.ContentSelectionColor = VintasoftDrawingConverter.Convert(textSelectionColorPanelControl.Color);
            _visualEditor.BackColor = VintasoftDrawingConverter.Convert(backgroundColorPanelControl.Color);
            _visualEditor.ShowInvisibleTableBorders = showInvisibleTableBordersCheckBox.Checked;
            _visualEditor.UnitsConverter.DefaultUnits = (UnitOfMeasure)defaultUnitsComboBox.SelectedItem;
        }

        /// <summary>
        /// Handles the Click event of buttonOk object.
        /// </summary>
        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            SetSettings();
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of buttonCancel object.
        /// </summary>
        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion

    }
}
