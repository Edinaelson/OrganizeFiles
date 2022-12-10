namespace FileChecks;

public static class Controller
{
    public static void moveArchivePictures()
    {
        string[] archivesPng = Directory.GetFiles(@Names.path, "*.png");
        string[] archivesJpg = Directory.GetFiles(@Names.path, "*.jpg");
        string[] archivesJpeg = Directory.GetFiles(@Names.path, "*.jpeg");

        string destiny = @Names.path + "\\Imagens";

        utils.moveArchive(archivesPng, destiny);
        utils.moveArchive(archivesJpg, destiny);
        utils.moveArchive(archivesJpeg, destiny);

        Color.color("Imagens");
    }

    public static void moveArchives()
    {
        string[] archivesRar = Directory.GetFiles(@Names.path, "*.rar");
        string[] archivesDocx = Directory.GetFiles(@Names.path, "*.docx");
        string[] archivesPdf = Directory.GetFiles(@Names.path, "*.pdf");
        string[] archivesZip = Directory.GetFiles(@Names.path, "*.zip");

        string destiny = @Names.path + "\\Documentos";

        utils.moveArchive(archivesRar, destiny);
        utils.moveArchive(archivesDocx, destiny);
        utils.moveArchive(archivesPdf, destiny);
        utils.moveArchive(archivesZip, destiny);
        
        Color.color("Arquivos");
    }

    public static void moveProgramas()
    {
        string[] archivesExe = Directory.GetFiles(@Names.path, "*.exe");
        string[] archivesMsi = Directory.GetFiles(@Names.path, "*.msi");

        string destiny = @Names.path + "\\Programs";

        utils.moveArchive(archivesMsi, destiny);
        
        //função para o proprio programa não se auto enviar.
        for (int i = 0; i < archivesExe.Length; i++)
        {
            var files = new FileInfo(archivesExe[i]);
            if (!files.Name.Equals("FileChecks.exe"))
            {
                files.MoveTo(Path.Combine(destiny, files.Name));
            }
        }

        Color.color("Programas");
    }

    public static void moveArchiveVideos()
    {
        string[] archives = Directory.GetFiles(@Names.path, "*.mp4");
        string[] archivesMkv = Directory.GetFiles(@Names.path, "*.mkv");

        string destiny = @Names.path + "\\Video";

        utils.moveArchive(archives, destiny);
        utils.moveVideos(archivesMkv, destiny);

        Color.color("Videos");
    }
    
}