using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManGa_Manager.Views
{
	public partial class Setting : Form
	{
		private String setFile = "Setting.txt";
		private Dictionary<string, string> settingFromFile = new Dictionary<string, string>();
		MainDialog parent;
		public Setting(String path,MainDialog parent)
		{
			setFile = path;
			readSetting(setFile);
			InitializeComponent();
			loadSetting(settingFromFile);
			this.parent = parent;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			writeSetting(setFile);
			parent.loadSetting();
			this.Dispose();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void button3_Click(object sender, EventArgs e)
		{

			System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
			dialog.Description = "请选择文件夹";
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				System.Console.WriteLine(dialog.SelectedPath);
				//reNameFiles(dialog.SelectedPath);
				defPathText.Text = dialog.SelectedPath;
				
			}
		}

		private void writeSetting(String path)
		{

			Dictionary<string, string> setting = new Dictionary<string, string>();

			setting.Clear();
			setting.Add("defPath", defPathText.Text);
			setting.Add("png", check_png.Checked == true ? "T" : "F");
			setting.Add("bmp", check_bmp.Checked == true ? "T" : "F");
			setting.Add("gif", check_gif.Checked == true ? "T" : "F");
			setting.Add("tif", check_tif.Checked == true ? "T" : "F");
			setting.Add("webp", check_webp.Checked == true ? "T" : "F");

			FileInfo fi = new FileInfo(path);
			StreamWriter w;
			if (fi.Exists)
			{
				//从文件尾部写入数据
				w = new StreamWriter(path);

				foreach (var key in setting)
				{
					w.WriteLine(key.Key + "=" + key.Value + "\n");
				}
				w.Flush();
				w.Close();
				System.Console.WriteLine("写入文件完毕");
			}
			setting.Clear();
		}

		/// <summary>
		/// 读取文件数据
		/// </summary>
		private void readSetting(String set)
		{
			//String set = "Setting.txt";
			settingFromFile.Clear();
			if (!File.Exists(set))
			{
				//如果log文件不存在，就创建log文件
				MessageBox.Show("文件损坏");
				//TODO initSettingFile
			}
			StreamReader sr = new StreamReader(set, Encoding.UTF8);
			String line;
			String[] data;
			try
			{
				while ((line = sr.ReadLine()) != null )
				{
					if (sr.EndOfStream)
						break;
					if (line.Length == 0)
						continue;
					System.Console.WriteLine(line);
					data = line.Split('=');
					settingFromFile.Add(data[0], data[1]);

				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			sr.Close();
			try
			{
				//无效数据测试
				String emptyTest;
				emptyTest = settingFromFile["defPath"];
				emptyTest = settingFromFile["png"];
				emptyTest = settingFromFile["bmp"];
				emptyTest = settingFromFile["gif"];
				emptyTest = settingFromFile["tif"];
				emptyTest = settingFromFile["webp"];
			}
			catch (Exception e)
			{
				MessageBox.Show("设置文件已损坏，重新启动程序");
				File.Delete(set);
			}



		}

		private void loadSetting(Dictionary<string, string> set)
		{
			defPathText.Text = set["defPath"];
			check_png.Checked = set["png"] == "T" ? true : false;
			check_bmp.Checked = set["bmp"] == "T" ? true : false;
			check_gif.Checked = set["gif"] == "T" ? true : false;
			check_tif.Checked = set["tif"] == "T" ? true : false;
			check_webp.Checked = set["webp"] == "T" ? true : false;
		}
	}
}
