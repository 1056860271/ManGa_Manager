using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManGa_Manager
{


	/// <summary>
	/// 自定义类TreeViewItems 调用其Add(TreeNode e)方法加载子目录
	/// </summary>
	public static class TreeViewItems
	{
		public static void Add(TreeNode e)
		{
			//try..catch异常处理
			try
			{
				//判断"我的电脑"Tag 上面加载的该结点没指定其路径
				if (e.Tag.ToString() != "我的电脑")
				{
					e.Nodes.Clear();                               //清除空节点再加载子节点
					TreeNode tNode = e;                            //获取选中\展开\折叠结点
					string path = tNode.Name;                      //路径  

					//获取"我的文档"路径
					if (e.Tag.ToString() == "我的文档")
					{
						path = Environment.GetFolderPath           //获取计算机我的文档文件夹
							(Environment.SpecialFolder.MyDocuments);
					}

					//获取指定目录中的子目录名称并加载结点
					string[] dics = Directory.GetDirectories(path);
					foreach (string dic in dics)
					{ 
						try
						{
							TreeNode subNode = new TreeNode(new DirectoryInfo(dic).Name); //实例化
							subNode.Name = new DirectoryInfo(dic).FullName;               //完整目录
							subNode.Tag = subNode.Name;
							subNode.ImageIndex = IconIndexes.ClosedFolder;       //获取节点显示图片
							subNode.SelectedImageIndex = IconIndexes.OpenFolder; //选择节点显示图片
							tNode.Nodes.Add(subNode);
							subNode.Nodes.Add("");                               //加载空节点 实现+号
						}catch(System.IO.PathTooLongException ex)
						{
							//MessageBox.Show(ex.Message);
						}
					}
				}
			}
			catch (Exception msg)
			{
				MessageBox.Show(msg.Message);                   //异常处理
			}
		}

		/// <summary>
        /// 通过fullpath 查找treeview节点 节点name属性需要赋过值
        /// </summary>
        /// <param name="nodes">TreeNodeCollection node集合</param>
        /// <param name="fullPath">要查找的节点的fullPath</param>
        /// <returns></returns>
		public static TreeNode GetNode(TreeNodeCollection nodes, string fullPath)
        {
            string[] paths = fullPath.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries); 
            TreeNode tn = null;
            if (paths.Length >0)
            {
                string lastPath = paths[paths.Length - 1]; 
                var finds = nodes.Find(lastPath, true);
                if (finds.Length > 0)
                {
                    foreach (var item in finds)
                    {
						Add(item);
                        if (item.FullPath == fullPath)
                        {
                            tn  = item;
							tn.Expand();
                            break;
                        }
                    }  
                }  
            } 
            return tn;
        }


	}
}
