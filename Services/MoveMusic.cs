namespace FileChecks.controller;

public class MoveMusic
{
    private static int _contMusic;
    public static string moveMusic()
    {
        
        // caminho da pasta de Musicas
        string path = Directories.path;
        
        //novo caminho
        string musicasPath = Path.Combine(Directories.path, "Music");
        
        
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
                    _contMusic++;
                    if (!Directory.Exists(musicasPath))
                    {
                        if(_contMusic > 0)
                            Directory.CreateDirectory(musicasPath);
                    }
                    
                    string destinationPath = Path.Combine(musicasPath, Path.GetFileName(archive));
                    if (File.Exists(destinationPath))
                    {
                        File.Move(archive, destinationPath, true);
                    }
                    else
                    {
                        File.Move(archive, destinationPath);
                    }
                    
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
        Console.WriteLine("quantidade de musicas: " + _contMusic);
    }
    
}