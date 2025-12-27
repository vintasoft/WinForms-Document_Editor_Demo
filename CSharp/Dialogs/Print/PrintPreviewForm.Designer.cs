
namespace DocumentEditorDemo
{
    partial class PrintPreviewForm
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
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.printButton = new System.Windows.Forms.Button();
            this.pageSettingsButton = new System.Windows.Forms.Button();
            this.previewZoomLabel = new System.Windows.Forms.Label();
            this.previewZoomComboBox = new System.Windows.Forms.ComboBox();
            this.previewPageLabel = new System.Windows.Forms.Label();
            this.previewPageIndexNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.printPreviewGroupBox = new System.Windows.Forms.GroupBox();
            this.previewPageCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewPageIndexNumericUpDown)).BeginInit();
            this.printPreviewGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Location = new System.Drawing.Point(12, 19);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(684, 627);
            this.printPreviewControl1.TabIndex = 0;
            this.printPreviewControl1.Zoom = 0.55517536355859709D;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(12, 12);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(182, 65);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // pageSettingsButton
            // 
            this.pageSettingsButton.Location = new System.Drawing.Point(12, 94);
            this.pageSettingsButton.Name = "pageSettingsButton";
            this.pageSettingsButton.Size = new System.Drawing.Size(182, 32);
            this.pageSettingsButton.TabIndex = 2;
            this.pageSettingsButton.Text = "Page settings...";
            this.pageSettingsButton.UseVisualStyleBackColor = true;
            this.pageSettingsButton.Click += new System.EventHandler(this.pageSettingsButton_Click);
            // 
            // previewZoomLabel
            // 
            this.previewZoomLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.previewZoomLabel.AutoSize = true;
            this.previewZoomLabel.Location = new System.Drawing.Point(404, 660);
            this.previewZoomLabel.Name = "previewZoomLabel";
            this.previewZoomLabel.Size = new System.Drawing.Size(37, 13);
            this.previewZoomLabel.TabIndex = 4;
            this.previewZoomLabel.Text = "Zoom:";
            // 
            // previewZoomComboBox
            // 
            this.previewZoomComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.previewZoomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.previewZoomComboBox.FormattingEnabled = true;
            this.previewZoomComboBox.Items.AddRange(new object[] {
            "25%",
            "50%",
            "75%",
            "100%",
            "125%",
            "150%",
            "200%",
            "300%",
            "400%"});
            this.previewZoomComboBox.Location = new System.Drawing.Point(447, 656);
            this.previewZoomComboBox.Name = "previewZoomComboBox";
            this.previewZoomComboBox.Size = new System.Drawing.Size(115, 21);
            this.previewZoomComboBox.TabIndex = 5;
            this.previewZoomComboBox.SelectedIndexChanged += new System.EventHandler(this.previewZoomComboBox_SelectedIndexChanged);
            // 
            // previewPageLabel
            // 
            this.previewPageLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.previewPageLabel.AutoSize = true;
            this.previewPageLabel.Location = new System.Drawing.Point(144, 659);
            this.previewPageLabel.Name = "previewPageLabel";
            this.previewPageLabel.Size = new System.Drawing.Size(35, 13);
            this.previewPageLabel.TabIndex = 6;
            this.previewPageLabel.Text = "Page:";
            // 
            // previewPageIndexNumericUpDown
            // 
            this.previewPageIndexNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.previewPageIndexNumericUpDown.Location = new System.Drawing.Point(185, 656);
            this.previewPageIndexNumericUpDown.Name = "previewPageIndexNumericUpDown";
            this.previewPageIndexNumericUpDown.Size = new System.Drawing.Size(95, 20);
            this.previewPageIndexNumericUpDown.TabIndex = 7;
            this.previewPageIndexNumericUpDown.ValueChanged += new System.EventHandler(this.previewPageIndexNumericUpDown_ValueChanged);
            // 
            // printPreviewGroupBox
            // 
            this.printPreviewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewGroupBox.Controls.Add(this.previewPageCountLabel);
            this.printPreviewGroupBox.Controls.Add(this.printPreviewControl1);
            this.printPreviewGroupBox.Controls.Add(this.previewPageIndexNumericUpDown);
            this.printPreviewGroupBox.Controls.Add(this.previewZoomComboBox);
            this.printPreviewGroupBox.Controls.Add(this.previewPageLabel);
            this.printPreviewGroupBox.Controls.Add(this.previewZoomLabel);
            this.printPreviewGroupBox.Location = new System.Drawing.Point(208, 12);
            this.printPreviewGroupBox.Name = "printPreviewGroupBox";
            this.printPreviewGroupBox.Size = new System.Drawing.Size(707, 686);
            this.printPreviewGroupBox.TabIndex = 8;
            this.printPreviewGroupBox.TabStop = false;
            this.printPreviewGroupBox.Text = "Preview";
            // 
            // previewPageCountLabel
            // 
            this.previewPageCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.previewPageCountLabel.AutoSize = true;
            this.previewPageCountLabel.Location = new System.Drawing.Point(286, 659);
            this.previewPageCountLabel.Name = "previewPageCountLabel";
            this.previewPageCountLabel.Size = new System.Drawing.Size(68, 13);
            this.previewPageCountLabel.TabIndex = 8;
            this.previewPageCountLabel.Text = "from 1 pages";
            // 
            // PrintPreviewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(927, 710);
            this.Controls.Add(this.printPreviewGroupBox);
            this.Controls.Add(this.pageSettingsButton);
            this.Controls.Add(this.printButton);
            this.Name = "PrintPreviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print XLSX document";
            ((System.ComponentModel.ISupportInitialize)(this.previewPageIndexNumericUpDown)).EndInit();
            this.printPreviewGroupBox.ResumeLayout(false);
            this.printPreviewGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button pageSettingsButton;
        private System.Windows.Forms.Label previewZoomLabel;
        private System.Windows.Forms.ComboBox previewZoomComboBox;
        private System.Windows.Forms.Label previewPageLabel;
        private System.Windows.Forms.NumericUpDown previewPageIndexNumericUpDown;
        private System.Windows.Forms.GroupBox printPreviewGroupBox;
        private System.Windows.Forms.Label previewPageCountLabel;
    }
}