using System;

namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anyValue = 6;
            string message = "";
            if(anyValue == 7)
            {
                message = "Es 7";
            }
            else if(anyValue == 14)
            {
                message = "Es 14";
            }
            else
            {
                message = "No es 7 ni 14";
            }
            Console.WriteLine(message);
        }
    }
}
