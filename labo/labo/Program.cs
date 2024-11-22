string[] names = { "Peter", "Tom", "Piet", "Ahmed", "Benny", "Anna", "Jane", "Ali", "John", "Tom" };
Console.WriteLine("Geef een naam");
string input = Console.ReadLine();

int index = Array.IndexOf(names, input);

if (index == -1)
{
    Console.WriteLine($"De naam {input} staat op plaats {index + 1}");
}
else
{
    Console.WriteLine($"De naam {input} staat niet op de lijst {index + 1}");
}
Console.ReadLine();  //deel 1