using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManGa_Manager.Views;

namespace ManGa_Manager
{
	public partial class MainDialog : Form
	{
		private String defPath = "D:\\manga";
		private String setFile = "Setting.txt";
		private Dictionary<string, string> settingFromFile = new Dictionary<string, string>();
		public MainDialog()
		{
			loadSetting();
			InitializeComponent();
		}

		private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}


		private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
			dialog.Description = "请选择文件夹";
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				loadPath(dialog.SelectedPath);
			}
		}
		private void MainDialog_Load(object sender, EventArgs e)
		{
			dirTree_Load();
			loadPath(settingFromFile["defPath"]);

		}

		private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Setting setting = new Setting(setFile,this);
			setting.ShowDialog();
		}

		/// <summary>
		/// 加载磁盘节点
		/// </summary>
		private void dirTree_Load()
		{

			
			//实例化TreeNode类 TreeNode(string text,int imageIndex,int selectImageIndex)  
			
			/*
			TreeNode rootNode = new TreeNode("我的电脑",
				IconIndexes.MyComputer, IconIndexes.MyComputer);  //载入显示 选择显示
			rootNode.Tag = "我的电脑";                            //树节点数据
			rootNode.Text = "我的电脑";                           //树节点标签内容
			this.directoryTree.Nodes.Add(rootNode);               //树中添加根目录

			//显示MyDocuments(我的文档)结点
			var myDocuments = Environment.GetFolderPath           //获取计算机我的文档文件夹
				(Environment.SpecialFolder.MyDocuments);
			TreeNode DocNode = new TreeNode(myDocuments);
			DocNode.Tag = "我的文档";                            //设置结点名称
			DocNode.Text = "我的文档";
			DocNode.ImageIndex = IconIndexes.MyDocuments;         //设置获取结点显示图片
			DocNode.SelectedImageIndex = IconIndexes.MyDocuments; //设置选择显示图片
			rootNode.Nodes.Add(DocNode);                          //rootNode目录下加载节点
			DocNode.Nodes.Add("");
			*/

			//循环遍历计算机所有逻辑驱动器名称(盘符)
			foreach (string drive in Environment.GetLogicalDrives())
			{
				//实例化DriveInfo对象 命名空间System.IO
				var dir = new DriveInfo(drive);
				switch (dir.DriveType)           //判断驱动器类型
				{
					case DriveType.Fixed:        //仅取固定磁盘盘符 Removable-U盘 
						{
							//Split仅获取盘符字母
							TreeNode tNode = new TreeNode(dir.Name.Split(':')[0] + ":");
							tNode.Name = dir.Name;
							tNode.Tag = tNode.Name;
							tNode.ImageIndex = IconIndexes.FixedDrive;         //获取结点显示图片
							tNode.SelectedImageIndex = IconIndexes.FixedDrive; //选择显示图片
							directoryTree.Nodes.Add(tNode);                    //加载驱动节点
							tNode.Nodes.Add("");
						}
						break;
				}
			}
			//rootNode.Expand();                  //展开树状视图




		}

		/// <summary>
		/// 在结点展开后发生 展开子结点
		/// </summary>
		private void directoryTree_AfterExpand(object sender, TreeViewEventArgs e)
		{
			e.Node.Expand();
		}

		/// <summary>
		/// 在将要展开结点时发生 加载子结点
		/// </summary>
		private void directoryTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			Console.WriteLine("load node");
			TreeViewItems.Add(e.Node);
		}

		/// <summary>
		/// 点击时获取path，加载path下的图片
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private CancellationTokenSource cancelSource = new CancellationTokenSource();
		private void directoryTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			//Console.WriteLine(e.Node.FullPath);
			//bindImgList(e.Node.FullPath);
			//终止上个操作并释放cancelSource
			cancelSource.Cancel();
			cancelSource.Dispose();
			//刷新
			imglist.Images.Clear();
			imgView.Clear();
			cancelSource = new CancellationTokenSource();
			
			//使用线程修改UI界面，避免读取图片量过大，窗体进入假死状态
			Task<Int32> task = new Task<Int32>(n => bindImgList(e.Node.FullPath, cancelSource.Token), 0);
			task.Start();
			//Task tsk = task.ContinueWith(t => doFresh());
			
		}


		//private void bindListView(String path, CancellationToken token)
		private ArrayList filePaths = new ArrayList();
		/// <summary>
		/// 重新加载imagelist
		/// </summary>
		/// <param name="path"></param>
		private int bindImgList(String path, CancellationToken token)
		{
			//刷新
			DirectoryInfo dir = new DirectoryInfo(path);

			string[] files = new string[1000];
			filePaths.Clear();
			int number = dir.GetFiles().Length;
			int index = 0;
			string ext = "";
			try
			{
				foreach (FileInfo d in dir.GetFiles())
				{
					ext = System.IO.Path.GetExtension(path + d.Name);
					token.ThrowIfCancellationRequested();
					foreach(var k in settingFromFile)
					{
						System.Console.WriteLine(k.Key + "//" + k.Value);
					}
					if ((ext == ".jpg") 
						|| (ext == ".png" && settingFromFile["png"]=="T"?true:false)
						 || (ext == ".bmp" && settingFromFile["bmp"] == "T" ? true : false)
						  || (ext == ".gif" && settingFromFile["gif"] == "T" ? true : false)
						   || (ext == ".tif" && settingFromFile["tif"] == "T" ? true : false)
						   || (ext == ".tiff" && settingFromFile["tif"] == "T" ? true : false)
							|| (ext == ".webp" && settingFromFile["webp"] == "T" ? true : false))//在此只显示Jpg
					{
						imglist.Images.Add(Image.FromFile(path + "\\" + d.Name));
						System.Console.WriteLine("index is " + index + "total is " + number);
						doProgress(((index+1)/number)*100);
						index++;

						filePaths.Add(path + "\\" + d.Name);
					}
				}
			}catch(System.OperationCanceledException e)
			{
				return 0;
				//MessageBox.Show(e.Message);
			}
			catch(Exception e)
			{
				//MessageBox.Show(e.Message);
			}
			doFresh();
			return 1;
		}

		/// <summary>
		/// 重新加载listView
		/// </summary>
		private delegate void FreshUI();//不同线程之间无法修改控件，采用代理
		private void bindListView()
		{

			try
			{
				if (!imglist.Images.Empty)
				{
					for (int i = 0; i < imglist.Images.Count; i++)
					{
						//imglist.Images.Add(System.Drawing.Image.FromFile(imglist.Images[i].ToString()));
						imgView.Items.Add(System.IO.Path.GetFileName(imglist.Images.Keys[i]), i);
						imgView.Items[i].ImageIndex = i;
						imgView.Items[i].Name = imglist.Images[i].ToString();
					}
				}
				
			}catch(ArgumentOutOfRangeException ex)
			{
				//MessageBox.Show("操作中断！");
			}

		}
		private void doFresh()
		{
			FreshUI bindimage = new FreshUI(bindListView);
			this.Invoke(bindimage);

		}


		private delegate void FreshProc(int value);
		private void procBarStep(int  value)
		{
			System.Console.WriteLine("progress value  is " + value);
			progressBar.Value = value;
		}
		private void doProgress(int value)
		{
			FreshProc proc = new FreshProc(procBarStep);
			this.Invoke(proc, new object[] { value });

		}


		/// <summary>
		/// 将treeview定位到指定的path
		/// </summary>
		/// <param name="fullPath"></param>
		private void loadPath(String fullPath)
		{
			System.Console.WriteLine("load path " + fullPath);
			//TreeViewItems.GetNode(treeNodes, path);
			string[] paths = fullPath.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
			TreeNode fatherNode = null;
			String fatherPath = "";
			//展开磁盘节点
			TreeNode[] nodes = directoryTree.Nodes.Find(paths[0] + "\\", true);
			if (nodes.Length != 0)
			{
				//System.Console.WriteLine(paths[0]);
				nodes[0].Expand();
				fatherNode = nodes[0];
				fatherPath += paths[0] + "\\";
			}


			//展开非磁盘节点
			//System.Console.WriteLine(paths[1]);
			//System.Console.WriteLine(fatherNode.Nodes[0].Name);
			for (int i = 1; i < paths.Length; i++)
			{
				nodes = fatherNode.Nodes.Find(fatherPath + paths[i], true);
				if (nodes.Length != 0)
				{
					nodes[0].Expand();
					fatherNode = nodes[0];
					fatherPath += paths[i] + "\\";
				}
			}
			
		}

		private void imgView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			int index = imgView.Items.IndexOf(imgView.SelectedItems[0]);
			//System.Console.WriteLine("index:" + index);
			ImageViewer viewer = new ImageViewer(filePaths, index);
			//viewer.StartPosition = FormStartPosition.Manual;
			viewer.Show();
		}

		/// <summary>
		/// 从文件加载设置信息
		/// </summary>
		public void loadSetting()
		{
			String set = "Setting.txt";
			settingFromFile.Clear();
			if (!File.Exists(set))
			{
				//如果log文件不存在，就创建log文件
				FileStream fileStream = File.Create(set);
				fileStream.Close();
				System.Console.WriteLine("新建设置文件");
				initSettingFile(set);
			}
			StreamReader sr = new StreamReader(set, Encoding.UTF8);
			String line;
			try
			{
				while ((line = sr.ReadLine()) != null)
				{
					if (sr.EndOfStream)
						break;
					if (line.Length == 0)
						continue;
					String[] data = line.Split('=');
					settingFromFile.Add(data[0], data[1]);
				}
				sr.Close();
			}catch(Exception e)
			{
				//MessageBox.Show(e.Message);
			}
			try
			{

				defPath = settingFromFile["defPath"];
			}catch(Exception e)
			{
				MessageBox.Show("设置文件已损坏");
				File.Delete(set);
				loadPath(set);
			}
			
			

		}

		/// <summary>
		/// 对设置文件写入默认数据
		/// </summary>
		/// <param name="path"></param>
		private void initSettingFile(String path)
		{
			Dictionary<string, string> setting = new Dictionary<string, string>();
			setting.Add("defPath", "D:\\");
			setting.Add("png", "F");
			setting.Add("bmp", "F");
			setting.Add("gif", "F");
			setting.Add("tif", "F");
			setting.Add("webp", "F");

			FileInfo fi = new FileInfo(path);
			StreamWriter w;
			if (fi.Exists)
			{
				//从文件尾部写入数据
				w = fi.AppendText();

				foreach (var key in setting)
				{
					w.WriteLine(key.Key + "=" + key.Value + "\n");
				}
				w.Flush();
				w.Close();
				System.Console.WriteLine("写入文件完毕");
			}
		}

		private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			About about = new About();
			about.ShowDialog();
		}
	}
}
