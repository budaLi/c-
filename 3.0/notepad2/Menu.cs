using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace notepad2
{
    class Menu
    {
        //声明委托
        public delegate void FunctionEventHandler(Object sender, FunctionEventArgs e);
        //声明事件
        public event FunctionEventHandler function;

        // 可以供继承自 Menu 的类重写，以便继承类拒绝其他对象对它的监视
        protected virtual void OnFunction(FunctionEventArgs e)
        {
            if (function != null)
            { // 如果有对象注册
                function(this, e);  // 调用所有注册对象的方法
            }
        }
        //菜单
        public void Menu1()
        {

            Notebook note = new Notebook();
            //给委托赋值
            this.function += note.Open;
            this.function += note.SetNote;

            while (true)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("*     1.新建笔记      2.打开笔记          *");
                Console.WriteLine("*     3.管理分类      4.退出              *");
                Console.WriteLine("*******************************************");
            
               int option = Convert.ToInt32(Console.ReadLine());

                if (option > 0 && option < 5)
                {
                    FunctionEventArgs e = new FunctionEventArgs(option);
                    OnFunction(e);
                    if (option == 3)
                    {
                        Console.Clear();
                        ManageSort ct = new ManageSort();
                        ct.Sort();
                        Menu1();
                    }
                    if (option == 4)
                    {
                        System.Environment.Exit(0);

                    }
                }
                else
                {
                    Console.WriteLine("输入有误请重新输入");
                    Menu1();
                }
            }
        }
    }
}
