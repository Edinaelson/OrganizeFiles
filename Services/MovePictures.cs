namespace FileChecks.controller;

public class MovePictures
{
    private static int _contImg;
    public static string MoveImg()
    {
        // caminho da pasta de Imagens
        string path = Directories.path;
    
        // novo caminho
        string imagensPath = Path.Combine(Directories.path, "Imagens");
        
        string[] archives = Directory.GetFiles(path);
    
        // mover apenas imagens
        foreach (string archive in archives)
        {
            if (ListOfExtensions.PicturesList().Any(ext=> archive.EndsWith(ext)))
            {
                try
                {
                    _contImg++;
                    if (!Directory.Exists(imagensPath))
                    {
                        if (_contImg > 0)
                            Directory.CreateDirectory(imagensPath);    
                    }
                    
                    string destinationPath = Path.Combine(imagensPath, Path.GetFileName(archive));
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
    public static void printContImagens() {
        Console.WriteLine("quantidade de imagens: " + _contImg);
    }
    
}