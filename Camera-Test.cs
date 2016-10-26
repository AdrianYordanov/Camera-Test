﻿namespace Camera_Test
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
    }
}
