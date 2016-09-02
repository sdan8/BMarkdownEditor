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

	}
}
