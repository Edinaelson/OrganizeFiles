namespace FileChecks;

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
<<<<<<< HEAD
        string[] archivesExe = Directory.GetFiles(@"C:\\Users\\sedin\\Downloads", "*.exe");
=======
        string[] archivesExe = Directory.GetFiles(@Names.path, "*.exe");
>>>>>>> a84d5f6fc28525956e7fb08e0e54b6acde92f049
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

<<<<<<< HEAD
        utils.moveArchive(archives, destiny);
        utils.moveArchive(archivesMkv, destiny);

        Console.WriteLine("Movimentação de videos realizado com sucesso");
    }

    public static void mostrarArquivos()
    {
        string[] diretorios = Directory.GetDirectories("C:\\Users\\sedin\\Downloads\\Video");
        string[] arquivos =
            Directory.GetFiles("C:\\Users\\sedin\\Downloads\\Video", "*.mp4", SearchOption.AllDirectories);

        Console.WriteLine("Diretórios:");
        foreach (string dir in diretorios)
        {
            Console.WriteLine(dir);
        }

        Console.WriteLine("Arquivos:");

        int cont = 0;

        foreach (string arq in arquivos)
        {
            Console.WriteLine(arq);
            cont++;
        }

        Console.WriteLine("Quantidade de filmes: " + cont);
    }
    
=======
        utils.moveVideos(archives, destiny);
        utils.moveVideos(archivesMkv, destiny);

        Console.WriteLine("Movimentação de videos realizado com sucesso");
    }
>>>>>>> a84d5f6fc28525956e7fb08e0e54b6acde92f049
}