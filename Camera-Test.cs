namespace Camera_Test
{
    using System;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    // External namespaces.
    using AForge.Video;
    using AForge.Video.DirectShow;

    public partial class CameraTest : Form
    {
        private const int defaultImageFileNameLenght = 10;
        private readonly Random random = new Random((int)DateTime.Now.Ticks);
        private const string imagesPath = @"..\..\images\";

        private VideoCaptureDevice videoSource;
        private FilterInfoCollection videoDevices;
        private Bitmap currentImage;
        private Bitmap capturedImage;

        public CameraTest()
        {
            InitializeComponent();
        }


        #region Tools Functions
        private void InitializateCameraDevices()
        {
            this.videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in videoDevices)
            {
                devicesBox.Items.Add(device.Name);
            }

            // First item is selected by default.
            devicesBox.SelectedIndex = 0;
            this.videoSource = new VideoCaptureDevice();
        }

        private string GenerateImageName(int fileNameLenght = defaultImageFileNameLenght)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < fileNameLenght; i++)
            {
                char ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            string imageFileName = builder.ToString() + ".png";
            return imageFileName;
        }
        #endregion
    }
}
