namespace FileChecks;

public static class Controller
{
    public static void movePicture()
    {
        string[] archivesPng = Directory.GetFiles(@Names.path, "*.png");
        string[] archivesJpg = Directory.GetFiles(@Names.path, "*.jpg");
        string[] archivesJpeg = Directory.GetFiles(@Names.path, "*.jpeg");
        string[] archivesGif = Directory.GetFiles(@Names.path, "*.gif");
        string[] archivesPsd = Directory.GetFiles(@Names.path, "*.psd");
        string[] archivesSvg = Directory.GetFiles(@Names.path, "*.svg");

        string destiny = @Names.path + "\\Imagens";

        utils.moveArchive(archivesPng, destiny);
        utils.moveArchive(archivesJpg, destiny);
        utils.moveArchive(archivesJpeg, destiny);
        utils.moveArchive(archivesGif, destiny);
        utils.moveArchive(archivesPsd, destiny);
        utils.moveArchive(archivesSvg, destiny);

        Color.color("Imagens");
    }

    public static void moveArchive()
    {
        string[] archivesRar = Directory.GetFiles(@Names.path, "*.rar");
        string[] archivesDocx = Directory.GetFiles(@Names.path, "*.docx");
        string[] archivesDoc = Directory.GetFiles(@Names.path, "*.doc");
        string[] archivesPdf = Directory.GetFiles(@Names.path, "*.pdf");
        string[] archivesZip = Directory.GetFiles(@Names.path, "*.zip");
        string[] archivesDocm = Directory.GetFiles(@Names.path, "*.docm");
        string[] archivesTxt = Directory.GetFiles(@Names.path, "*.txt");
        string[] archivesXml = Directory.GetFiles(@Names.path, "*.xml");
        string[] archivesXps = Directory.GetFiles(@Names.path, "*.xps");
        string[] archivesCsv = Directory.GetFiles(@Names.path, "*.csv");
        string[] archivesOds = Directory.GetFiles(@Names.path, "*.ods");
        string[] archivesXls = Directory.GetFiles(@Names.path, "*.xls");
        string[] archivesXlsb = Directory.GetFiles(@Names.path, "*.xlsb");
        string[] archivesXlsx = Directory.GetFiles(@Names.path, "*.xlsx");
        string[] archivesXltm = Directory.GetFiles(@Names.path, "*.xltm");
        string[] archivesBmp = Directory.GetFiles(@Names.path, "*.bmp");
        string[] archivesOdp = Directory.GetFiles(@Names.path, "*.odp");
        string[] archivesPpt = Directory.GetFiles(@Names.path, "*.ppt");
        string[] archivesPptx = Directory.GetFiles(@Names.path, "*.pptx");
        string[] archivesRtf = Directory.GetFiles(@Names.path, "*.rtf");
        string[] archivesOdg = Directory.GetFiles(@Names.path, "*.odg");
        string[] archivesOdt = Directory.GetFiles(@Names.path, "*.odt");

        string destiny = @Names.path + "\\Documentos";

        utils.moveArchive(archivesRar, destiny);
        utils.moveArchive(archivesDocx, destiny);
        utils.moveArchive(archivesPdf, destiny);
        utils.moveArchive(archivesZip, destiny);
        utils.moveArchive(archivesDoc, destiny);
        utils.moveArchive(archivesDocm, destiny);
        utils.moveArchive(archivesTxt, destiny);
        utils.moveArchive(archivesXml, destiny);
        utils.moveArchive(archivesXps, destiny);
        utils.moveArchive(archivesCsv, destiny);
        utils.moveArchive(archivesOds, destiny);
        utils.moveArchive(archivesXls, destiny);
        utils.moveArchive(archivesXlsb, destiny);
        utils.moveArchive(archivesXlsx, destiny);
        utils.moveArchive(archivesXltm, destiny);
        utils.moveArchive(archivesBmp, destiny);
        utils.moveArchive(archivesOdp, destiny);
        utils.moveArchive(archivesPpt, destiny);
        utils.moveArchive(archivesPptx, destiny);
        utils.moveArchive(archivesRtf, destiny);
        utils.moveArchive(archivesOdg, destiny);
        utils.moveArchive(archivesOdt, destiny);

        Color.color("Arquivos");
    }

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

    public static void moveVideo()
    {
        string[] archivesMp4 = Directory.GetFiles(@Names.path, "*.mp4");
        string[] archivesAvi = Directory.GetFiles(@Names.path, "*.avi");
        string[] archivesMov = Directory.GetFiles(@Names.path, "*.mov");
        string[] archivesMpg = Directory.GetFiles(@Names.path, "*.mpg");
        string[] archivesMpeg = Directory.GetFiles(@Names.path, "*.mpeg");
        string[] archivesWmv = Directory.GetFiles(@Names.path, "*.wmv");
        string[] archivesFlv = Directory.GetFiles(@Names.path, "*.flv");
        string[] archivesMkv = Directory.GetFiles(@Names.path, "*.mkv");

        string destiny = @Names.path + "\\Video";

        utils.moveArchive(archivesMp4, destiny);
        utils.moveArchive(archivesAvi, destiny);
        utils.moveArchive(archivesMov, destiny);
        utils.moveArchive(archivesMpg, destiny);
        utils.moveArchive(archivesMpeg, destiny);
        utils.moveArchive(archivesWmv, destiny);
        utils.moveArchive(archivesFlv, destiny);
        utils.moveArchive(archivesMkv, destiny);

        Color.color("Videos");
    }

    public static void moveMusic()
    {
        string[] archivesMp3 = Directory.GetFiles(@Names.path, "*.mp3");
        string[] archivesM4a = Directory.GetFiles(@Names.path, "*.m4a");
        string[] archivesWav = Directory.GetFiles(@Names.path, "*.wav");
        string[] archivesWma = Directory.GetFiles(@Names.path, "*.wma");
        string[] archivesAu = Directory.GetFiles(@Names.path, "*.au");
        
        string destiny = @Names.path + "\\Music";
        
        utils.moveArchive(archivesMp3, destiny);
        utils.moveArchive(archivesM4a, destiny);
        utils.moveArchive(archivesWav, destiny);
        utils.moveArchive(archivesWma, destiny);
        utils.moveArchive(archivesAu, destiny);
        
        Color.color("Música");
    }
}