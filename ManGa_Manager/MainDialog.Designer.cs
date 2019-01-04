namespace ManGa_Manager
{
	partial class MainDialog
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDialog));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.directoryTree = new System.Windows.Forms.TreeView();
			this.directoryIcons = new System.Windows.Forms.ImageList(this.components);
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.imgView = new System.Windows.Forms.ListView();
			this.imglist = new System.Windows.Forms.ImageList(this.components);
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.关于ToolStripMenuItem});
			resources.ApplyResources(this.menuStrip, "menuStrip");
			this.menuStrip.Name = "menuStrip";
			// 
			// 文件ToolStripMenuItem
			// 
			this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.退出ToolStripMenuItem});
			this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
			resources.ApplyResources(this.文件ToolStripMenuItem, "文件ToolStripMenuItem");
			// 
			// 打开ToolStripMenuItem
			// 
			this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
			resources.ApplyResources(this.打开ToolStripMenuItem, "打开ToolStripMenuItem");
			this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
			// 
			// 设置ToolStripMenuItem
			// 
			this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
			resources.ApplyResources(this.设置ToolStripMenuItem, "设置ToolStripMenuItem");
			this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
			// 
			// 退出ToolStripMenuItem
			// 
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			resources.ApplyResources(this.退出ToolStripMenuItem, "退出ToolStripMenuItem");
			this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
			// 
			// 关于ToolStripMenuItem
			// 
			this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem1});
			this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
			resources.ApplyResources(this.关于ToolStripMenuItem, "关于ToolStripMenuItem");
			this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
			// 
			// 关于ToolStripMenuItem1
			// 
			this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
			resources.ApplyResources(this.关于ToolStripMenuItem1, "关于ToolStripMenuItem1");
			this.关于ToolStripMenuItem1.Click += new System.EventHandler(this.关于ToolStripMenuItem1_Click);
			// 
			// directoryTree
			// 
			resources.ApplyResources(this.directoryTree, "directoryTree");
			this.directoryTree.ImageList = this.directoryIcons;
			this.directoryTree.Name = "directoryTree";
			this.directoryTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.directoryTree_BeforeExpand);
			this.directoryTree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.directoryTree_AfterExpand);
			this.directoryTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.directoryTree_NodeMouseClick);
			// 
			// directoryIcons
			// 
			this.directoryIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("directoryIcons.ImageStream")));
			this.directoryIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.directoryIcons.Images.SetKeyName(0, "computer.png");
			this.directoryIcons.Images.SetKeyName(1, "folder.png");
			this.directoryIcons.Images.SetKeyName(2, "folder-open.png");
			this.directoryIcons.Images.SetKeyName(3, "disk.png");
			this.directoryIcons.Images.SetKeyName(4, "folder_personal.png");
			// 
			// splitContainer1
			// 
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.directoryTree);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.progressBar);
			this.splitContainer1.Panel2.Controls.Add(this.imgView);
			// 
			// imgView
			// 
			resources.ApplyResources(this.imgView, "imgView");
			this.imgView.LargeImageList = this.imglist;
			this.imgView.Name = "imgView";
			this.imgView.UseCompatibleStateImageBehavior = false;
			this.imgView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.imgView_MouseDoubleClick);
			// 
			// imglist
			// 
			this.imglist.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			resources.ApplyResources(this.imglist, "imglist");
			this.imglist.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// progressBar
			// 
			resources.ApplyResources(this.progressBar, "progressBar");
			this.progressBar.Name = "progressBar";
			// 
			// MainDialog
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainDialog";
			this.Load += new System.EventHandler(this.MainDialog_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
		private System.Windows.Forms.TreeView directoryTree;
		private System.Windows.Forms.ImageList directoryIcons;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView imgView;
		private System.Windows.Forms.ImageList imglist;
		private System.Windows.Forms.ProgressBar progressBar;
	}
}