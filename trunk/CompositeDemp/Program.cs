using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeDemp
{
    class Program
    {
        static void Main(string[] args)
        {
            LegionComponsite PRC = new LegionComponsite("毛泽东", 300);
            LegionComponsite PRCZhu = new LegionComponsite("朱德", 200);
            LegionComponsite PRCChen = new LegionComponsite("陈毅", 200);
            Legion PRCLuo = new Legion("罗荣桓", 100);
            PRCChen.Add(PRCLuo);
            PRC.Add(PRCZhu);
            PRC.Add(PRCChen);

            Console.WriteLine("指挥官一览："+PRC.GetCommanders());
            Console.WriteLine("全军数量："+PRC.GetQuantity());
            Console.ReadLine();
        }
    }
}
