string[] names = { "Peter", "Tom", "Piet", "Ahmed", "Benny", "Anna", "Jane", "Ali", "John", "Tom" };
Console.Write("Geef een naam: ");
string input = Console.ReadLine();

int index = Array.IndexOf(names, input);

if (index != -1)
{
    Console.WriteLine($"De naam {input} staat op plaats {index + 1}");
}
else
{
    Console.WriteLine($"De naam {input} staat niet op de lijst");
}

Console.Write("\nGeef een letter: ");
string letter = Console.ReadLine().ToUpper();

if (!string.IsNullOrEmpty(letter) && char.IsLetter(letter[0]))
{
    string[] filterednames = Array.FindAll(names, name => name.ToUpper().StartsWith(letter.ToUpper()));
    if (filterednames.Length > 0)
    {
        Console.WriteLine($"Namen die beginnen met de letter {letter}: {string.Join(", ", filterednames)}");
    }
    else
    {
        Console.WriteLine($"Er zijn geen namen die beginnen met de letter {letter}");
    }
}
else
{
    Console.WriteLine("Voer een geldige letter in");
}

Console.Write("\nGeef eerste getal: ");
int.TryParse(Console.ReadLine(), out int inputStartIndex);

Console.Write("Geef tweede getal: ");
int.TryParse(Console.ReadLine(), out int inputEndIndex);

if ((inputStartIndex > 0 && inputStartIndex <= inputEndIndex) || ((inputEndIndex <= names.Length) && inputEndIndex >= inputStartIndex))
{
    Console.WriteLine($"Ongesorteerde array: {string.Join(", ", names)}");
    Array.Sort(names, inputStartIndex, inputEndIndex);
    Console.WriteLine($"Gesorteerde array: {string.Join(", ", names)}");
}
else
{
    Console.WriteLine("De input klopt niet!");
}

Console.ReadLine();