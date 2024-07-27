namespace FileChecks.controller;

public class MoveVideo
{
    public static int contVid;
    public static string moveVideo()
    {
        // caminho da pasta de videos
        string path = Names.path;
    
        // novo caminho
        string videoPath = Path.Combine(Names.path, "Videos");
        if (!Directory.Exists(videoPath))
        {
            Directory.CreateDirectory(videoPath);
        }
    
        string[] archives = Directory.GetFiles(path);
    
        // mover apenas videos
        foreach (string archive in archives)
        {
            if (archive.EndsWith(".mp4", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".avi", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".mov", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".mpg", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".mpeg", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".flv", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".mkv", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".wmv", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    string destinationPath = Path.Combine(videoPath, Path.GetFileName(archive));
                    if (File.Exists(destinationPath))
                    {
                        File.Move(archive, destinationPath, true);
                    }
                    else
                    {
                        File.Move(archive, destinationPath);
                    }
                    contVid++;
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        return null;
    }
    public static void imprimirContagemVideos() {
        Console.WriteLine("quantidade de videos: " + contVid);
    }
}