namespace LINQ;

public class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string> { "Star Wars: The Force Unleashed", "Final Fantasy", "God of War", "Elden Ring", "Terraria", "Cyberpunk 2077", "Elder Scrolls" };

        // LINQ Method Syntax
        names = names.OrderBy(x => x.Count()).ToList();
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
