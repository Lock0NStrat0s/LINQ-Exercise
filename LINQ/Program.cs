namespace LINQ;

public class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string> { "Star Wars: The Force Unleashed", "Final Fantasy", "God of War", "Elden Ring", "Terraria", "Cyberpunk 2077", "Elder Scrolls" };

        // LINQ Query Syntax
        Console.WriteLine("Query Syntax:");
        var nameSpaces = from name in names
                         orderby name.Count() ascending
                         select name;

        foreach (var name in nameSpaces)
        {
            Console.WriteLine(name);
        }

        // LINQ Method Syntax
        Console.WriteLine("\nMethod Syntax:");
        names = names.OrderBy(x => x.Count()).ToList();
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
