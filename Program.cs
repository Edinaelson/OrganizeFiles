using FileChecks;
using FileChecks.controller;
using static FileChecks.Controller;
using Console = System.Console;
class Program
{
    static void Main(string[] args)
    {
        Color.colorUkraine();
        moveVideo();
        moveMusic();
        MovePictures.MoveImg();
        MovePictures.imprimirContagem();
        moveProgram();
        MoveDocs.moveDocs();
        imprimirContagem();
        Console.WriteLine("Aperte qualquer tecla para sair...");
        Console.ReadKey();
        Console.ReadKey();
    }
}