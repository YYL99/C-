using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("请输入名字：");
            String name = Console.ReadLine();
            Console.WriteLine("欢迎"+ name +"来到C#的世界！");
        }
    }
}
