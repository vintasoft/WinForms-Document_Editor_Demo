using System;
using System.Linq;
using System.Windows.Forms;

using DemosCommonCode;

using Vintasoft.Imaging.Office.DocumentEditor.UI;
using Vintasoft.Imaging.Office.Vmf;
using Vintasoft.Primitives;

namespace DocumentEditorDemo
{
    /// <summary>
    /// A form that allows to view and change the page (section) properties.
    /// </summary>
    public partial class PageSettingsForm : Form
    {

        #region Fields

        /// <summary>
        /// The document visual editor.
        /// </summary>
        DocumentVisualEditor _visualEditor;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PageSettingsForm"/> class.
        /// </summary>
        public PageSettingsForm()
        {
            InitializeComponent();

            sectionBreakComboBox.Items.Add("");
            sectionBreakComboBox.Items.Add(VmfSectionBreakType.NextPage);
            sectionBreakComboBox.Items.Add(VmfSectionBreakType.NextColumn);
            sectionBreakComboBox.Items.Add(VmfSectionBreakType.Continuous);
            sectionBreakComboBox.Items.Add(VmfSectionBreakType.EvenPage);
            sectionBreakComboBox.Items.Add(VmfSectionBreakType.OddPage);

            pageOrientationComboBox.Items.Add("");
            pageOrientationComboBox.Items.Add("Portrait");
            pageOrientationComboBox.Items.Add("Landscape");
        }

        #endregion



        #region Methods

        /// <summary>
        /// Shows this form with current settings of the document visual editor.
        /// </summary>
        /// <param name="visualEditor">The document visual editor.</param>
        public static DialogResult ShowDialog(DocumentVisualEditor visualEditor)
        {
            using (PageSettingsForm form = new PageSettingsForm())
            {
                form.SetVisualEditor(visualEditor);
                return form.ShowDialog();
            }
        }


        /// <summary>
        /// Sets the document visual editor settings to this form UI.
        /// </summary>
        /// <param name="visualEditor">The document visual editor.</param>
        private void SetVisualEditor(DocumentVisualEditor visualEditor)
        {
            _visualEditor = visualEditor;

            pageSizeComboBox.Items.Clear();
            pageSizeComboBox.Items.Add("");
            pageSizeComboBox.Items.AddRange(_visualEditor.UnitsConverter.PredefinedPageSizes.Keys.ToArray());

            UpdateUI();
        }

        /// <summary>
        /// Updates the user interface.
        /// </summary>
        private void UpdateUI()
        {
            DocumentSectionProperties sectionProperties = _visualEditor.SectionProperties;

            if (sectionProperties.BreakType != null)
                sectionBreakComboBox.SelectedItem = sectionProperties.BreakType.Value;

            if (sectionProperties.PageSize != null)
            {
                VintasoftSize pageSize = sectionProperties.PageSize.Value;
                if (!sectionProperties.IsPortraitOrientation.Value)
                {
                    double width = pageSize.Width;
                    pageSize.Width = pageSize.Height;
                    pageSize.Height = width;
                }
                pageSizeComboBox.Text = _visualEditor.UnitsConverter.DipSizeToString(pageSize, true, null);
            }

            if (sectionProperties.IsPortraitOrientation.HasValue)
            {
                if (sectionProperties.IsPortraitOrientation.Value)
                    pageOrientationComboBox.SelectedIndex = 1;
                else
                    pageOrientationComboBox.SelectedIndex = 2;
            }

            DocumentPageMarginProperties pageMargin = sectionProperties.PageMargin ?? new DocumentPageMarginProperties();
            pageMarginLeftTextBox.Text = _visualEditor.UnitsConverter.DipNumberToString(pageMargin.Left, null);
            pageMarginRightTextBox.Text = _visualEditor.UnitsConverter.DipNumberToString(pageMargin.Right, null);
            pageMarginTopTextBox.Text = _visualEditor.UnitsConverter.DipNumberToString(pageMargin.Top, null);
            pageMarginBottomTextBox.Text = _visualEditor.UnitsConverter.DipNumberToString(pageMargin.Bottom, null);
            pageMarginHeaderTextBox.Text = _visualEditor.UnitsConverter.DipNumberToString(pageMargin.Header, null);
            pageMarginFooterTextBox.Text = _visualEditor.UnitsConverter.DipNumberToString(pageMargin.Footer, null);
            pageMarginGutterTextBox.Text = _visualEditor.UnitsConverter.DipNumberToString(pageMargin.Gutter, null);
         
            useDifferentHeadlineForFirstPageCheckBox.Checked = _visualEditor.UseDifferentHeadlineForFirstPage;
            useDifferentHeadlineForOddAndEvenPagesCheckBox.Checked = _visualEditor.UseDifferentHeadlineForOddAndEvenPages;
        }

