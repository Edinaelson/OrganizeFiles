using System.IO;
using System.Security.Cryptography.X509Certificates;
using FileChecks;

class Program
{
    static void Main(string[] args)
    {
        //moverArquivosVideos();
        moverArquivosImagens();
        //moverProgramas();
        //moverArquivos();
        //Console.WriteLine("Caminho atual: {0}",Names.path);
        Console.ReadKey();
    }
    
    

    public static void moverArquivosImagens()
    {
        string[] archivesPng = Directory.GetFiles(@Names.path, "*.png");
        string[] archivesJpg = Directory.GetFiles(@Names.path, "*.jpg");
        string[] archivesJpeg = Directory.GetFiles(@Names.path, "*.jpeg");

        string destiny = @Names.path + "\\Imagens";

        if (!Directory.Exists(destiny))
        {
            Directory.CreateDirectory(destiny);
        }

        for (int i = 0; i < archivesJpeg.Length; i++)
        {
            var files = new FileInfo(archivesJpeg[i]);
            files.MoveTo(Path.Combine(destiny, files.Name)); 
        }

        for (int i = 0; i < archivesPng.Length; i++)
        {
            var files = new FileInfo(archivesPng[i]);
            files.MoveTo(Path.Combine(destiny, files.Name));
        }

        for (int i = 0; i < archivesJpg.Length; i++)
        {
            var files = new FileInfo(archivesJpg[i]);
            files.MoveTo(Path.Combine(destiny, files.Name));
        }

        Console.WriteLine("Movimentação de imagens realizada com sucesso");
    }

    public static void moverArquivos()
    {
        
        string[] archivesRar = Directory.GetFiles(@Names.path,"*.rar");
        string[] archivesDocx = Directory.GetFiles(@Names.path,"*.docx");
        string[] archivesPdf = Directory.GetFiles(@Names.path,"*.pdf");
        string[] archivesZip = Directory.GetFiles(@Names.path,"*.zip");
        
        string destiny = @Names.path + "\\Documentos";
        
        if (!Directory.Exists(destiny))
        {
            Directory.CreateDirectory(destiny);
        }
        
        for (int i = 0; i < archivesRar.Length; i++)
        {
            var files = new FileInfo(archivesRar[i]);
            files.MoveTo(Path.Combine(destiny, files.Name));
        }
        
        for (int i = 0; i < archivesDocx.Length; i++)
        {
            var files = new FileInfo(archivesDocx[i]);
            files.MoveTo(Path.Combine(destiny, files.Name));
        }
        
        for (int i = 0; i < archivesPdf.Length; i++)
        {
            var files = new FileInfo(archivesPdf[i]);
            files.MoveTo(Path.Combine(destiny, files.Name));
        }
        
        for (int i = 0; i < archivesZip.Length; i++)
        {
            var files = new FileInfo(archivesZip[i]);
            files.MoveTo(Path.Combine(destiny, files.Name));
        }
        
        Console.WriteLine("Movimentação de arquivos realizada com sucesso"); 
        
    }

    public static void moverProgramas()
    {
        string[] archivesExe = Directory.GetFiles(@Names.path,"*.exe");
        string[] archivesMsi = Directory.GetFiles(@Names.path,"*.msi");
        string destiny = @Names.path + "\\Programs";
        
        //create directory
        if (!Directory.Exists(destiny))
        {
            Directory.CreateDirectory(destiny);
        }
        
        for (int i = 0; i < archivesExe.Length; i++)
        {
            var files = new FileInfo(archivesExe[i]);
            files.MoveTo(Path.Combine(destiny, files.Name));
        }
        
        for (int i = 0; i < archivesMsi.Length; i++)
        {
            var files = new FileInfo(archivesMsi[i]);
            files.MoveTo(Path.Combine(destiny, files.Name));
        }
        
        Console.WriteLine("Movimentação de programas realizada com sucesso"); 
    }

    public static void moverArquivosVideos()
    {
        string[] archives = Directory.GetFiles(@Names.path,"*.mp4");
        string destiny = @Names.path + "\\Video";
        
        if (!Directory.Exists(destiny))
        {
            Directory.CreateDirectory(destiny);
        }

        for (int i = 0; i < archives.Length; i++)
        {
            var files = new FileInfo(archives[i]);
            files.MoveTo(Path.Combine(destiny, files.Name));
        }
        Console.WriteLine("Movimentação de videos realizado com sucesso");

    }

    public static void mostrarArquivos()
    {
        string[] diretorios = Directory.GetDirectories("C:\\Users\\sedin\\Downloads\\Video");
        string[] arquivos = Directory.GetFiles("C:\\Users\\sedin\\Downloads\\Video", "*.mp4", SearchOption.AllDirectories);

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

}