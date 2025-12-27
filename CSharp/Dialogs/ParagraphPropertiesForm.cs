using System;
using System.Windows.Forms;

using DemosCommonCode;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.DocumentEditor.UI;
using Vintasoft.Imaging.Office.Vmf;

namespace DocumentEditorDemo
{
    /// <summary>
    /// A form that allows to view and change the paragraph properties.
    /// </summary>
    public partial class ParagraphPropertiesForm : Form
    {

        #region Constants

        /// <summary>
        /// The value units.
        /// </summary>
        const UnitOfMeasure VALUE_UNITS = UnitOfMeasure.Points;

        #endregion



        #region Fields

        /// <summary>
        /// The document visual editor.
        /// </summary>
        DocumentVisualEditor _visualEditor;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ParagraphPropertiesForm"/> class.
        /// </summary>
        public ParagraphPropertiesForm()
        {
            InitializeComponent();

            foreach (VmfHorizontalAlignmentType alignmentType in Enum.GetValues(typeof(VmfHorizontalAlignmentType)))
                alignmentComboBox.Items.Add(alignmentType);

            foreach (VmfParagraphLineSpacingRule spacingRule in Enum.GetValues(typeof(VmfParagraphLineSpacingRule)))
                lineSpacingTypeComboBox.Items.Add(spacingRule);
        }

        #endregion



        #region Methods

        #region PUBLIC, STATIC

        /// <summary>
        /// Shows this form with current settings of the document visual editor.
        /// </summary>
        /// <param name="visualEditor">The document visual editor.</param>
        public static DialogResult ShowDialog(DocumentVisualEditor visualEditor)
        {
            using (ParagraphPropertiesForm form = new ParagraphPropertiesForm())
            {
                form.SetVisualEditor(visualEditor);
                return form.ShowDialog();
            }
        }

        #endregion


        #region PRIVATE

        /// <summary>
        /// Handles the Click event of buttonOk object.
        /// </summary>
        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            if (SetSettings())
                DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the CheckedChanged event of spacingBeforeAutoCheckBox object.
        /// </summary>
        private void spacingBeforeAutoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Handles the CheckedChanged event of spacingAfterAutoCheckBox object.
        /// </summary>
        private void spacingAfterAutoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of lineSpacingTypeComboBox object.
        /// </summary>
        private void lineSpacingTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((VmfParagraphLineSpacingRule)lineSpacingTypeComboBox.SelectedItem == VmfParagraphLineSpacingRule.Scale)
                lineSpacingTextBox.Text = _visualEditor.UnitsConverter.NumberToString(1);
            else
                lineSpacingTextBox.Text = _visualEditor.UnitsConverter.DipNumberToString(16, VALUE_UNITS);
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of specialIndentationComboBox object.
        /// </summary>
        private void specialIndentationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSpecialIndentationTextBox();

            UpdateUI();
        }

