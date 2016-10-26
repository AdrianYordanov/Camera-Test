namespace Camera_Test
{
    partial class CameraTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraTest));
            this.captureShow = new System.Windows.Forms.PictureBox();
            this.DeviceOptions = new System.Windows.Forms.Label();
            this.CameraOptions = new System.Windows.Forms.Label();
            this.SelectDeviceButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.devicesBox = new System.Windows.Forms.ComboBox();
            this.streamShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.captureShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamShow)).BeginInit();
            this.SuspendLayout();
            // 
            // captureShow
            // 
            this.captureShow.BackColor = System.Drawing.Color.White;
            this.captureShow.Location = new System.Drawing.Point(617, 226);
            this.captureShow.Name = "captureShow";
            this.captureShow.Size = new System.Drawing.Size(152, 130);
            this.captureShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.captureShow.TabIndex = 16;
            this.captureShow.TabStop = false;
            // 
            // DeviceOptions
            // 
            this.DeviceOptions.AutoSize = true;
            this.DeviceOptions.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceOptions.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.DeviceOptions.Location = new System.Drawing.Point(409, 12);
            this.DeviceOptions.Name = "DeviceOptions";
            this.DeviceOptions.Size = new System.Drawing.Size(303, 41);
            this.DeviceOptions.TabIndex = 15;
            this.DeviceOptions.Text = "Device Options:";
            // 
            // CameraOptions
            // 
            this.CameraOptions.AutoSize = true;
            this.CameraOptions.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CameraOptions.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CameraOptions.Location = new System.Drawing.Point(409, 161);
            this.CameraOptions.Name = "CameraOptions";
            this.CameraOptions.Size = new System.Drawing.Size(303, 41);
            this.CameraOptions.TabIndex = 14;
            this.CameraOptions.Text = "Camera Options:";
            // 
            // SelectDeviceButton
            // 
            this.SelectDeviceButton.BackColor = System.Drawing.Color.White;
            this.SelectDeviceButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDeviceButton.Location = new System.Drawing.Point(407, 98);
            this.SelectDeviceButton.Name = "SelectDeviceButton";
            this.SelectDeviceButton.Size = new System.Drawing.Size(362, 46);
            this.SelectDeviceButton.TabIndex = 13;
            this.SelectDeviceButton.Text = "Select Device";
            this.SelectDeviceButton.UseVisualStyleBackColor = false;
            this.SelectDeviceButton.Click += new System.EventHandler(this.SelectDeviceButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(407, 310);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(191, 46);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save Image";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.BackColor = System.Drawing.Color.White;
            this.captureButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureButton.Location = new System.Drawing.Point(407, 226);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(191, 46);
            this.captureButton.TabIndex = 11;
            this.captureButton.Text = "Capture Image";
            this.captureButton.UseVisualStyleBackColor = false;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // devicesBox
            // 
            this.devicesBox.FormattingEnabled = true;
            this.devicesBox.Location = new System.Drawing.Point(407, 56);
            this.devicesBox.Name = "devicesBox";
            this.devicesBox.Size = new System.Drawing.Size(362, 21);
            this.devicesBox.TabIndex = 10;
            // 
            // streamShow
            // 
            this.streamShow.BackColor = System.Drawing.Color.White;
            this.streamShow.Location = new System.Drawing.Point(12, 12);
            this.streamShow.Name = "streamShow";
            this.streamShow.Size = new System.Drawing.Size(382, 344);
            this.streamShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.streamShow.TabIndex = 9;
            this.streamShow.TabStop = false;
            // 
            // CameraTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(781, 367);
            this.Controls.Add(this.captureShow);
            this.Controls.Add(this.DeviceOptions);
            this.Controls.Add(this.CameraOptions);
            this.Controls.Add(this.SelectDeviceButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.devicesBox);
            this.Controls.Add(this.streamShow);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CameraTest";
            this.Text = "Camera Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraTest_FormClosing);
            this.Load += new System.EventHandler(this.CameraTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.captureShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox captureShow;
        private System.Windows.Forms.Label DeviceOptions;
        private System.Windows.Forms.Label CameraOptions;
        private System.Windows.Forms.Button SelectDeviceButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.ComboBox devicesBox;
        private System.Windows.Forms.PictureBox streamShow;

    }
}

