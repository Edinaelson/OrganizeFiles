namespace FileChecks.controller;

public class MovePictures
{
    public static int contImg;
    public static string MoveImg()
    {
        // caminho da pasta de Imagens
        string path = Names.path;
    
        // novo caminho
        string imagensPath = Path.Combine(Names.path, "imagens");
        if (!Directory.Exists(imagensPath))
        {
            Directory.CreateDirectory(imagensPath);
        }
    
        string[] archives = Directory.GetFiles(path);
    
        // mover apenas imagens
        foreach (string archive in archives)
        {
            if (archive.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".psd", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".svg", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    string destinationPath = Path.Combine(imagensPath, Path.GetFileName(archive));
                    if (File.Exists(destinationPath))
                    {
                        File.Move(archive, destinationPath, true);
                    }
                    else
                    {
                        File.Move(archive, destinationPath);
                    }
                    contImg++;
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        return null;
    }
    public static void imprimirContagem() {
        Console.WriteLine("quantidade de imagens: " + contImg);
    }
    
}