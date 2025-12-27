using System;
using System.Collections.Generic;
using System.Windows.Forms;

using DemosCommonCode;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Fonts;
using Vintasoft.Imaging.Office.DocumentEditor.UI;
using Vintasoft.Imaging.Office.Vmf;
using Vintasoft.Primitives;

namespace DocumentEditorDemo
{
    /// <summary>
    /// A form that allows to view and change the text properties.
    /// </summary>
    public partial class TextPropertiesForm : Form
    {

        #region Fields

        /// <summary>
        /// The document visual editor.
        /// </summary>
        DocumentVisualEditor _visualEditor;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TextPropertiesForm"/> class.
        /// </summary>
        public TextPropertiesForm()
        {
            InitializeComponent();

            foreach (string fontName in GetAvailableFontNames())
                fontNameComboBox.Items.Add(fontName);

            foreach (VmfRunUnderlineType underlineType in Enum.GetValues(typeof(VmfRunUnderlineType)))
                underlineComboBox.Items.Add(underlineType);

            foreach (VmfStrikethroughType strikethroughType in Enum.GetValues(typeof(VmfStrikethroughType)))
                strikeoutTypeComboBox.Items.Add(strikethroughType);

            foreach (VmfTextVerticalPosition verticalPosition in Enum.GetValues(typeof(VmfTextVerticalPosition)))
                verticalPositionComboBox.Items.Add(verticalPosition);
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
            using (TextPropertiesForm form = new TextPropertiesForm())
            {
                form.SetVisualEditor(visualEditor);
                return form.ShowDialog();
            }
        }

        /// <summary>
        /// Returns an array with avaliable font names.
        /// </summary>
        public static string[] GetAvailableFontNames()
        {
            List<string> result = new List<string>();
            try
            {
                FileFontProgramsController fontProgramsController =
                    (FileFontProgramsController)Vintasoft.Imaging.Drawing.DrawingFactory.Default.FontProgramsController;
                Dictionary<string, string> systemFonts = fontProgramsController.GetSystemInstalledFonts();
                foreach (string fontName in systemFonts.Keys)
                {
                    if (fontName.ToUpperInvariant().Contains(" BOLD") || fontName.ToUpperInvariant().Contains(" ITALIC"))
                        continue;
                    result.Add(fontName);
                }
            }
            catch
            {
            }
            return result.ToArray();
        }

        #endregion


        #region PRIVATE

        /// <summary>
        /// Handles the CheckedChanged event of smallCapsCheckBox object.
        /// </summary>
        private void smallCapsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (smallCapsCheckBox.Checked)
                allCapsCheckBox.Checked = false;
        }

