
namespace DocumentEditorDemo
{
    partial class DocumentInfoForm
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
            this.creatorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.managerLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.keywordsLabel = new System.Windows.Forms.Label();
            this.keywordsTextBox = new System.Windows.Forms.TextBox();
            this.createdLabel = new System.Windows.Forms.Label();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.modifiedLabel = new System.Windows.Forms.Label();
            this.modifiedTextBox = new System.Windows.Forms.TextBox();
            this.printedLabel = new System.Windows.Forms.Label();
            this.printedTextBox = new System.Windows.Forms.TextBox();
            this.lastModifiedByLabel = new System.Windows.Forms.Label();
            this.lastModifiedByTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(398, 285);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 83;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(317, 285);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 82;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // creatorTextBox
            // 
            this.creatorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creatorTextBox.Location = new System.Drawing.Point(95, 55);
            this.creatorTextBox.Name = "creatorTextBox";
            this.creatorTextBox.Size = new System.Drawing.Size(363, 20);
            this.creatorTextBox.TabIndex = 88;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(95, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(363, 20);
            this.titleTextBox.TabIndex = 84;
            // 
            // creatorLabel
            // 
            this.creatorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Location = new System.Drawing.Point(3, 58);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(44, 13);
            this.creatorLabel.TabIndex = 86;
            this.creatorLabel.Text = "Creator:";
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 87;
            this.titleLabel.Text = "Title:";
            // 
            // subjectLabel
            // 
            this.subjectLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(3, 32);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 13);
            this.subjectLabel.TabIndex = 89;
            this.subjectLabel.Text = "Subject:";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Location = new System.Drawing.Point(95, 29);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(363, 20);
            this.subjectTextBox.TabIndex = 85;
            // 
            // managerLabel
            // 
            this.managerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.managerLabel.AutoSize = true;
            this.managerLabel.Location = new System.Drawing.Point(3, 84);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(63, 13);
            this.managerLabel.TabIndex = 91;
            this.managerLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(95, 81);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(363, 20);
            this.descriptionTextBox.TabIndex = 90;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(3, 110);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 95;
            this.categoryLabel.Text = "Category:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryTextBox.Location = new System.Drawing.Point(95, 107);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(363, 20);
            this.categoryTextBox.TabIndex = 94;
            // 
            // keywordsLabel
            // 
            this.keywordsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.keywordsLabel.AutoSize = true;
            this.keywordsLabel.Location = new System.Drawing.Point(3, 136);
            this.keywordsLabel.Name = "keywordsLabel";
            this.keywordsLabel.Size = new System.Drawing.Size(56, 13);
            this.keywordsLabel.TabIndex = 97;
            this.keywordsLabel.Text = "Keywords:";
            // 
            // keywordsTextBox
            // 
            this.keywordsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keywordsTextBox.Location = new System.Drawing.Point(95, 133);
            this.keywordsTextBox.Name = "keywordsTextBox";
            this.keywordsTextBox.Size = new System.Drawing.Size(363, 20);
            this.keywordsTextBox.TabIndex = 96;
            // 
            // createdLabel
            // 
            this.createdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(3, 162);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(47, 13);
            this.createdLabel.TabIndex = 103;
            this.createdLabel.Text = "Created:";
            // 
            // createdTextBox
            // 
            this.createdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createdTextBox.Enabled = false;
            this.createdTextBox.Location = new System.Drawing.Point(95, 159);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.Size = new System.Drawing.Size(363, 20);
            this.createdTextBox.TabIndex = 102;
            // 
            // modifiedLabel
            // 
            this.modifiedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modifiedLabel.AutoSize = true;
            this.modifiedLabel.Location = new System.Drawing.Point(3, 188);
            this.modifiedLabel.Name = "modifiedLabel";
            this.modifiedLabel.Size = new System.Drawing.Size(50, 13);
            this.modifiedLabel.TabIndex = 105;
            this.modifiedLabel.Text = "Modified:";
            // 
            // modifiedTextBox
            // 
            this.modifiedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modifiedTextBox.Enabled = false;
            this.modifiedTextBox.Location = new System.Drawing.Point(95, 185);
            this.modifiedTextBox.Name = "modifiedTextBox";
            this.modifiedTextBox.Size = new System.Drawing.Size(363, 20);
            this.modifiedTextBox.TabIndex = 104;
            // 
            // printedLabel
            // 
            this.printedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.printedLabel.AutoSize = true;
            this.printedLabel.Location = new System.Drawing.Point(3, 214);
            this.printedLabel.Name = "printedLabel";
            this.printedLabel.Size = new System.Drawing.Size(43, 13);
            this.printedLabel.TabIndex = 107;
            this.printedLabel.Text = "Printed:";
            // 
            // printedTextBox
            // 
            this.printedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printedTextBox.Enabled = false;
            this.printedTextBox.Location = new System.Drawing.Point(95, 211);
            this.printedTextBox.Name = "printedTextBox";
            this.printedTextBox.Size = new System.Drawing.Size(363, 20);
            this.printedTextBox.TabIndex = 106;
            // 
            // lastModifiedByLabel
            // 
            this.lastModifiedByLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastModifiedByLabel.AutoSize = true;
            this.lastModifiedByLabel.Location = new System.Drawing.Point(3, 240);
            this.lastModifiedByLabel.Name = "lastModifiedByLabel";
            this.lastModifiedByLabel.Size = new System.Drawing.Size(86, 13);
            this.lastModifiedByLabel.TabIndex = 109;
            this.lastModifiedByLabel.Text = "Last modified by:";
            // 
            // lastModifiedByTextBox
            // 
            this.lastModifiedByTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastModifiedByTextBox.Enabled = false;
            this.lastModifiedByTextBox.Location = new System.Drawing.Point(95, 237);
            this.lastModifiedByTextBox.Name = "lastModifiedByTextBox";
            this.lastModifiedByTextBox.Size = new System.Drawing.Size(363, 20);
            this.lastModifiedByTextBox.TabIndex = 108;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.subjectLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.titleTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.subjectTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.creatorLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lastModifiedByLabel, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.creatorTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lastModifiedByTextBox, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.managerLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.printedLabel, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.descriptionTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.printedTextBox, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.modifiedLabel, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.modifiedTextBox, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.categoryLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.createdLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.categoryTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.createdTextBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.keywordsTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.keywordsLabel, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 267);
            this.tableLayoutPanel1.TabIndex = 116;
            // 
            // DocumentInfoForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(485, 320);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocumentInfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Document Information";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox creatorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label keywordsLabel;
        private System.Windows.Forms.TextBox keywordsTextBox;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.Label modifiedLabel;
        private System.Windows.Forms.TextBox modifiedTextBox;
        private System.Windows.Forms.Label printedLabel;
        private System.Windows.Forms.TextBox printedTextBox;
        private System.Windows.Forms.Label lastModifiedByLabel;
        private System.Windows.Forms.TextBox lastModifiedByTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}