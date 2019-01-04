using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManGa_Manager.Views
{
	public partial class ImageViewer : Form
	{
		private ArrayList filePaths;
		private int index;


		public ImageViewer(ArrayList list, int num)
		{
			filePaths = list;
			index = num;
			InitializeComponent();

			//绑定滚轮事件
			this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.ImageViewer_MouseWheel);
			optionBar.BringToFront();
			matchWinSize();

		}

		private void ImageViewer_Load(object sender, EventArgs e)
		{
			//加载从上一个界面打开来的图片index
			loadImage(filePaths[index].ToString());
		}

		/// <summary>
		/// 加载图片到pictureBox
		/// </summary>
		/// <param name="path"></param>
		private void loadImage(String path)
		{
			pictureBox.Image = Image.FromFile(path);
		}
		/// <summary>
		/// 上一张
		/// </summary>
		private void previous()
		{
			if(index > 0)
			{
				index--;
			}
			String path = filePaths[index].ToString();
			loadImage(path);
		}
		/// <summary>
		/// 下一张
		/// </summary>
		private void next()
		{
			if (index < filePaths.Count-1)
			{
				index++;
			}
			String path = filePaths[index].ToString();
			loadImage(path);
		}

		private void previousButton_Click(object sender, EventArgs e)
		{
			previous();
		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			next();
		}

		/// <summary>
		/// 键盘事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ImageViewer_KeyDown(object sender, KeyEventArgs e)
		{
			//方向键默认为系统切换焦点
			switch (e.KeyCode)
			{
				case Keys.Left:
					previous();
					break;
				case Keys.Right:
					next();
					break;
			}
		}

		/// <summary>
		/// 覆盖默认方向键事件
		/// </summary>
		/// <param name="keyData"></param>
		/// <returns></returns>
		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (keyData == Keys.Up || keyData == Keys.Down ||
				keyData == Keys.Left || keyData == Keys.Right)
				return false;
			else
				return base.ProcessDialogKey(keyData); //否则交给窗体自己处理
		}

		/// <summary>
		/// 滚轮事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ImageViewer_MouseWheel(object sender, MouseEventArgs e)
		{
			double step = 1.1;//缩放倍率
			if (e.Delta > 0)
			{
				//设置放大上限为屏幕10倍
				if (pictureBox.Height >= Screen.PrimaryScreen.Bounds.Height * 10)
					return;
				pictureBox.Height = (int)(pictureBox.Height * step);
				pictureBox.Width = (int)(pictureBox.Width * step);

				int px = Cursor.Position.X - pictureBox.Location.X;
				int py = Cursor.Position.Y - pictureBox.Location.Y;
				//System.Console.WriteLine("mouse is in x:" + (Cursor.Position.X) + " y:" + (Cursor.Position.Y));
				int px_add = (int)(px * (step - 1.0));
				int py_add = (int)(py * (step - 1.0));
				//System.Console.WriteLine("Location is in x:" + (pictureBox.Location.X - px_add) + " y:" + (pictureBox.Location.Y - py_add));
				pictureBox.Location = new Point(pictureBox.Location.X - px_add, pictureBox.Location.Y - py_add);
				Application.DoEvents();
			}
			else
			{
				//设置缩小上限为屏幕10倍
				if (pictureBox.Height <= Screen.PrimaryScreen.Bounds.Height / 10)
					return;
				pictureBox.Height = (int)(pictureBox.Height / step);
				pictureBox.Width = (int)(pictureBox.Width / step); //图片放大

				int px = Cursor.Position.X - pictureBox.Location.X;
				int py = Cursor.Position.Y - pictureBox.Location.Y;
				int px_add = (int)(px * (1.0 - 1.0 / step));
				int py_add = (int)(py * (1.0 - 1.0 / step));//图片根据鼠标位置复位
				pictureBox.Location = new Point(pictureBox.Location.X + px_add, pictureBox.Location.Y + py_add);
				Application.DoEvents();
			}
		}

		/// <summary>
		/// 鼠标点击事件，保存当前点击位置
		/// </summary>
		private Point mouseDownPoint = new Point();
		private Boolean isSelected = false;
		private void pictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				mouseDownPoint.X = Cursor.Position.X;  //注：全局变量mouseDownPoint前面已定义为Point类型  
				mouseDownPoint.Y = Cursor.Position.Y;
				isSelected = true;
			}
		}
		/// <summary>
		/// 鼠标拖动事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (isSelected && IsMouseInPanel())//确定已经激发MouseDown事件，和鼠标在picturebox的范围内，否则无法拖动
			{
				this.pictureBox.Left = this.pictureBox.Left + (Cursor.Position.X - mouseDownPoint.X);
				this.pictureBox.Top = this.pictureBox.Top + (Cursor.Position.Y - mouseDownPoint.Y);
				mouseDownPoint.X = Cursor.Position.X;
				mouseDownPoint.Y = Cursor.Position.Y;
			}
		}
		/// <summary>
		/// 查看鼠标是否在图片内部
		/// </summary>
		/// <returns></returns>
		private bool IsMouseInPanel()
		{
			if (this.pictureBox.Left < PointToClient(Cursor.Position).X && PointToClient(Cursor.Position).X < this.pictureBox.Left + this.pictureBox.Width && this.pictureBox.Top < PointToClient(Cursor.Position).Y && PointToClient(Cursor.Position).Y < this.pictureBox.Top + this.pictureBox.Height)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private void pictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			isSelected = false;
		}

		/// <summary>
		/// 将窗口设置为合适图片的大小
		/// </summary>
		private void matchWinSize()
		{
			int maxWidth = Screen.PrimaryScreen.Bounds.Width;
			int maxHeigtht = Screen.PrimaryScreen.Bounds.Height -60; //较为合适的大小，过大会被任务栏遮住一部分
			int minWidth = maxWidth / 5;
			int minHeight = maxHeigtht / 5;

			Image img = Image.FromFile(filePaths[index].ToString());

			int height = img.Height;
			int width = img.Width;

			if (height > maxHeigtht)
				height = maxHeigtht;
			else if (height < minHeight)
				height = minHeight;
			

			if (width > maxWidth)
				width = maxWidth;
			else if (width < minWidth)
				width = minWidth;
			//设置窗口大小
			this.Width = width;
			this.Height = height;
			//设置窗口居中
			//this.Location = new Point(maxWidth/2 - width / 2, maxHeigtht/2 - height / 2);
			matchImgSize();
		}
		/// <summary>
		/// 将图片设置为合适窗口的大小
		/// </summary>
		private void matchImgSize()
		{
			pictureBox.Width = this.Width;
			pictureBox.Height = this.Height - optionBar.Height;
		}


		/// <summary>
		/// 窗体大小改变事件
		/// </summary>
		private Boolean isMaximized = false;
		private void ImageViewer_Resize(object sender, EventArgs e)
		{
			//窗体最大化时
			if (this.WindowState == FormWindowState.Maximized)
			{
				isMaximized = true;
				matchImgSize();
			}
			//窗体从最大化恢复正常时
			if (this.WindowState == FormWindowState.Normal && isMaximized)
			{
				isMaximized = false;
				matchImgSize();
				//System.Console.WriteLine("max");
			}
			//pictureBox.Width = this.Width;
		}

	}
}
