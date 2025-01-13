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
            if (ListOfExtensions.MusicList().Any(ext=> archive.EndsWith(ext)))
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
                    
                    Color.ColorConsole(Path.GetFileName(archive));
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        return null;
    }
    public static void printContMusics() {
        Console.WriteLine("quantidade de musicas: " + _contMusic);
    }
    
}