
namespace ColourToTransparency
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.AddFilesButton = new System.Windows.Forms.Button();
            this.ClearImagesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectColourButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AlphaValueInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputDirectoryField = new System.Windows.Forms.TextBox();
            this.OutputDirBrowseButton = new System.Windows.Forms.Button();
            this.AddTransparencyButton = new System.Windows.Forms.Button();
            this.SamplePictureBox = new System.Windows.Forms.PictureBox();
            this.ReplaceColourBox = new ColourToTransparency.NoInterpPicturebox();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaValueInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplaceColourBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Files";
            // 
            // FilesListBox
            // 
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.Location = new System.Drawing.Point(15, 25);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(182, 199);
            this.FilesListBox.TabIndex = 1;
            this.FilesListBox.SelectedIndexChanged += new System.EventHandler(this.FilesListBox_SelectedIndexChanged);
            // 
            // AddFilesButton
            // 
            this.AddFilesButton.Location = new System.Drawing.Point(15, 321);
            this.AddFilesButton.Name = "AddFilesButton";
            this.AddFilesButton.Size = new System.Drawing.Size(182, 23);
            this.AddFilesButton.TabIndex = 2;
            this.AddFilesButton.Text = "Add Images";
            this.AddFilesButton.UseVisualStyleBackColor = true;
            this.AddFilesButton.Click += new System.EventHandler(this.AddFilesButton_Click);
            // 
            // ClearImagesButton
            // 
            this.ClearImagesButton.Location = new System.Drawing.Point(15, 350);
            this.ClearImagesButton.Name = "ClearImagesButton";
            this.ClearImagesButton.Size = new System.Drawing.Size(182, 23);
            this.ClearImagesButton.TabIndex = 3;
            this.ClearImagesButton.Text = "Clear Images";
            this.ClearImagesButton.UseVisualStyleBackColor = true;
            this.ClearImagesButton.Click += new System.EventHandler(this.ClearImagesButton_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Colour to replace";
            // 
            // SelectColourButton
            // 
            this.SelectColourButton.Location = new System.Drawing.Point(212, 51);
            this.SelectColourButton.Name = "SelectColourButton";
            this.SelectColourButton.Size = new System.Drawing.Size(182, 23);
            this.SelectColourButton.TabIndex = 5;
            this.SelectColourButton.Text = "Select Colour";
            this.SelectColourButton.UseVisualStyleBackColor = true;
            this.SelectColourButton.Click += new System.EventHandler(this.SelectColourButton_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alpha value to set";
            // 
            // AlphaValueInput
            // 
            this.AlphaValueInput.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.AlphaValueInput.Location = new System.Drawing.Point(212, 93);
            this.AlphaValueInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AlphaValueInput.Name = "AlphaValueInput";
            this.AlphaValueInput.Size = new System.Drawing.Size(182, 20);
            this.AlphaValueInput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output directory";
            // 
            // OutputDirectoryField
            // 
            this.OutputDirectoryField.Location = new System.Drawing.Point(212, 132);
            this.OutputDirectoryField.Name = "OutputDirectoryField";
            this.OutputDirectoryField.Size = new System.Drawing.Size(154, 20);
            this.OutputDirectoryField.TabIndex = 11;
            // 
            // OutputDirBrowseButton
            // 
            this.OutputDirBrowseButton.Location = new System.Drawing.Point(372, 132);
            this.OutputDirBrowseButton.Name = "OutputDirBrowseButton";
            this.OutputDirBrowseButton.Size = new System.Drawing.Size(22, 20);
            this.OutputDirBrowseButton.TabIndex = 12;
            this.OutputDirBrowseButton.Text = "..";
            this.OutputDirBrowseButton.UseVisualStyleBackColor = true;
            this.OutputDirBrowseButton.Click += new System.EventHandler(this.OutputDirBrowseButton_Click);
            // 
            // AddTransparencyButton
            // 
            this.AddTransparencyButton.Location = new System.Drawing.Point(212, 350);
            this.AddTransparencyButton.Name = "AddTransparencyButton";
            this.AddTransparencyButton.Size = new System.Drawing.Size(182, 23);
            this.AddTransparencyButton.TabIndex = 13;
            this.AddTransparencyButton.Text = "Add Transparency";
            this.AddTransparencyButton.UseVisualStyleBackColor = true;
            this.AddTransparencyButton.Click += new System.EventHandler(this.AddTransparencyButton_Click);
            // 
            // SamplePictureBox
            // 
            this.SamplePictureBox.Location = new System.Drawing.Point(15, 230);
            this.SamplePictureBox.Name = "SamplePictureBox";
            this.SamplePictureBox.Size = new System.Drawing.Size(182, 85);
            this.SamplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SamplePictureBox.TabIndex = 14;
            this.SamplePictureBox.TabStop = false;
            // 
            // ReplaceColourBox
            // 
            this.ReplaceColourBox.Location = new System.Drawing.Point(212, 25);
            this.ReplaceColourBox.Name = "ReplaceColourBox";
            this.ReplaceColourBox.Size = new System.Drawing.Size(182, 20);
            this.ReplaceColourBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReplaceColourBox.TabIndex = 8;
            this.ReplaceColourBox.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 381);
            this.Controls.Add(this.SamplePictureBox);
            this.Controls.Add(this.AddTransparencyButton);
            this.Controls.Add(this.OutputDirBrowseButton);
            this.Controls.Add(this.OutputDirectoryField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReplaceColourBox);
            this.Controls.Add(this.AlphaValueInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectColourButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearImagesButton);
            this.Controls.Add(this.AddFilesButton);
            this.Controls.Add(this.FilesListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colour To Transparency";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.AlphaValueInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplaceColourBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Button AddFilesButton;
        private System.Windows.Forms.Button ClearImagesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SelectColourButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AlphaValueInput;
        private NoInterpPicturebox ReplaceColourBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OutputDirectoryField;
        private System.Windows.Forms.Button OutputDirBrowseButton;
        private System.Windows.Forms.Button AddTransparencyButton;
        private System.Windows.Forms.PictureBox SamplePictureBox;
    }
}

