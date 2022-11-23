using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        moverArquivosMp4();
        moverArquivosImagens();
        moverProgramas();
        moverArquivos();
        
        Console.ReadKey();
    }

    public static void moverArquivosImagens()
    {
        string[] archivesPng = Directory.GetFiles(@"C:\\Users\\sedin\\Downloads", "*.png");
        string[] archivesJpg = Directory.GetFiles(@"C:\\Users\\sedin\\Downloads", "*.jpg");
        string[] archivesJpeg = Directory.GetFiles(@"C:\\Users\\sedin\\Downloads", "*.jpeg");

        string destiny = @"C:\\Users\\sedin\\Downloads\\Imagens";

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
        
        string[] archivesRar = Directory.GetFiles(@"C:\Users\sedin\Downloads","*.rar");
        string[] archivesDocx = Directory.GetFiles(@"C:\Users\sedin\Downloads","*.docx");
        string[] archivesPdf = Directory.GetFiles(@"C:\Users\sedin\Downloads","*.pdf");
        string[] archivesZip = Directory.GetFiles(@"C:\Users\sedin\Downloads","*.zip");
        
        string destiny = @"C:\Users\sedin\Downloads\Documentos";
        
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
        string[] archivesExe = Directory.GetFiles(@"C:\Users\sedin\Downloads","*.exe");
        string[] archivesMsi = Directory.GetFiles(@"C:\Users\sedin\Downloads","*.msi");
        string destiny = @"C:\Users\sedin\Downloads\Programs";
        
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

    public static void moverArquivosMp4()
    {
        string[] archives = Directory.GetFiles(@"C:\Users\sedin\Downloads","*.mp4");
        string destiny = @"C:\\Users\\sedin\\Downloads\\Video";
        
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