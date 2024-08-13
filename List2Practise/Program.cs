// See https://aka.ms/new-console-template for more information


List<string> kahveler = new List<string>();

// we  take the coffee's name from users and add the list
for(int i = 1; i < 6; i++)
{
    Console.Write("Kahve "+i+": ");
    kahveler.Add(Console.ReadLine());
}

// print the coffee list
Console.WriteLine("----Girilen Kahve İsimleri----");
foreach (string k in kahveler)
{
    Console.WriteLine(k);
}