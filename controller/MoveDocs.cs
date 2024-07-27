namespace FileChecks.controller;

public class MoveDocs
{
    public static void moveDocs()
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
}