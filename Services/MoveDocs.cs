namespace FileChecks.controller;

public class MoveDocs
{
     public static int contDocumentos;
    public static string MoveDocumentos()
    {
        // caminho da pasta de documentos
        string path = Directories.path;
    
        // novo caminho
        string documentosPath = Path.Combine(Directories.path, "Documentos");
    
        string[] archives = Directory.GetFiles(path);
    
        // mover apenas documentos
        foreach (string archive in archives)
        {
            if (archive.EndsWith(".rar", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".docx", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".doc", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".zip", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".txt", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".xml", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".xps", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".csv", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".ods", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".xls", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".xlsb", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".xltm", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".odp", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".ppt", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".pptx", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".odg", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".odt", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".docm", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    contDocumentos++;
                    if (!Directory.Exists(documentosPath))
                    {
                        if(contDocumentos > 0)
                            Directory.CreateDirectory(documentosPath);
                    }
                    
                    string destinationPath = Path.Combine(documentosPath, Path.GetFileName(archive));
                    
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
    public static void imprimirContagemDocumentos() {
        Console.WriteLine("quantidade de documentos: " + contDocumentos);
    }
    
}