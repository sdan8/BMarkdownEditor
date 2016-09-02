namespace BMarkdownEditor
{
	partial class Frm_Input
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
			this.label1 = new System.Windows.Forms.Label();
			this.txt_title = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_author = new System.Windows.Forms.TextBox();
			this.btn_ok = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "请输入文章标题：";
			// 
			// txt_title
			// 
			this.txt_title.Location = new System.Drawing.Point(127, 23);
			this.txt_title.Name = "txt_title";
			this.txt_title.Size = new System.Drawing.Size(207, 21);
			this.txt_title.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "请输入作者：";
			// 
			// txt_author
			// 
			this.txt_author.Location = new System.Drawing.Point(127, 55);
			this.txt_author.Name = "txt_author";
			this.txt_author.Size = new System.Drawing.Size(207, 21);
			this.txt_author.TabIndex = 3;
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(362, 53);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(75, 23);
			this.btn_ok.TabIndex = 4;
			this.btn_ok.Text = "确定";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
			// 
			// Frm_Input
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 103);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.txt_author);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_title);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Frm_Input";
			this.Text = "输入";
			this.Load += new System.EventHandler(this.Frm_Input_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_title;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_author;
		private System.Windows.Forms.Button btn_ok;
	}
}