namespace FileChecks.controller;

public class MoveVideo
{
    private static int _contVid;
    public static string moveVideo()
    {
        // caminho da pasta de videos
        string path = Directories.path;
    
        // novo caminho
        string videoPath = Path.Combine(Directories.path, "Video");
        
    
        string[] archives = Directory.GetFiles(path);
    
        // mover apenas videos
        foreach (string archive in archives)
        {
            if (ListOfExtensions.VideoList().Any(ext=> archive.EndsWith(ext)))
            {
                try
                {
                    _contVid++;
                    if (!Directory.Exists(videoPath))
                    {
                        if(_contVid > 0)
                            Directory.CreateDirectory(videoPath);
                    }
                    
                    string destinationPath = Path.Combine(videoPath, Path.GetFileName(archive));
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
    public static void printContVideos() {
        Console.WriteLine("quantidade de videos: " + _contVid);
    }
}