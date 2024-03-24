using System;

namespace Adapter_1_obszar
{

    class Program
    {
        static void Main(string[] args)
        {
            Square adaptee = new Square(7);
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetArea());
        }
    }
}
