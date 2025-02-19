namespace FileChecks;

public class MoveProgram
{
    private static int _contProgram = -1;
    public static string MoveProgramas()
    {
        // caminho da pasta de programas
        string path = Directories.path;
    
        // novo caminho
        string programasPath = Path.Combine(Directories.path, "Programs");
        
    
        string[] archives = Directory.GetFiles(path);
    
        // mover apenas programas
        foreach (string archive in archives)
        {
            if (ListOfExtensions.ProgramList().Any(ext=> archive.EndsWith(ext)))
            {
                try
                {
                    _contProgram++;
                    if (!Directory.Exists(programasPath))
                    {
                        if(_contProgram > 0)
                            Directory.CreateDirectory(programasPath);
                    }
                    
                    string destinationPath = Path.Combine(programasPath, Path.GetFileName(archive));

                    if (!Path.GetFileName(archive).Equals("FileChecks.exe"))
                    {
                        if (File.Exists(destinationPath))
                        {
                            File.Move(archive, destinationPath, true);
                        }
                        else
                        {
                            File.Move(archive, destinationPath);
                        }    
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
    public static void printContPrograms() {
        Console.WriteLine("quantidade de programas: " + _contProgram);
    }
}