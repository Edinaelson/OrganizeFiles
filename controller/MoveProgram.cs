namespace FileChecks.controller;

public class MoveProgram
{
    public static int contProgram;
    public static string MoveProgramas()
    {
        // caminho da pasta de programas
        string path = Names.path;
    
        // novo caminho
        string programasPath = Path.Combine(Names.path, "Programas");
        if (!Directory.Exists(programasPath))
        {
            Directory.CreateDirectory(programasPath);
        }
    
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
                    string destinationPath = Path.Combine(programasPath, Path.GetFileName(archive));
                    
                    //tentativa para o programa que executa não se auto enviar
                    // var files = Path.GetFileName(archive);
                    // if (!files.Equals("FileChecks.exe"))
                    // {
                    //     File.Move(archive, destinationPath, true);
                    // }
                    
                    if (File.Exists(destinationPath))
                    {
                        File.Move(archive, destinationPath, true);
                    }
                    else
                    {
                        File.Move(archive, destinationPath);
                    }
                    contProgram++;
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