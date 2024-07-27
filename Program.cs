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
        MoveProgram.MoveProgramas();
        MoveDocs.moveDocs();
        MoveProgram.imprimirContagemProgramas();
        MoveMusic.imprimirContagemMusicas();
        MovePictures.imprimirContagemImagens();
        MoveVideo.imprimirContagemVideos();
        Console.WriteLine("Aperte qualquer tecla para sair...");
        Console.ReadKey();
    }
}