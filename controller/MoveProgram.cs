namespace FileChecks.controller;

public class MoveProgram
{
    public static void moveProgram()
    {
        string[] archivesExe = Directory.GetFiles(@Names.path, "*.exe");
        string[] archivesMsi = Directory.GetFiles(@Names.path, "*.msi");
        string[] archivesIso = Directory.GetFiles(@Names.path, "*.iso");

        string destiny = @Names.path + "\\Programs";

        utils.moveArchive(archivesMsi, destiny);
        utils.moveArchive(archivesIso, destiny);
        
        //função para o programa não se auto enviar.
        for (int i = 0; i < archivesExe.Length; i++)
        {
            var files = new FileInfo(archivesExe[i]);
            if (!files.Name.Equals("FileChecks.exe"))
            {
                files.MoveTo(Path.Combine(destiny, files.Name));
            }
        }

        Color.color("Programs");
    }
}