using System;
using System.Windows.Forms;

using DemosCommonCode;

using Vintasoft.Imaging.Office.DocumentEditor.UI;

namespace DocumentEditorDemo
{
    /// <summary>
    /// A form that allows to view and change the properties of page columns.
    /// </summary>
    public partial class PageColumnsSettingsForm : Form
    {

        #region Fields

        /// <summary>
        /// The visual editor.
        /// </summary>
        DocumentVisualEditor _visualEditor;

        /// <summary>
        /// The section columns.
        /// </summary>
        DocumentSectionColumnsProperties _sectionColumns;

        /// <summary>
        /// The section properties.
        /// </summary>
        DocumentSectionProperties _sectionProperties;

        /// <summary>
        /// UI is updating now.
        /// </summary>
        bool _isUiUpdating = false;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PageColumnsSettingsForm"/> class.
        /// </summary>
        public PageColumnsSettingsForm()
        {
            InitializeComponent();
        }

        #endregion



        #region Methods

        #region PUBLIC

        /// <summary>
        /// Shows this form with current document visual editor settings.
        /// </summary>
        /// <param name="visualEditor">The document visual editor.</param>
        public static DialogResult ShowDialog(DocumentVisualEditor visualEditor)
        {
            using (PageColumnsSettingsForm form = new PageColumnsSettingsForm())
            {
                form.SetVisualEditor(visualEditor);
                return form.ShowDialog();
            }
        }

        #endregion


        #region PRIVATE 

        /// <summary>
        /// Sets the document visual editor settings to this form UI.
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
            _isUiUpdating = true;

            DocumentSectionProperties sectionProperties = _visualEditor.SectionProperties;
            _sectionProperties = sectionProperties;

            DocumentSectionColumnsProperties sectionColumns = sectionProperties.Columns;
            if (sectionColumns == null)
                _sectionColumns = new DocumentSectionColumnsProperties();
            else
                _sectionColumns = sectionColumns.Clone();

            columnCountNumericUpDown.Value = _sectionColumns.ColumnCount;
            columnNumberNumericUpDown.Maximum = _sectionColumns.ColumnCount;
            equalColumnWidthCheckBox.Checked = _sectionColumns.IsEqualWidth;
            lineBetweenCheckBox.Checked = _sectionColumns.Separator;

            _isUiUpdating = false;

            UpdateCurrentColumnProperties();
        }

        /// <summary>
        /// Updates the current column properties.
        /// </summary>
        private void UpdateCurrentColumnProperties()
        {
            int columnNumber = (int)columnNumberNumericUpDown.Value;
            if (columnNumber > 0)
            {
                _isUiUpdating = true;

                double width;
                double space;
                _sectionColumns.GetColumnProperties(_sectionProperties, columnNumber, out width, out space);

                columnWidthTextBox.Text = _visualEditor.UnitsConverter.DipNumberToString(width, null);
                columnSpaceTextBox.Text = _visualEditor.UnitsConverter.DipNumberToString(space, null);
                _isUiUpdating = false;
            }
        }

        /// <summary>
        /// Sets the settings to to the document visual editor.
        /// </summary>
        private bool SetSettings()
        {
            DocumentSectionProperties sectionProperties = _visualEditor.SectionProperties.Clone();

            sectionProperties.Columns = _sectionColumns;

            try
            {
                _visualEditor.SectionProperties = sectionProperties;
            }
            catch (Exception ex)
            {
                DemosTools.ShowWarningMessage(ex.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Handles the ValueChanged event of columnCountNumericUpDown object.
        /// </summary>
        private void columnCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            columnNumberNumericUpDown.Maximum = columnCountNumericUpDown.Value;
            _sectionColumns.ColumnCount = (int)columnCountNumericUpDown.Value;
            UpdateCurrentColumnProperties();
        }

        /// <summary>
        /// Handles the CheckedChanged event of equalColumnWidthCheckBox object.
        /// </summary>
        private void equalColumnWidthCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (equalColumnWidthCheckBox.Checked)
            {
                columnNumberNumericUpDown.Enabled = false;
                columnNumberNumericUpDown.Value = 1;
            }
            else
            {
                columnNumberNumericUpDown.Enabled = true;
            }
            _sectionColumns.IsEqualWidth = equalColumnWidthCheckBox.Checked;
        }

        /// <summary>
        /// Handles the CheckedChanged event of lineBetweenCheckBox object.
        /// </summary>
        private void lineBetweenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _sectionColumns.Separator = lineBetweenCheckBox.Checked;
        }

        /// <summary>
        /// Handles the ValueChanged event of columnNumberNumericUpDown object.
        /// </summary>
        private void columnNumberNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateCurrentColumnProperties();
        }

        /// <summary>
        /// Handles the TextChanged event of columnWidthTextBox object.
        /// </summary>
        private void columnWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUiUpdating)
                return;

            double width;
            if (_visualEditor.UnitsConverter.TryConvertPosisiveNumberToDip(columnWidthTextBox.Text, out width))
                _sectionColumns.SetColumnWidth((int)columnNumberNumericUpDown.Value, width);
        }

        /// <summary>
        /// Handles the TextChanged event of columnSpaceTextBox object.
        /// </summary>
        private void columnSpaceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUiUpdating)
                return;

            double space;
            if (_visualEditor.UnitsConverter.TryConvertPosisiveNumberToDip(columnSpaceTextBox.Text, out space))
                _sectionColumns.SetColumnSpace((int)columnNumberNumericUpDown.Value, space);
        }

        /// <summary>
        /// Handles the Click event of buttonOk object.
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (SetSettings())
                DialogResult = DialogResult.OK;
        }

        #endregion

        #endregion

    }
}
