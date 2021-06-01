using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task5.MegaBitmap
{
    public partial class MainForm : Form
    {
        private Graphics g;
        private bool isImageLoaded = false;

        public MainForm() => InitializeComponent();

        private void FormMain_Load(object sender, EventArgs e)
        {
            //g = panelDrawCanvas.CreateGraphics();
            //g.SmoothingMode = SmoothingMode.HighQuality;
            //g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            DoubleBuffered = true;
        }

        private void loadImage(string path)
        {
            if (Path.HasExtension(path)
                && Regex.IsMatch(Path.GetExtension(path), "(jpg)|(jpeg)|(png)|(gif)|(tif)"))
            {
                clearImages();
                groupBoxImage.Text = $"Изображение: {Path.GetFileName(path)}";
                pictureBoxInput.Load(path);
                isImageLoaded = true;
                
                //output pixels
                outputPixels(50,50);
            }
            else
            {
                groupBoxImage.Text = $"Изображение: не удалось загрузить {Path.GetFileName(path)}";
                isImageLoaded = false;
            }
        }

        private void outputPixels(int areaWidth, int areaHeight)
        {
            var bitmap = new Bitmap(pictureBoxInput.Image);
            var pixelsList = new List<string>();
            areaWidth = Math.Min(bitmap.Width, areaWidth);
            areaHeight = Math.Min(bitmap.Width, areaWidth);
            groupBoxPixels.Text = $"Первые {areaWidth}x{areaHeight} пикселей";
            for (var x = 0; x <areaWidth; x++)
            {
                for (var y = 0; y < areaHeight; y++)
                {
                    var color = bitmap.GetPixel(x, y);
                    pixelsList.Add($"({x:D2},{y:D2}) {ColorTranslator.ToHtml(color)} {color.GetBrightness():0.00000}");
                }
            }
            listBoxPixels.Items.AddRange(pixelsList.ToArray());
        }

        private void clearImages()
        {
            pictureBoxInput.Image?.Dispose();
            pictureBoxOutput.Image?.Dispose();
            pictureBoxInput.Image = null;
            pictureBoxOutput.Image = null;
            groupBoxImage.Text = "Изображение: не выбрано";
            isImageLoaded = false;
        }

        private void buttonLoadJellyfish_Click(object sender, EventArgs e)
        {
            loadImage(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "assets", "jellyfish.jpg"));
        }

        private void buttonLoadSteveImage_Click(object sender, EventArgs e)
        {
            loadImage(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "assets", "steve.jpg"));
        }

        private void buttonLoadCustomImage_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            loadImage(openFileDialog.FileName);
        }

        private void buttonClearImages_Click(object sender, EventArgs e) => clearImages();

        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            // todo process large images in extra thread
            if (!isImageLoaded) return;
            var imageBitmap = new Bitmap(pictureBoxInput.Image);
            var random = new Random();
            random.Next(0, imageBitmap.Width);
            var outputBitmap = imageBitmap;
            for (var x = 0; x < imageBitmap.Width; x++)
            {
                for (var y = 0; y < imageBitmap.Height; y++)
                {
                    // Берем рандомный цвет
                    var color = imageBitmap.GetPixel(x, y);


                    // Затемняем цвет по диагонали (справа внизу- самое темное) 
                    var dark = 1 - Math.Abs(x * y * 0.4d) / (imageBitmap.Width * imageBitmap.Height);

                    // Меняем прозрачность (слева вверху - самое прозрачное)
                    var alpha = 1 - Math.Abs((imageBitmap.Width * imageBitmap.Height - x * y) * 0.4d) /
                        (imageBitmap.Width * imageBitmap.Height);

                    // Обновляем пиксель у битмапа
                    outputBitmap.SetPixel(x, y,
                        Color.FromArgb(
                            (int) Math.Round(color.A * alpha),
                            (int) Math.Round(color.R * dark),
                            (int) Math.Round(color.G * dark),
                            (int) Math.Round(color.B * dark)));
                }
            }

            pictureBoxOutput.Image = outputBitmap;
        }
    }
}