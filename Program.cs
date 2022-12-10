using System.ComponentModel.Design;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using FileChecks;

using static FileChecks.Controller;

class Program
{
    static void Main(string[] args)
    {
        moveArchiveVideos();
        moveMusic();
        moveArchivePictures();
        moveProgramas();
        moveArchives();

        Console.WriteLine("Aperte qualquer tecla para sair.");
        Console.ReadKey();
    }
}