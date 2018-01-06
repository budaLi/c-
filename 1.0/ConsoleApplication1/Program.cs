using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace notepad0
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            Classification classify = new Classification();
            while (true)
            {
                Console.WriteLine("欢迎来到记事本1.0");
                Console.WriteLine("是否进行操作？Y/N");
                string s = Console.ReadLine().ToString();

                switch (s)
                {
                    case "Y":
                        Console.WriteLine("*************************************************************");
                        Console.WriteLine("*                                                           *");
                        Console.WriteLine("*           1:新建笔记          2：打开笔记                 *");
                        Console.WriteLine("*           3:新建分类          4：管理分类                 *");
                        Console.WriteLine("*           5:保存笔记          6：退出                     *");
                        Console.WriteLine("*                                                           *");
                        Console.WriteLine("*************************************************************");
                        Console.WriteLine("请选择要执行的功能（1-6）：");
                        while (true)
                        {
                            int option = int.Parse(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    text.Createnote();
                                    break;
                                case 2:
                                    text.Opennote();
                                    break;
                                case 3:
                                    classify.CreateClassification();
                                    break;
                                case 4:
                                    classify.ManageClassification();
                                    break;
                                case 5:
                                    text.Savenote();
                                    break;
                                case 6:
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("输入有误！");
                                    break;
                            }
                        }

                    case "N":
                        Console.WriteLine("已退出！");
                        break;
                    default: break;
                }

            }
        }


        class Text
        {
            public void Createnote()
            {
                Console.WriteLine("创建笔记");
            }

            public void Opennote()
            {
                Console.WriteLine("打开笔记");
            }
            public void Savenote()
            {
                Console.WriteLine("保存笔记");
            }
        }
        class Classification
        {
            public void CreateClassification()
            {
                Console.WriteLine("新建分类");
            }
            public void ManageClassification()
            {
                Console.WriteLine("管理分类");
            }
        }
    }
}