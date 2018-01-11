using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace notepad1
{
    class text : Createnote,Opennote,Savenote,CreateClassification,functionManage
    {
        public void createNotes()
        {
            StreamWriter sw = new StreamWriter(@"A:\wenjian\note.txt", true);
            Console.WriteLine("新建笔记");
        }

        public void openNotes()
        {
            String file = @"A:\wenjian\note.txt";
            FileInfo info = new FileInfo(file);
            Process p = new Process();
            p.StartInfo.FileName = file;
            p.StartInfo.WorkingDirectory = info.DirectoryName;
            p.Start();
        }

        public void saveNotes()
        {
            Console.WriteLine("请编辑要保存的内容：");
            String text = Console.ReadLine();
            StreamWriter sw = new StreamWriter(@"A:\wenjian\note.txt");
            sw.WriteLine(text);
            Console.WriteLine("笔记保存成功");
            sw.Close();
        }

        public void CreateClassificationNotes()
        {
            Console.WriteLine("新建分类成功");
        }

        public void functionManage()
        {
            Console.WriteLine("管理分类模块");
        }
    }
}
