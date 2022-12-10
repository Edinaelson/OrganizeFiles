namespace FileChecks;

public class Color
{
    public static void color(String name)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        
        Console.Write("{0} enviado com sucesso!", name);
        
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("+++");
        Console.WriteLine("");
        
        Console.ResetColor();
    }

    public static void colorUkraine()
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