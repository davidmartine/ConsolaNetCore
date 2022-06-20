using System;

namespace ConsolaNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dato = 2.7m;
            decimal dato2 = 2.5m;
            decimal resultado = dato + dato2;
            decimal total=resultado+3.6;
            Console.WriteLine("Hola primera linea net core {0}",resultado);
            Console.ReadKey();

        }
    }
}
