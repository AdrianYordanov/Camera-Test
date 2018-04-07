namespace Camera_Test
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;
    using AForge.Video;
    using AForge.Video.DirectShow;

    public partial class CameraTest : Form
    {
        private readonly string imagesPath;
        private readonly int defaultImageFileNameLenght;
        private readonly Random random;
        // ReSharper disable once CollectionNeverUpdated.Local
        private readonly FilterInfoCollection videoDevices;
        private Bitmap currentImage;
        private Bitmap capturedImage;
        private VideoCaptureDevice videoSource;

        public CameraTest()
        {
            this.imagesPath = @"..\..\saved images\";
            this.defaultImageFileNameLenght = 10;
            this.random = new Random((int)DateTime.Now.Ticks);
            this.videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            this.currentImage = null;
            this.capturedImage = null;
            this.videoSource = new VideoCaptureDevice();
            this.InitializeComponent();
        }

        // Event functions.
        private void CameraTest_Load(object sender, EventArgs e)
        {
            this.InitializateCameraDevices();
        }

        private void CameraTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.videoSource.IsRunning)
            {
                this.videoSource.Stop();
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            this.currentImage = (Bitmap)eventArgs.Frame.Clone();
            this.streamShow.Image = this.currentImage;
        }

        private void SelectDeviceButton_Click(object sender, EventArgs e)
        {
            this.videoSource = new VideoCaptureDevice(this.videoDevices[this.devicesBox.SelectedIndex].MonikerString);
            this.videoSource.NewFrame += this.VideoSource_NewFrame;
            this.videoSource.Start();
        }

        private void CaptureButton_Click(object sender, EventArgs eventArgs)
        {
            if (this.videoSource.IsRunning)
            {
                this.capturedImage = this.currentImage;
                this.captureShow.Image = this.streamShow.Image;
            }
            else
            {
                this.captureShow.Image = null;
                this.captureShow.Invalidate();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this.captureShow.Image != null)
            {
                if (!Directory.Exists(this.imagesPath))
                {
                    Directory.CreateDirectory(this.imagesPath);
                }

                var randomFileName = this.GenerateImageName();
                var path = $"{this.imagesPath}{randomFileName}";
                this.capturedImage.Save(path, ImageFormat.Png);
            }
        }
        
        private void InitializateCameraDevices()
        {
            foreach (FilterInfo device in this.videoDevices)
            {
                this.devicesBox.Items.Add(device.Name);
            }

            // First item is selected by default.
            this.devicesBox.SelectedIndex = 0;
        }

        private string GenerateImageName()
        {
            var builder = new StringBuilder();
            for (var i = 0; i < this.defaultImageFileNameLenght; i++)
            {
                var ch = Convert.ToChar(Convert.ToInt32(Math.Floor((26 * this.random.NextDouble()) + 65)));
                builder.Append(ch);
            }

            var imageFileName = builder + ".png";
            return imageFileName;
        }
    }
}