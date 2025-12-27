using DemosCommonCode;
using System.Windows.Forms;

namespace DocumentEditorDemo
{
    /// <summary>
    /// Provides the "Help" panel.
    /// </summary>
    public partial class HelpPanel : UserControl
    {


        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HelpPanel"/> class.
        /// </summary>
        public HelpPanel()
        {
            InitializeComponent();

            DemosTools.AutoFitToolstripButtons(this.toolStrip1);
        }


        #endregion



        #region Methods 

        #region PUBLIC  

        /// <summary>
        /// Shows the about dialog.
        /// </summary>
        public void ShowAboutDialog()
        {
            using (AboutBoxForm aboutDialog = new AboutBoxForm())
            {
                aboutDialog.ShowDialog();
            }
        }

        #endregion


        #region PRIVATE

        /// <summary>
        /// Handles the Click event of aboutButton object.
        /// </summary>
        private void aboutButton_Click(object sender, System.EventArgs e)
        {
            ShowAboutDialog();
        }

        #endregion

        #endregion

    }
}
