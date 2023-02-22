using System.ComponentModel.Design;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using FileChecks;

using static FileChecks.Controller;
using static FileChecks.utils;
using Console = System.Console;

class Program
{
    static void Main(string[] args)
    {
        Color.colorUkraine();
        moveVideo();
        moveMusic();
        movePicture();
        moveProgram();
        moveArchive();
        Console.WriteLine("Aperte qualquer tecla para sair...");
        Console.ReadKey();
        Console.ReadKey();
    }
}