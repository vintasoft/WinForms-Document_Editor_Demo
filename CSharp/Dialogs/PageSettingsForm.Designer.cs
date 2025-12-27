namespace DocumentEditorDemo
{
    partial class PageSettingsForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.pageOrientationComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sectionBreakComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pageSizeComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.pageMarginTopTextBox = new System.Windows.Forms.TextBox();
            this.pageMarginBottomTextBox = new System.Windows.Forms.TextBox();
            this.pageMarginHeaderTextBox = new System.Windows.Forms.TextBox();
            this.pageMarginRightTextBox = new System.Windows.Forms.TextBox();
            this.pageMarginLeftTextBox = new System.Windows.Forms.TextBox();
            this.pageMarginFooterTextBox = new System.Windows.Forms.TextBox();
            this.pageMarginGutterTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.useDifferentHeadlineForOddAndEvenPagesCheckBox = new System.Windows.Forms.CheckBox();
            this.useDifferentHeadlineForFirstPageCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(365, 354);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(284, 354);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pageOrientationComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sectionBreakComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pageSizeComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.useDifferentHeadlineForOddAndEvenPagesCheckBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.useDifferentHeadlineForFirstPageCheckBox, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 336);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 196);
            this.label4.TabIndex = 6;
            this.label4.Text = "Page margin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pageOrientationComboBox
            // 
            this.pageOrientationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageOrientationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pageOrientationComboBox.FormattingEnabled = true;
            this.pageOrientationComboBox.Location = new System.Drawing.Point(161, 57);
            this.pageOrientationComboBox.Name = "pageOrientationComboBox";
            this.pageOrientationComboBox.Size = new System.Drawing.Size(271, 21);
            this.pageOrientationComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Page orientation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sectionBreakComboBox
            // 
            this.sectionBreakComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionBreakComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionBreakComboBox.FormattingEnabled = true;
            this.sectionBreakComboBox.Location = new System.Drawing.Point(161, 3);
            this.sectionBreakComboBox.Name = "sectionBreakComboBox";
            this.sectionBreakComboBox.Size = new System.Drawing.Size(271, 21);
            this.sectionBreakComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Section start";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Page size";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pageSizeComboBox
            // 
            this.pageSizeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageSizeComboBox.FormattingEnabled = true;
            this.pageSizeComboBox.Location = new System.Drawing.Point(161, 30);
            this.pageSizeComboBox.Name = "pageSizeComboBox";
            this.pageSizeComboBox.Size = new System.Drawing.Size(271, 21);
            this.pageSizeComboBox.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pageMarginTopTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.pageMarginBottomTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.pageMarginHeaderTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.pageMarginRightTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pageMarginLeftTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pageMarginFooterTextBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.pageMarginGutterTextBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(161, 84);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(271, 190);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Top";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pageMarginTopTextBox
            // 
            this.pageMarginTopTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageMarginTopTextBox.Location = new System.Drawing.Point(139, 58);
            this.pageMarginTopTextBox.Name = "pageMarginTopTextBox";
            this.pageMarginTopTextBox.Size = new System.Drawing.Size(128, 20);
            this.pageMarginTopTextBox.TabIndex = 1;
            // 
            // pageMarginBottomTextBox
            // 
            this.pageMarginBottomTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageMarginBottomTextBox.Location = new System.Drawing.Point(139, 85);
            this.pageMarginBottomTextBox.Name = "pageMarginBottomTextBox";
            this.pageMarginBottomTextBox.Size = new System.Drawing.Size(128, 20);
            this.pageMarginBottomTextBox.TabIndex = 2;
            // 
            // pageMarginHeaderTextBox
            // 
            this.pageMarginHeaderTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageMarginHeaderTextBox.Location = new System.Drawing.Point(139, 112);
            this.pageMarginHeaderTextBox.Name = "pageMarginHeaderTextBox";
            this.pageMarginHeaderTextBox.Size = new System.Drawing.Size(128, 20);
            this.pageMarginHeaderTextBox.TabIndex = 3;
            // 
            // pageMarginRightTextBox
            // 
            this.pageMarginRightTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageMarginRightTextBox.Location = new System.Drawing.Point(139, 31);
            this.pageMarginRightTextBox.Name = "pageMarginRightTextBox";
            this.pageMarginRightTextBox.Size = new System.Drawing.Size(128, 20);
            this.pageMarginRightTextBox.TabIndex = 4;
            // 
            // pageMarginLeftTextBox
            // 
            this.pageMarginLeftTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageMarginLeftTextBox.Location = new System.Drawing.Point(139, 4);
            this.pageMarginLeftTextBox.Name = "pageMarginLeftTextBox";
            this.pageMarginLeftTextBox.Size = new System.Drawing.Size(128, 20);
            this.pageMarginLeftTextBox.TabIndex = 5;
            // 
            // pageMarginFooterTextBox
            // 
            this.pageMarginFooterTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageMarginFooterTextBox.Location = new System.Drawing.Point(139, 139);
            this.pageMarginFooterTextBox.Name = "pageMarginFooterTextBox";
            this.pageMarginFooterTextBox.Size = new System.Drawing.Size(128, 20);
            this.pageMarginFooterTextBox.TabIndex = 6;
            // 
            // pageMarginGutterTextBox
            // 
            this.pageMarginGutterTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageMarginGutterTextBox.Location = new System.Drawing.Point(139, 166);
            this.pageMarginGutterTextBox.Name = "pageMarginGutterTextBox";
            this.pageMarginGutterTextBox.Size = new System.Drawing.Size(128, 20);
            this.pageMarginGutterTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Left";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(4, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Right";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(4, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 26);
            this.label8.TabIndex = 10;
            this.label8.Text = "Bottom";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(4, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 26);
            this.label9.TabIndex = 11;
            this.label9.Text = "Header";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(4, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 26);
            this.label10.TabIndex = 12;
            this.label10.Text = "Footer";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(4, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 26);
            this.label11.TabIndex = 13;
            this.label11.Text = "Gutter";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // useDifferentHeadlineForOddAndEvenPagesCheckBox
            // 
            this.useDifferentHeadlineForOddAndEvenPagesCheckBox.AutoSize = true;
            this.useDifferentHeadlineForOddAndEvenPagesCheckBox.Location = new System.Drawing.Point(161, 303);
            this.useDifferentHeadlineForOddAndEvenPagesCheckBox.Name = "useDifferentHeadlineForOddAndEvenPagesCheckBox";
            this.useDifferentHeadlineForOddAndEvenPagesCheckBox.Size = new System.Drawing.Size(245, 17);
            this.useDifferentHeadlineForOddAndEvenPagesCheckBox.TabIndex = 8;
            this.useDifferentHeadlineForOddAndEvenPagesCheckBox.Text = "Use different headline for odd and even pages";
            this.useDifferentHeadlineForOddAndEvenPagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // useDifferentHeadlineForFirstPageCheckBox
            // 
            this.useDifferentHeadlineForFirstPageCheckBox.AutoSize = true;
            this.useDifferentHeadlineForFirstPageCheckBox.Location = new System.Drawing.Point(161, 280);
            this.useDifferentHeadlineForFirstPageCheckBox.Name = "useDifferentHeadlineForFirstPageCheckBox";
            this.useDifferentHeadlineForFirstPageCheckBox.Size = new System.Drawing.Size(190, 17);
            this.useDifferentHeadlineForFirstPageCheckBox.TabIndex = 9;
            this.useDifferentHeadlineForFirstPageCheckBox.Text = "Use different headline for first page";
            this.useDifferentHeadlineForFirstPageCheckBox.UseVisualStyleBackColor = true;
            // 
            // PageSettingsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(454, 389);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PageSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Page Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox sectionBreakComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pageOrientationComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox pageSizeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pageMarginTopTextBox;
        private System.Windows.Forms.TextBox pageMarginBottomTextBox;
        private System.Windows.Forms.TextBox pageMarginHeaderTextBox;
        private System.Windows.Forms.TextBox pageMarginRightTextBox;
        private System.Windows.Forms.TextBox pageMarginLeftTextBox;
        private System.Windows.Forms.TextBox pageMarginFooterTextBox;
        private System.Windows.Forms.TextBox pageMarginGutterTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox useDifferentHeadlineForOddAndEvenPagesCheckBox;
        private System.Windows.Forms.CheckBox useDifferentHeadlineForFirstPageCheckBox;
    }
}