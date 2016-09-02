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
	public partial class Frm_Input : Form
	{
		private string _titleValue;
		public string titleValue
		{
			get	{	return _titleValue;	}
			set	{	_titleValue = value;	}
		}

		private string _authorValue;
		public string authorValue
		{
			get	{	return _authorValue;	}
			set	{	_authorValue = value;	}
		}

		public Frm_Input()
		{
			InitializeComponent();
		}

		private void Frm_Input_Load(object sender, EventArgs e)
		{
			txt_author.Text = "sdan8";
		}

		private void btn_ok_Click(object sender, EventArgs e)
		{
			if (txt_author.Text.Trim() == "" || txt_title.Text.Trim() == "")
			{
				MessageBox.Show("请填写完整！");
			}
			else
			{
				_authorValue = txt_author.Text.Trim();
				_titleValue = txt_title.Text.Trim();
				this.Close();
			}
		}
	}
}
