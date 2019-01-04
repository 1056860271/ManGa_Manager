namespace ManGa_Manager.Views
{
	partial class ImageViewer
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
			this.nextButton = new System.Windows.Forms.Button();
			this.previousButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.optionBar = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.optionBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// nextButton
			// 
			this.nextButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.nextButton.Location = new System.Drawing.Point(541, 0);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(75, 25);
			this.nextButton.TabIndex = 1;
			this.nextButton.Text = "-->";
			this.nextButton.UseVisualStyleBackColor = true;
			this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
			// 
			// previousButton
			// 
			this.previousButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.previousButton.Location = new System.Drawing.Point(0, 0);
			this.previousButton.Name = "previousButton";
			this.previousButton.Size = new System.Drawing.Size(75, 25);
			this.previousButton.TabIndex = 0;
			this.previousButton.Text = "<--";
			this.previousButton.UseVisualStyleBackColor = true;
			this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(616, 580);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 2;
			this.pictureBox.TabStop = false;
			this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
			this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
			this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
			// 
			// optionBar
			// 
			this.optionBar.Controls.Add(this.nextButton);
			this.optionBar.Controls.Add(this.previousButton);
			this.optionBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.optionBar.Location = new System.Drawing.Point(0, 586);
			this.optionBar.Name = "optionBar";
			this.optionBar.Size = new System.Drawing.Size(616, 25);
			this.optionBar.TabIndex = 0;
			// 
			// ImageViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 611);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.optionBar);
			this.KeyPreview = true;
			this.Name = "ImageViewer";
			this.Text = "imageViewer";
			this.Load += new System.EventHandler(this.ImageViewer_Load);
			this.SizeChanged += new System.EventHandler(this.ImageViewer_Resize);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageViewer_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.optionBar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.Button previousButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Panel optionBar;
	}
}