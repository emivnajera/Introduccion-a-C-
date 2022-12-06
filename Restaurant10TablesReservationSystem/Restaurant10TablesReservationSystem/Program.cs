using System;
/*
 * 1. Validar si es usuario existente o si se debe registrar
 * 2. El programa debe saludar a un usuario existente
 * 3. El programa debe repetirse hasta que se registren las 10 personas.
 */

namespace Restaurant10TablesReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10] { "emivnajera", "", "", "", "", "", "", "", "", "" };
            int arrayCurrentIndex = 1;
            bool userType;
            Console.WriteLine("WELCOME");
            while (arrayCurrentIndex < 10)
            { 
                Console.WriteLine("Ingrese true si esta registrado o falso si no lo esta.");
                userType = Convert.ToBoolean(Console.ReadLine());
                if(userType) {
                    Console.WriteLine("Ingrese su nombre");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("El usuario ingresado es {0}", userToSearch);
                    int index = Array.IndexOf(userNames, userToSearch);
                    if(index == -1) {
                        Console.WriteLine("Usuario No Encontrado");
                    }
                    else
                    {
                        Console.WriteLine("Bienvenido {0}",userToSearch);
                    }
                }
                else if(userType == false)
                {
                    Console.WriteLine("Ingrese su nombre de usuario");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("Usuario Guardado");
                    arrayCurrentIndex++;
                }
            }
            Console.WriteLine("Sin espacio disponible");
            int auxIndex = 0;
            foreach (string element in userNames)
            {
                Console.WriteLine(userNames[auxIndex]);
                auxIndex++;
            }
            Environment.Exit(0);
        }
    }
}
