using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sip s = new Sip();
            Produt produt = s.produt("A");
            produt.use();
        }

    }
   public abstract class Produt//虚方法
    {
       public abstract  void use();
    } 
    public class ProdutA : Produt
    {
        public override void use()
        {
            Console.WriteLine("胡晓宇");
        }
    }
    public class ProdutB : Produt
    {
        public override void use()
        {
            Console.WriteLine("方善康");
        }
    }
    class Sip
    {
        public Produt produt(string arg)
        {
            if (arg=="A")
            {
                return new ProdutA();
            }
            else
            {
                return new ProdutB();
            }
        }
    }
}
