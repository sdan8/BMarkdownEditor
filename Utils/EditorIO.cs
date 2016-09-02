using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMarkdownEditor.Utils
{
	public static class EditorIO
	{

		public static string FilePath	{ get; set; }
		public static bool Saved = false;

		public static void Read(string path, RichTextBox richTextBox)
		{
			
			try
			{
				richTextBox.Text = System.IO.File.ReadAllText(path, Encoding.UTF8);
			}
			catch (Exception)
			{
				MessageBox.Show("读取失败！");
				return;
			}
			FilePath = path;

		}


		public static void Save(RichTextBox richTextBox)
		{
			try
			{
				System.IO.File.WriteAllText(FilePath, richTextBox.Text, Encoding.UTF8);
			}
			catch (Exception)
			{
				MessageBox.Show("保存文件失败！");
			}
			Saved = true;
		}

		public static void Save(string path, RichTextBox richTextBox)
		{
			FilePath = path;
			Save(richTextBox);
		}

		public static void SaveToHtml(string path, RichTextBox richTextBox)
		{
			string header = "<!DOCTYPE html>\n<html>\n<head>\n<meta charset=\"UTF-8\">\n<title>title</title>\n</head>\n<body>";
			string footer = "</body>\n</html>";
			try
			{
				System.IO.File.WriteAllText(path, header + richTextBox.Text + footer, Encoding.UTF8);
			}
			catch (Exception)
			{
				MessageBox.Show("导出失败！");
				return;
			}
		}

		/// <summary>
		/// 保存为文章
		/// </summary>
		/// <param name="path"></param>
		/// <param name="richTextBox"></param>
		/// <param name="title"></param>
		public static void SaveToPost(string path, RichTextBox richTextBox, string title, string author)
		{
			
			string date = DateTime.Now.ToString("yyyy-M-d");
			string part1 = "";
			string part2 = "";
			string part3 = "";
			string part4 = "";
			string part5 = "";
			try
			{
				part1 = System.IO.File.ReadAllText(Application.StartupPath + "\\part1.xxx", Encoding.UTF8);
				part2 = System.IO.File.ReadAllText(Application.StartupPath + "\\part2.xxx", Encoding.UTF8);
				part3 = System.IO.File.ReadAllText(Application.StartupPath + "\\part3.xxx", Encoding.UTF8);
				part4 = System.IO.File.ReadAllText(Application.StartupPath + "\\part4.xxx", Encoding.UTF8);
				part5 = System.IO.File.ReadAllText(Application.StartupPath + "\\part5.xxx", Encoding.UTF8);
			}
			catch (Exception)
			{
				MessageBox.Show("读取文章模板失败！！");
				return;
			}

			string part = part1 + title + part2 + date + part3 + author + part4 + richTextBox.Text + part5;

			try
			{
				System.IO.File.WriteAllText(path, part, Encoding.UTF8);
			}
			catch (Exception)
			{
				MessageBox.Show("导出文章失败！");
				return;
			}
		}

	}
}
