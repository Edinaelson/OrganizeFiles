using FileChecks;
using FileChecks.controller;
using Console = System.Console;
class Program
{
    static void Main(string[] args)
    {
        Color.colorUkraine();
        MoveVideo.moveVideo();
        MoveMusic.moveMusic();
        MovePictures.MoveImg();
        MoveProgram.moveProgram();
        MoveDocs.moveDocs();
        MoveMusic.imprimirContagemMusicas();
        MovePictures.imprimirContagemImagens();
        Console.WriteLine("Aperte qualquer tecla para sair...");
        Console.ReadKey();
        Console.ReadKey();
    }
}