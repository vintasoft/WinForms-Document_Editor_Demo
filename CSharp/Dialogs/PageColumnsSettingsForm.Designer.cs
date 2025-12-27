namespace DocumentEditorDemo
{
    partial class PageColumnsSettingsForm
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
            this.label12 = new System.Windows.Forms.Label();
            this.columnCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.equalColumnWidthCheckBox = new System.Windows.Forms.CheckBox();
            this.lineBetweenCheckBox = new System.Windows.Forms.CheckBox();
            this.columnNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.columnWidthTextBox = new System.Windows.Forms.TextBox();
            this.columnSpaceTextBox = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.columnCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnNumberNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "Column count:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // columnCountNumericUpDown
            // 
            this.columnCountNumericUpDown.Location = new System.Drawing.Point(113, 14);
            this.columnCountNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.columnCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnCountNumericUpDown.Name = "columnCountNumericUpDown";
            this.columnCountNumericUpDown.Size = new System.Drawing.Size(269, 20);
            this.columnCountNumericUpDown.TabIndex = 1;
            this.columnCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnCountNumericUpDown.ValueChanged += new System.EventHandler(this.columnCountNumericUpDown_ValueChanged);
            // 
            // equalColumnWidthCheckBox
            // 
            this.equalColumnWidthCheckBox.AutoSize = true;
            this.equalColumnWidthCheckBox.Location = new System.Drawing.Point(12, 23);
            this.equalColumnWidthCheckBox.Name = "equalColumnWidthCheckBox";
            this.equalColumnWidthCheckBox.Size = new System.Drawing.Size(118, 17);
            this.equalColumnWidthCheckBox.TabIndex = 4;
            this.equalColumnWidthCheckBox.Text = "Equal column width";
            this.equalColumnWidthCheckBox.UseVisualStyleBackColor = true;
            this.equalColumnWidthCheckBox.CheckedChanged += new System.EventHandler(this.equalColumnWidthCheckBox_CheckedChanged);
            // 
            // lineBetweenCheckBox
            // 
            this.lineBetweenCheckBox.AutoSize = true;
            this.lineBetweenCheckBox.Location = new System.Drawing.Point(15, 40);
            this.lineBetweenCheckBox.Name = "lineBetweenCheckBox";
            this.lineBetweenCheckBox.Size = new System.Drawing.Size(90, 17);
            this.lineBetweenCheckBox.TabIndex = 5;
            this.lineBetweenCheckBox.Text = "Line between";
            this.lineBetweenCheckBox.UseVisualStyleBackColor = true;
            this.lineBetweenCheckBox.CheckedChanged += new System.EventHandler(this.lineBetweenCheckBox_CheckedChanged);
            // 
            // columnNumberNumericUpDown
            // 
            this.columnNumberNumericUpDown.Location = new System.Drawing.Point(157, 45);
            this.columnNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnNumberNumericUpDown.Name = "columnNumberNumericUpDown";
            this.columnNumberNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.columnNumberNumericUpDown.TabIndex = 6;
            this.columnNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnNumberNumericUpDown.ValueChanged += new System.EventHandler(this.columnNumberNumericUpDown_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Column number:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Column width (cm):";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Space (cm):";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // columnWidthTextBox
            // 
            this.columnWidthTextBox.Location = new System.Drawing.Point(157, 71);
            this.columnWidthTextBox.Name = "columnWidthTextBox";
            this.columnWidthTextBox.Size = new System.Drawing.Size(200, 20);
            this.columnWidthTextBox.TabIndex = 10;
            this.columnWidthTextBox.TextChanged += new System.EventHandler(this.columnWidthTextBox_TextChanged);
            // 
            // columnSpaceTextBox
            // 
            this.columnSpaceTextBox.Location = new System.Drawing.Point(157, 95);
            this.columnSpaceTextBox.Name = "columnSpaceTextBox";
            this.columnSpaceTextBox.Size = new System.Drawing.Size(200, 20);
            this.columnSpaceTextBox.TabIndex = 11;
            this.columnSpaceTextBox.TextChanged += new System.EventHandler(this.columnSpaceTextBox_TextChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(226, 197);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(307, 197);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.columnSpaceTextBox);
            this.groupBox1.Controls.Add(this.columnWidthTextBox);
            this.groupBox1.Controls.Add(this.columnNumberNumericUpDown);
            this.groupBox1.Controls.Add(this.equalColumnWidthCheckBox);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(15, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Width and spacing";
            // 
            // PageColumnsSettingsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(398, 232);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lineBetweenCheckBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.columnCountNumericUpDown);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PageColumnsSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Page Columns Settings";
            ((System.ComponentModel.ISupportInitialize)(this.columnCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnNumberNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown columnCountNumericUpDown;
        private System.Windows.Forms.CheckBox equalColumnWidthCheckBox;
        private System.Windows.Forms.CheckBox lineBetweenCheckBox;
        private System.Windows.Forms.NumericUpDown columnNumberNumericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox columnWidthTextBox;
        private System.Windows.Forms.TextBox columnSpaceTextBox;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}