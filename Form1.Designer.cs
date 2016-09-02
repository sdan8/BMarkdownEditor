namespace BMarkdownEditor
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPg_preview = new System.Windows.Forms.TabPage();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.tabPg_html = new System.Windows.Forms.TabPage();
			this.richTxt_html = new System.Windows.Forms.RichTextBox();
			this.richTxt_markdown = new System.Windows.Forms.RichTextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.保存为MarkdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.导出为HTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.全屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_copyHtml = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel_line = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel_line2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmi_post = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1.SuspendLayout();
			this.tabPg_preview.SuspendLayout();
			this.tabPg_html.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControl1.Controls.Add(this.tabPg_preview);
			this.tabControl1.Controls.Add(this.tabPg_html);
			this.tabControl1.Location = new System.Drawing.Point(670, 55);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(590, 560);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPg_preview
			// 
			this.tabPg_preview.Controls.Add(this.webBrowser1);
			this.tabPg_preview.Location = new System.Drawing.Point(4, 25);
			this.tabPg_preview.Name = "tabPg_preview";
			this.tabPg_preview.Padding = new System.Windows.Forms.Padding(3);
			this.tabPg_preview.Size = new System.Drawing.Size(582, 531);
			this.tabPg_preview.TabIndex = 0;
			this.tabPg_preview.Text = "预览";
			this.tabPg_preview.UseVisualStyleBackColor = true;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 3);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(576, 525);
			this.webBrowser1.TabIndex = 0;
			// 
			// tabPg_html
			// 
			this.tabPg_html.Controls.Add(this.richTxt_html);
			this.tabPg_html.Location = new System.Drawing.Point(4, 25);
			this.tabPg_html.Name = "tabPg_html";
			this.tabPg_html.Padding = new System.Windows.Forms.Padding(3);
			this.tabPg_html.Size = new System.Drawing.Size(582, 531);
			this.tabPg_html.TabIndex = 1;
			this.tabPg_html.Text = "HTML";
			this.tabPg_html.UseVisualStyleBackColor = true;
			// 
			// richTxt_html
			// 
			this.richTxt_html.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTxt_html.Location = new System.Drawing.Point(0, 0);
			this.richTxt_html.Name = "richTxt_html";
			this.richTxt_html.Size = new System.Drawing.Size(567, 506);
			this.richTxt_html.TabIndex = 0;
			this.richTxt_html.Text = "";
			// 
			// richTxt_markdown
			// 
			this.richTxt_markdown.AcceptsTab = true;
			this.richTxt_markdown.Location = new System.Drawing.Point(40, 80);
			this.richTxt_markdown.Name = "richTxt_markdown";
			this.richTxt_markdown.Size = new System.Drawing.Size(590, 530);
			this.richTxt_markdown.TabIndex = 1;
			this.richTxt_markdown.Text = "";
			this.richTxt_markdown.TextChanged += new System.EventHandler(this.richTxt_markdown_TextChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.全屏ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 文件ToolStripMenuItem
			// 
			this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.保存为MarkdownToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.导出为HTMLToolStripMenuItem,
            this.tsmi_post,
            this.toolStripSeparator2,
            this.退出EToolStripMenuItem});
			this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
			this.文件ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.文件ToolStripMenuItem.Text = "文件(&F)";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
			this.toolStripMenuItem1.Text = "新建(&N)";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 22);
			this.toolStripMenuItem2.Text = "打开(&O)";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// 保存为MarkdownToolStripMenuItem
			// 
			this.保存为MarkdownToolStripMenuItem.Name = "保存为MarkdownToolStripMenuItem";
			this.保存为MarkdownToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.保存为MarkdownToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.保存为MarkdownToolStripMenuItem.Text = "保存(&S)";
			this.保存为MarkdownToolStripMenuItem.Click += new System.EventHandler(this.保存为MarkdownToolStripMenuItem_Click);
			// 
			// 另存为ToolStripMenuItem
			// 
			this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
			this.另存为ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.另存为ToolStripMenuItem.Text = "另存为(&A)";
			this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
			// 
			// 导出为HTMLToolStripMenuItem
			// 
			this.导出为HTMLToolStripMenuItem.Name = "导出为HTMLToolStripMenuItem";
			this.导出为HTMLToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.导出为HTMLToolStripMenuItem.Text = "导出为HTML";
			this.导出为HTMLToolStripMenuItem.Click += new System.EventHandler(this.导出为HTMLToolStripMenuItem_Click);
			// 
			// 退出EToolStripMenuItem
			// 
			this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
			this.退出EToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.退出EToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.退出EToolStripMenuItem.Text = "退出(&X)";
			this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
			// 
			// 全屏ToolStripMenuItem
			// 
			this.全屏ToolStripMenuItem.CheckOnClick = true;
			this.全屏ToolStripMenuItem.Name = "全屏ToolStripMenuItem";
			this.全屏ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
			this.全屏ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.全屏ToolStripMenuItem.Text = "全屏";
			this.全屏ToolStripMenuItem.Click += new System.EventHandler(this.全屏ToolStripMenuItem_Click);
			// 
			// btn_copyHtml
			// 
			this.btn_copyHtml.Location = new System.Drawing.Point(709, 612);
			this.btn_copyHtml.Name = "btn_copyHtml";
			this.btn_copyHtml.Size = new System.Drawing.Size(75, 23);
			this.btn_copyHtml.TabIndex = 3;
			this.btn_copyHtml.Text = "复制HTML";
			this.btn_copyHtml.UseVisualStyleBackColor = true;
			this.btn_copyHtml.Click += new System.EventHandler(this.btn_copyHtml_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_line,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_line2,
            this.toolStripStatusLabel3});
			this.statusStrip1.Location = new System.Drawing.Point(0, 649);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(91, 17);
			this.toolStripStatusLabel1.Text = "aaaaaaaaaaaa";
			// 
			// toolStripStatusLabel_line
			// 
			this.toolStripStatusLabel_line.Name = "toolStripStatusLabel_line";
			this.toolStripStatusLabel_line.Size = new System.Drawing.Size(10, 17);
			this.toolStripStatusLabel_line.Text = "|";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel_line2
			// 
			this.toolStripStatusLabel_line2.Name = "toolStripStatusLabel_line2";
			this.toolStripStatusLabel_line2.Size = new System.Drawing.Size(10, 17);
			this.toolStripStatusLabel_line2.Text = "|";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(111, 17);
			this.toolStripStatusLabel3.Text = "按F11进入全屏模式";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
			// 
			// tsmi_post
			// 
			this.tsmi_post.Name = "tsmi_post";
			this.tsmi_post.Size = new System.Drawing.Size(203, 22);
			this.tsmi_post.Text = "导出文章";
			this.tsmi_post.Click += new System.EventHandler(this.tsmi_post_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1284, 671);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btn_copyHtml);
			this.Controls.Add(this.richTxt_markdown);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(1300, 710);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BMarkdownEditor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
			this.tabControl1.ResumeLayout(false);
			this.tabPg_preview.ResumeLayout(false);
			this.tabPg_html.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPg_preview;
		private System.Windows.Forms.TabPage tabPg_html;
		private System.Windows.Forms.RichTextBox richTxt_markdown;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.RichTextBox richTxt_html;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button btn_copyHtml;
		private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存为MarkdownToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 导出为HTMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem 全屏ToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_line;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_line2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem tsmi_post;
	}
}

