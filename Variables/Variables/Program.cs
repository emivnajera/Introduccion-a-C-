using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            var name = Console.ReadLine();
            Console.WriteLine("Holaaa " + name);

            int number1;
            int number2;

            Console.WriteLine("Ingrese un numero");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            number2= Convert.ToInt32(Console.ReadLine());

            int result = number1+ number2;
            Console.WriteLine("La suma es " + result);

        }
    }
}
