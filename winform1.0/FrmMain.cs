using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text;

namespace Prana.Notepad
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class FrmMain : System.Windows.Forms.Form
    {// 下载于www.51aspx.com
		private System.Drawing.Printing.PrintDocument printDoc;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuFile_New;
		private System.Windows.Forms.MenuItem menuFile_Open;
		private System.Windows.Forms.MenuItem menuFile_Save;
		private System.Windows.Forms.MenuItem menuFile_SaveAs;
		private System.Windows.Forms.MenuItem menuFile_Line1;
		private System.Windows.Forms.MenuItem menuFile_Print;
		private System.Windows.Forms.MenuItem menuFile_Line2;
		private System.Windows.Forms.MenuItem menuFile_Exit;
		private System.Windows.Forms.MenuItem menuEdit;
		private System.Windows.Forms.MenuItem menuEdit_Undo;
		private System.Windows.Forms.MenuItem menuEdit_Redo;
		private System.Windows.Forms.MenuItem menuEdit_Cut;
		private System.Windows.Forms.MenuItem menuEdit_Copy;
		private System.Windows.Forms.MenuItem menuEdit_Paste;
		private System.Windows.Forms.MenuItem menuEdit_All;
		private System.Windows.Forms.MenuItem menuHelp;
		private System.Windows.Forms.MenuItem menuHelp_About;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		public System.Windows.Forms.RichTextBox txtContent;
		private System.Windows.Forms.ToolBar tbMain;
		private System.Windows.Forms.MenuItem menuFile_SaveAsRTF;
		private System.Windows.Forms.MenuItem menuStyle;
		private System.Windows.Forms.MenuItem menuStyle_Font;
		private System.Windows.Forms.MenuItem menuStyle_Color;
		private System.Windows.Forms.MenuItem menuLook;
		private System.Windows.Forms.MenuItem menuLook_Status;
		private System.Windows.Forms.StatusBar statusBarMain;
		private System.Windows.Forms.StatusBarPanel stbTime;
		private System.Windows.Forms.MenuItem menuLook_Tool;
		private System.Windows.Forms.StatusBarPanel stbMouse;
		private System.Windows.Forms.StatusBarPanel stbFileName;
		private System.Windows.Forms.MenuItem menuEdit_Del;
		private System.Windows.Forms.ContextMenu contextMenu;
		private System.Windows.Forms.MenuItem menuEdit_Line01;
		private System.Windows.Forms.MenuItem menuEdit_Line02;
		private System.Windows.Forms.MenuItem menuEdit_Line03;
		private System.Windows.Forms.MenuItem menuFind_Find;
		private System.Windows.Forms.MenuItem menuFind_Replace;
		private System.Windows.Forms.MenuItem menuFind;
        private System.Windows.Forms.MenuItem menuFind_Time;
        private StatusBarPanel stbPrana;
        private Timer timer1;
		private System.ComponentModel.IContainer components;

		public FrmMain()
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
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuFile_New = new System.Windows.Forms.MenuItem();
            this.menuFile_Open = new System.Windows.Forms.MenuItem();
            this.menuFile_Save = new System.Windows.Forms.MenuItem();
            this.menuFile_SaveAs = new System.Windows.Forms.MenuItem();
            this.menuFile_SaveAsRTF = new System.Windows.Forms.MenuItem();
            this.menuFile_Line1 = new System.Windows.Forms.MenuItem();
            this.menuFile_Print = new System.Windows.Forms.MenuItem();
            this.menuFile_Line2 = new System.Windows.Forms.MenuItem();
            this.menuFile_Exit = new System.Windows.Forms.MenuItem();
            this.menuEdit = new System.Windows.Forms.MenuItem();
            this.menuEdit_Undo = new System.Windows.Forms.MenuItem();
            this.menuEdit_Redo = new System.Windows.Forms.MenuItem();
            this.menuEdit_Line01 = new System.Windows.Forms.MenuItem();
            this.menuEdit_Cut = new System.Windows.Forms.MenuItem();
            this.menuEdit_Copy = new System.Windows.Forms.MenuItem();
            this.menuEdit_Paste = new System.Windows.Forms.MenuItem();
            this.menuEdit_Del = new System.Windows.Forms.MenuItem();
            this.menuEdit_Line03 = new System.Windows.Forms.MenuItem();
            this.menuEdit_All = new System.Windows.Forms.MenuItem();
            this.menuFind = new System.Windows.Forms.MenuItem();
            this.menuFind_Find = new System.Windows.Forms.MenuItem();
            this.menuFind_Replace = new System.Windows.Forms.MenuItem();
            this.menuEdit_Line02 = new System.Windows.Forms.MenuItem();
            this.menuFind_Time = new System.Windows.Forms.MenuItem();
            this.menuStyle = new System.Windows.Forms.MenuItem();
            this.menuStyle_Font = new System.Windows.Forms.MenuItem();
            this.menuStyle_Color = new System.Windows.Forms.MenuItem();
            this.menuLook = new System.Windows.Forms.MenuItem();
            this.menuLook_Status = new System.Windows.Forms.MenuItem();
            this.menuLook_Tool = new System.Windows.Forms.MenuItem();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.menuHelp_About = new System.Windows.Forms.MenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbMain = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.statusBarMain = new System.Windows.Forms.StatusBar();
            this.stbPrana = new System.Windows.Forms.StatusBarPanel();
            this.stbFileName = new System.Windows.Forms.StatusBarPanel();
            this.stbTime = new System.Windows.Forms.StatusBarPanel();
            this.stbMouse = new System.Windows.Forms.StatusBarPanel();
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stbPrana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stbFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stbMouse)).BeginInit();
            this.SuspendLayout();
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuFind,
            this.menuStyle,
            this.menuLook,
            this.menuHelp});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile_New,
            this.menuFile_Open,
            this.menuFile_Save,
            this.menuFile_SaveAs,
            this.menuFile_SaveAsRTF,
            this.menuFile_Line1,
            this.menuFile_Print,
            this.menuFile_Line2,
            this.menuFile_Exit});
            this.menuFile.Text = "文件";
            // 
            // menuFile_New
            // 
            this.menuFile_New.Index = 0;
            this.menuFile_New.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuFile_New.Text = "新建";
            this.menuFile_New.Click += new System.EventHandler(this.menuFile_New_Click);
            // 
            // menuFile_Open
            // 
            this.menuFile_Open.Index = 1;
            this.menuFile_Open.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuFile_Open.Text = "打开";
            this.menuFile_Open.Click += new System.EventHandler(this.menuFile_Open_Click);
            // 
            // menuFile_Save
            // 
            this.menuFile_Save.Index = 2;
            this.menuFile_Save.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuFile_Save.Text = "保存";
            this.menuFile_Save.Click += new System.EventHandler(this.menuFile_Save_Click);
            // 
            // menuFile_SaveAs
            // 
            this.menuFile_SaveAs.Index = 3;
            this.menuFile_SaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.menuFile_SaveAs.Text = "保存为Txt格式";
            this.menuFile_SaveAs.Click += new System.EventHandler(this.menuFile_SaveAs_Click);
            // 
            // menuFile_SaveAsRTF
            // 
            this.menuFile_SaveAsRTF.Index = 4;
            this.menuFile_SaveAsRTF.Shortcut = System.Windows.Forms.Shortcut.CtrlT;
            this.menuFile_SaveAsRTF.Text = "保存为RTF格式";
            this.menuFile_SaveAsRTF.Click += new System.EventHandler(this.menuFile_SaveAsRTF_Click);
            // 
            // menuFile_Line1
            // 
            this.menuFile_Line1.Index = 5;
            this.menuFile_Line1.Text = "-";
            // 
            // menuFile_Print
            // 
            this.menuFile_Print.Index = 6;
            this.menuFile_Print.Text = "打印";
            this.menuFile_Print.Click += new System.EventHandler(this.menuFile_Print_Click);
            // 
            // menuFile_Line2
            // 
            this.menuFile_Line2.Index = 7;
            this.menuFile_Line2.Text = "-";
            // 
            // menuFile_Exit
            // 
            this.menuFile_Exit.Index = 8;
            this.menuFile_Exit.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.menuFile_Exit.Text = "退出";
            this.menuFile_Exit.Click += new System.EventHandler(this.menuFile_Exit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.Index = 1;
            this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuEdit_Undo,
            this.menuEdit_Redo,
            this.menuEdit_Line01,
            this.menuEdit_Cut,
            this.menuEdit_Copy,
            this.menuEdit_Paste,
            this.menuEdit_Del,
            this.menuEdit_Line03,
            this.menuEdit_All});
            this.menuEdit.Text = "编辑";
            // 
            // menuEdit_Undo
            // 
            this.menuEdit_Undo.Index = 0;
            this.menuEdit_Undo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.menuEdit_Undo.Text = "撤消";
            this.menuEdit_Undo.Click += new System.EventHandler(this.menuEdit_Undo_Click);
            // 
            // menuEdit_Redo
            // 
            this.menuEdit_Redo.Index = 1;
            this.menuEdit_Redo.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.menuEdit_Redo.Text = "重做";
            this.menuEdit_Redo.Click += new System.EventHandler(this.menuEdit_Redo_Click);
            // 
            // menuEdit_Line01
            // 
            this.menuEdit_Line01.Index = 2;
            this.menuEdit_Line01.Text = "-";
            // 
            // menuEdit_Cut
            // 
            this.menuEdit_Cut.Index = 3;
            this.menuEdit_Cut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuEdit_Cut.Text = "剪切";
            this.menuEdit_Cut.Click += new System.EventHandler(this.menuEdit_Cut_Click);
            // 
            // menuEdit_Copy
            // 
            this.menuEdit_Copy.Index = 4;
            this.menuEdit_Copy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.menuEdit_Copy.Text = "复制";
            this.menuEdit_Copy.Click += new System.EventHandler(this.menuEdit_Copy_Click);
            // 
            // menuEdit_Paste
            // 
            this.menuEdit_Paste.Index = 5;
            this.menuEdit_Paste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.menuEdit_Paste.Text = "粘贴";
            this.menuEdit_Paste.Click += new System.EventHandler(this.menuEdit_Paste_Click);
            // 
            // menuEdit_Del
            // 
            this.menuEdit_Del.Index = 6;
            this.menuEdit_Del.Text = "删除";
            this.menuEdit_Del.Click += new System.EventHandler(this.menuEdit_Del_Click);
            // 
            // menuEdit_Line03
            // 
            this.menuEdit_Line03.Index = 7;
            this.menuEdit_Line03.Text = "-";
            // 
            // menuEdit_All
            // 
            this.menuEdit_All.Index = 8;
            this.menuEdit_All.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.menuEdit_All.Text = "全选";
            this.menuEdit_All.Click += new System.EventHandler(this.menuEdit_All_Click);
            // 
            // menuFind
            // 
            this.menuFind.Index = 2;
            this.menuFind.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFind_Find,
            this.menuFind_Replace,
            this.menuEdit_Line02,
            this.menuFind_Time});
            this.menuFind.Text = "查找";
            // 
            // menuFind_Find
            // 
            this.menuFind_Find.Index = 0;
            this.menuFind_Find.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.menuFind_Find.Text = "查找";
            this.menuFind_Find.Click += new System.EventHandler(this.menuFind_Find_Click);
            // 
            // menuFind_Replace
            // 
            this.menuFind_Replace.Index = 1;
            this.menuFind_Replace.Text = "替换";
            this.menuFind_Replace.Click += new System.EventHandler(this.menuFind_Replace_Click);
            // 
            // menuEdit_Line02
            // 
            this.menuEdit_Line02.Index = 2;
            this.menuEdit_Line02.Text = "-";
            // 
            // menuFind_Time
            // 
            this.menuFind_Time.Index = 3;
            this.menuFind_Time.Text = "日期时间";
            this.menuFind_Time.Click += new System.EventHandler(this.menuFind_Time_Click);
            // 
            // menuStyle
            // 
            this.menuStyle.Index = 4;
            this.menuStyle.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuStyle_Font,
            this.menuStyle_Color});
            this.menuStyle.Text = "格式";
            // 
            // menuStyle_Font
            // 
            this.menuStyle_Font.Index = 0;
            this.menuStyle_Font.Text = "字体";
            this.menuStyle_Font.Click += new System.EventHandler(this.menuStyle_Font_Click);
            // 
            // menuStyle_Color
            // 
            this.menuStyle_Color.Index = 1;
            this.menuStyle_Color.Text = "颜色";
            this.menuStyle_Color.Click += new System.EventHandler(this.menuStyle_Color_Click);
            // 
            // menuLook
            // 
            this.menuLook.Index = 5;
            this.menuLook.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuLook_Status,
            this.menuLook_Tool});
            this.menuLook.Text = "查看";
            // 
            // menuLook_Status
            // 
            this.menuLook_Status.Index = 0;
            this.menuLook_Status.Text = "状态栏";
            this.menuLook_Status.Click += new System.EventHandler(this.menuLook_Status_Click);
            // 
            // menuLook_Tool
            // 
            this.menuLook_Tool.Checked = true;
            this.menuLook_Tool.Index = 1;
            this.menuLook_Tool.Text = "工具栏";
            this.menuLook_Tool.Click += new System.EventHandler(this.menuLook_Tool_Click);
            // 
            // menuHelp
            // 
          //  this.menuHelp.Index = 6;
            this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuHelp_About});
            this.menuHelp.Text = "帮助";
            // 
            // menuHelp_About
            // 
          this.menuHelp_About.Index = 0;
            this.menuHelp_About.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.menuHelp_About.Text = "关于...";
            this.menuHelp_About.Click += new System.EventHandler(this.menuHelp_About_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // tbMain
            // 
            this.tbMain.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbMain.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3,
            this.toolBarButton4,
            this.toolBarButton5,
            this.toolBarButton6,
            this.toolBarButton7});
            this.tbMain.Divider = false;
            this.tbMain.DropDownArrows = true;
            this.tbMain.ImageList = this.imageList1;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.ShowToolTips = true;
            this.tbMain.Size = new System.Drawing.Size(424, 38);
            this.tbMain.TabIndex = 3;
            this.tbMain.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbMain_ButtonClick);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Tag = "1";
            this.toolBarButton1.Text = "新建";
            this.toolBarButton1.ToolTipText = "新建一个文档";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Tag = "2";
            this.toolBarButton2.Text = "打开";
            this.toolBarButton2.ToolTipText = "打开文件";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 2;
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Tag = "3";
            this.toolBarButton3.Text = "保存";
            this.toolBarButton3.ToolTipText = "保存文件";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.ImageIndex = 3;
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Tag = "5";
            this.toolBarButton5.Text = "剪切";
            this.toolBarButton5.ToolTipText = "剪切文本";
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.ImageIndex = 4;
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.Tag = "6";
            this.toolBarButton6.Text = "复制";
            this.toolBarButton6.ToolTipText = "复制文本";
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.ImageIndex = 5;
            this.toolBarButton7.Name = "toolBarButton7";
            this.toolBarButton7.Tag = "7";
            this.toolBarButton7.Text = "粘贴";
            this.toolBarButton7.ToolTipText = "粘贴文本";
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.AutoSize = true;
            this.txtContent.AutoWordSelection = true;
            this.txtContent.Location = new System.Drawing.Point(0, 38);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(424, 216);
            this.txtContent.TabIndex = 4;
            this.txtContent.Text = "";
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            this.txtContent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtContent_MouseMove);
            // 
            // statusBarMain
            // 
            this.statusBarMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBarMain.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBarMain.Location = new System.Drawing.Point(0, 232);
            this.statusBarMain.Name = "statusBarMain";
            this.statusBarMain.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.stbPrana,
            this.stbFileName,
            this.stbTime,
            this.stbMouse});
            this.statusBarMain.ShowPanels = true;
            this.statusBarMain.Size = new System.Drawing.Size(424, 22);
            this.statusBarMain.TabIndex = 6;
            this.statusBarMain.Text = "statusBar1";
            this.statusBarMain.Visible = false;
            this.statusBarMain.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.statusBarMain_PanelClick);
            // 
            // stbPrana
            // 
            this.stbPrana.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.stbPrana.Name = "stbPrana";
            this.stbPrana.Text = "三人组";
            this.stbPrana.Width = 52;
            // 
            // stbFileName
            // 
            this.stbFileName.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.stbFileName.Name = "stbFileName";
            this.stbFileName.Width = 10;
            // 
            // stbTime
            // 
            this.stbTime.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.stbTime.Name = "stbTime";
            this.stbTime.Width = 10;
            // 
            // stbMouse
            // 
            this.stbMouse.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.stbMouse.Name = "stbMouse";
            this.stbMouse.Width = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(424, 254);
            this.Controls.Add(this.statusBarMain);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.tbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "记事本";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FrmMain_Closing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stbPrana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stbFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stbMouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// 新建文件
		/// </summary>
		private void NewFile()
		{
			txtContent.Clear();
            stbFileName.Text = "无标题 - 记事本";
		}

		private void menuFile_New_Click(object sender, System.EventArgs e)
		{
			NewFile();
		}

		private void tbMain_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch(e.Button.Text)
			{
				case "新建":
				{
					NewFile();
					break;
				}
				case "打开":
				{
					OpenFile();
					break;
				}
				case "保存":
				{
					SaveFile(strPathName);
					break;
				}
				case "剪切":
				{
					FileCut();
					break;
				}
				case "复制":
				{
					this.FileCopy();
					break;
				}
				case "粘贴":
				{
					FilePaste();
					break;
				}
				default:
				{
					MessageBox.Show("三人组记事本！！！", "信息提示", MessageBoxButtons.OK);
					break;
				}
			}
		}

		private string strPathName = null;
        private string strFileName = "Prana.txt";
		private bool bWrite = false;

		/// <summary>
		/// 打开对话框
		/// </summary>
		private void OpenFile()
		{
			System.Windows.Forms.OpenFileDialog openDlg = new OpenFileDialog();
			openDlg.Filter = "*.txt|*.txt|*.*|*.*";
			openDlg.InitialDirectory = System.Environment.CurrentDirectory;
			if (openDlg.ShowDialog() == DialogResult.OK)
			{
				strPathName = openDlg.FileName;
				StreamReader objSR = new StreamReader(strPathName, Encoding.Default);
				txtContent.Text = objSR.ReadToEnd();
				objSR.Close();
				stbFileName.Text = strPathName;
			}
		}

		private void menuFile_Open_Click(object sender, System.EventArgs e)
		{
			OpenFile();
		}

		private void SaveFile(string PathName)
		{
			if(PathName == null)
			{
				System.Windows.Forms.SaveFileDialog saveDlg = new SaveFileDialog();
				saveDlg.Filter = "*.txt|*.txt";
				saveDlg.InitialDirectory = System.Environment.CurrentDirectory;
				saveDlg.FileName = strFileName;
				if (saveDlg.ShowDialog() == DialogResult.OK)
				{
					strPathName = saveDlg.FileName;
				}
			}
			if (strPathName != null)
			{
				StreamWriter objSW = new StreamWriter(strPathName, true);
				objSW.Write(txtContent.Text);
				objSW.Close();
				bWrite = false;
			}
			stbFileName.Text = strPathName;
		}

		private void menuFile_Save_Click(object sender, System.EventArgs e)
		{
			SaveFile(strPathName);
		}

		private void menuFile_SaveAs_Click(object sender, System.EventArgs e)
		{
			SaveFile(null);
		}

		private void menuFile_Exit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuFile_Print_Click(object sender, System.EventArgs e)
		{
			PrintFile();
		}

		/// <summary>
		/// 打印操作
		/// </summary>
		private void PrintFile()
		{
			PrintDialog PrintDlg = new PrintDialog();
			PrintDlg.Document = printDoc;
			if (PrintDlg.ShowDialog() == DialogResult.OK)
				printDoc.Print();
		}

		private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString(txtContent.Text, new Font("宋体", 13, FontStyle.Regular), Brushes.Black, 100, 200);
		}

		private void txtContent_TextChanged(object sender, System.EventArgs e)
		{
			bWrite = true;
		}

		private void FrmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(bWrite)
			{
				switch(MessageBox.Show("文件的内容已经改变，是否保存？", "提示信息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
				{
					case DialogResult.Yes: 
					{
						SaveFile(null);
						e.Cancel = false;
						break;
					}
					case DialogResult.Cancel: 
					{
						e.Cancel = true;
						break;
					}
				}
			}
		}

		/// <summary>
		/// 以RTF文件格式保存文件
		/// </summary>
		private void SaveRTF()
		{
			System.Windows.Forms.SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.FileName = "Prana.rtf";
			saveDlg.Filter = "RTF格式文件(*.rtf)|*.rtf";
			saveDlg.ShowDialog();
			string FileName=saveDlg.FileName;
			if(FileName.Length == 0)
				return;
			txtContent.SaveFile(FileName,RichTextBoxStreamType.RichText);	
		}

		private void menuFile_SaveAsRTF_Click(object sender, System.EventArgs e)
		{
			SaveRTF();
		}

		private void menuEdit_Undo_Click(object sender, System.EventArgs e)
		{
			txtContent.Undo();
		}

		private void menuEdit_Redo_Click(object sender, System.EventArgs e)
		{
			txtContent.Redo();
		}

		/// <summary>
		/// 剪切
		/// </summary>
		private void FileCut()
		{
			txtContent.Cut();
		}

		private void menuEdit_Cut_Click(object sender, System.EventArgs e)
		{
			FileCut();
		}

		/// <summary>
		/// 复制
		/// </summary>
		private void FileCopy()
		{
			txtContent.Copy();
		}

		private void menuEdit_Copy_Click(object sender, System.EventArgs e)
		{
			FileCopy();
		}

		/// <summary>
		/// 粘贴
		/// </summary>
		private void FilePaste()
		{
			txtContent.Paste();
		}

		private void menuEdit_Paste_Click(object sender, System.EventArgs e)
		{
			FilePaste();
		}

		private void menuEdit_All_Click(object sender, System.EventArgs e)
		{
			txtContent.SelectAll();
			txtContent.BackColor = System.Drawing.Color.BlanchedAlmond;
		}

		private void menuHelp_About_Click(object sender, System.EventArgs e)
		{
			new FrmAbout().ShowDialog();
		}

		private void menuFind_Find_Click(object sender, System.EventArgs e)
		{
			new FrmFind(this.txtContent).Show();
		}

		private void menuFind_Replace_Click(object sender, System.EventArgs e)
		{
			new FrmReplace(this.txtContent).Show();
		}

		private void menuFind_Time_Click(object sender, System.EventArgs e)
		{
			txtContent.Text += "\n" + System.DateTime.Now.ToString();
		}

		/// <summary>
		/// 字体
		/// </summary>
		private void FileFont()
		{
			FontDialog objFontDlg = new FontDialog();
			objFontDlg.Font = txtContent.Font;
			objFontDlg.ShowDialog();
			System.Drawing.Font objFont = objFontDlg.Font; 
			if(txtContent.SelectionLength >= 1)
			{
				txtContent.SelectionFont = objFont;
			}
			else
			{
				txtContent.Font = objFont;
			}
		}

		private void menuStyle_Font_Click(object sender, System.EventArgs e)
		{
			 FileFont();
		}

		/// <summary>
		/// 颜色
		/// </summary>
		private void FileColor()
		{
			System.Windows.Forms.ColorDialog objColorDlg = new ColorDialog();
			objColorDlg.Color = txtContent.ForeColor;
			objColorDlg.ShowDialog();
			System.Drawing.Color objColor = objColorDlg.Color;
			if(txtContent.SelectionLength >= 1)
			{
				txtContent.SelectionColor = objColor;
			}
			else
			{
				txtContent.ForeColor = objColor;
			}
		}

		private void menuStyle_Color_Click(object sender, System.EventArgs e)
		{
			FileColor();
		}

		private void menuLook_Status_Click(object sender, System.EventArgs e)
		{
			menuLook_Status.Checked = !menuLook_Status.Checked;
			statusBarMain.Visible = !statusBarMain.Visible;
		}

		private void FrmMain_Load(object sender, System.EventArgs e)
		{
			contextMenu.MergeMenu(menuEdit);
			txtContent.ContextMenu = contextMenu;
			
			//stbTime.Text = System.DateTime.Now.ToString();
		}

		private void menuLook_Tool_Click(object sender, System.EventArgs e)
		{
			menuLook_Tool.Checked = !menuLook_Tool.Checked;
			tbMain.Visible = !tbMain.Visible;
		}

		private void txtContent_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//检测鼠标的位置
			int xPos = Cursor.Position.X;
			int yPos = Cursor.Position.Y;			
			stbMouse.Text = string.Format("鼠标位置:X={0}  Y={1}", xPos, yPos);	
		}

		private void menuEdit_Del_Click(object sender, System.EventArgs e)
		{
			if (txtContent.SelectedText.Length > 0)
			{
				txtContent.SelectedText = "";
			}
		}

		private void menuHelp_Help_Click(object sender, System.EventArgs e)
		{
			//Help.ShowHelp(this, "notepad.chm");
		}

        private void statusBarMain_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            if (e.StatusBarPanel == stbPrana)
            {
                MessageBox.Show("三人组");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stbTime.Text = System.DateTime.Now.ToString();
        }

        private void menuLanguage_Click(object sender, EventArgs e)
        {

        }

        private void menuLan_CSharp_Click(object sender, EventArgs e)
        {

        }

        private void menuLan_SQL_Click(object sender, EventArgs e)
        {

        }
	}
}
