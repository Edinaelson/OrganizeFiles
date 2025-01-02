namespace FileChecks.controller;

public class MoveProgram
{
    public static int contProgram;
    public static string MoveProgramas()
    {
        // caminho da pasta de programas
        string path = Directories.path;
    
        // novo caminho
        string programasPath = Path.Combine(Directories.path, "Programas");
        
    
        string[] archives = Directory.GetFiles(path);
    
        // mover apenas programas
        foreach (string archive in archives)
        {
            if (archive.EndsWith(".exe", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".iso", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".dll", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".pdb", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".json", StringComparison.OrdinalIgnoreCase)
                || archive.EndsWith(".msi", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    contProgram++;
                    if (!Directory.Exists(programasPath))
                    {
                        if(contProgram > 0)
                            Directory.CreateDirectory(programasPath);
                    }
                    
                    string destinationPath = Path.Combine(programasPath, Path.GetFileName(archive));
                    
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
    public static void imprimirContagemProgramas() {
        Console.WriteLine("quantidade de programas: " + contProgram);
    }
}