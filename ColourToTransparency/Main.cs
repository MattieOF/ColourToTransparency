using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cyotek.Windows.Forms;
using WK.Libraries.BetterFolderBrowserNS;

namespace ColourToTransparency
{
    // Uses BetterFolderBrowser, Cyotek.Windows.Forms.ColorPicker and Fody.Costura
    // Possible improvements: Ignore alpha checkbox

    public partial class Main : Form
    {
        private Bitmap colourImage;
        private Color colourToReplace;
        private ColorPickerDialog colourPicker;
        private List<string> imagePaths = new List<string>();
        private Dictionary<string, Bitmap> outputImages = new Dictionary<string, Bitmap>();

        public Main()
        {
            InitializeComponent();
            KeyPreview = true;
            colourImage = new Bitmap(1, 1);
            colourToReplace = Color.Black;
            SetColourImageFromColour(colourToReplace);
            colourPicker = new ColorPickerDialog();
        }

        private void SetColourImageFromColour(Color colour)
        {
            colourImage.SetPixel(0, 0, colour);
            ReplaceColourBox.Image = colourImage;
        }

        private void ReplaceColourBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
        }

        private void SelectColourButton_Click(object sender, EventArgs e)
        {
            colourPicker.Color = colourToReplace;
            if (colourPicker.ShowDialog() == DialogResult.OK)
            {
                colourToReplace = colourPicker.Color;
                SetColourImageFromColour(colourToReplace);
            }
        }

        private void OutputDirBrowseButton_Click(object sender, EventArgs e)
        {
            BetterFolderBrowser folderBrowser = new BetterFolderBrowser();
            folderBrowser.Title = "Browse for output directory";
            folderBrowser.Multiselect = false;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                OutputDirectoryField.Text = folderBrowser.SelectedPath;
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void AddFilesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Open Images";
            fileDialog.Filter = "Image Files|*.png;*.jpeg;*.jpg;*.bmp;*.tiff";
            fileDialog.CheckFileExists = true;
            fileDialog.Multiselect = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                AddImagePaths(fileDialog.FileNames);
            }
        }

        public void AddImagePaths(string[] filePaths)
        {
            foreach (string path in filePaths)
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show($"Attemped to load file {path} but it doesn't exist", "Error loading images",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                if (imagePaths.Contains(path))
                    continue;

                AddImage(path);
            }
        }

        public void AddImage(string path)
        {
            imagePaths.Add(path);
            FilesListBox.Items.Add(path);
        }

        public void ClearPaths()
        {
            imagePaths.Clear();
            FilesListBox.Items.Clear();
        }

        private void ClearImagesButton_Click(object sender, EventArgs e)
        {
            ClearPaths();
        }

        public bool CheckInputsAreValid()
        {
            if (string.IsNullOrWhiteSpace(OutputDirectoryField.Text))
            {
                MessageBox.Show("Output directory is empty", "Error removing transparency",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (imagePaths.Count == 0)
            {
                MessageBox.Show("No images have been added", "Error removing transparency",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Directory.Exists(OutputDirectoryField.Text))
            {
                if (MessageBox.Show($"Output directory ({OutputDirectoryField.Text}) doesn't exist. Create it?", "Error removing transparency",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Directory.CreateDirectory(OutputDirectoryField.Text);
                } else
                {
                    return false;
                }
            }

            return true;
        }

        private void AddTransparencyButton_Click(object sender, EventArgs e)
        {
            if (!CheckInputsAreValid()) return;

            Color newColour = Color.FromArgb((int)AlphaValueInput.Value, Color.Black);

            foreach (string path in imagePaths)
            {
                Bitmap imageBitmap = new Bitmap(path);

                if (newColour.A == 0)
                    imageBitmap.MakeTransparent(colourToReplace);
                else
                    imageBitmap = ReplaceColour(imageBitmap, colourToReplace, newColour);

                outputImages.Add(Path.GetFileNameWithoutExtension(path), imageBitmap);
            }

            SaveOutputImages();

            outputImages.Clear();
        }

        public Bitmap ReplaceColour(Bitmap bitmap, Color toReplace, Color replaceWith)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    if (bitmap.GetPixel(x, y) == toReplace)
                    {
                        bitmap.SetPixel(x, y, replaceWith);
                    }
                }
            }

            return bitmap;
        }

        public void SaveOutputImages()
        {
            foreach (string filename in outputImages.Keys)
            {
                outputImages[filename].Save($"{OutputDirectoryField.Text}/{filename}.png");
            }
        }

        private void FilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imagePaths.Count < FilesListBox.SelectedIndex || FilesListBox.SelectedIndex < 0)
            {
                SamplePictureBox.Image = null;
                return;
            }

            SamplePictureBox.Image = new Bitmap(imagePaths[FilesListBox.SelectedIndex]);
        }
    }
}
