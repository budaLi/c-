using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace notepad2
{
    class ManageSort
    {
        //声明委托
        public delegate void FunctionEventHandler(Object sender1, FunctionEventArgs e2);
        //声明事件
        public event FunctionEventHandler function1;

        // 可以供继承自 Menu 的类重写，以便继承类拒绝其他对象对它的监视
        protected virtual void OnFunction1(FunctionEventArgs e2)
        {
            if (function1 != null)
            { // 如果有对象注册
                function1(this, e2);  // 调用所有注册对象的方法
            }
        }

        //分类管理界面
        public void Sort()
        {

            SortFunction n = new SortFunction();
            Notebook n1 = new Notebook();
            //给委托赋值
            this.function1 += n.sort;
            this.function1 += n.Delete;
            this.function1 += n.showCategory;
            this.function1 += n.ModifySort;

            while (true)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("*     1.查询         2.新建               *");
                Console.WriteLine("*     3.删除         4.修改               *");
                Console.WriteLine("*     5.返回                              *");
                Console.WriteLine("*******************************************");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y > 0 && y < 5)
                {
                    FunctionEventArgs e = new FunctionEventArgs(y);
                    OnFunction1(e);
                }
                    if (y == 5)
                    {
                        Console.Clear();
                        Menu mm = new Menu();
                        mm.Menu1();
                        
                    
                }
            }
        }
    }
}
