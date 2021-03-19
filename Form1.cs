using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewerTrue
{
    public partial class Form1 : Form
    {
        private List<FileInfo> _filelist;
        private int index;
        
        public Environment.SpecialFolder RootFolder { get; private set; }

        public Form1()
        {
            InitializeComponent();
            _filelist = new List<FileInfo>();
        }

        #region Folder select

        private void DisplayImageByIndex()
        {
            if (_filelist.Count() == 0)
            {
                return;
            }
            var image = _filelist.ElementAtOrDefault(index);
            if (image == default)
            {
                return;
            }
            pictureBox.Image?.Dispose();
            _currentImage = Image.FromFile(image.FullName);
            pictureBox.Image = _currentImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog
            {
                Tag = "Select folder",
                RootFolder = Environment.SpecialFolder.Desktop
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var files = new DirectoryInfo
                    (folderBrowserDialog.SelectedPath).GetFiles()
                    .Where(c => c.Extension == ".jpg"
                    || c.Extension == ".png");
                _filelist = new List<FileInfo>(files);

                pathList.Items.Clear();
                pathList.Items.AddRange(files.
                    Select(c => c.Name)
                    .ToArray());
                DisplayImageByIndex();
            }
            else
            {
                MessageBox.Show("Выбрать путь");
            }
        }
        #endregion

        #region DisplayImage

        private void pathList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            index = listBox.SelectedIndex;
            DisplayImageByIndex();
        }

        private void ChangeImageButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            switch (button.Name)
            {
                case "button1":
                    if (index == 0)
                    {
                        return;
                    }
                    index--;
                    break;
                case "button2":
                    if (index == _filelist.Count()-1)
                    {
                        return;
                    }
                    index++;
                    break;
            }
            DisplayImageByIndex();
        }

        private Image _currentImage;

        #endregion

        private void ChangeBrightness(object sender, EventArgs e)
        {
            var slider = sender as TrackBar;
            var currentImage = new Bitmap(_currentImage);
            ImageAttributes imageAttributes = new ImageAttributes();
            int width = currentImage.Width;
            int height = currentImage.Height;
            float bright = slider.Value *0.1f;
            float[][] colorMatrixElements =
            {
                new float[] {bright, 0, 0, 0, 0}, // R
                new float[] {0, bright, 0, 0, 0}, // G
                new float[] {0, 0, bright, 0, 0}, // B
                new float[] {0, 0, 0, 1, 0}, // Alpha
                new float[] { bright, bright, bright, 0, 1}, //
            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            Graphics graphics = Graphics.FromImage(_currentImage);
            graphics.DrawImage(currentImage,
                new Rectangle(0, 0, width, height), 0, 0, width, height,
                GraphicsUnit.Pixel,
                imageAttributes);
            pictureBox.Image = currentImage;
        }

        private void ChangeTransparency(object sender, EventArgs e)
        {
            var slider = sender as TrackBar;
            var currentImage = new Bitmap(_currentImage);
            ImageAttributes imageAttributes = new ImageAttributes();
            int width = currentImage.Width;
            int height = currentImage.Height;

            float[][] transparentMatrixElements =
                {
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 0.8f, 0},
                    new float[] {0, 0, 0, 0, 1}
            };
            ColorMatrix colorMatrix = new ColorMatrix(transparentMatrixElements);

            imageAttributes.SetColorMatrix(
                    colorMatrix,
                    ColorMatrixFlag.Default,
                    ColorAdjustType.Bitmap);

            Graphics graphics = Graphics.FromImage(_currentImage);
            graphics.DrawImage(currentImage,
                    new Rectangle(30, 0, width, height),  
                    0.0f,                          
                    0.0f,                          
                    width,                        
                    height,                     
                    GraphicsUnit.Pixel,
                    imageAttributes);
            pictureBox.Image = currentImage;
        }

        // Следующий обработчик события запускается, но не работает корректно
        
        //private void ChangeBW(object sender, EventArgs e)
        //{
        //    var slider = sender as TrackBar;
        //    var currentImage = new Bitmap(_currentImage);
        //    ImageAttributes imageAttributes = new ImageAttributes();
        //    int width = currentImage.Width;
        //    int height = currentImage.Height;
        //    int P = 10;

        //    Color color = new Color();
        //    try
        //    {
        //        for (int j = 0; j < height; j++)
        //        {
        //            for (int i = 0; i < width; i++)
        //            {
        //                color = currentImage.GetPixel(i, j);
        //                int K = (color.R + color.G + color.B) / 3;
        //                currentImage.SetPixel(i, j, K <= P ? Color.Black : Color.White);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
