namespace FileChecks.controller;

public class MoveDocs
{
    private static int _contDocs;
    public static string MoveDocumentos()
    {
        // caminho da pasta de documentos
        string path = Directories.path;
    
        // caminho a ser enviado
        string documentosPath = Path.Combine(Directories.path, "Documentos");
    
        string[] archives = Directory.GetFiles(path);
        
        // mover apenas documentos
        foreach (string archive in archives)
        {
            if (ListOfExtensions.DoscList().Any(ext => archive.EndsWith(ext)))
            {
                try
                {
                    _contDocs++;
                    if (!Directory.Exists(documentosPath))
                    {
                        if(_contDocs > 0)
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

    public static void printContDocs() {
        Console.WriteLine("quantidade de documentos: " + _contDocs);
    }
    
}