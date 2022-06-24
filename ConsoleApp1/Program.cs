using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static async Task Dosomew()
        {
            Console.WriteLine("胡晓宇");
            await Task.Delay(2000);
            Console.WriteLine("房山看");
        }
        
      public  async static Task Main(string[] args)
        {
            Console.WriteLine("12");
            Task task = Dosomew();
            await task;//等这个打印完方法在执行下一个
            Console.WriteLine("32432");
            
           // await task;//插入中间

            Console.ReadLine();
            //Console.WriteLine("How");
            //doSnmethisn("12");
            //ThreadStart threadStart = () => doSnmethisn("胡晓宇");//异步
            //Thread thread = new Thread(threadStart);//引用委托
            ////Thread thread=new Thread(new ThreadStart())
            //thread.Start();
            //Console.WriteLine("123");
            //Console.ReadLine();//阻塞

            //ThreadPool.QueueUserWorkItem(t =>doSnmethisn("123"));



        }
        private static void doSnmethisn(string name) {
            Console.WriteLine($"doethis{name}23232");
            
            Thread.Sleep(2000);//休息两秒
        }
    }
    class Test
    {
        public void Mysql()
        {
            Console.WriteLine("123");
        }

    }
}
