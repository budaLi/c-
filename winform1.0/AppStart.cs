using System;
using System.Windows.Forms;

namespace Prana.Notepad
{
	/// <summary>
	/// AppStart 的摘要说明。
	/// </summary>
	public class AppStart
	{
		public AppStart()
		{
			// 下载于www.51aspx.com
			// TODO: 在此处添加构造函数逻辑
			//
		}

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FrmMain());
		}
	}
}
