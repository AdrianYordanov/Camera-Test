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
        private readonly string imagesPath;
        private readonly int defaultImageFileNameLenght;
        private readonly Random random;

        private Bitmap currentImage;
        private Bitmap capturedImage;
        private VideoCaptureDevice videoSource;
        private FilterInfoCollection videoDevices;

        public CameraTest()
        {
            this.imagesPath = @"..\..\images\";
            this.defaultImageFileNameLenght = 10;
            this.random = new Random((int)DateTime.Now.Ticks);

            this.currentImage = null;
            this.capturedImage = null;
            this.videoSource = new VideoCaptureDevice();
            this.videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            InitializeComponent();
        }

        //Event functions.
        private void CameraTest_Load(object sender, EventArgs e)
        {
            this.InitializateCameraDevices();
        }

        // Tool functions.
        private void InitializateCameraDevices()
        {
            foreach (FilterInfo device in videoDevices)
            {
                devicesBox.Items.Add(device.Name);
            }

            // First item is selected by default.
            devicesBox.SelectedIndex = 0;
        }

        private string GenerateImageName()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < this.defaultImageFileNameLenght; i++)
            {
                char ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            string imageFileName = builder.ToString() + ".png";
            return imageFileName;
        }
    }
}
