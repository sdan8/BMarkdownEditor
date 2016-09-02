using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMarkdownEditor
{
	public partial class MainForm : Form
	{

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			BtnVisible();
			toolStripStatusLabel1.Text = "BMarkdownEditor";
		}

		private void richTxt_markdown_TextChanged(object sender, EventArgs e)
		{
			string str = richTxt_markdown.Text;
			MarkdownDeep.Markdown markdown = new MarkdownDeep.Markdown(){	ExtraMode = true	};
			richTxt_html.Text = markdown.Transform(str);
			webBrowser1.DocumentText = markdown.Transform(str);

			toolStripStatusLabel1.Text = "BMarkdownEditor";
			if (Utils.EditorIO.FilePath != null)
			{
				toolStripStatusLabel2.Text = "<未保存>" + Utils.EditorIO.FilePath;
			}
			else
			{
				toolStripStatusLabel2.Text = "<未保存>未命名文件";
			}
			
		}


		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			BtnVisible();
		}
		

		private void btn_copyHtml_Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(richTxt_html.Text);
			MessageBox.Show("已复制到剪贴板！");
			
			toolStripStatusLabel1.Text = "已复制";
		}

		#region 菜单栏

		/// <summary>
		/// 新建
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (!Utils.EditorIO.Saved)
			{
				DialogResult dr = MessageBox.Show("文件还没有保存，是否忽略并继续？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				if (dr == DialogResult.Cancel)
					return;
				richTxt_markdown.Clear();
				Utils.EditorIO.FilePath = null;
			}
		}

		/// <summary>
		/// 打开
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			if (!Utils.EditorIO.Saved)
			{
				DialogResult dr = MessageBox.Show("文件还没有保存，是否忽略并继续？", "提示", MessageBoxButtons.OKCancel);
				if (dr == DialogResult.Cancel)
					return;
			}
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Markdown文本文件(*.md;*.markdown)|*.md;*.markdown";
			ofd.ShowDialog();
			if (!System.IO.File.Exists(ofd.FileName))
			{
				MessageBox.Show("打开的文件不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				Utils.EditorIO.Read(ofd.FileName, richTxt_markdown);

			}
			catch (Exception)
			{
				MessageBox.Show("打开文件失败！");
				return;
			}

			if (Utils.EditorIO.FilePath != null)
			{
				toolStripStatusLabel2.Text = "<未保存>" + Utils.EditorIO.FilePath;
			}
			else
			{
				toolStripStatusLabel2.Text = "<未保存>未命名文件";
			}
		}

		/// <summary>
		/// 保存
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 保存为MarkdownToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Utils.EditorIO.FilePath != null)
			{
				Utils.EditorIO.Save(richTxt_markdown);
				toolStripStatusLabel2.Text = "<已保存>" + Utils.EditorIO.FilePath;
				return;
			}

			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Markdown文本文件(*.md;*.markdown)|*.md;*.markdown";
			sfd.ShowDialog();

			Utils.EditorIO.Save(sfd.FileName, richTxt_markdown);
			toolStripStatusLabel2.Text = "<已保存>" + Utils.EditorIO.FilePath;
		}

		/// <summary>
		/// 另存为
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Markdown文本文件(*.md;*.markdown)|*.md;*.markdown";
			sfd.ShowDialog();
			Utils.EditorIO.Save(sfd.FileName, richTxt_markdown);
			if (Utils.EditorIO.Saved)
			{
				toolStripMenuItem2.Text = "<已保存>" + Utils.EditorIO.FilePath;
			}
		}

		/// <summary>
		/// 导出
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 导出为HTMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "html(*.html)|*.html";
			sfd.ShowDialog();
			try
			{
				Utils.EditorIO.SaveToHtml(sfd.FileName, richTxt_html);
				toolStripMenuItem1.Text = "<已导出>" + sfd.FileName;
			}
			catch (Exception)
			{
				MessageBox.Show("导出失败！");
				return;
			}
		}

		/// <summary>
		/// 退出
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// 全屏
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 全屏ToolStripMenuItem_Click(object sender, EventArgs e)
		{

			if (全屏ToolStripMenuItem.Checked)
			{
				this.FormBorderStyle = FormBorderStyle.None;
				this.WindowState = FormWindowState.Maximized;
				toolStripStatusLabel3.Text = "全屏模式 按F11退出全屏";
			}
			else
			{
				this.FormBorderStyle = FormBorderStyle.Sizable;
				this.WindowState = FormWindowState.Normal;
				toolStripStatusLabel3.Text = "按F11进入全屏模式";
			}
		}

		#endregion

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Utils.EditorIO.Saved && DialogResult.OK != MessageBox.Show("文件还没有保存，是否忽略并继续？", "提示",
			   MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
				e.Cancel = true; 
		}

		private void BtnVisible()
		{
			if (tabControl1.SelectedIndex == 0)
			{
				btn_copyHtml.Visible = false;
			}
			else
			{
				btn_copyHtml.Visible = true;
			}
		}

		private void MainForm_SizeChanged(object sender, EventArgs e)
		{
			richTxt_markdown.Location = new Point(40, 80);
			richTxt_markdown.Size = new Size((this.Size.Width - 120) / 2, this.Size.Height - 180);
			tabControl1.Location = new Point(richTxt_markdown.Size.Width + 80, 55);
			tabControl1.Size = new Size((this.Size.Width - 120) / 2, this.Size.Height - 150);
		}

	}
}
