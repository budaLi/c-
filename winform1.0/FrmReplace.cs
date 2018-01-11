using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Prana.Notepad
{
	/// <summary>
	/// FrmReplace 的摘要说明。
	/// </summary>
	public class FrmReplace : System.Windows.Forms.Form
    {// 下载于www.51aspx.com
		private System.Windows.Forms.CheckBox chkMatchCase;
		public System.Windows.Forms.TextBox txtFind;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnFind;
		public System.Windows.Forms.TextBox txtReplace;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnReplace;
		private System.Windows.Forms.Button btnReplaceAll;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmReplace()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 文件内容，与主窗体同步
		/// </summary>
		private System.Windows.Forms.RichTextBox txtContent;

		/// <summary>
		/// 重构FrmReplace窗体
		/// </summary>
		/// <param name="textBox1">txtContent</param>
		public FrmReplace(System.Windows.Forms.RichTextBox textBox1)
		{
			InitializeComponent();
			this.txtContent = textBox1;
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReplace));
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.Location = new System.Drawing.Point(40, 72);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(88, 24);
            this.chkMatchCase.TabIndex = 13;
            this.chkMatchCase.Text = "区分大小写";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(80, 8);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(232, 21);
            this.txtFind.TabIndex = 10;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "查找内容";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(328, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 24);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(328, 8);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(80, 24);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "查找下一个";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(80, 40);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(232, 21);
            this.txtReplace.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "替换为";
            // 
            // btnReplace
            // 
            this.btnReplace.Enabled = false;
            this.btnReplace.Location = new System.Drawing.Point(328, 37);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(80, 24);
            this.btnReplace.TabIndex = 16;
            this.btnReplace.Text = "替换";
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Enabled = false;
            this.btnReplaceAll.Location = new System.Drawing.Point(328, 66);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(80, 24);
            this.btnReplaceAll.TabIndex = 17;
            this.btnReplaceAll.Text = "全部替换";
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // FrmReplace
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(426, 135);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReplace";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "替换";
            this.Load += new System.EventHandler(this.FrmReplace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		/// <summary>
		///  替换
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnReplace_Click(object sender, System.EventArgs e)
		{
			//先检查文本选择内容与查找框中内容是否相同，相同则替换
			if (txtContent.SelectedText == txtFind.Text)
			{
				txtContent.SelectedText = txtReplace.Text;
				location += txtFind.Text.Length;
			}
			btnFind_Click(sender, e);
		}

		/// <summary>
		/// 全部替换
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnReplaceAll_Click(object sender, System.EventArgs e)
		{
			int numbers = 0;
			int start;
			int end;
			if (location == -1)
				start = 0;
			else
				start = location;
			end = txtContent.Text.Length - 1;
			//循环直到替换位置
			while (start!= end)
			{
				//根据大小写调用不同的搜索方法
				if (chkMatchCase.Checked)
				{
					location = txtContent.Find(txtFind.Text, start, end, RichTextBoxFinds.MatchCase);
				}
				else
				{
					location = txtContent.Find(txtFind.Text, start, end, RichTextBoxFinds.None);
				}
				//没有找到指定内容，跳出循环
				if (location == -1)
				{
					//MessageBox.Show(string.Format("没有找到 [ {0} ]！", txtFind.Text), "C#记事本", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;
				}
				else
				{
					//标记字符串位置
					numbers++;
					this.txtContent.Select(location, txtFind.Text.Length);
					this.txtContent.Focus();
					location += txtFind.Text.Length;
				}

				//替换找到指定的字符串
				if (txtContent.SelectedText == txtFind.Text)
				{
					txtContent.SelectedText = txtReplace.Text;
					location += txtFind.Text.Length;
				}
			}
			//如果一次都没找到字符串，给出提示
			if (numbers == 0)
			{
				MessageBox.Show(string.Format("没有找到 [ {0} ]！", txtFind.Text), "C#记事本", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		 private int location = -1;

		/// <summary>
		/// 查找功能的实现，与查找窗体功能相同
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnFind_Click(object sender, System.EventArgs e)
		{
			int start;
			int end;
			if (location == -1)
			{
				if (txtContent.SelectionStart < txtContent.Text.Length)
					start = txtContent.SelectionStart;
				else
					start = txtContent.Text.Length - 1;
			}
			else
				start = location;
			end = txtContent.Text.Length-1;
			if (chkMatchCase.Checked)
			{
				location = txtContent.Find(txtFind.Text , start, end, RichTextBoxFinds.MatchCase);
			}
			else
			{
				location = txtContent.Find(txtFind.Text, start, end, RichTextBoxFinds.None);
			}
			if (location == -1)
			{
				//显示未找到指定字符串
				MessageBox.Show(string.Format("没有找到 [ {0} ]！", txtFind.Text), "C#记事本", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				this.txtContent .Select(location, txtFind.Text.Length);
				this.txtContent.Focus();
				location += txtFind.Text.Length;
			}
		}

		private void txtFind_TextChanged(object sender, System.EventArgs e)
		{
			if(txtFind.Text.Length > 0)
			{
				btnFind.Enabled = true;
				btnReplace.Enabled = true;
				btnReplaceAll.Enabled = true;
			}
			else 
			{
				btnFind.Enabled = false ;
				btnReplace.Enabled = false;
				btnReplaceAll.Enabled = false;
			}
		}

		private void FrmReplace_Load(object sender, System.EventArgs e)
		{
			 this.txtFind.Focus();
		}
	}
}
