using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (Mutex mutex=new Mutex(false,"MutexDemo"))
            //{
            //    if (!mutex.WaitOne(5000,false))//阻止当前线路
            //    {
            //        Console.WriteLine("胡晓宇");
            //        Console.ReadKey();
            //        return;
            //    }
            //    Console.Wri
            //    Console.ReadKey();
            //}
            SimpleFactory simple = new SimpleFactory();
            Product a = simple.creaProduct("A");
            a.use();
            
        }
    }
    class SimpleFactory
    {
        public Product creaProduct(string arg)
        {
            if (arg=="A")
            {
                return new ConcreteProdutA();
            }
            else
            {
                return new ConcreteProdutB();
            }
        }
    }
    public abstract class Product//抽象类 基类
    {
        public abstract void use();//方法
    }
    
    public class ConcreteProdutA:Product
    {
        public override void use() {
            Console.WriteLine("23");
        }
    }
    public class ConcreteProdutB: Product
    {
        public override void use()
        {
            Console.WriteLine("32");
        }
    }



}
