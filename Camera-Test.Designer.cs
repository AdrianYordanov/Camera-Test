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
            this.streamShow = new System.Windows.Forms.PictureBox();
            this.captureShow = new System.Windows.Forms.PictureBox();
            this.captureButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.streamShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureShow)).BeginInit();
            this.SuspendLayout();
            // 
            // streamShow
            // 
            this.streamShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.streamShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.streamShow.Location = new System.Drawing.Point(330, 36);
            this.streamShow.Name = "streamShow";
            this.streamShow.Size = new System.Drawing.Size(254, 253);
            this.streamShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.streamShow.TabIndex = 0;
            this.streamShow.TabStop = false;
            // 
            // captureShow
            // 
            this.captureShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.captureShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.captureShow.Location = new System.Drawing.Point(12, 194);
            this.captureShow.Name = "captureShow";
            this.captureShow.Size = new System.Drawing.Size(111, 95);
            this.captureShow.TabIndex = 1;
            this.captureShow.TabStop = false;
            // 
            // captureButton
            // 
            this.captureButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.captureButton.BackColor = System.Drawing.Color.White;
            this.captureButton.Enabled = false;
            this.captureButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureButton.Location = new System.Drawing.Point(129, 194);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(195, 47);
            this.captureButton.TabIndex = 3;
            this.captureButton.Text = "Capture Image";
            this.captureButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(129, 243);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(195, 46);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save Image";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // CameraTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(596, 295);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.captureShow);
            this.Controls.Add(this.streamShow);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CameraTest";
            this.Text = "Camera Test";
            ((System.ComponentModel.ISupportInitialize)(this.streamShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox streamShow;
        private System.Windows.Forms.PictureBox captureShow;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button saveButton;
    }
}

