namespace ManGa_Manager.Views
{
	partial class Setting
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.choosePath = new System.Windows.Forms.Button();
			this.defPathText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.check_webp = new System.Windows.Forms.CheckBox();
			this.check_tif = new System.Windows.Forms.CheckBox();
			this.check_gif = new System.Windows.Forms.CheckBox();
			this.check_bmp = new System.Windows.Forms.CheckBox();
			this.check_png = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(495, 390);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.choosePath);
			this.tabPage1.Controls.Add(this.defPathText);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(487, 364);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "常规";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// choosePath
			// 
			this.choosePath.Location = new System.Drawing.Point(406, 17);
			this.choosePath.Name = "choosePath";
			this.choosePath.Size = new System.Drawing.Size(75, 23);
			this.choosePath.TabIndex = 2;
			this.choosePath.Text = "打开";
			this.choosePath.UseVisualStyleBackColor = true;
			this.choosePath.Click += new System.EventHandler(this.button3_Click);
			// 
			// defPathText
			// 
			this.defPathText.Location = new System.Drawing.Point(104, 18);
			this.defPathText.Name = "defPathText";
			this.defPathText.Size = new System.Drawing.Size(296, 21);
			this.defPathText.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "默认资源位置";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.check_webp);
			this.tabPage2.Controls.Add(this.check_tif);
			this.tabPage2.Controls.Add(this.check_gif);
			this.tabPage2.Controls.Add(this.check_bmp);
			this.tabPage2.Controls.Add(this.check_png);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(487, 364);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "文件类型";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// check_webp
			// 
			this.check_webp.AutoSize = true;
			this.check_webp.Location = new System.Drawing.Point(178, 124);
			this.check_webp.Name = "check_webp";
			this.check_webp.Size = new System.Drawing.Size(54, 16);
			this.check_webp.TabIndex = 5;
			this.check_webp.Text = ".webp";
			this.check_webp.UseVisualStyleBackColor = true;
			// 
			// check_tif
			// 
			this.check_tif.AutoSize = true;
			this.check_tif.Location = new System.Drawing.Point(178, 102);
			this.check_tif.Name = "check_tif";
			this.check_tif.Size = new System.Drawing.Size(90, 16);
			this.check_tif.TabIndex = 4;
			this.check_tif.Text = ".tif、.tiff";
			this.check_tif.UseVisualStyleBackColor = true;
			// 
			// check_gif
			// 
			this.check_gif.AutoSize = true;
			this.check_gif.Location = new System.Drawing.Point(178, 80);
			this.check_gif.Name = "check_gif";
			this.check_gif.Size = new System.Drawing.Size(48, 16);
			this.check_gif.TabIndex = 3;
			this.check_gif.Text = ".GIF";
			this.check_gif.UseVisualStyleBackColor = true;
			// 
			// check_bmp
			// 
			this.check_bmp.AutoSize = true;
			this.check_bmp.Location = new System.Drawing.Point(178, 58);
			this.check_bmp.Name = "check_bmp";
			this.check_bmp.Size = new System.Drawing.Size(48, 16);
			this.check_bmp.TabIndex = 2;
			this.check_bmp.Text = ".BMP";
			this.check_bmp.UseVisualStyleBackColor = true;
			// 
			// check_png
			// 
			this.check_png.AutoSize = true;
			this.check_png.Location = new System.Drawing.Point(178, 36);
			this.check_png.Name = "check_png";
			this.check_png.Size = new System.Drawing.Size(48, 16);
			this.check_png.TabIndex = 1;
			this.check_png.Text = ".PNG";
			this.check_png.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(176, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "检测JPEG以及以下文件";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(347, 408);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 30);
			this.button1.TabIndex = 1;
			this.button1.Text = "确定";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(428, 408);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 30);
			this.button2.TabIndex = 2;
			this.button2.Text = "取消";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Setting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Setting";
			this.Text = "设置";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox check_webp;
		private System.Windows.Forms.CheckBox check_tif;
		private System.Windows.Forms.CheckBox check_gif;
		private System.Windows.Forms.CheckBox check_bmp;
		private System.Windows.Forms.CheckBox check_png;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button choosePath;
		private System.Windows.Forms.TextBox defPathText;
		private System.Windows.Forms.Label label2;
	}
}