namespace FileChecks;

public class Color
{
    public static void color(String name)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        
        Console.WriteLine("{0} enviado com sucesso!", name);
        
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("++++++++++++++++++++++++++++++++");
        Console.WriteLine("");
        
        Console.ResetColor();
    }
    
}