namespace DocumentEditorDemo
{
    partial class DocumentVisualEditorSettingsForm
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
            this.asyncModeCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.showInvisibleTableBordersCheckBox = new System.Windows.Forms.CheckBox();
            this.textSelectionColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultUnitsComboBox = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // asyncModeCheckBox
            // 
            this.asyncModeCheckBox.AutoSize = true;
            this.asyncModeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asyncModeCheckBox.Location = new System.Drawing.Point(127, 109);
            this.asyncModeCheckBox.Name = "asyncModeCheckBox";
            this.asyncModeCheckBox.Size = new System.Drawing.Size(284, 17);
            this.asyncModeCheckBox.TabIndex = 0;
            this.asyncModeCheckBox.Text = "Async Mode";
            this.asyncModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(270, 145);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.98138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.01862F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.backgroundColorPanelControl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.showInvisibleTableBordersCheckBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.asyncModeCheckBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textSelectionColorPanelControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.defaultUnitsComboBox, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 127);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Default units";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundColorPanelControl
            // 
            this.backgroundColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.backgroundColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.backgroundColorPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundColorPanelControl.Location = new System.Drawing.Point(127, 31);
            this.backgroundColorPanelControl.Name = "backgroundColorPanelControl";
            this.backgroundColorPanelControl.Size = new System.Drawing.Size(284, 22);
            this.backgroundColorPanelControl.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Background color";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showInvisibleTableBordersCheckBox
            // 
            this.showInvisibleTableBordersCheckBox.AutoSize = true;
            this.showInvisibleTableBordersCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showInvisibleTableBordersCheckBox.Location = new System.Drawing.Point(127, 86);
            this.showInvisibleTableBordersCheckBox.Name = "showInvisibleTableBordersCheckBox";
            this.showInvisibleTableBordersCheckBox.Size = new System.Drawing.Size(284, 17);
            this.showInvisibleTableBordersCheckBox.TabIndex = 6;
            this.showInvisibleTableBordersCheckBox.Text = "Show Invisible Table Borders";
            this.showInvisibleTableBordersCheckBox.UseVisualStyleBackColor = true;
            // 
            // textSelectionColorPanelControl
            // 
            this.textSelectionColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.textSelectionColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.textSelectionColorPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSelectionColorPanelControl.Location = new System.Drawing.Point(127, 3);
            this.textSelectionColorPanelControl.Name = "textSelectionColorPanelControl";
            this.textSelectionColorPanelControl.Size = new System.Drawing.Size(284, 22);
            this.textSelectionColorPanelControl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Text selection color";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // defaultUnitsComboBox
            // 
            this.defaultUnitsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultUnitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultUnitsComboBox.FormattingEnabled = true;
            this.defaultUnitsComboBox.Location = new System.Drawing.Point(127, 59);
            this.defaultUnitsComboBox.Name = "defaultUnitsComboBox";
            this.defaultUnitsComboBox.Size = new System.Drawing.Size(284, 21);
            this.defaultUnitsComboBox.TabIndex = 11;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(351, 145);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 84;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // DocumentVisualEditorSettingsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(438, 180);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocumentVisualEditorSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Document Visual Editor Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox asyncModeCheckBox;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DemosCommonCode.CustomControls.ColorPanelControl textSelectionColorPanelControl;
        private System.Windows.Forms.CheckBox showInvisibleTableBordersCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private DemosCommonCode.CustomControls.ColorPanelControl backgroundColorPanelControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox defaultUnitsComboBox;
    }
}