        /// <summary>
        /// Sets the settings to the document visual editor.
        /// </summary>
        private bool SetSettings()
        {
            DocumentSectionProperties sectionProperties = _visualEditor.SectionProperties.Clone();
            if (sectionBreakComboBox.SelectedIndex > 0)
            {
                sectionProperties.BreakType = (VmfSectionBreakType)sectionBreakComboBox.SelectedItem;
            }

            if (!string.IsNullOrEmpty(pageSizeComboBox.Text))
            {
                VintasoftSize pageSize;
                if (_visualEditor.UnitsConverter.TryConvertSizeToDip(pageSizeComboBox.Text, true, out pageSize))
                {
                    sectionProperties.PageSize = pageSize;
                }
            }

            if (pageOrientationComboBox.SelectedIndex > 0)
            {
                sectionProperties.IsPortraitOrientation = pageOrientationComboBox.SelectedIndex == 1;
            }

            DocumentPageMarginProperties pageMargin = sectionProperties.PageMargin.Clone();
            
            double pageMarginLeft;
            if (_visualEditor.UnitsConverter.TryConvertPosisiveNumberToDip(pageMarginLeftTextBox.Text, out pageMarginLeft))
                pageMargin.Left = pageMarginLeft;
            
            double pageMarginRight;
            if (_visualEditor.UnitsConverter.TryConvertPosisiveNumberToDip(pageMarginRightTextBox.Text, out pageMarginRight))
                pageMargin.Right = pageMarginRight;
            
            double pageMarginTop;
            if (_visualEditor.UnitsConverter.TryConvertPosisiveNumberToDip(pageMarginTopTextBox.Text, out pageMarginTop))
                pageMargin.Top = pageMarginTop;

            double pageMarginBottom;
            if (_visualEditor.UnitsConverter.TryConvertPosisiveNumberToDip(pageMarginBottomTextBox.Text, out pageMarginBottom))
                pageMargin.Bottom = pageMarginBottom;

            double pageMarginHeader;
            if (_visualEditor.UnitsConverter.TryConvertPosisiveNumberToDip(pageMarginHeaderTextBox.Text, out pageMarginHeader))
                pageMargin.Header = pageMarginHeader;

            double pageMarginFooter;
            if (_visualEditor.UnitsConverter.TryConvertPosisiveNumberToDip(pageMarginFooterTextBox.Text, out pageMarginFooter))
                pageMargin.Footer = pageMarginFooter;

            double pageMarginGutter;
            if (_visualEditor.UnitsConverter.TryConvertPosisiveNumberToDip(pageMarginGutterTextBox.Text, out pageMarginGutter))
                pageMargin.Gutter = pageMarginGutter;

            sectionProperties.PageMargin = pageMargin;

            try
            {
                _visualEditor.UseDifferentHeadlineForFirstPage = useDifferentHeadlineForFirstPageCheckBox.Checked;
                _visualEditor.UseDifferentHeadlineForOddAndEvenPages = useDifferentHeadlineForOddAndEvenPagesCheckBox.Checked;

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
        /// Handles the Click event of buttonOk object.
        /// </summary>
        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            if (SetSettings())
                DialogResult = DialogResult.OK;
        }

        #endregion

    }
}
