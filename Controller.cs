﻿namespace FileChecks;

public static class Controller
{
    
    public static string changename()
    {
        Console.WriteLine("Informe nome: ");
        string name = Console.ReadLine();

        return name;
    }

    public static void moverArquivosImagens()
    {
        string[] archivesPng = Directory.GetFiles(@Names.path, "*.png");
        string[] archivesJpg = Directory.GetFiles(@Names.path, "*.jpg");
        string[] archivesJpeg = Directory.GetFiles(@Names.path, "*.jpeg");

        string destiny = @Names.path + "\\Imagens";

        utils.moveArchive(archivesPng, destiny);
        utils.moveArchive(archivesJpg, destiny);
        utils.moveArchive(archivesJpeg, destiny);

        Console.WriteLine("Movimentação de imagens realizada com sucesso");
    }

    public static void moverArquivos()
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

        Console.WriteLine("Movimentação de arquivos realizada com sucesso");
    }

    public static void moverProgramas()
    {
        string[] archivesExe = Directory.GetFiles(@Names.path, "*.exe");
        string[] archivesMsi = Directory.GetFiles(@Names.path, "*.msi");

        string destiny = @Names.path + "\\Programs";

        utils.moveArchive(archivesMsi, destiny);
        //Encontrar maneira de refatorar programa que se auto envia.
        //utils.moveArchive(archivesExe,destiny);
        for (int i = 0; i < archivesExe.Length; i++)
        {
            var files = new FileInfo(archivesExe[i]);
            if (!files.Name.Equals("FileChecks.exe"))
            {
                files.MoveTo(Path.Combine(destiny, files.Name));
            }
        }

        Console.WriteLine("Movimentação de programas realizada com sucesso");
    }

    public static void moverArquivosVideos()
    {
        string[] archives = Directory.GetFiles(@Names.path, "*.mp4");
        string[] archivesMkv = Directory.GetFiles(@Names.path, "*.mkv");

        string destiny = @Names.path + "\\Video";

        utils.moveVideos(archives, destiny);
        utils.moveVideos(archivesMkv, destiny);

        Console.WriteLine("Movimentação de videos realizado com sucesso");
    }
}