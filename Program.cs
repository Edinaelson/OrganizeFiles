using System.ComponentModel.Design;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using FileChecks;

using static FileChecks.Controller;

class Program
{
    static void Main(string[] args)
    {
        moverArquivosVideos();
        moverArquivosImagens();
        moverProgramas();
        moverArquivos();
        
        Console.ReadKey();
    }
}