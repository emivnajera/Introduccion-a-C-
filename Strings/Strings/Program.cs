using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 170;
            int age = 22;
            string name = "Emiliano Velasquez";
            string placeholder = "La informacion es: ";
            string information = placeholder + "\n User name: " + name +"\n User age: " + age + "\n User Height: " +height;
            Console.WriteLine(information);
        }
    }
}