        /// <summary>
        /// Handles the CheckedChanged event of allCapsCheckBox object.
        /// </summary>
        private void allCapsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allCapsCheckBox.Checked)
                smallCapsCheckBox.Checked = false;
        }

        /// <summary>
        /// Handles the Click event of buttonOk object.
        /// </summary>
        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            if (SetSettings())
                DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Sets the settings of document visual editor to this form UI.
        /// </summary>
        /// <param name="visualEditor">The document visual editor.</param>
        private void SetVisualEditor(DocumentVisualEditor visualEditor)
        {
            _visualEditor = visualEditor;

            DocumentUnitsConverter unitsConverter = visualEditor.UnitsConverter;
            const UnitOfMeasure UNITS = UnitOfMeasure.Points;

            fontNameComboBox.Text = visualEditor.FontName;

            if (visualEditor.IsFontBold && visualEditor.IsFontItalic)
                fontStyleComboBox.SelectedIndex = 3;
            else if (visualEditor.IsFontBold)
                fontStyleComboBox.SelectedIndex = 2;
            else if (visualEditor.IsFontItalic)
                fontStyleComboBox.SelectedIndex = 1;
            else
                fontStyleComboBox.SelectedIndex = 0;

            fontSizeComboBox.Text = unitsConverter.NumberToString(visualEditor.TextProperties.FontSize.Value);

            fontColorPanelControl.Color = System.Drawing.Color.FromArgb(visualEditor.TextColor.ToArgb());

            if (visualEditor.Underline == null)
                underlineComboBox.SelectedItem = VmfRunUnderlineType.None;
            else
                underlineComboBox.SelectedItem = visualEditor.Underline.Type;

            strikeoutTypeComboBox.SelectedItem = visualEditor.TextStrikeout;

            verticalPositionComboBox.SelectedItem = visualEditor.TextProperties.VerticalPosition.Value;

            smallCapsCheckBox.Checked = visualEditor.TextProperties.IsSmallCaps.Value;

            allCapsCheckBox.Checked = visualEditor.TextProperties.DisplayAllCharactersAsCapitalLetters.Value;

            scaleNumericUpDown.Value = Math.Max(
                scaleNumericUpDown.Minimum, Math.Min(scaleNumericUpDown.Maximum,
                (decimal)(visualEditor.TextProperties.CharacterScale.Value) * 100));

            spacingTextBox.Text = unitsConverter.DipNumberToString(visualEditor.TextProperties.Spacing.Value, UNITS);

            positionTextBox.Text = unitsConverter.DipNumberToString(visualEditor.TextProperties.Position.Value, UNITS);
        }

        /// <summary>
        /// Sets the settings to the document visual editor.
        /// </summary>
        private bool SetSettings()
        {
            DocumentUnitsConverter unitsConverter = _visualEditor.UnitsConverter;
            DocumentTextProperties textProperties = _visualEditor.TextProperties.Clone();

            textProperties.FontName = fontNameComboBox.Text;

            switch (fontStyleComboBox.SelectedIndex)
            {
                case 1:
                    textProperties.IsBold = false;
                    textProperties.IsItalic = true;
                    break;

                case 2:
                    textProperties.IsBold = true;
                    textProperties.IsItalic = false;
                    break;

                case 3:
                    textProperties.IsBold = true;
                    textProperties.IsItalic = true;
                    break;

                default:
                    textProperties.IsBold = false;
                    textProperties.IsItalic = false;
                    break;
            }

            double fontSize;
            if (unitsConverter.TryConvertNumber(fontSizeComboBox.Text, false, out fontSize))
            {
                textProperties.FontSize = fontSize;
            }
            else
            {
                DemosTools.ShowErrorMessage("Invalid font size.");
                fontSizeComboBox.SelectAll();
                return false;
            }

            textProperties.TextColor = VintasoftColor.FromArgb(fontColorPanelControl.Color.ToArgb());

            if ((VmfRunUnderlineType)underlineComboBox.SelectedItem == VmfRunUnderlineType.None)
                textProperties.Underline = null;
            else
                textProperties.Underline = new DocumentTextUnderlineProperties((VmfRunUnderlineType)underlineComboBox.SelectedItem);

            textProperties.StrikeoutType = (VmfStrikethroughType)strikeoutTypeComboBox.SelectedItem;

            textProperties.VerticalPosition = (VmfTextVerticalPosition)verticalPositionComboBox.SelectedItem;

            textProperties.IsSmallCaps = smallCapsCheckBox.Checked;

            textProperties.DisplayAllCharactersAsCapitalLetters = allCapsCheckBox.Checked;

            textProperties.CharacterScale = (double)scaleNumericUpDown.Value / 100;

            double spacing;
            if (unitsConverter.TryConvertNumberToDip(spacingTextBox.Text, true, out spacing))
            {
                textProperties.Spacing = spacing;
            }
            else
            {
                DemosTools.ShowErrorMessage("Invalid spacing value.");
                spacingTextBox.SelectAll();
                return false;
            }

            double position;
            if (unitsConverter.TryConvertNumberToDip(positionTextBox.Text, true, out position))
            {
                textProperties.Position = position;
            }
            else
            {
                DemosTools.ShowErrorMessage("Invalid position value.");
                positionTextBox.SelectAll();
                return false;
            }

            _visualEditor.TextProperties = textProperties;
            return true;
        }

        #endregion

        #endregion

    }
}
