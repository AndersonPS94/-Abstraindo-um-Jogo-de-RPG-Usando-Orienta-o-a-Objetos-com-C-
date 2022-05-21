using System;
using dotnet.src.Entities;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23,"Knight");
            Wizard jennica = new Wizard("Jennica", 23,"White Wizard");
            Ninja wedge = new Ninja("Wedge", 25, "Ninja");
            Wizard topapa = new Wizard ("Topapa", 28, "Black Wizard");

            Console.WriteLine(jennica.Attack(1));
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(topapa.Attack());
        }
    }
}
