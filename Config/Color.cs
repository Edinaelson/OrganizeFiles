namespace FileChecks;

public class Color
{
    public static void ColorConsole(String name)
    {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("+");
        Console.ResetColor();
        
        Console.WriteLine(" {0} ", name);
        
    }

    public static void Sucess(string name)
    {
        //Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(name);
        Console.ResetColor();
    }

    public static void ColorUkraine()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("        Peace");
        Console.ResetColor();
        
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(" Ukraine        ");
        Console.ResetColor();
        Console.WriteLine("");
    }
    
}