using System;

using System.Windows.Forms;

using Vintasoft.Imaging.Office.DocumentEditor.UI;
using Vintasoft.Imaging.Office.Vmf.UI;

namespace DocumentEditorDemo
{
    /// <summary>
    /// A form that allows to manipulate the document bookmarks.
    /// </summary>
    public partial class BookmarksForm : Form
    {

        #region Fields

        /// <summary>
        /// The visual editor.
        /// </summary>
        DocumentVisualEditor _visualEditor;

        /// <summary>
        /// The document bookmarks.
        /// </summary>
        VmfContentBookmarkInfo[] _bookmarks;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BookmarksForm"/> class.
        /// </summary>
        public BookmarksForm()
        {
            InitializeComponent();
        }

        #endregion



        #region Methods

        /// <summary>
        /// Shows this form with current document visual editor settings.
        /// </summary>
        /// <param name="visualEditor">The document visual editor.</param>
        public static DialogResult ShowDialog(DocumentVisualEditor visualEditor)
        {
            using (BookmarksForm form = new BookmarksForm())
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
            UpdateBookmarkList();
        }

        /// <summary>
        /// Updates the bookmark list.
        /// </summary>
        private void UpdateBookmarkList()
        {
            _bookmarks = _visualEditor.GetBookmarks();

            bookmarksListBox.Items.Clear();
            foreach (VmfContentBookmarkInfo bookmark in _bookmarks)
            {
                bookmarksListBox.Items.Add(bookmark);
            }
        }

        /// <summary>
        /// Handles the Click event of buttonClose object.
        /// </summary>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the Click event of buttonGoTo object.
        /// </summary>
        private void buttonGoTo_Click(object sender, EventArgs e)
        {
            if (bookmarksListBox.SelectedItem != null)
                _visualEditor.SelectFragment((VmfContentBookmarkInfo)(bookmarksListBox.SelectedItem));
        }

        #endregion

    }
}
