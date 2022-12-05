using System;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
           while (i <= 50){
                Console.WriteLine(i);
                i = i + 10;
           }

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j = j + 10;
            }while(j <= 50);
        }
    }
}
