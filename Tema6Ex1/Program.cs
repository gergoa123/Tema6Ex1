using System;

namespace Tema6Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dulap d = new Dulap();
            Dulap d2 = new Dulap(1, 2, 3);
            Console.WriteLine(d.volum() + " " + d2.volum());
        }

    }
}
