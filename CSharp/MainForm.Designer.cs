
using Vintasoft.Imaging.Office.Spreadsheet.UI.Controls;

namespace DocumentEditorDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openDocumentFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.viewerStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveDocumentFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.imagePrintDocument1 = new Vintasoft.Imaging.Print.ImagePrintDocument();
            this.documentEditor1 = new Vintasoft.Imaging.Office.DocumentEditor.UI.Controls.DocumentEditor();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openDocumentFileDialog
            // 
            this.openDocumentFileDialog.Filter = "DOCX files|*.docx";
            this.openDocumentFileDialog.FilterIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewerStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // viewerStatusLabel
            // 
            this.viewerStatusLabel.Name = "viewerStatusLabel";
            this.viewerStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.viewerStatusLabel.Text = "Ready";
            // 
            // saveDocumentFileDialog
            // 
            this.saveDocumentFileDialog.Filter = "DOCX files|*.docx";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // imagePrintDocument1
            // 
            this.imagePrintDocument1.Center = false;
            this.imagePrintDocument1.DistanceBetweenImages = 0;
            this.imagePrintDocument1.PrintScaleMode = Vintasoft.Imaging.Print.PrintScaleMode.None;
            // 
            // documentEditor1
            // 
            this.documentEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documentEditor1.Location = new System.Drawing.Point(0, -2);
            this.documentEditor1.Name = "documentEditor1";
            this.documentEditor1.Size = new System.Drawing.Size(1084, 688);
            this.documentEditor1.TabIndex = 16;
            this.documentEditor1.ShowPageSettingsOptions += new System.EventHandler<System.EventArgs>(this.DocumentEditor_ShowPageSettingsOptions);
            this.documentEditor1.ShowColumnsSettingsOptions += new System.EventHandler<System.EventArgs>(this.DocumentEditor_ShowColumnsSettingsOptions);
            this.documentEditor1.ColorRequest += new System.EventHandler<Vintasoft.Imaging.Office.UI.ColorEventArgs>(this.DocumentEditor_ColorRequest);
            this.documentEditor1.PrintDocument += new System.EventHandler<System.EventArgs>(this.DocumentEditor_PrintDocument);
            this.documentEditor1.ShowPrintLayoutSettings += new System.EventHandler<System.EventArgs>(this.DocumentEditor_ShowPrintLayoutSettings);
            this.documentEditor1.ShowPrintPageSettings += new System.EventHandler<System.EventArgs>(this.DocumentEditor_ShowPrintPageSettings);
            this.documentEditor1.ShowPrintPreview += new System.EventHandler<System.EventArgs>(this.DocumentEditor_ShowPrintPreview);
            this.documentEditor1.FilenameChanged += new System.EventHandler(this.DocumentEditor_FilenameChanged);
            this.documentEditor1.VisualEditorError += new System.EventHandler<Vintasoft.Imaging.ExceptionEventArgs>(this.DocumentEditor_VisualEditorError);
            this.documentEditor1.OpenFileRequest += new System.EventHandler<Vintasoft.Imaging.Office.UI.FilenameEventArgs>(this.DocumentEditor_OpenFileRequest);
            this.documentEditor1.SaveChangesRequest += new System.EventHandler<Vintasoft.Imaging.Office.UI.ActionRequestEventArgs>(this.DocumentEditor_SaveChangesRequest);
            this.documentEditor1.SaveAsRequest += new System.EventHandler<Vintasoft.Imaging.Office.UI.FilenameEventArgs>(this.DocumentEditor_SaveAsRequest);
            this.documentEditor1.ShowDocumentInfo += new System.EventHandler<System.EventArgs>(this.DocumentEditor_ShowDocumentInfo);
            this.documentEditor1.ShowVisualEditorOptions += new System.EventHandler<System.EventArgs>(this.DocumentEditor_ShowVisualEditorOptions);
            this.documentEditor1.ExportFile += new System.EventHandler<System.EventArgs>(this.DocumentEditor_ExportFile);
            this.documentEditor1.ShowBookmarkDialog += new System.EventHandler(this.DocumentEditor_ShowBookmarkDialog);
            this.documentEditor1.TextPropertiesRequest += new System.EventHandler<System.EventArgs>(this.DocumentEditor_TextPropertiesRequest);
            this.documentEditor1.ParagraphPropertiesRequest += new System.EventHandler<System.EventArgs>(this.DocumentEditor_ParagraphPropertiesRequest);
            this.documentEditor1.ViewPropertiesRequest += new System.EventHandler(this.DocumentEditor_ViewPropertiesRequest);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.imagePrintDocument1;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.documentEditor1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VintaSoft Document Editor Demo";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openDocumentFileDialog;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel viewerStatusLabel;
        private Vintasoft.Imaging.Office.DocumentEditor.UI.Controls.DocumentEditor documentEditor1;
        private System.Windows.Forms.SaveFileDialog saveDocumentFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private Vintasoft.Imaging.Print.ImagePrintDocument imagePrintDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}