        /// <summary>
        /// Handles the Format event of numberingComboBox object.
        /// </summary>
        private void numberingComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is DocumentParagraphNumbering)
            {
                DocumentParagraphNumbering numbering = (DocumentParagraphNumbering)e.ListItem;

                e.Value = numbering.GetLevelsNumberingDescription(3, "  ");
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of numberingComboBox object.
        /// </summary>
        private void numberingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] descriptions = new string[0];
            string[] fonts = new string[0];

            DocumentParagraphNumbering numbering = numberingComboBox.SelectedItem as DocumentParagraphNumbering;
            if (numbering != null)
            {
                descriptions = numbering.GetLevelNumberingDescription();
                fonts = numbering.GetLevelFonts();
            }

            SetNumberingDescription(numberingLevel0label, descriptions, fonts, 0);
            SetNumberingDescription(numberingLevel1label, descriptions, fonts, 1);
            SetNumberingDescription(numberingLevel2label, descriptions, fonts, 2);
            SetNumberingDescription(numberingLevel3label, descriptions, fonts, 3);
            SetNumberingDescription(numberingLevel4label, descriptions, fonts, 4);
            SetNumberingDescription(numberingLevel5label, descriptions, fonts, 5);
            SetNumberingDescription(numberingLevel6label, descriptions, fonts, 6);
            SetNumberingDescription(numberingLevel7label, descriptions, fonts, 7);
            SetNumberingDescription(numberingLevel8label, descriptions, fonts, 8);
        }

        /// <summary>
        /// Updates the user interface.
        /// </summary>
        private void UpdateUI()
        {
            spacingBeforeTextBox.Enabled = !spacingBeforeAutoCheckBox.Checked;
            spacingAfterTextBox.Enabled = !spacingAfterAutoCheckBox.Checked;
            specialIndentationTextBox.Enabled = specialIndentationComboBox.SelectedIndex > 0;
        }

        /// <summary>
        /// Sets the settings of document visual editor to this form UI.
        /// </summary>
        /// <param name="visualEditor">Spreadsheet visual editor.</param>
        private void SetVisualEditor(DocumentVisualEditor visualEditor)
        {
            _visualEditor = visualEditor;
            DocumentUnitsConverter unitsConverter = visualEditor.UnitsConverter;
            DocumentParagraphProperties paragraphProperties = visualEditor.ParagraphProperties;
            DocumentParagraphSpacingProperties paragraphSpacing = paragraphProperties.Spacing;

            alignmentComboBox.SelectedItem = paragraphProperties.HorizontalAlignment.Value;

            indentationLeftTextBox.Text = unitsConverter.DipNumberToString(paragraphProperties.Indentation.Left.Value, null);
            indentationRightTextBox.Text = unitsConverter.DipNumberToString(paragraphProperties.Indentation.Right.Value, null);

            if (paragraphProperties.Indentation.FirstLine > 0)
                specialIndentationComboBox.SelectedIndex = 1;
            else if (paragraphProperties.Indentation.Hanging > 0)
                specialIndentationComboBox.SelectedIndex = 2;
            else
                specialIndentationComboBox.SelectedIndex = 0;
            UpdateSpecialIndentationTextBox();

            spacingBeforeAutoCheckBox.Checked = paragraphSpacing.BeforeAutoSpacing.Value;
            spacingBeforeTextBox.Text = unitsConverter.DipNumberToString(paragraphSpacing.Before.Value, VALUE_UNITS);
            spacingAfterAutoCheckBox.Checked = paragraphSpacing.AfterAutoSpacing.Value;
            spacingAfterTextBox.Text = unitsConverter.DipNumberToString(paragraphSpacing.After.Value, VALUE_UNITS);
            lineSpacingTypeComboBox.SelectedItem = paragraphSpacing.LineRule.Value;
            if (paragraphSpacing.LineRule == VmfParagraphLineSpacingRule.Scale)
                lineSpacingTextBox.Text = unitsConverter.NumberToString(paragraphSpacing.Line.Value);
            else
                lineSpacingTextBox.Text = unitsConverter.DipNumberToString(paragraphSpacing.Line.Value, VALUE_UNITS);

            contextualSpacingCheckBox.Checked = paragraphProperties.ContextualSpacing.Value;

            windowControlCheckBox.Checked = paragraphProperties.WidowControl.Value;
            keepNextCheckBox.Checked = paragraphProperties.KeepNext.Value;
            keepLinesCheckBox.Checked = paragraphProperties.KeepLines.Value;
            pageBreakBeforeCheckBox.Checked = paragraphProperties.PageBreakBefore.Value;

            numberingComboBox.BeginUpdate();
            numberingComboBox.Items.Clear();
            numberingComboBox.Items.Add("(unnumbered)");
            foreach (DocumentParagraphNumbering numbering in visualEditor.GetNumberings())
            {
                numberingComboBox.Items.Add(numbering);
            }

            numberingComboBox.SelectedIndex = 0;
            if (paragraphProperties.Numbering != null)
            {
                for (int i = 1; i < numberingComboBox.Items.Count; i++)
                {
                    DocumentParagraphNumbering numbering = (DocumentParagraphNumbering)numberingComboBox.Items[i];

                    if (numbering.Id == paragraphProperties.Numbering.Id)
                    {
                        numberingComboBox.SelectedIndex = i;
                        break;
                    }
                }
            }
            numberingComboBox.EndUpdate();

            UpdateUI();
        }

        /// <summary>
        /// Updates the special indentation text box.
        /// </summary>
        private void UpdateSpecialIndentationTextBox()
        {
            double? value = null;

            switch (specialIndentationComboBox.SelectedIndex)
            {
                case 1:
                    if (_visualEditor.ParagraphProperties.Indentation != null &&
                        _visualEditor.ParagraphProperties.Indentation.FirstLine != null)
                    {
                        value = _visualEditor.ParagraphProperties.Indentation.FirstLine;
                    }
                    else
                    {
                        value = 0;
                    }
                    break;

                case 2:
                    if (_visualEditor.ParagraphProperties.Indentation != null &&
                        _visualEditor.ParagraphProperties.Indentation.Hanging != null)
                    {
                        value = _visualEditor.ParagraphProperties.Indentation.Hanging;
                    }
                    else
                    {
                        value = 0;
                    }
                    break;

                default:
                    value = null;
                    break;
            }

            if (value == null)
            {
                specialIndentationTextBox.Text = string.Empty;
            }
            else
            {
                specialIndentationTextBox.Text = _visualEditor.UnitsConverter.DipNumberToString(
                   value.Value, VALUE_UNITS);
            }
        }

        /// <summary>
        /// Sets the settings to the document visual editor.
        /// </summary>
        private bool SetSettings()
        {
            try
            {
                DocumentUnitsConverter unitsConverter = _visualEditor.UnitsConverter;
                DocumentParagraphProperties paragraphProperties = new DocumentParagraphProperties();

                paragraphProperties.HorizontalAlignment = (VmfHorizontalAlignmentType)alignmentComboBox.SelectedItem;

                DocumentParagraphIndentationProperties indentation = new DocumentParagraphIndentationProperties();

                double indentationLeft;
                if (TryConvertNumberToDip(indentationLeftTextBox, out indentationLeft))
                    indentation.Left = indentationLeft;
                else
                    return false;

                double indentationRight;
                if (TryConvertNumberToDip(indentationRightTextBox, out indentationRight))
                    indentation.Right = indentationRight;
                else
                    return false;

                double value;
                if (specialIndentationComboBox.SelectedIndex == 1)
                {
                    if (TryConvertNumberToDip(specialIndentationTextBox, out value))
                        indentation.FirstLine = value;
                    else
                        return false;
                }
                else if (specialIndentationComboBox.SelectedIndex == 2)
                {
                    if (TryConvertNumberToDip(specialIndentationTextBox, out value))
                        indentation.Hanging = value;
                    else
                        return false;
                }
                paragraphProperties.Indentation = indentation;

                DocumentParagraphSpacingProperties paragraphSpacing = new DocumentParagraphSpacingProperties();

                paragraphSpacing.BeforeAutoSpacing = spacingBeforeAutoCheckBox.Checked;
                double spacingBefore;
                if (TryConvertNumberToDip(spacingBeforeTextBox, out spacingBefore))
                    paragraphSpacing.Before = spacingBefore;
                else
                    return false;

                paragraphSpacing.AfterAutoSpacing = spacingAfterAutoCheckBox.Checked;
                double spacingAfter;
                if (TryConvertNumberToDip(spacingAfterTextBox, out spacingAfter))
                    paragraphSpacing.After = spacingAfter;
                else
                    return false;

                paragraphSpacing.LineRule = (VmfParagraphLineSpacingRule)lineSpacingTypeComboBox.SelectedItem;
                double scale;
                if (paragraphSpacing.LineRule == VmfParagraphLineSpacingRule.Scale)
                {
                    if (TryConvertPositiveNumber(lineSpacingTextBox, out scale))
                        paragraphSpacing.Line = scale;
                    else
                        return false;
                }
                else
                {
                    double height;
                    if (TryConvertNumberToDip(lineSpacingTextBox, out height))
                        paragraphSpacing.Line = height;
                    else
                        return false;
                }
                paragraphProperties.Spacing = paragraphSpacing;

                paragraphProperties.ContextualSpacing = contextualSpacingCheckBox.Checked;

                paragraphProperties.WidowControl = windowControlCheckBox.Checked;
                paragraphProperties.KeepNext = keepNextCheckBox.Checked;
                paragraphProperties.KeepLines = keepLinesCheckBox.Checked;
                paragraphProperties.PageBreakBefore = pageBreakBeforeCheckBox.Checked;
                if (numberingComboBox.SelectedIndex > 0)
                {
                    DocumentParagraphNumbering numbering = (DocumentParagraphNumbering)numberingComboBox.SelectedItem;

                    paragraphProperties.Numbering = _visualEditor.CreateParagraphNumberingProperties(numbering);
                }
                else
                {
                    paragraphProperties.Numbering = _visualEditor.CreateParagraphNumberingProperties(null);
                }

                _visualEditor.ParagraphProperties = paragraphProperties;
                return true;
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
                return false;
            }
        }

        /// <summary>
        /// Tries to convert number to the Device Independed Pixels (DIP).
        /// </summary>
        /// <param name="textBox">The text box that contains text to convert.</param>
        /// <param name="value">The converted value.</param>
        /// <returns><b>true</b> if text was converted successfully; otherwise, <b>false</b>.</returns>
        private bool TryConvertNumberToDip(TextBox textBox, out double value)
        {
            if (_visualEditor.UnitsConverter.TryConvertPosisiveNumberToDip(textBox.Text, out value))
            {
                return true;
            }
            else
            {
                DemosTools.ShowErrorMessage("Invalid value.");
                textBox.Focus();
                textBox.SelectAll();
                return false;
            }
        }

        /// <summary>
        /// Tries to convert string to a number.
        /// </summary>
        /// <param name="textBox">The text box that contains text to convert.</param>
        /// <param name="value">The converted value.</param>
        /// <returns><b>true</b> if text was converted successfully; otherwise, <b>false</b>.</returns>
        private bool TryConvertPositiveNumber(TextBox textBox, out double value)
        {
            if (_visualEditor.UnitsConverter.TryConvertNumber(textBox.Text, false, out value))
            {
                return true;
            }
            else
            {
                DemosTools.ShowErrorMessage("Invalid value.");
                textBox.SelectAll();
                return false;
            }
        }

        /// <summary>
        /// Sets the numbering description.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="descriptions">The descriptions.</param>
        /// <param name="fonts">The fonts.</param>
        /// <param name="index">The index.</param>
        private string SetNumberingDescription(Label label, string[] descriptions, string[] fonts, int index)
        {
            if (descriptions.Length > index)
                label.Text = descriptions[index];
            else
                label.Text = string.Empty;

            if (fonts.Length > index && !string.IsNullOrEmpty(fonts[index]))
                label.Font = new System.Drawing.Font(fonts[index], DefaultFont.SizeInPoints);
            else
                label.Font = DefaultFont;

            return string.Empty;
        }

        #endregion

        #endregion

    }
}
