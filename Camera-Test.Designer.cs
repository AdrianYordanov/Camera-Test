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
            ((System.ComponentModel.ISupportInitialize)(this.streamShow)).BeginInit();
            this.SuspendLayout();
            // 
            // streamShow
            // 
            this.streamShow.Location = new System.Drawing.Point(288, 12);
            this.streamShow.Name = "streamShow";
            this.streamShow.Size = new System.Drawing.Size(254, 253);
            this.streamShow.TabIndex = 0;
            this.streamShow.TabStop = false;
            // 
            // CameraTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(554, 277);
            this.Controls.Add(this.streamShow);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CameraTest";
            this.Text = "Camera Test";
            ((System.ComponentModel.ISupportInitialize)(this.streamShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox streamShow;
    }
}

