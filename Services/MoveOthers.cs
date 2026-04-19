namespace FileChecks;

public class MoveOthers
{
    private static int _contOthers;

    public static string MoveOutros()
    {
        // caminho da pasta de entrada
        string path = Directories.path;

        // novo caminho
        string outrosPath = Path.Combine(Directories.path, "Outros");

        string[] archives = Directory.GetFiles(path);

        // mover apenas arquivos não categorizados
        foreach (string archive in archives)
        {
            // Ignora arquivos do próprio programa
            if (Path.GetFileName(archive).Equals("FileChecks.exe"))
                continue;

            // Se o arquivo não está categorizado, move para "Outros"
            if (!ListOfExtensions.IsCategorized(archive))
            {
                try
                {
                    _contOthers++;
                    if (!Directory.Exists(outrosPath))
                    {
                        if (_contOthers > 0)
                            Directory.CreateDirectory(outrosPath);
                    }

                    string destinationPath = Path.Combine(outrosPath, Path.GetFileName(archive));
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

    public static void printContOutros()
    {
        Console.WriteLine("quantidade de arquivos em Outros: " + _contOthers);
    }
}
