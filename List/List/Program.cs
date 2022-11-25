// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<string> list = new List<string>();

list.Add("UNO");
list.Add("DOS");
list.Add("TRES");
list.Add("CUATRO");


for(int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}

list.Remove("TRES");
list.RemoveAt(0);

Console.WriteLine();

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}