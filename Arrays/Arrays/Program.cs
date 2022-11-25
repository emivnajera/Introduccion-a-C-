using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] coffeTypes;
            float[] coffeValues;

            coffeTypes = new string[] { "Expresso", "Largo", "Filtrado", "Latte" };
            coffeValues = new float[] { 1.2f, 1.5f, 5.0f, 5, 5f };

            coffeTypes[1] = "Lungo";

            for(int i = 0; i<4;i++)
            {
                Console.WriteLine(coffeTypes[i] + "Coffe $" + coffeValues[i]);
            }
        }
    }
}
