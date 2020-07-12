using System;

namespace 練習1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("你好~ 你的名字是:");
            string N = Console.ReadLine();
            Console.WriteLine("那你的年級是:");
            int G = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("你好~" + G + "年級的" + N);
            student s = new student();
            s.Name = "小王";
            s.Grade = 6;
            Console.WriteLine(s.Talk(G, N));
        }
        
    }
}
