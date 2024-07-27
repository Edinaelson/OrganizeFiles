namespace FileChecks.controller;

public class MoveMusic
{
    public static int contMusic;
    public static string moveMusic()
    {
        
        // caminho da pasta de Musicas
        string path = Names.path;
        
        //novo caminho
        string musicasPath = Path.Combine(Names.path, "Music");
        if (!Directory.Exists(musicasPath))
        {
            Directory.CreateDirectory(musicasPath);
        }
        
        string[] archives = Directory.GetFiles(path);
        
        foreach (string archive in archives)
        {
            if (archive.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".m4a", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".wav", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".wma", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".au", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    string destinationPath = Path.Combine(musicasPath, Path.GetFileName(archive));
                    if (File.Exists(destinationPath))
                    {
                        File.Move(archive, destinationPath, true);
                    }
                    else
                    {
                        File.Move(archive, destinationPath);
                    }
                    contMusic++;
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        return null;
    }
    public static void imprimirContagemMusicas() {
        Console.WriteLine("quantidade de musicas: " + contMusic);
    }
    
}