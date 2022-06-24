using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static readonly object _lock = new object();
        static void Main(string[] args)
        {
            Thread ths1 = new Thread(Pr);
            Thread ths2 = new Thread(Pr);
            ths1.Start();
            ths2.Start();
        }
        public static void Pr() {
            string strArray = "胡晓宇";
            lock (_lock)
            {
                for (int i = 0; i < strArray.Length; i++)
                {
                    Console.WriteLine($"{strArray[i]}");
                    Thread.Sleep(TimeSpan.FromSeconds(2));//时间
                }
            }
            Console.Write("");
          
        }
    }
}
